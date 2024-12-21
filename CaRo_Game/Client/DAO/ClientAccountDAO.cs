using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DAO
{
    public class ClientAccountDAO
    {
        private static ClientAccountDAO instance;

        public static ClientAccountDAO Instance
        {
            get { if (instance == null) instance = new ClientAccountDAO(); return instance; }
            private set => instance = value;
        }

        private ClientAccountDAO() { }

        private string AccUsername; 
        private string AccFullname;
        private string AccEmail;
        private string AccBirthday;
        private int AccWins;
        private string AccRank;
        private int AccTotalWins;
        private string AccAvatar;

        private string[] Ranks = { "Dirt", "Plastic", "A", "B", "C" };

        #region GetSet
        public string GetSetAccUsername
        {
            get { if (AccUsername == null) AccUsername = "Guest"; return AccUsername; }
            private set => AccUsername = value;
        }
        public string GetSetAccFullname
        {
            get { if (AccFullname == null) AccFullname = ""; return AccFullname; }
            private set => AccFullname = value;
        }
        public string GetSetAccEmail
        {
            get { if (AccEmail == null) AccEmail = ""; return AccEmail; }
            private set => AccEmail = value;
        }
        public string GetSetAccBirthday
        {
            get { if (AccBirthday == null) AccBirthday = DateTime.Now.ToString(); return AccBirthday; }
            private set => AccBirthday = value;
        }

        public int GetSetAccWins
        {
            get { if (AccWins == 0) AccWins = 0; return AccWins; }
            private set => AccWins = value;
        }

        public string GetSetAccRank
        {
            get { if (AccRank == null) AccRank = "Dirt"; return AccRank; }
            private set => AccRank = value;
        }

        public int GetSetAccTotalWins
        {
            get { if (AccTotalWins == 0) AccTotalWins = 0; return AccTotalWins; }
            private set => AccTotalWins = value;
        }

        public string GetSetAccAvatar
        {
            get { if (AccAvatar == null) AccAvatar = ""; return AccAvatar; }
            private set => AccAvatar = value;
        }
        #endregion

        public void GetUserInfo(string[] Info)
        {

            GetSetAccUsername = Info[0];
            GetSetAccFullname = Info[1];
            GetSetAccEmail = Info[2];
            GetSetAccBirthday = Info[3];
            GetSetAccWins = Convert.ToInt32(Info[4]);
            GetSetAccRank = Info[5];
            GetSetAccTotalWins = Convert.ToInt32(Info[6]);
            GetSetAccAvatar = Info[7];
        }

        public Image GetUserAvatar(string Base64Image)
        {
            try
            {
                byte[] ImageData = Convert.FromBase64String(Base64Image);


                using (MemoryStream ms = new MemoryStream(ImageData))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid Base64 string format.");
                throw new ArgumentException("Invalid Base64 string format.", ex);
            }
        }
    }
}
