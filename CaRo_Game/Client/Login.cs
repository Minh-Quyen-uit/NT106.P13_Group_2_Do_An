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

namespace Client
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        IPEndPoint ipe;
        private bool _loginResult = false;

        public Login()
        {
            InitializeComponent();
            ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            ClientSocketManager.Instance.Connect(ipe);
            ClientSocketManager.Instance.RegisterHandler<SocketRequestData>("LoginResult", loginResult);
        }

        #region system

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = PassWord.Text;
            if (username.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!!!");
            }
            else if (password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!!!");
            }
            else
            {

                var sha256 = SHA256.Create();
                byte[] EnteredPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string EncryptEnteredPassword = Convert.ToBase64String(EnteredPassword);
                SendLoginRequest(username, EncryptEnteredPassword);

            }

            await Task.Delay(100);
            if (_loginResult)
            {
                showMainMenu();
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
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
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
                bool result = (bool)loginResult.Data;
                if (!result)
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _loginResult = true;
                }
            }
        }
        #endregion



        private void showMainMenu()
        {
            using MainMenu mainMenu = new MainMenu();
            //mainMenu.Show();
            //this.Close();
            this.Hide();
            mainMenu.ShowDialog();
            this.Show();
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
    }
}
