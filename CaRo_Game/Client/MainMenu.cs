using Client.DAO;
using Client.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Client
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        //IPEndPoint ipe;
        private bool _CreateRoomResult = false;
        private bool _JoinRoomResult = false;

        private Image[] tabImages;

        public MainMenu(string username)
        {
            InitializeComponent();
            //ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            //ClientSocketManager.Instance.Connect(ipe);

            AccountDAO.Instance.GetUserInfo(username);
            Username_Tb.Text = AccountDAO.Instance.GetSetAccUsername;

            ClientSocketManager.Instance.RegisterHandler<SocketRequestData>("CreateRoomResult", CreateRoomResult);
            ClientSocketManager.Instance.RegisterHandler<SocketRequestData>("JoinRoomIDResult", JoinRoomIDResult);
            ClientSocketManager.Instance.RegisterHandler<SocketRequestData>("JoinRoomRandomResult", JoinRoomRandomResult);

        }

        #region system
        private async void JoinRoomByID_Btn_Click(object sender, EventArgs e)
        {
            string ID = RoomID.Text;
            ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.JoinRoomByID, ID));

            await Task.Delay(1000);
            if (_JoinRoomResult)
                ShowChessBoard();
        }

        private async void CreateRoom_Btn_Click(object sender, EventArgs e)
        {
            ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.CreateRoom, "CreateRequest"));

            await Task.Delay(1000);
            if (_CreateRoomResult)
                ShowChessBoard();
        }

        private async void JoinRandom_Btn_Click(object sender, EventArgs e)
        {
            ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.JoinRoomRandom, "JoinRequest"));

            await Task.Delay(1000);
            if (_JoinRoomResult)
                ShowChessBoard();
        }
        private void tabMain1_Click(object sender, EventArgs e)
        {
            //UserName.Text = Username_Tb.Text;
            //PassWord.Text = ">_<";
            //FullName.Text = AccountDAO.Instance.GetSetAccFullname;
            //Email.Text = AccountDAO.Instance.GetSetAccEmail;
            //Birthday.Text = AccountDAO.Instance.GetSetAccBirthday;
        }

        private void updateAccBtn_Click(object sender, EventArgs e)
        {
            UserName.Text = Username_Tb.Text;
            PassWord.Text = ">_<";
            FullName.Text = AccountDAO.Instance.GetSetAccFullname;
            Email.Text = AccountDAO.Instance.GetSetAccEmail;
            Birthday.Text = AccountDAO.Instance.GetSetAccBirthday;
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

        private void ShowChessBoard()
        {
            ChessBoard chessBoard = new ChessBoard();

            //this.Hide();
            chessBoard.Show();

            //this.Show();
            _JoinRoomResult = false;
        }

    }
}
