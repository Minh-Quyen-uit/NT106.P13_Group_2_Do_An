using Client.DAO;
using System.Drawing.Imaging;
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
            ClientSocketManager.Instance.RegisterHandler<SocketRequestData>("ChangeAvatarResult", ChangeAvatarResult);

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

        private async void updateAccBtn_Click(object sender, EventArgs e)
        {
            ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.AccountInfo, ClientAccountDAO.Instance.GetSetAccUsername));
            await ClientSocketManager.Instance.AwaitHandler<SocketRequestData>("AccountInfoResult", TimeSpan.FromSeconds(50));
            MessageBox.Show(this, "Cập nhật thành công!");

            UserName.Text = Username_Tb.Text;
            PassWord.Text = "********";
            FullName.Text = ClientAccountDAO.Instance.GetSetAccFullname;
            Email.Text = ClientAccountDAO.Instance.GetSetAccEmail;
            Birthday.Text = ClientAccountDAO.Instance.GetSetAccBirthday;

            Username_Tb.Text = ClientAccountDAO.Instance.GetSetAccUsername;
            RankTxt.Text = ClientAccountDAO.Instance.GetSetAccRank;
            AchievementTxt.Text = ClientAccountDAO.Instance.GetSetAccTotalWins.ToString() + " Trận thắng";
            pictureBox1.Image = ClientAccountDAO.Instance.GetUserAvatar(ClientAccountDAO.Instance.GetSetAccAvatar);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private async void changeAvatar_Btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Đổi Avatar";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filepath = openFileDialog.FileName;

                    //Check valid image
                    if (!File.Exists(filepath))
                    {
                        MessageBox.Show(this, "File không tồn tại!!!");
                        return;
                    }

                    try
                    {
                        using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                        {
                            Image testImage = Image.FromStream(fs);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, $"Đây không phải ảnh!!!");
                        return;
                    }

                    Image chosenAvatar = Image.FromFile(filepath);
                    ImageFormat format = chosenAvatar.RawFormat;
                    string Base64Image;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        chosenAvatar.Save(ms, format);
                        byte[] ImageData = ms.ToArray();

                        Base64Image = Convert.ToBase64String(ImageData);
                    }

                    ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.ChangeAvatar, Base64Image));
                    await ClientSocketManager.Instance.AwaitHandler<SocketRequestData>("ChangeAvatarResult", TimeSpan.FromSeconds(50));
                }
            }
        }

        #endregion

        private void informationOfPlayer()
        {
            UserName.Text = ClientAccountDAO.Instance.GetSetAccUsername;
            PassWord.Text = "********";
            FullName.Text = ClientAccountDAO.Instance.GetSetAccFullname;
            Email.Text = ClientAccountDAO.Instance.GetSetAccEmail;
            Birthday.Text = ClientAccountDAO.Instance.GetSetAccBirthday;

            Username_Tb.Text = ClientAccountDAO.Instance.GetSetAccUsername;
            RankTxt.Text = ClientAccountDAO.Instance.GetSetAccRank;
            AchievementTxt.Text = ClientAccountDAO.Instance.GetSetAccTotalWins.ToString() + " Trận thắng";
            pictureBox1.Image = ClientAccountDAO.Instance.GetUserAvatar(ClientAccountDAO.Instance.GetSetAccAvatar);
        }

        #region DataHandler

        private void CreateRoomResult(SocketRequestData Result)
        {
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

        private void ChangeAvatarResult(SocketRequestData Result)
        {
            if ((int)Result.RequestType == (int)SocketRequestType.ChangeAvatar)
            {
                bool result = (bool)Result.Data;
                if (result)
                {
                    MessageBox.Show("Đổi Avatar thành công!");
                }
                else
                {
                    MessageBox.Show("Đổi Avatar không thành công!");
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
            informationOfPlayer();
        }
    }
}
