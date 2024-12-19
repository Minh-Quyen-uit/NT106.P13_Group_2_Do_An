using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Client.DAO
{
    //
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance=value;
        }

        private AccountDAO() { }

        private string AccUsername;
        private string AccFullname;
        private string AccEmail;
        private string AccBirthday;
        private int AccWins;
        private string AccRank;

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
        #endregion

        #region login/signup
        public bool login(string username, string password)
        {
            string query = " begin select * from dbo.CaRoGameAccounts where UserName = N'" + username + "' and PassWord = N'" + password + "' end";
            //string query = "select * from dbo.CaRoGameAccounts where UserName = N'staff01' and PassWord = N'staff01123456@'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }


        public int signin(string username, string password, string fullname, string email, string birthday)
        {
            if (username.Length < 4) { MessageBox.Show("Tên tài khoản phải chứa từ 4 ký tự trở lên! "); return 0; }
            DataTable usernameResult = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CaRoGameAccounts WHERE Username = N'" + username + "' ");
            if (usernameResult.Rows.Count > 0) { MessageBox.Show("Tên tài khoản đã tồn tại!"); return 0; }

            if (!string.IsNullOrEmpty(email))
            {
                if (!AccountDAO.Instance.checkSigninEmail(email)) { MessageBox.Show("Email đã nhập sai định dạng!"); return 0; }
                DataTable emailResult = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CaRoGameAccounts WHERE Email = N'" + email + "'");
                if (emailResult.Rows.Count > 0) { MessageBox.Show("Email đã được đăng ký!"); return 0; }
            }


            string query = "INSERT INTO dbo.CaRoGameAccounts (UserName, PassWord, FullName, Email, BirthDay) VALUES ( @Username , @Password , @Fullname , @Email , @Birthday )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, password, fullname, email, birthday });
            return result;
        }

        #endregion

        public int UpdateWins(string username)
        {
            string query = "update dbo.CaRoGameAccounts set Wins = Wins+1 where UserName = N'" + username + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result;
        }

        public int UpdateRank(string username, string rank)
        {
            string query = "update dbo.CaRoGameAccounts set Rank = @Rank where Username = N'" + username + "'";
            
            int RankIndex = Array.IndexOf(Ranks, rank);
            string NextRank = RankIndex != rank.Length-1 ? Ranks[RankIndex+1] : Ranks[rank.Length-1];

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { NextRank });
            return result;

        }

        public void GetUserInfo(string username)
        {

            string query = "select * from dbo.CaRoGameAccounts where UserName = N'" + username + "'";
            List<string> result = DataProvider.Instance.ExecuteReader(query);
            GetSetAccUsername = result[0];
            GetSetAccFullname = result[2];
            GetSetAccEmail = result[3];
            GetSetAccBirthday = result[4];
            GetSetAccWins = Convert.ToInt32(result[5]);
            GetSetAccRank = result[6];
        }

        private bool checkSigninEmail(string email)
        {
            return Regex.IsMatch(email, "^[a-zA-Z0-9_.]{3,24}@gmail.com$");
        }
    }
}
