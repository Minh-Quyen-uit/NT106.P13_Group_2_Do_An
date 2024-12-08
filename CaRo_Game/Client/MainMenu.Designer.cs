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
            tabControlMain.SuspendLayout();
            tabMain1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tabPage2.Location = new Point(4, 54);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(764, 414);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tài Khoản";
            tabPage2.UseVisualStyleBackColor = true;
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
    }
}