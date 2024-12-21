using Client.DAO;
using System.Net.NetworkInformation;

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
            newGame();
            ClientSocketManager.Instance.RegisterHandler<SocketData>("SocketData", processData);

            panel_Board.Enabled = false;
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
        }
        #endregion

        #region SocketConnection

        private void processData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    panel_Board.Enabled = true;
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
                        panel_Board.Enabled = false;
                        MessageBox.Show(data.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                case(int)SocketCommand.EXIT_GAME:
                    this.Close();
                    break;

                default:
                    break;
            }
        }

        #endregion

        #region System

        private void ChessBoard_PlayerMarked(object? sender, BtnClickEvent e)
        {
            tmCoolDown.Start();
            panel_Board.Enabled = false;
            PrcBCoolDown.Value = 0;
            ClientSocketManager.Instance.Send("SocketData", new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickPoint));
            //Listen();
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
                if(panel_Board.Enabled)
                {
                    ClientSocketManager.Instance.Send("SocketData", new SocketData((int)SocketCommand.TIME_OUT, "Client", new Point()));
                }
                else
                {
                    ClientSocketManager.Instance.Send("SocketData", new SocketData((int)SocketCommand.TIME_OUT, "Opponent", new Point()));
                }
                
            }
        }

        private void ChessBoard_Shown(object sender, EventArgs e)
        {
            SocketManager socket;
            socket = new SocketManager();
            IPMessage.Text = socket.GetLocalIPV4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(IPMessage.Text))
            {
                IPMessage.Text = socket.GetLocalIPV4(NetworkInterfaceType.Ethernet);
            }
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
                    ClientSocketManager.Instance.Send("SocketData", new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }
            }

            ClientSocketManager.Instance.RemoveHandler("SocketData");
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Send_Btn_Click(object sender, EventArgs e)
        {
            string text = "[" + ClientAccountDAO.Instance.GetSetAccFullname + "]" + ": " + ChatTxt.Text;
            AddMessage(text);
            ClientSocketManager.Instance.Send("SocketData", new SocketData((int)SocketCommand.CHAT, text, new Point()));
            ChatTxt.Clear();
        }
        #endregion

        #region Method

        void AddMessage(string msg)
        {
            if (string.IsNullOrEmpty(Message_Box.Text))
            {
                Message_Box.Text = msg;
            }
            else
            {
                Message_Box.Text += Environment.NewLine + msg;
            }
        }
        #endregion

    }
}
