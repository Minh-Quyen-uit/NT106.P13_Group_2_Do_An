using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Client
{
    public class PlayInfo
    {
        private Point point;
        private int currentPlayer;

        // Thêm các thuộc tính mới
        public string Username { get; set; }
        public string Avatar { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }
        public int Rank { get; set; }
        public Point Point { get => point; set => point=value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer=value; }

        // Constructor với các thông tin bổ sung
        public PlayInfo(string username, string avatar, Point point, int currentPlayer)
        {
            this.Username = username;
            this.Avatar = avatar;
            this.Point = point;
            this.CurrentPlayer = currentPlayer;
            this.GamesPlayed = 0; // Khởi tạo số ván đã chơi
            this.Wins = 0;        // Khởi tạo số trận thắng
            this.Rank = 0;       // Khởi tạo thứ hạng
        }
    }
}
