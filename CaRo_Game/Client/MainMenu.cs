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
        private bool _JoinRoomIDResult = false;


        public MainMenu()
        {
            InitializeComponent();
            //ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            //ClientSocketManager.Instance.Connect(ipe);
            ClientSocketManager.Instance.RegisterHandler<SocketRequestData>("CreateRoomResult", CreateRoomResult);
            ClientSocketManager.Instance.RegisterHandler<SocketRequestData>("JoinRoomIDResult", JoinRoomIDResult);

        }

        private async void JoinRoomByID_Btn_Click(object sender, EventArgs e)
        {
            string ID = RoomID.Text;
            ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.JoinRoomByID, ID));
            
            await Task.Delay(1000);
            if(_JoinRoomIDResult) 
                ShowChessBoard();
        }

        private async void CreateRoom_Btn_Click(object sender, EventArgs e)
        {
            ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.CreateRoom, "CreateRequest"));
            
            await Task.Delay(1000);
            if(_CreateRoomResult) ShowChessBoard();
        }
        
        private void JoinRandom_Btn_Click(object sender, EventArgs e)
        {

        }

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
            if((int)Result.RequestType == (int)SocketRequestType.JoinRoomByID)
            {
                bool result = (bool)Result.Data;
                if (result)
                {
                    _JoinRoomIDResult = true;
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
            using ChessBoard chessBoard = new ChessBoard();
            this.Hide();
            chessBoard.ShowDialog();
            this.Show();
        }
    }
}
