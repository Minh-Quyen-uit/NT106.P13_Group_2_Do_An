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
using Client.DAO;

namespace Client
{
    public partial class Server : Form
    {
        IPEndPoint ipe;
        Socket client;
        TcpListener tcpListen;

        public Server()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        #region TCP
        void Connect()
        {
            ipe = new IPEndPoint(IPAddress.Any, 9999);
            tcpListen = new TcpListener(ipe);
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    tcpListen.Start();
                    client = tcpListen.AcceptSocket();
                    Thread rec = new Thread(Receive);
                    rec.IsBackground = true;
                    rec.Start(client);
                }
            });
            thread.IsBackground = true;
            thread.Start();


        }

        void Send(Socket client, object result)
        {
            byte[] data = SerializeData(result);
            client.Send(data);

        }

        void Receive(object obj)
        {
            while (true)
            {
                Socket client = obj as Socket;
                if (client == null)
                {

                    throw new ArgumentException("obj không thể chuyển đổi sang Socket");
                }

                byte[] recv = new byte[5000*1024];
                int bytesReceived = client.Receive(recv);
                string s = Encoding.UTF8.GetString(recv, 0, bytesReceived);
                string[] str = s.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                ReceiveMessage(s);

                switch (int.Parse(str[0].Trim()))
                {
                    case 0: Selection0(client, str); break;
                    case 1: Selection1(client, str); break;
                    //case 2: Selection2(client, str); break;
                        //case 3: Selection3(client, str); break;
                        //case 4: Selection4(client, str); break;
                }
            }

        }

        void Selection0(Socket client, string[] str)
        {
            ReceiveMessage("Client Login form:\n");
            string username = str[1].Trim();
            string password = str[2].Trim();
            ReceiveMessage(username);
            ReceiveMessage(password);

            bool result = AccountDAO.Instance.login(username, password);

            if (result)
            {
                //cho phep dang nhap
                //LoadUserAccount(username);

                Send(client, "1");
                SendMessage("To client Login: 1");
            }
            else
            {
                //khong cho phep dang nhap

                Send(client, "0");
                SendMessage("To client Login: 0");
            }
        }

        void Selection1(Socket client, string[] str)
        {
            ReceiveMessage("Client Sign up form:\n");
            string username = str[1].Trim();
            string password = str[2].Trim();
            string fullname = str[3].Trim();
            string email = str[4].Trim();
            string birthday = str[5].Trim();
            ReceiveMessage(username);
            ReceiveMessage(password);
            ReceiveMessage(fullname);
            ReceiveMessage(email);
            ReceiveMessage(birthday);

            if (AccountDAO.Instance.signin(username, password, fullname, email, birthday) != 0)
            {
                Send(client, "1");
                SendMessage("To client Sign up: 1");
            }
            else
            {
                Send(client, "0");
                SendMessage("To client Sign up: 0");
            }
        }

        //void Selection2(Socket client, string[] str)
        //{
        //    string username = str[1].Trim();
        //    AccountDAO.Instance.GetUserInfo(username);
        //    ReceiveMessage("Client Main form:\n");
        //    ReceiveMessage(username);
        //    string rec = AccountDAO.Instance.GetSetAccUsername + Environment.NewLine
        //        + AccountDAO.Instance.GetSetAccFullname + Environment.NewLine
        //        + AccountDAO.Instance.GetSetAccEmail + Environment.NewLine
        //        + AccountDAO.Instance.GetSetAccBirthday + Environment.NewLine;
        //    //AddMessage(rec);
        //    Send(client, rec);
        //    SendMessage("To client Main form:");
        //    SendMessage(rec);
        //}

        //void Selection3(Socket client, string[] str)
        //{
        //    string username = str[1].Trim();
        //    ReceiveMessage("Client Search form:\n");
        //    ReceiveMessage(username);
        //    //List<string> list = BookShelf.Instance.GetBookShelfs(username);
        //    DataTable dt = BookShelf.Instance.GetBookShelfs(username);
        //    dt.TableName = "BookshelfName";
        //    Send(client, dt);
        //}

        //void Selection4(Socket client, string[] str)
        //{
        //    string BookshelfName = str[1].Trim();
        //    string username = str[2].Trim();
        //    ReceiveMessage("Client Search form:\n");
        //    ReceiveMessage(BookshelfName);
        //    ReceiveMessage(username);
        //    //List<string> data = new List<string>();


        //    if (BookShelf.Instance.AddBookShelf(BookshelfName, username) == 0)
        //    {
        //        DataTable dataTable = new DataTable();
        //        dataTable.TableName = "BookshelfName";
        //        Send(client, dataTable);
        //    }
        //    else
        //    {
        //        DataTable dataTable = BookShelf.Instance.GetBookShelfs(username);
        //        dataTable.TableName = "BookshelfName";
        //        Send(client, dataTable);
        //    }

        //}

        public byte[] SerializeData(object obj)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                DataContractSerializer serializer = new DataContractSerializer(obj.GetType());
                serializer.WriteObject(ms, obj);
                return ms.ToArray();
            }
        }



        public object DeserializeData(byte[] data)
        {
            return Encoding.UTF8.GetString(data);
        }
        #endregion

        #region system
        private void ExtBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        void ReceiveMessage(string msg)
        {
            if (ServerScreen.Text == "")
            {
                ServerScreen.Text = msg;
            }
            else
            {
                ServerScreen.Text += Environment.NewLine + msg;
            }
        }
        void SendMessage(string msg)
        {
            if (SendMess.Text == "")
            {
                SendMess.Text = msg;
            }
            else
            {
                SendMess.Text += Environment.NewLine + msg;
            }
        }
        
    }
}
