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
using Newtonsoft.Json;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Client.Server;
using Newtonsoft.Json.Bson;

namespace Client.Server
{
    public partial class Server : Form
    {
        IPEndPoint ipe;
        Socket client;
        TcpListener tcpListen;

        //Create a dictionary to handle specific datatype sent by the client
        private readonly Dictionary<string, (Delegate handler, Type targetType)> _typehandler = new();

        private readonly Dictionary<string, Socket> _matchQueue = new();
        private readonly Dictionary<int, MatchRoom> _matchRooms = new();
        private int MatchID = 1;

        //Replace ClientInfo with a proper class later
        private readonly Dictionary<string, Socket> _clients = new();

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

        void Receive(object obj)
        {
            Socket client = obj as Socket;
            if (client == null)
            {

                throw new ArgumentException("obj không thể chuyển đổi sang Socket");
            }

            while (true)
            {
                try
                {
                    RegisterHandler<SocketRequestData>("SocketRequestData", Request =>
                    {
                        switch ((int)Request.RequestType)
                        {
                            case (int)SocketRequestType.Login:
                                LoginRequest(client, Request);
                                SendMessage(client); break;

                            case (int)SocketRequestType.SignUp:
                                SignUpRequest(client, Request);
                                SendMessage(client); break;

                            case (int)SocketRequestType.CreateRoom:
                                CreateRoomRequest(client, Request);
                                SendMessage(client); break;

                            case (int)SocketRequestType.JoinRoomByID:
                                EnterRoomByIDRequest(client, Request);
                                SendMessage(client); break;

                            case (int)SocketRequestType.JoinRoomRandom:
                                EnterRoomRandom(client, Request);
                                SendMessage(client); break;
                        }

                    });

                    RegisterHandler<SocketData>("SocketData", MatchData =>
                    {
                        MatchDataFoward(client, MatchData);
                    });

                    byte[] recv = new byte[5000 * 1024];
                    int bytesReceived = client.Receive(recv);

                    if (bytesReceived > 0)
                    {
                        ReceiveMessage("--------------------------\n");
                        ReceiveMessage(client.RemoteEndPoint.ToString());
                        ReceiveMessage("--------------------------\n");

                        string json = Encoding.UTF8.GetString(recv, 0, bytesReceived);
                        dynamic message = JsonConvert.DeserializeObject<dynamic>(json);
                        string messageType = message.Type;
                        var data = message.Data;

                        ReceiveMessage(json);

                        if (_typehandler.ContainsKey(messageType))
                        {
                            var (handler, targetType) = _typehandler[messageType];

                            //MessageBox.Show($"Handler found for type '{messageType}'. Expected data type: '{targetType.Name}'.");

                            try
                            {
                                // Deserialize the data to the correct type
                                var deserializedData = JsonConvert.DeserializeObject(JsonConvert.SerializeObject(data), targetType);

                                // Invoke the handler
                                handler.DynamicInvoke(deserializedData);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error deserializing data for type '{messageType}': {ex.Message}");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"No handler found for type: {messageType}");
                        }
                    }
                }
                catch
                {
                    DisconnectClient(client);
                }
            }

        }

        //Register a handler to handle a specific type
        public void RegisterHandler<T>(string type, Action<T> handler)
        {
            _typehandler[type] = (handler, typeof(T));
        }

        public byte[] SerializeData(string type, object data)
        {
            var message = new
            {
                Type = type,
                Data = data
            };
            string json = JsonConvert.SerializeObject(message);
            return Encoding.UTF8.GetBytes(json);
        }

        void DisconnectClient(Socket client)
        {
            client.Close();
            string key = _clients.FirstOrDefault(kvp => kvp.Value == client).Key;

            if(_clients.ContainsKey(key))
            {
                _clients.Remove(key);
            }
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
        void SendMessage(Socket client)
        {
            //if (SendMess.Text == "")
            //{
            //    SendMess.Text = msg;
            //}
            //else
            //{
            //    SendMess.Text += Environment.NewLine + msg;
            //}

            if (SendMess.Text == "")
            {
                SendMess.Text = "------------------" + Environment.NewLine;
                SendMess.Text += client.RemoteEndPoint.ToString() + Environment.NewLine;
                SendMess.Text += "------------------" + Environment.NewLine;
            }
            else
            {
                SendMess.Text += "------------------" + Environment.NewLine;
                SendMess.Text += client.RemoteEndPoint.ToString() + Environment.NewLine;
                SendMess.Text += "------------------" + Environment.NewLine;
            }
        }

        #region DataHandler
        private void LoginRequest(Socket client, SocketRequestData Request)
        {
            ReceiveMessage("Client Login form:\n");
            string[] Credentials = ((IEnumerable)Request.Data).Cast<object>().Select(x => x.ToString()).ToArray();

            string username = Credentials[0];
            string password = Credentials[1];

            ReceiveMessage(username);
            ReceiveMessage(password);

            bool LoginResult = AccountDAO.Instance.login(username, password);
            int Data = 0;

            if(LoginResult)
            {
                if (!_clients.ContainsKey(username))
                {
                    _clients[username] = client;
                    Data = 1;
                }
                else
                {
                    Data = 2;
                }
            }

            byte[] LoginData = SerializeData("LoginResult", new SocketRequestData((int)SocketRequestType.Login, Data));
            client.Send(LoginData);
        }

        private void SignUpRequest(Socket client, SocketRequestData Request)
        {
            ReceiveMessage("Client Sign Up form:\n");
            string[] Credentials = ((IEnumerable)Request.Data).Cast<object>().Select(x => x.ToString()).ToArray();
            string username = Credentials[0];
            string password = Credentials[1];
            string fullname = Credentials[2];
            string email = Credentials[3];
            string birthday = Credentials[4];
            
            ReceiveMessage(username);
            ReceiveMessage(password);
            ReceiveMessage(fullname);
            ReceiveMessage(email);
            ReceiveMessage(birthday);

            int result = AccountDAO.Instance.signin(username, password, fullname, email, birthday);
            byte[] data = SerializeData("SignUpResult", new SocketRequestData((int)SocketRequestType.SignUp, result));

            client.Send(data);
        }

        private void CreateRoomRequest(Socket client, SocketRequestData Request)
        {
            ReceiveMessage("Client create room:\n");
            string IPAddress = ((IPEndPoint)client.RemoteEndPoint).Address.ToString();
            _matchQueue[IPAddress] = client;

            bool result = false;
            if (_matchQueue.ContainsKey(IPAddress))
                result = true;

            byte[] data = SerializeData("CreateRoomResult", new SocketRequestData((int)SocketRequestType.CreateRoom, result));
            
            client.Send(data);
        }

        private Socket FindPlayerIP(string IP)
        {

            if(_matchQueue.ContainsKey(IP))
                return _matchQueue[IP];

            return null;
        }

        private void EnterRoomByIDRequest(Socket client, SocketRequestData Request)
        {
            ReceiveMessage("Client Enter room ID");
            
            String ID = Request.Data.ToString();
            var TargetPlayer = FindPlayerIP(ID);
            bool result = false;
            
            if (_matchQueue.ContainsKey(ID))
            {
                _matchRooms[MatchID] = new MatchRoom(TargetPlayer, client);
                MatchID += 1;

                _matchQueue.Remove(ID);
                result = true;
            }

            byte[] data = SerializeData("JoinRoomIDResult", new SocketRequestData((int)SocketRequestType.JoinRoomByID, result));

            client.Send(data);
        }

        private void EnterRoomRandom(Socket client, SocketRequestData Request)
        {
            ReceiveMessage("Client Enter room random");
            bool result = false;

            if (_matchQueue.Keys.Count != 0)
            {
                foreach (var Queueing in _matchQueue)
                {
                    var TargetPlayer = Queueing.Value;
                    var TargetPlayerIP = Queueing.Key;
                    _matchRooms[MatchID] = new MatchRoom(TargetPlayer, client);
                    MatchID += 1;

                    _matchQueue.Remove(TargetPlayerIP);
                    result = true;
                    break;
                }
            }
            
            byte[] data = SerializeData("JoinRoomIDResult", new SocketRequestData((int)SocketRequestType.JoinRoomByID, result));

            client.Send(data);
        }

        private bool MatchEndCondition(SocketData Data)
        {
            switch (Data.Command)
            {
                case (int)SocketCommand.QUIT:
                    return true;
                case (int)SocketCommand.END_GAME:
                    return true;
                case (int)SocketCommand.TIME_OUT:
                    return true;
            }

            return false;
        }

        private void MatchDataFoward(Socket client, SocketData Data)
        {
            ReceiveMessage("Match Data from" + ((IPEndPoint)client.RemoteEndPoint).Address.ToString());
            
            //Unhandled exception: Null matchroom
            int MatchID = _matchRooms.FirstOrDefault(MatchRoomInfo => MatchRoomInfo.Value == MatchRoomInfo.Value.GetRoom(client)).Key;

            if (MatchID > 0)
            {
                MatchRoom CurrMatchRoom = _matchRooms[MatchID];
                var Opponent = CurrMatchRoom.GetOpponent(client);
                if (Opponent != null)
                {
                    byte[] data = SerializeData("SocketData", Data);
                    Opponent.Send(data);
                }

                if (MatchEndCondition(Data))
                {
                    byte[] data = SerializeData("SocketData", Data);
                    Opponent.Send(data);
                    _matchRooms.Remove(MatchID);
                }
            }
        }
        
        #endregion
    }
}
