using Client.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Client
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        //IPEndPoint ipe;
        private bool _CreateRoomResult = false;
        private bool _JoinRoomResult = false;
        private bool _CreateRoom = false;

        private Image[] tabImages;

        public MainMenu()
        {
            InitializeComponent();
            //ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            //ClientSocketManager.Instance.Connect(ipe);


            Username_Tb.Text = ClientAccountDAO.Instance.GetSetAccUsername;
            RankTxt.Text = ClientAccountDAO.Instance.GetSetAccRank;
            AchievementTxt.Text = ClientAccountDAO.Instance.GetSetAccTotalWins.ToString() + " Trận thắng";

            string Base64AccAvatar = ClientAccountDAO.Instance.GetSetAccAvatar;
            Image Avatar = ClientAccountDAO.Instance.GetUserAvatar(Base64AccAvatar);
            pictureBox1.Image = Avatar;

            informationOfPlayer();

            ClientSocketManager.Instance.RegisterHandler<SocketRequestData>("CreateRoomResult", CreateRoomResult);
            ClientSocketManager.Instance.RegisterHandler<SocketRequestData>("JoinRoomIDResult", JoinRoomIDResult);
            ClientSocketManager.Instance.RegisterHandler<SocketRequestData>("JoinRoomRandomResult", JoinRoomRandomResult);

        }

        #region system
        private async void JoinRoomByID_Btn_Click(object sender, EventArgs e)
        {
            string ID = RoomID.Text;
            ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.JoinRoomByID, ID));

            await ClientSocketManager.Instance.AwaitHandler<SocketRequestData>("JoinRoomIDResult", TimeSpan.FromSeconds(5));
            if (_JoinRoomResult)
            {
                _JoinRoomResult = false;
                ShowChessBoard(_CreateRoom);
            }
        }

        private async void CreateRoom_Btn_Click(object sender, EventArgs e)
        {
            ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.CreateRoom, "CreateRequest"));

            await ClientSocketManager.Instance.AwaitHandler<SocketRequestData>("CreateRoomResult", TimeSpan.FromSeconds(5));
            if (_CreateRoomResult)
            {
                _CreateRoomResult = false;
                ShowChessBoard(_CreateRoom);
                _CreateRoom = false;
            }
        }

        private async void JoinRandom_Btn_Click(object sender, EventArgs e)
        {
            ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.JoinRoomRandom, "JoinRequest"));

            await ClientSocketManager.Instance.AwaitHandler<SocketRequestData>("JoinRoomRandomResult", TimeSpan.FromSeconds(5));
            if (_JoinRoomResult)
            {
                _JoinRoomResult = false;
                ShowChessBoard(_CreateRoom);
            }
        }
        private void informationOfPlayer()
        {
            UserName.Text = Username_Tb.Text;
            PassWord.Text = ">_<";
            FullName.Text = AccountDAO.Instance.GetSetAccFullname;
            Email.Text = AccountDAO.Instance.GetSetAccEmail;
            Birthday.Text = AccountDAO.Instance.GetSetAccBirthday;
        }

        private void updateAccBtn_Click(object sender, EventArgs e)
        {
            UserName.Text = Username_Tb.Text;
            PassWord.Text = ">_<";
            FullName.Text = AccountDAO.Instance.GetSetAccFullname;
            Email.Text = AccountDAO.Instance.GetSetAccEmail;
            Birthday.Text = AccountDAO.Instance.GetSetAccBirthday;

            Username_Tb.Text = ClientAccountDAO.Instance.GetSetAccUsername;
            RankTxt.Text = ClientAccountDAO.Instance.GetSetAccRank;
            AchievementTxt.Text = ClientAccountDAO.Instance.GetSetAccTotalWins.ToString() + " Trận thắng";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region DataHandler

        private void CreateRoomResult(SocketRequestData Result)
        {
            //MessageBox.Show("recieved");
            if ((int)Result.RequestType == (int)SocketRequestType.CreateRoom)
            {
                bool result = (bool)Result.Data;
                if (result)
                {
                    _CreateRoomResult = true;
                    _CreateRoom = true;
                }
                else
                {
                    MessageBox.Show("Tạo phòng không thành công!");
                }
            }
        }

        private void JoinRoomIDResult(SocketRequestData Result)
        {
            if ((int)Result.RequestType == (int)SocketRequestType.JoinRoomByID)
            {
                bool result = (bool)Result.Data;
                if (result)
                {
                    _JoinRoomResult = true;
                }
                else
                {
                    MessageBox.Show("Vào phòng không thành công!");
                }
            }
        }

        private void JoinRoomRandomResult(SocketRequestData Result)
        {
            if ((int)Result.RequestType == (int)SocketRequestType.JoinRoomRandom)
            {
                bool result = (bool)Result.Data;
                if (result)
                {
                    _JoinRoomResult = true;
                }
                else
                {
                    MessageBox.Show("Vào phòng không thành công!");
                }
            }
        }

        #endregion

        private void ShowChessBoard(bool isCreate)
        {
            using ChessBoard chessBoard = new ChessBoard(isCreate);

            this.Hide();
            chessBoard.ShowDialog();
            this.Show();

            ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.AccountInfo, ClientAccountDAO.Instance.GetSetAccUsername));
            //this.Show();
        }

        
    }
}
