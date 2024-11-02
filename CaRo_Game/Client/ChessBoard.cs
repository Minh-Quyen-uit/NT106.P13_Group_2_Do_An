using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ChessBoard : Form
    {
        #region Properties
        ChessBoardManager Board;
        SocketManager socket;
        #endregion
        public ChessBoard()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Board = new ChessBoardManager(panel_Board, FullName, Avatar_Player);
            Board.EndedGame += ChessBoard_EndedGame;
            Board.PlayerMarked += ChessBoard_PlayerMarked;

            PrcBCoolDown.Step = Cons.Cool_Down_Step;
            PrcBCoolDown.Maximum = Cons.Cool_Down_Time;
            PrcBCoolDown.Value = 0;

            tmCoolDown.Interval = Cons.Cool_Down_Interval;

            socket = new SocketManager();
            
            socket.IP = GenerateRandomIPAddress();
            newGame();

        }
        private string GenerateRandomIPAddress()
        {
            Random random = new Random();
            int part1 = 127;    // Phần đầu (1-255)
            int part2 = random.Next(0, 256);    // Phần thứ hai (0-255)
            int part3 = random.Next(0, 256);    // Phần thứ ba (0-255)
            int part4 = random.Next(1, 256);    // Phần cuối (1-255)

            return $"{part1}.{part2}.{part3}.{part4}";
        }

        #region
        

        private void ChessBoard_PlayerMarked(object? sender, BtnClickEvent e)
        {
            tmCoolDown.Start();
            panel_Board.Enabled=false;
            PrcBCoolDown.Value = 0;
            socket.Send1(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickPoint));
            Listen();
        }

        private void ChessBoard_EndedGame(object? sender, EventArgs e)
        {
            endGame();
            socket.Send1(new SocketData((int)SocketCommand.END_GAME, "Đã có 5 con!!!", new Point()));
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            PrcBCoolDown.PerformStep();

            if (PrcBCoolDown.Value >= PrcBCoolDown.Maximum)
            {
                endGame();

                socket.Send1(new SocketData((int)SocketCommand.TIME_OUT, "Hết giờ!!!", new Point()));
            }
        }

        void newGame()
        {
            PrcBCoolDown.Value = 0;
            tmCoolDown.Stop();
            Board.DrawChessBoard();
        }

        void Chat()
        {
            //Board.Undo();
        }

        void Undo()
        {
            Board.Undo();
            PrcBCoolDown.Value = 0;
        }
        void endGame()
        {
            tmCoolDown.Stop();
            panel_Board.Enabled = false;
            //MessageBox.Show("kết thúc!!!");
        }

        void Quit()
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
            socket.Send1(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));

        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void ChessBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {

                e.Cancel = true;
            }
            else
            {
                try
                {
                    socket.Send1(new SocketData((int)SocketCommand.QUIT, "Đối thủ đã bỏ cuộc :))", new Point()));
                }
                catch { }
            }

        }
        private void LAN_Btn_Click(object sender, EventArgs e)
        {
            

            if (!socket.ConnectServer())
            {
                socket.isServer = true;
                panel_Board.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                socket.Send1(new SocketData((int)SocketCommand.NOTIFY, "đã kết nối", new Point()));
                socket.isServer = false;
                panel_Board.Enabled = false;
                Listen();
                //MessageBox.Show("Kết nối thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            

        }

        private void ChessBoard_Shown(object sender, EventArgs e)
        {
            IPMessage.Text = socket.GetLocalIPV4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(IPMessage.Text))
            {
                IPMessage.Text = socket.GetLocalIPV4(NetworkInterfaceType.Ethernet);
            }
        }

        void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    object data = socket.Receive1();
                    SocketData data1 = socket.DeserializeSocketData(data.ToString()); //không chuyển từ object qua SocketData được
                    processData(data1);
                }
                catch (Exception e)
                {
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void processData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        newGame();
                        panel_Board.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        PrcBCoolDown.Value = 0;
                        panel_Board.Enabled = true;
                        tmCoolDown.Start();
                        Board.OtherPlayerMark(data.Point);

                    }));
                    break;

                case (int)SocketCommand.CHAT:
                    AddMessage(data.Message);
                    break;
                case (int)SocketCommand.UNDO:
                    Undo();
                    PrcBCoolDown.Value = 0;
                    break;
                case (int)SocketCommand.QUIT:
                    tmCoolDown.Stop();
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.END_GAME:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.TIME_OUT:
                    tmCoolDown.Stop();
                    MessageBox.Show(data.Message);
                    break;
                default:
                    break;
            }

            Listen();
        }

        #endregion


        private void Send_Btn_Click(object sender, EventArgs e)
        {
            

            string text = "[" + socket.IP + "]" + ": " + ChatTxt.Text;
            AddMessage(text);
            socket.Send1(new SocketData((int)SocketCommand.CHAT, text, new Point()));



        }

        void AddMessage(string msg)
        {
            if (Message_Box.Text == "")
            {
                Message_Box.Text = msg;
            }
            else
            {
                Message_Box.Text += Environment.NewLine + msg;
            }
        }
    }


}
