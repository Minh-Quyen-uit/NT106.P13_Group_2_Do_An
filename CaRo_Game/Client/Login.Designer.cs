namespace Client
{
    partial class Login
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
            panel1 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            ExitBtn = new Button();
            panel5 = new Panel();
            SignUpBtn = new Button();
            label4 = new Label();
            panel4 = new Panel();
            LoginBtn = new Button();
            PasswordCheck = new CheckBox();
            panel3 = new Panel();
            PassWord = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            UserName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 204, 188);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(26, 72);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 521);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(200, 27);
            label1.Name = "label1";
            label1.Size = new Size(212, 45);
            label1.TabIndex = 5;
            label1.Text = "Đăng Nhập";
            // 
            // panel6
            // 
            panel6.Controls.Add(ExitBtn);
            panel6.Location = new Point(0, 429);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(594, 64);
            panel6.TabIndex = 5;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Red;
            ExitBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.Location = new Point(384, 4);
            ExitBtn.Margin = new Padding(3, 4, 3, 4);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(198, 57);
            ExitBtn.TabIndex = 5;
            ExitBtn.Text = "Thoát";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(SignUpBtn);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(3, 345);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(591, 69);
            panel5.TabIndex = 4;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.FromArgb(0, 192, 0);
            SignUpBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpBtn.Location = new Point(381, 4);
            SignUpBtn.Margin = new Padding(3, 4, 3, 4);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(198, 66);
            SignUpBtn.TabIndex = 4;
            SignUpBtn.Text = "Đăng ký";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(3, 21);
            label4.Name = "label4";
            label4.Size = new Size(297, 32);
            label4.TabIndex = 0;
            label4.Text = "Bạn chưa có tài khoản ?";
            // 
            // panel4
            // 
            panel4.Controls.Add(LoginBtn);
            panel4.Controls.Add(PasswordCheck);
            panel4.Location = new Point(3, 257);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(591, 67);
            panel4.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DeepSkyBlue;
            LoginBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(381, 0);
            LoginBtn.Margin = new Padding(3, 4, 3, 4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(198, 67);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Đăng nhập";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // PasswordCheck
            // 
            PasswordCheck.AutoSize = true;
            PasswordCheck.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PasswordCheck.Location = new Point(3, 15);
            PasswordCheck.Margin = new Padding(3, 4, 3, 4);
            PasswordCheck.Name = "PasswordCheck";
            PasswordCheck.Size = new Size(245, 36);
            PasswordCheck.TabIndex = 6;
            PasswordCheck.Text = "Hiện thị mật khẩu";
            PasswordCheck.UseVisualStyleBackColor = true;
            PasswordCheck.CheckedChanged += PasswordCheck_CheckedChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(PassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(5, 180);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(591, 58);
            panel3.TabIndex = 2;
            // 
            // PassWord
            // 
            PassWord.Location = new Point(197, 7);
            PassWord.Margin = new Padding(3, 4, 3, 4);
            PassWord.Name = "PassWord";
            PassWord.PasswordChar = '*';
            PassWord.Size = new Size(381, 39);
            PassWord.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 14);
            label3.Name = "label3";
            label3.Size = new Size(140, 32);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(UserName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 100);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 61);
            panel2.TabIndex = 1;
            // 
            // UserName
            // 
            UserName.Location = new Point(197, 10);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Name = "UserName";
            UserName.Size = new Size(381, 39);
            UserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-3, 14);
            label2.Name = "label2";
            label2.Size = new Size(205, 32);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập:";
            // 
            // Login
            // 
            AcceptButton = LoginBtn;
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(645, 618);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(6);
            Name = "Login";
            Padding = new Padding(23, 74, 23, 25);
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel6;
        private Panel panel5;
        private Label label4;
        private Panel panel4;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private Button ExitBtn;
        private Button SignUpBtn;
        private Button LoginBtn;
        private CheckBox PasswordCheck;
        private TextBox PassWord;
        private TextBox UserName;
    }
}