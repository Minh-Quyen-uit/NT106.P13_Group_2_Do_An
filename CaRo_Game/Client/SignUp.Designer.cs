namespace Client
{
    partial class SignUp
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
            panel11 = new Panel();
            ExitBtn = new Button();
            panel10 = new Panel();
            label8 = new Label();
            LoginBtn = new Button();
            label1 = new Label();
            panel9 = new Panel();
            SignUpBtn = new Button();
            panel8 = new Panel();
            BirthDay = new DateTimePicker();
            label7 = new Label();
            panel7 = new Panel();
            Email = new TextBox();
            label6 = new Label();
            panel6 = new Panel();
            FullName = new TextBox();
            label5 = new Label();
            panel5 = new Panel();
            PasswordChar = new CheckBox();
            panel4 = new Panel();
            PassWordConfirm = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            PassWord = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            UserName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(76, 161, 175);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(23, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 712);
            panel1.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(ExitBtn);
            panel11.Location = new Point(3, 650);
            panel11.Name = "panel11";
            panel11.Size = new Size(566, 48);
            panel11.TabIndex = 9;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Red;
            ExitBtn.Location = new Point(383, 1);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(180, 45);
            ExitBtn.TabIndex = 9;
            ExitBtn.Text = "Thoát";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(label8);
            panel10.Controls.Add(LoginBtn);
            panel10.Location = new Point(3, 596);
            panel10.Name = "panel10";
            panel10.Size = new Size(566, 48);
            panel10.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 12);
            label8.Name = "label8";
            label8.Size = new Size(230, 25);
            label8.TabIndex = 1;
            label8.Text = "Bạn đã có tài khoản ?";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(173, 239, 209);
            LoginBtn.ForeColor = Color.FromArgb(0, 32, 63);
            LoginBtn.Location = new Point(383, 3);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(180, 42);
            LoginBtn.TabIndex = 8;
            LoginBtn.Text = "Đăng nhập";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(219, 15);
            label1.Name = "label1";
            label1.Size = new Size(147, 38);
            label1.TabIndex = 8;
            label1.Text = "Đăng Ký";
            // 
            // panel9
            // 
            panel9.Controls.Add(SignUpBtn);
            panel9.Location = new Point(3, 542);
            panel9.Name = "panel9";
            panel9.Size = new Size(566, 48);
            panel9.TabIndex = 7;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.RoyalBlue;
            SignUpBtn.Location = new Point(383, 3);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(180, 42);
            SignUpBtn.TabIndex = 7;
            SignUpBtn.Text = "Đăng ký";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(BirthDay);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(3, 484);
            panel8.Name = "panel8";
            panel8.Size = new Size(566, 52);
            panel8.TabIndex = 6;
            // 
            // BirthDay
            // 
            BirthDay.Location = new Point(237, 10);
            BirthDay.Name = "BirthDay";
            BirthDay.Size = new Size(326, 34);
            BirthDay.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 13);
            label7.Name = "label7";
            label7.Size = new Size(118, 25);
            label7.TabIndex = 0;
            label7.Text = "Ngày sinh:";
            // 
            // panel7
            // 
            panel7.Controls.Add(Email);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(3, 413);
            panel7.Name = "panel7";
            panel7.Size = new Size(566, 52);
            panel7.TabIndex = 5;
            // 
            // Email
            // 
            Email.Location = new Point(237, 10);
            Email.Name = "Email";
            Email.Size = new Size(326, 34);
            Email.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 13);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 0;
            label6.Text = "Email:";
            // 
            // panel6
            // 
            panel6.Controls.Add(FullName);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(3, 339);
            panel6.Name = "panel6";
            panel6.Size = new Size(566, 52);
            panel6.TabIndex = 4;
            // 
            // FullName
            // 
            FullName.Location = new Point(237, 11);
            FullName.Name = "FullName";
            FullName.Size = new Size(326, 34);
            FullName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 14);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 0;
            label5.Text = "Họ và tên:";
            // 
            // panel5
            // 
            panel5.Controls.Add(PasswordChar);
            panel5.Location = new Point(3, 281);
            panel5.Name = "panel5";
            panel5.Size = new Size(566, 52);
            panel5.TabIndex = 10;
            // 
            // PasswordChar
            // 
            PasswordChar.AutoSize = true;
            PasswordChar.Location = new Point(349, 12);
            PasswordChar.Name = "PasswordChar";
            PasswordChar.Size = new Size(214, 29);
            PasswordChar.TabIndex = 10;
            PasswordChar.Text = "Hiện thị mật khẩu";
            PasswordChar.UseVisualStyleBackColor = true;
            PasswordChar.CheckedChanged += PasswordChar_CheckedChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(PassWordConfirm);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 223);
            panel4.Name = "panel4";
            panel4.Size = new Size(566, 52);
            panel4.TabIndex = 3;
            // 
            // PassWordConfirm
            // 
            PassWordConfirm.Location = new Point(237, 10);
            PassWordConfirm.Name = "PassWordConfirm";
            PassWordConfirm.PasswordChar = '*';
            PassWordConfirm.Size = new Size(326, 34);
            PassWordConfirm.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 13);
            label4.Name = "label4";
            label4.Size = new Size(216, 25);
            label4.TabIndex = 0;
            label4.Text = "Xác nhận mật khẩu:";
            // 
            // panel3
            // 
            panel3.Controls.Add(PassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 149);
            panel3.Name = "panel3";
            panel3.Size = new Size(566, 52);
            panel3.TabIndex = 2;
            // 
            // PassWord
            // 
            PassWord.Location = new Point(237, 9);
            PassWord.Name = "PassWord";
            PassWord.PasswordChar = '*';
            PassWord.Size = new Size(326, 34);
            PassWord.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(UserName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 49);
            panel2.TabIndex = 1;
            // 
            // UserName
            // 
            UserName.Location = new Point(237, 8);
            UserName.Name = "UserName";
            UserName.Size = new Size(326, 34);
            UserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập:";
            // 
            // SignUp
            // 
            AcceptButton = SignUpBtn;
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 795);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonFace;
            Margin = new Padding(5, 4, 5, 4);
            Name = "SignUp";
            Text = "SignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox PassWord;
        private TextBox UserName;
        private DateTimePicker BirthDay;
        private TextBox Email;
        private TextBox FullName;
        private CheckBox PasswordChar;
        private TextBox PassWordConfirm;
        private Panel panel11;
        private Panel panel10;
        private Button ExitBtn;
        private Button LoginBtn;
        private Button SignUpBtn;
        private Label label8;
    }
}