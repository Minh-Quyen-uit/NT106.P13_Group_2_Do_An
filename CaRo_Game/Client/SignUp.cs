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
        }

        #region System
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            Connect();
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

            Send(username, EncryptedPassword, fullname, email, birthday);
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
        void Connect()
        {
            ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            tcpClient = new TcpClient();
            tcpClient.Connect(ipe);
            stream = tcpClient.GetStream();
            Thread recv = new Thread(Receive);
            recv.IsBackground = true;
            recv.Start();
        }

        void Send(string username, string password, string fullname, string email, string birthday)
        {
            string str = "1" + Environment.NewLine + username + Environment.NewLine + password + Environment.NewLine
                + fullname + Environment.NewLine
                + email + Environment.NewLine + birthday;
            byte[] data = Encoding.UTF8.GetBytes(str);
            stream.Write(data, 0, data.Length);
            //AddMessage(Message.str);

        }

        void Receive()
        {
            while (true)
            {

                byte[] recv = new byte[1024];
                stream.Read(recv, 0, recv.Length);
                string xmlStr = Encoding.UTF8.GetString(recv);
                string s = DeserializeXMLData(xmlStr);
                //AddMessage(s);

                int result = int.Parse(s);
                if (result == 1)
                {
                    if (MessageBox.Show("Bạn đăng kí thành công", "Thông báo", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    return;
                }
            }

        }

        public string DeserializeXMLData(string xmlString)
        {
            xmlString = xmlString.TrimEnd('\0');
            using (var stringReader = new StringReader(xmlString))
            using (var xmlReader = XmlReader.Create(stringReader))
            {
                var serializer = new DataContractSerializer(typeof(string));
                return (string)serializer.ReadObject(xmlReader);
            }
        }
        #endregion


    }
}
