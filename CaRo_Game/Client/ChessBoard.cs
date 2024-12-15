using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.DAO;
using Guna.UI2.WinForms;

namespace Client
{
    public partial class ChessBoard : MetroFramework.Forms.MetroForm
    {
        #region Properties

        ChessBoardManager Board;
        //SocketManager socket;

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

            //socket = new SocketManager();

            //socket.IP = GenerateRandomIPAddress();
            newGame();
            ClientSocketManager.Instance.RegisterHandler<SocketData>("SocketData", processData);
        }

        #region SelectionMode

        void newGame()
        {
            PrcBCoolDown.Value = 0;
            tmCoolDown.Stop();
            Board.DrawChessBoard();
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

        #endregion

        #region SocketConnection

        //void Listen()
        //{
        //    Thread listenThread = new Thread(() =>
        //    {
        //        try
        //        {
        //            object data = socket.Receive1();
        //            SocketData data1 = socket.DeserializeSocketData(data.ToString()); //không chuyển từ object qua SocketData được
        //            processData(data1);
        //        }
        //        catch (Exception e)
        //        {
        //        }
        //    });
        //    listenThread.IsBackground = true;
        //    listenThread.Start();
        //}

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
                    this.Invoke((MethodInvoker)(() =>
                    {
                        endGame();
                        MessageBox.Show(" đã chiến thắng ♥ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                    break;
                case (int)SocketCommand.TIME_OUT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        endGame();
                        MessageBox.Show("Hết giờ rồi !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                    break;
                case (int)SocketCommand.PLAYER_1:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        Board.setUpPlayer1(data.Message);
                        Board.setUpPlayer2(FullName.Text);
                    }));
                    break;
                case (int)SocketCommand.PLAYER_2:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        Board.setUpPlayer2(data.Message);
                        ClientSocketManager.Instance.Send("SocketData", new SocketData((int)SocketCommand.PLAYER_1, FullName.Text, new Point()));
                    }));
                    break;
                default:
                    break;
            }

            //Listen();
        }

        #endregion

        #region System

        private void ChessBoard_PlayerMarked(object? sender, BtnClickEvent e)
        {
            tmCoolDown.Start();
            panel_Board.Enabled=false;
            PrcBCoolDown.Value = 0;
            ClientSocketManager.Instance.Send("SocketData",new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickPoint));
            //Listen();
        }

        private void ChessBoard_EndedGame(object? sender, EventArgs e)
        {
            endGame();
            ClientSocketManager.Instance.Send("SocketData", new SocketData((int)SocketCommand.END_GAME, "Đã có 5 con!!!", new Point()));
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            PrcBCoolDown.PerformStep();

            if (PrcBCoolDown.Value >= PrcBCoolDown.Maximum)
            {
                endGame();
                ClientSocketManager.Instance.Send("SocketData", new SocketData((int)SocketCommand.TIME_OUT, "Hết giờ!!!", new Point()));
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
            ClientSocketManager.Instance.Send("SocketData", new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void ChessBoard_Shown(object sender, EventArgs e)
        {
            //IPMessage.Text = socket.GetLocalIPV4(NetworkInterfaceType.Wireless80211);
            //if (string.IsNullOrEmpty(IPMessage.Text))
            //{
            //    IPMessage.Text = socket.GetLocalIPV4(NetworkInterfaceType.Ethernet);
            //}
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
                    ClientSocketManager.Instance.Send("SocketData", new SocketData((int)SocketCommand.QUIT, "Đối thủ đã bỏ cuộc :))", new Point()));
                }
                catch { }
            }

        }

        private void Send_Btn_Click_1(object sender, EventArgs e)
        {
            //string text = "[" + socket.IP + "]" + ": " + ChatTxt.Text;
            //AddMessage(text);
            //socket.Send1(new SocketData((int)SocketCommand.CHAT, text, new Point()));
            //ChatTxt.Clear();
        }

        private void LAN_Btn_Click(object sender, EventArgs e)
        {
            //if (!socket.ConnectServer())
            //{
            //    socket.isServer = true;
            //    panel_Board.Enabled = true;
            //    socket.CreateServer();
            //}
            //else
            //{
            //    socket.Send1(new SocketData((int)SocketCommand.NOTIFY, "đã kết nối", new Point()));
            //    socket.isServer = false;
            //    panel_Board.Enabled = false;
            //    Listen();
            //    //MessageBox.Show("Kết nối thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
        #endregion

        #region Method
        private string GenerateRandomIPAddress()
        {
            Random random = new Random();
            int part1 = 127;    // Phần đầu (1-255)
            int part2 = random.Next(0, 256);    // Phần thứ hai (0-255)
            int part3 = random.Next(0, 256);    // Phần thứ ba (0-255)
            int part4 = random.Next(1, 256);    // Phần cuối (1-255)

            return $"{part1}.{part2}.{part3}.{part4}";
        }

        void AddMessage(string msg)
        {
            if (string.IsNullOrEmpty(Message_Box.Text))
            {
                Message_Box.Text = msg ;
            }
            else
            {
                Message_Box.Text += Environment.NewLine + msg;
            }
        }
        #endregion

        
    }


}
