using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.clients
{
    public class Player
    {
        private string name;
        private Image mark;

        // Thêm thông tin người dùng
        public string Username { get; set; }
        public Image Avatar { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }
        public int Rank { get; set; }


        public string Name { get => name; set => name=value; }

        public Image Mark { get => mark; set => mark=value; }

        public Player(string name, Image mark)
        {
            Name = name;
            Mark = mark;
            GamesPlayed = 0; // Khởi tạo số ván đã chơi
            Wins = 0;        // Khởi tạo số trận thắng
            Rank = 0;       // Khởi tạo thứ hạng

        }

        //Phương thức cập nhật thông tin khi trận đấu kết thúc


        private int CalculateRank()
        {
            return Wins / 10; // Ví dụ: mỗi 10 trận thắng tương ứng với một hạng
        }
    }


}
