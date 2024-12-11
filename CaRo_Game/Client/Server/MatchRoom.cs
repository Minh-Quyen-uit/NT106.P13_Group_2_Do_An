using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client.Server
{
    public class MatchRoom
    {
        public Socket Player1 { get; }
        public Socket Player2 { get; }

        private readonly Dictionary<string, (Delegate handler, Type targetType)> _matchHandler = new();

        public MatchRoom(Socket player1, Socket player2)
        {
            Player1 = player1;
            Player2 = player2;

            Listen(Player1);
            Listen(Player2);
        }

        private void Listen(Socket Player)
        {
            new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        byte[] recv = new byte[1024];
                        int bytesRead = Player.Receive(recv);

                        string json = Encoding.UTF8.GetString(recv, 0, bytesRead);
                        dynamic message = JsonConvert.DeserializeObject<dynamic>(json);
                        string messageType = message.Type;
                        var data = message.Data;

                        if (_matchHandler.ContainsKey(messageType))
                        {
                            var (handler, targetType) = _matchHandler[messageType];

                            try
                            {
                                // Deserialize the data to the correct type
                                var deserializedData = JsonConvert.DeserializeObject(JsonConvert.SerializeObject(data), targetType);

                                // Invoke the handler
                                handler.DynamicInvoke(deserializedData, Player);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error deserializing data for type '{messageType}': {ex.Message}");
                            }

                        }
                        else
                        {
                            //Forward the data to the opponent
                            var Opponent = GetOpponent(Player);
                            if (Opponent != null)
                            {
                                Send(Player, messageType, data);
                            }
                        }
                    }
                    catch
                    {
                        var Opponent = GetOpponent(Player);
                        if (Opponent != null)
                        {
                            Send(Opponent, "OpponentDisconnected", "Oppenent Dissconnected");
                        }
                    }

                }
            }).Start();
        }

        public void RegisterHandler<T>(string type, Action<T, Socket> handler)
        {
            _matchHandler[type] = (handler, typeof(T));
        }

        private Socket GetOpponent(Socket player)
        {
            return player == Player1 ? Player2 : (player == Player2 ? Player1 : null);
        }

        public void Send<T>(Socket recipient, string type, T data)
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

                recipient.Send(jsonBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
