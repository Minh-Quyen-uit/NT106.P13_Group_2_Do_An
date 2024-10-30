using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class SocketManager
    {
        #region Client
        Socket Client;
        public bool ConnectServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                Client.Connect(iep);
                return true;
            }
            catch
            {
                return false;

            }

        }
        #endregion

        #region Server
        Socket Server;
        public void CreateServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Server.Bind(iep);
            Server.Listen(10);

            Thread accepClient = new Thread(() =>
            {
                Client = Server.Accept();
            });
            accepClient.IsBackground = true;
            accepClient.Start();
        }
        #endregion

        #region Both
        public string IP = "127.0.0.1";
        public int PORT = 9999;
        public const int Buffer = 1024;
        public bool isServer = true;

        public bool Send(object obj)
        {
            byte[] sendData = SerializeData(obj);
            return SendData(Client, sendData);
            //return false;
        }

        public object Receive()
        {
            byte[] receiveData = new byte[Buffer];
            bool isOk = ReceiveData(Client, receiveData);
            return DeserializeData(receiveData);
        }

        private bool SendData(Socket target, byte[] data)
        {
            return target.Send(data) == 1 ? true : false;

        }

        private bool ReceiveData(Socket target, byte[] data)
        {
            return target.Receive(data) == 1 ? true : false;
        }

        public byte[] SerializeData(object obj)
        {
            byte[] data = Encoding.UTF8.GetBytes(obj.ToString());
            return data;
        }

        //Gom mảnh lại
        public object DeserializeData(byte[] data)
        {
            object obj = Encoding.UTF8.GetString(data);
            return obj;
        }

        //Lấy ra IPV4 của card mạng người dùng
        public string GetLocalIPV4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces()) 
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if(ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }
        #endregion
    }
}
