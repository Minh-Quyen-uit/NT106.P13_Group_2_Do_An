namespace Client
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabMain1 = new TabPage();
            panel1 = new Panel();
            AchievementTxt = new Label();
            label10 = new Label();
            RankTxt = new Label();
            label9 = new Label();
            panel4 = new Panel();
            JoinRandom_Btn = new Button();
            panel3 = new Panel();
            CreateRoom_Btn = new Button();
            panel2 = new Panel();
            RoomID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            JoinRoomByID_Btn = new Button();
            label1 = new Label();
            Username_Tb = new TextBox();
            pictureBox1 = new PictureBox();
            tabMain2 = new TabPage();
            ExitBtn = new Button();
            updateAccBtn = new Button();
            Birthday = new TextBox();
            Email = new TextBox();
            FullName = new TextBox();
            PassWord = new TextBox();
            UserName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            changeAvatar_Btn = new Button();
            tabControlMain.SuspendLayout();
            tabMain1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabMain2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabMain1);
            tabControlMain.Controls.Add(tabMain2);
            tabControlMain.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlMain.ImeMode = ImeMode.NoControl;
            tabControlMain.ItemSize = new Size(120, 50);
            tabControlMain.Location = new Point(14, 26);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.Padding = new Point(5, 5);
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(772, 472);
            tabControlMain.TabIndex = 0;
            // 
            // tabMain1
            // 
            tabMain1.BackColor = Color.Cyan;
            tabMain1.Controls.Add(panel1);
            tabMain1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabMain1.ForeColor = Color.Black;
            tabMain1.ImageIndex = 0;
            tabMain1.Location = new Point(4, 54);
            tabMain1.Name = "tabMain1";
            tabMain1.Padding = new Padding(3);
            tabMain1.Size = new Size(764, 414);
            tabMain1.TabIndex = 0;
            tabMain1.Text = "Đấu ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(AchievementTxt);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(RankTxt);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Username_Tb);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(17, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 379);
            panel1.TabIndex = 0;
            // 
            // AchievementTxt
            // 
            AchievementTxt.AutoSize = true;
            AchievementTxt.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AchievementTxt.ForeColor = Color.Blue;
            AchievementTxt.Location = new Point(22, 325);
            AchievementTxt.Name = "AchievementTxt";
            AchievementTxt.Size = new Size(156, 32);
            AchievementTxt.TabIndex = 9;
            AchievementTxt.Text = "0 trận thắng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(22, 293);
            label10.Name = "label10";
            label10.Size = new Size(155, 32);
            label10.TabIndex = 8;
            label10.Text = "Thành tích:";
            // 
            // RankTxt
            // 
            RankTxt.AutoSize = true;
            RankTxt.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RankTxt.ForeColor = Color.Maroon;
            RankTxt.Location = new Point(104, 257);
            RankTxt.Name = "RankTxt";
            RankTxt.Size = new Size(68, 32);
            RankTxt.TabIndex = 7;
            RankTxt.Text = "rank";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(22, 257);
            label9.Name = "label9";
            label9.Size = new Size(88, 32);
            label9.TabIndex = 6;
            label9.Text = "Rank:";
            // 
            // panel4
            // 
            panel4.Controls.Add(JoinRandom_Btn);
            panel4.Location = new Point(231, 299);
            panel4.Name = "panel4";
            panel4.Size = new Size(477, 55);
            panel4.TabIndex = 5;
            // 
            // JoinRandom_Btn
            // 
            JoinRandom_Btn.BackColor = Color.FromArgb(38, 65, 94);
            JoinRandom_Btn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JoinRandom_Btn.ForeColor = Color.White;
            JoinRandom_Btn.Location = new Point(3, 3);
            JoinRandom_Btn.Name = "JoinRandom_Btn";
            JoinRandom_Btn.Size = new Size(471, 49);
            JoinRandom_Btn.TabIndex = 0;
            JoinRandom_Btn.Text = "Ghép Ngẫu Nhiên";
            JoinRandom_Btn.UseVisualStyleBackColor = false;
            JoinRandom_Btn.Click += JoinRandom_Btn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(CreateRoom_Btn);
            panel3.Location = new Point(230, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(478, 62);
            panel3.TabIndex = 4;
            // 
            // CreateRoom_Btn
            // 
            CreateRoom_Btn.BackColor = Color.RoyalBlue;
            CreateRoom_Btn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateRoom_Btn.ForeColor = Color.White;
            CreateRoom_Btn.Location = new Point(3, 5);
            CreateRoom_Btn.Name = "CreateRoom_Btn";
            CreateRoom_Btn.Size = new Size(475, 51);
            CreateRoom_Btn.TabIndex = 0;
            CreateRoom_Btn.Text = "Tạo Phòng";
            CreateRoom_Btn.UseVisualStyleBackColor = false;
            CreateRoom_Btn.Click += CreateRoom_Btn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(RoomID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(JoinRoomByID_Btn);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(230, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 180);
            panel2.TabIndex = 3;
            // 
            // RoomID
            // 
            RoomID.BackColor = Color.Aquamarine;
            RoomID.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoomID.Location = new Point(209, 13);
            RoomID.Name = "RoomID";
            RoomID.Size = new Size(266, 39);
            RoomID.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 139);
            label3.Name = "label3";
            label3.Size = new Size(464, 32);
            label3.TabIndex = 5;
            label3.Text = "--------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 119);
            label2.Name = "label2";
            label2.Size = new Size(462, 32);
            label2.TabIndex = 4;
            label2.Text = "^^^^^^^^^^^^^^^^^^^^^^^^^^^^";
            // 
            // JoinRoomByID_Btn
            // 
            JoinRoomByID_Btn.BackColor = Color.FromArgb(109, 163, 190);
            JoinRoomByID_Btn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JoinRoomByID_Btn.ForeColor = Color.White;
            JoinRoomByID_Btn.Location = new Point(3, 62);
            JoinRoomByID_Btn.Name = "JoinRoomByID_Btn";
            JoinRoomByID_Btn.Size = new Size(472, 54);
            JoinRoomByID_Btn.TabIndex = 3;
            JoinRoomByID_Btn.Text = "Vào Phòng";
            JoinRoomByID_Btn.UseVisualStyleBackColor = false;
            JoinRoomByID_Btn.Click += JoinRoomByID_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(209, 32);
            label1.TabIndex = 2;
            label1.Text = "Nhập ID phòng:";
            // 
            // Username_Tb
            // 
            Username_Tb.BackColor = Color.FromArgb(10, 112, 117);
            Username_Tb.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_Tb.ForeColor = Color.WhiteSmoke;
            Username_Tb.Location = new Point(21, 215);
            Username_Tb.Name = "Username_Tb";
            Username_Tb.Size = new Size(180, 39);
            Username_Tb.TabIndex = 1;
            Username_Tb.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(21, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabMain2
            // 
            tabMain2.BackColor = Color.Turquoise;
            tabMain2.Controls.Add(changeAvatar_Btn);
            tabMain2.Controls.Add(ExitBtn);
            tabMain2.Controls.Add(updateAccBtn);
            tabMain2.Controls.Add(Birthday);
            tabMain2.Controls.Add(Email);
            tabMain2.Controls.Add(FullName);
            tabMain2.Controls.Add(PassWord);
            tabMain2.Controls.Add(UserName);
            tabMain2.Controls.Add(label8);
            tabMain2.Controls.Add(label7);
            tabMain2.Controls.Add(label6);
            tabMain2.Controls.Add(label5);
            tabMain2.Controls.Add(label4);
            tabMain2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabMain2.Location = new Point(4, 54);
            tabMain2.Name = "tabMain2";
            tabMain2.Padding = new Padding(3);
            tabMain2.Size = new Size(764, 414);
            tabMain2.TabIndex = 1;
            tabMain2.Text = "Tài Khoản";
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Red;
            ExitBtn.ForeColor = Color.White;
            ExitBtn.Location = new Point(274, 337);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(204, 47);
            ExitBtn.TabIndex = 11;
            ExitBtn.Text = "Thoát";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // updateAccBtn
            // 
            updateAccBtn.BackColor = Color.Cyan;
            updateAccBtn.ForeColor = Color.Navy;
            updateAccBtn.Location = new Point(507, 337);
            updateAccBtn.Name = "updateAccBtn";
            updateAccBtn.Size = new Size(204, 47);
            updateAccBtn.TabIndex = 10;
            updateAccBtn.Text = "Cập Nhật";
            updateAccBtn.UseVisualStyleBackColor = false;
            updateAccBtn.Click += updateAccBtn_Click;
            // 
            // Birthday
            // 
            Birthday.BackColor = Color.FromArgb(192, 255, 192);
            Birthday.Location = new Point(274, 264);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(437, 42);
            Birthday.TabIndex = 9;
            // 
            // Email
            // 
            Email.BackColor = Color.FromArgb(192, 255, 192);
            Email.Location = new Point(274, 209);
            Email.Name = "Email";
            Email.Size = new Size(437, 42);
            Email.TabIndex = 8;
            // 
            // FullName
            // 
            FullName.BackColor = Color.FromArgb(192, 255, 192);
            FullName.Location = new Point(274, 156);
            FullName.Name = "FullName";
            FullName.Size = new Size(437, 42);
            FullName.TabIndex = 7;
            // 
            // PassWord
            // 
            PassWord.BackColor = Color.FromArgb(192, 255, 192);
            PassWord.Location = new Point(274, 102);
            PassWord.Name = "PassWord";
            PassWord.PasswordChar = '*';
            PassWord.Size = new Size(437, 42);
            PassWord.TabIndex = 6;
            // 
            // UserName
            // 
            UserName.BackColor = Color.FromArgb(192, 255, 192);
            UserName.Location = new Point(274, 48);
            UserName.Name = "UserName";
            UserName.Size = new Size(437, 42);
            UserName.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(48, 267);
            label8.Name = "label8";
            label8.Size = new Size(151, 35);
            label8.TabIndex = 4;
            label8.Text = "Ngày sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(48, 212);
            label7.Name = "label7";
            label7.Size = new Size(107, 35);
            label7.TabIndex = 3;
            label7.Text = "Email: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(48, 159);
            label6.Name = "label6";
            label6.Size = new Size(147, 35);
            label6.TabIndex = 2;
            label6.Text = "Họ và tên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(48, 105);
            label5.Name = "label5";
            label5.Size = new Size(146, 35);
            label5.TabIndex = 1;
            label5.Text = "Mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(48, 51);
            label4.Name = "label4";
            label4.Size = new Size(215, 35);
            label4.TabIndex = 0;
            label4.Text = "Tên đăng nhập:";
            // 
            // changeAvatar_Btn
            // 
            changeAvatar_Btn.BackColor = Color.FromArgb(0, 192, 0);
            changeAvatar_Btn.ForeColor = Color.White;
            changeAvatar_Btn.Location = new Point(48, 337);
            changeAvatar_Btn.Name = "changeAvatar_Btn";
            changeAvatar_Btn.Size = new Size(204, 47);
            changeAvatar_Btn.TabIndex = 12;
            changeAvatar_Btn.Text = "Đổi Avatar";
            changeAvatar_Btn.UseVisualStyleBackColor = false;
            changeAvatar_Btn.Click += changeAvatar_Btn_Click;
            // 
            // MainMenu
            // 
            ClientSize = new Size(804, 516);
            Controls.Add(tabControlMain);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MainMenu";
            tabControlMain.ResumeLayout(false);
            tabMain1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabMain2.ResumeLayout(false);
            tabMain2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabMain1;
        private TabPage tabMain2;
        private Panel panel1;
        private TextBox Username_Tb;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button JoinRoomByID_Btn;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox RoomID;
        private Panel panel4;
        private Button JoinRandom_Btn;
        private Panel panel3;
        private Button CreateRoom_Btn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private TextBox Birthday;
        private TextBox Email;
        private TextBox FullName;
        private TextBox PassWord;
        private TextBox UserName;
        private Button updateAccBtn;
        private Button ExitBtn;
        private Label RankTxt;
        private Label label9;
        private Label label10;
        private Label AchievementTxt;
        private Button changeAvatar_Btn;
    }
}