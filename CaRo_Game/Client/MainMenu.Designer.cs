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
            panel4 = new Panel();
            button2 = new Button();
            panel3 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            RoomID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            JoinRoomByID = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            UserName = new TextBox();
            PassWord = new TextBox();
            FullName = new TextBox();
            Email = new TextBox();
            Birthday = new TextBox();
            updateAccBtn = new Button();
            ExitBtn = new Button();
            tabControlMain.SuspendLayout();
            tabMain1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabMain1);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(17, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 379);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(button2);
            panel4.Location = new Point(231, 299);
            panel4.Name = "panel4";
            panel4.Size = new Size(477, 55);
            panel4.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(38, 65, 94);
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(471, 49);
            button2.TabIndex = 0;
            button2.Text = "Ghép Ngẫu Nhiên";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(230, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(478, 62);
            panel3.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 5);
            button1.Name = "button1";
            button1.Size = new Size(475, 51);
            button1.TabIndex = 0;
            button1.Text = "Tạo Phòng";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(RoomID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(JoinRoomByID);
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
            // JoinRoomByID
            // 
            JoinRoomByID.BackColor = Color.FromArgb(109, 163, 190);
            JoinRoomByID.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JoinRoomByID.ForeColor = Color.White;
            JoinRoomByID.Location = new Point(3, 62);
            JoinRoomByID.Name = "JoinRoomByID";
            JoinRoomByID.Size = new Size(472, 54);
            JoinRoomByID.TabIndex = 3;
            JoinRoomByID.Text = "Vào Phòng";
            JoinRoomByID.UseVisualStyleBackColor = false;
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
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(10, 112, 117);
            textBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.Location = new Point(21, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 39);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(21, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 180);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(255, 255, 192);
            tabPage2.Controls.Add(ExitBtn);
            tabPage2.Controls.Add(updateAccBtn);
            tabPage2.Controls.Add(Birthday);
            tabPage2.Controls.Add(Email);
            tabPage2.Controls.Add(FullName);
            tabPage2.Controls.Add(PassWord);
            tabPage2.Controls.Add(UserName);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 54);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(764, 414);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tài Khoản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 51);
            label4.Name = "label4";
            label4.Size = new Size(205, 32);
            label4.TabIndex = 0;
            label4.Text = "Tên đăng nhập:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 105);
            label5.Name = "label5";
            label5.Size = new Size(148, 32);
            label5.TabIndex = 1;
            label5.Text = "Mật Khẩu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 159);
            label6.Name = "label6";
            label6.Size = new Size(138, 32);
            label6.TabIndex = 2;
            label6.Text = "Họ và tên:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 212);
            label7.Name = "label7";
            label7.Size = new Size(101, 32);
            label7.TabIndex = 3;
            label7.Text = "Email: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 267);
            label8.Name = "label8";
            label8.Size = new Size(143, 32);
            label8.TabIndex = 4;
            label8.Text = "Ngày sinh:";
            // 
            // UserName
            // 
            UserName.Location = new Point(274, 48);
            UserName.Name = "UserName";
            UserName.Size = new Size(437, 39);
            UserName.TabIndex = 5;
            // 
            // PassWord
            // 
            PassWord.Location = new Point(274, 102);
            PassWord.Name = "PassWord";
            PassWord.Size = new Size(437, 39);
            PassWord.TabIndex = 6;
            // 
            // FullName
            // 
            FullName.Location = new Point(274, 156);
            FullName.Name = "FullName";
            FullName.Size = new Size(437, 39);
            FullName.TabIndex = 7;
            // 
            // Email
            // 
            Email.Location = new Point(274, 209);
            Email.Name = "Email";
            Email.Size = new Size(437, 39);
            Email.TabIndex = 8;
            // 
            // Birthday
            // 
            Birthday.Location = new Point(274, 264);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(437, 39);
            Birthday.TabIndex = 9;
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
            // 
            // MainMenu
            // 
            ClientSize = new Size(804, 516);
            Controls.Add(tabControlMain);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabMain1;
        private TabPage tabPage2;
        private Panel panel1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button JoinRoomByID;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox RoomID;
        private Panel panel4;
        private Button button2;
        private Panel panel3;
        private Button button1;
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
    }
}