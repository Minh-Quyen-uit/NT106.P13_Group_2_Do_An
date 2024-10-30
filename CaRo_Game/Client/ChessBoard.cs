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

            Board = new ChessBoardManager(panel_Board, FullName, Avatar_Player);
            Board.EndedGame += ChessBoard_EndedGame;
            Board.PlayerMarked += ChessBoard_PlayerMarked;

            PrcBCoolDown.Step = Cons.Cool_Down_Step;
            PrcBCoolDown.Maximum = Cons.Cool_Down_Time;
            PrcBCoolDown.Value = 0;

            tmCoolDown.Interval = Cons.Cool_Down_Interval;

            socket = new SocketManager();

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
        void endGame()
        {
            tmCoolDown.Stop();
            panel_Board.Enabled = false;
            MessageBox.Show("kết thúc!!!");
        }

        private void ChessBoard_PlayerMarked(object? sender, EventArgs e)
        {
            tmCoolDown.Start();
            PrcBCoolDown.Value = 0;
        }

        private void ChessBoard_EndedGame(object? sender, EventArgs e)
        {
            endGame();
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            PrcBCoolDown.PerformStep();

            if (PrcBCoolDown.Value >= PrcBCoolDown.Maximum)
            {
                endGame();
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

        }

        void Quit()
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chat();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void ChessBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;

        }
        private void LAN_Btn_Click(object sender, EventArgs e)
        {
            socket.IP = IPMessage.Text;
            if (!socket.ConnectServer())
            {
                socket.CreateServer();

                Thread listenThread = new Thread(() =>
                {
                    
                    while (true)
                    {
                        Thread.Sleep(500);
                        try
                        {
                            Listen();
                            break;
                        }
                        catch { }
                    }
                    
                });
                listenThread.IsBackground = true;
                listenThread.Start();
            }
            else
            {
                    Listen();
                socket.Send("Thông tin từ Client");
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
            string data = socket.Receive().ToString();

        }

        #endregion


    }
}
