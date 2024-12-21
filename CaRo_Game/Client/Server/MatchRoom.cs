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

            //Listen(Player1);
            //Listen(Player2);
        }

        public Socket GetOpponent(Socket player)
        {
            return player == Player1 ? Player2 : (player == Player2 ? Player1 : null);
        }

        public MatchRoom GetRoom(Socket player)
        {
            if (player == Player1 || player == Player2) return this;
            return null;
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
