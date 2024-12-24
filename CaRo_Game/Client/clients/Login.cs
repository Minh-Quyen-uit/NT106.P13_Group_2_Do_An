using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml;
using System.Security.Cryptography;
using System.Drawing.Drawing2D;
using Client.DAO;
using System.Runtime.InteropServices;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using Azure.Core;
using System.Collections;
using System.Net.NetworkInformation;

namespace Client
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        IPEndPoint ipe;
        private bool _loginResult = false;

        public Login(string ipTxt)
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(ipTxt))
            {
                ipTxt = getIPV4();
            } 
                
            ipe = new IPEndPoint(IPAddress.Parse(ipTxt), 9999);
            ClientSocketManager.Instance.Connect(ipe);
            ClientSocketManager.Instance.RegisterHandler<SocketRequestData>("LoginResult", loginResult);
            ClientSocketManager.Instance.RegisterHandler<SocketRequestData>("AccountInfoResult", AccountInfoResult);
        }

        #region system

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = PassWord.Text;
            if (username.Trim() == "")
            {
                MessageBox.Show(this, "Vui lòng nhập tên tài khoản!!!");
            }
            else if (password.Trim() == "")
            {
                MessageBox.Show(this, "Vui lòng nhập mật khẩu!!!");
            }
            else
            {

                var sha256 = SHA256.Create();
                byte[] EnteredPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string EncryptEnteredPassword = Convert.ToBase64String(EnteredPassword);
                SendLoginRequest(username, EncryptEnteredPassword);

                await ClientSocketManager.Instance.AwaitHandler<SocketRequestData>("LoginResult", TimeSpan.FromSeconds(5));
            }

            if (_loginResult)
            {
                _loginResult = false;
                ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.AccountInfo, username));
                await ClientSocketManager.Instance.AwaitHandler<SocketRequestData>("AccountInfoResult", TimeSpan.FromSeconds(5));

                showMainMenu(username);
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
            this.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        #region TCP
        void SendLoginRequest(string username, string password)
        {
            string[] Credentials = { username, password };
            ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.Login, Credentials));
        }

        private void loginResult(SocketRequestData loginResult)
        {
            if ((int)loginResult.RequestType == (int)SocketRequestType.Login)
            {
                int result = Convert.ToInt32(loginResult.Data);
                if (result == 0)
                {
                    MessageBox.Show(this, "Tên tài khoản hoặc mật khẩu không chính xác!!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 1)
                {
                    _loginResult = true;
                }
                else if (result == 2)
                {
                    MessageBox.Show(this, "Tài khoản đã được đăng nhập trên thiết bị khác!!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AccountInfoResult(SocketRequestData AccountInfo)
        {
            if ((int)AccountInfo.RequestType == (int)SocketRequestType.AccountInfo)
            {
                string[] result = ((IEnumerable)AccountInfo.Data).Cast<object>().Select(x => x.ToString()).ToArray();
                ClientAccountDAO.Instance.GetUserInfo(result);
            }
        }
        #endregion



        private void showMainMenu(string username)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void PasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheck.Checked)
            {
                // Hiển thị mật khẩu
                PassWord.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                PassWord.PasswordChar = '*';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private string getIPV4() { 
            SocketManager socket;
            socket = new SocketManager();
            string IP = socket.GetLocalIPV4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(IP))
            {
                IP = socket.GetLocalIPV4(NetworkInterfaceType.Ethernet);
            }
            return IP;
        }
    }
}
