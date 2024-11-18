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

namespace Client
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        IPEndPoint ipe;
        TcpClient tcpClient;
        Stream stream;

        public Login()
        {
            InitializeComponent();
        }

        #region system

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Connect();

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
                Send(username, EncryptEnteredPassword);

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

        void Send(string username, string password)
        {
            string str = "0" + Environment.NewLine + username + Environment.NewLine + password + Environment.NewLine;
            byte[] data = Encoding.UTF8.GetBytes(str);
            stream.Write(data, 0, data.Length);

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
                if (int.Parse(s) == 0)
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (int.Parse(s) == 1)
                {

                    showChessBoard();
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

      

        private void showChessBoard()
        {
            ChessBoard board = new ChessBoard();
            this.Hide();
            board.ShowDialog();
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
    }
}
