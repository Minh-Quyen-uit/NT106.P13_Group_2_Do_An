using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
//using Newtonsoft.Json;
using MessagePack;
using System.Runtime.Serialization;
using System.Xml;

namespace Client
{
    [Serializable]
    public class SocketManager
    {
        #region Client
        Socket client;
        public bool ConnectServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(iep);
                return true;
            }
            catch
            {
                return false;

            }

        }
        #endregion



        #region Server
        Socket server;
        public void CreateServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, PORT);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(iep);
            server.Listen(10);

            Thread accepClient = new Thread(() =>
            {
                try
                {
                    client = server.Accept();
                } catch { }
            });
            accepClient.IsBackground = true;
            accepClient.Start();
        }
        #endregion

        #region Both
        public string IP = "127.0.0.1";
        public int PORT = 5000;
        public const int Buffer = 1024;
        public bool isServer = true;

        public bool Send1(object data)
        {
            byte[] sendData = SerializeData(data);
            return SendData(client, sendData);
        }


        public object Receive1()
        {
            byte[] receiveData = new byte[Buffer];
            bool isOk = ReceiveData(client, receiveData);
            bool res = isOk;
            return DeserializeData(receiveData);

        }

        private bool SendData(Socket target, byte[] data)
        {
            try
            {
                if (target == null || !target.Connected)
                {
                    MessageBox.Show("Client chưa được kết nối.");
                    return false;
                }
                int result = target.Send(data); 
                return result >= 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi gửi dữ liệu: {ex.Message}");
                return false;
            }
        }

        private bool ReceiveData(Socket target, byte[] data)
        {
            int result = target.Receive(data);
            return result >= 1 ? true : false;
        }

        public byte[] SerializeData(object obj) 
        {
            using (MemoryStream ms = new MemoryStream())
            {
                DataContractSerializer serializer = new DataContractSerializer(obj.GetType());
                serializer.WriteObject(ms, obj);

                return ms.ToArray();
            }
        }

        //Gom mảnh lại
        public object DeserializeData(byte[] data)
        {
            object obj = Encoding.UTF8.GetString(data);
            return obj;
        }

        public SocketData DeserializeSocketData(string xmlString)
        {
            xmlString = xmlString.TrimEnd('\0');
            using (var stringReader = new StringReader(xmlString))
            using (var xmlReader = XmlReader.Create(stringReader))
            {
                var serializer = new DataContractSerializer(typeof(SocketData));
                return (SocketData)serializer.ReadObject(xmlReader);
            }
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
