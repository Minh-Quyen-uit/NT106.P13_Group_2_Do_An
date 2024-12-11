using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Client.DAO
{
    public sealed class ClientSocketManager
    {
        private static readonly Lazy<ClientSocketManager> instance = new(() => new ClientSocketManager());

        private TcpClient _tcpClient;
        private Stream _stream;
        private Thread _thread;

        //Create a dictionary to handle specific datatype
        //List<(Delegate handler, Type targetType)>> to allow multiple handler to handle a datatype in different form
        private readonly Dictionary<string, (Delegate handler, Type targetType)> _typehandler = new();

        public static ClientSocketManager Instance
        {
            get => instance.Value;
        }

        private ClientSocketManager() { }

        public void Connect(IPEndPoint ipe)
        {
            _tcpClient = new TcpClient();
            _tcpClient.Connect(ipe);
            _stream = _tcpClient.GetStream();

            _thread = new Thread(Listen);
            _thread.IsBackground = true;
            _thread.Start();
        }

        public void Listen()
        {
            while (true)
            {
                byte[] buffer = new byte[1024];

                try
                {
                    int bytesRead = _stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string json = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        dynamic message = JsonConvert.DeserializeObject<dynamic>(json);
                        string messageType = message.Type;
                        var data = message.Data;

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //USE THIS TO REGISTER A HANDLER ACCORDING TO EACH TYPE
        public void RegisterHandler<T>(string type, Action<T> handler)
        {   
            //Don't add a new handler if its already exist
            if (_typehandler.ContainsKey(type))
            {
                return;
            }
            
            //Add a new handler
            _typehandler[type] = (handler, typeof(T));
        }

        public void Send<T>(string type, T data)
        {
            try
            {
                var message = new
                {
                    Type = type,
                    Data = data
                };

                string json = JsonConvert.SerializeObject(message);
                byte[] jsonBytes = Encoding.UTF8.GetBytes(json);

                _stream.Write(jsonBytes, 0, jsonBytes.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
