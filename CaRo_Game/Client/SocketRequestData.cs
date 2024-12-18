using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class SocketRequestData
    {
        private int _requestType;
        private object _data;

        public int RequestType { get => _requestType; set => _requestType = value; }
        public object Data { get => _data; set => _data = value; }
        public SocketRequestData(int requestType, object data)
        {
            RequestType = requestType;
            Data = data;
        }
    }

    public enum SocketRequestType
    {
        Login,
        SignUp,
        CreateRoom,
        JoinRoomByID,
        JoinRoomRandom
    }
}
