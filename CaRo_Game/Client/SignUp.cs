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
using System.Security.Cryptography;
using System.Runtime.Serialization;
using System.Xml;

namespace Client
{
    public partial class SignUp : MetroFramework.Forms.MetroForm
    {
        IPEndPoint ipe;
        TcpClient tcpClient;
        Stream stream;
        public SignUp()
        {
            InitializeComponent();
            BirthDay.Format = DateTimePickerFormat.Custom;
            BirthDay.CustomFormat = "yyyy-MM-dd";

            ClientSocketManager.Instance.RegisterHandler<SocketRequestData>("SocketRequestData", SignUpResult);
        }

        #region System
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = PassWord.Text;
            string REpassword = PassWordConfirm.Text;
            string fullname = FullName.Text;
            string email = Email.Text;
            string birthday = BirthDay.Text;

            if (string.IsNullOrEmpty(username)) { MessageBox.Show("Vui lòng nhập tên tài khoản!"); return; }
            if (password.Length < 8) { MessageBox.Show("Mật khẩu dài ít nhất 8 ký tự!"); return; }
            if (password != REpassword) { MessageBox.Show("Mật khẩu nhập lại không chính xác!"); return; }
            if (string.IsNullOrEmpty(fullname)) { MessageBox.Show("Vui lòng nhập tên người dùng!"); return; }

            var sha256 = SHA256.Create();
            byte[] Encrypt = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            string EncryptedPassword = Convert.ToBase64String(Encrypt);

            string[] Credentials = { username, EncryptedPassword, fullname, email, birthday };

            ClientSocketManager.Instance.Send("SocketRequestData", new SocketRequestData((int)SocketRequestType.SignUp, Credentials));
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PasswordChar_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordChar.Checked)
            {
                // Hiển thị mật khẩu
                PassWord.PasswordChar = '\0';
                PassWordConfirm.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                PassWord.PasswordChar = '*';
                PassWordConfirm.PasswordChar = '*';
            }
        }
        #endregion

        #region TCP
        private void SignUpResult(SocketRequestData signUpResult)
        {
            if ((int)signUpResult.RequestType == (int)SocketRequestType.SignUp)
            {
                if (signUpResult.Data.ToString() == "0")
                {
                    MessageBox.Show("sign up failed");
                    return;
                }
                else
                {
                    MessageBox.Show("sign up success");
                }
            }
        }

        #endregion


    }
}
