namespace Client
{
    partial class Server
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
            ExtBtn = new Button();
            ServerScreen = new TextBox();
            SendMess = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ExtBtn
            // 
            ExtBtn.BackColor = Color.Red;
            ExtBtn.Location = new Point(470, 389);
            ExtBtn.Name = "ExtBtn";
            ExtBtn.Size = new Size(128, 42);
            ExtBtn.TabIndex = 0;
            ExtBtn.Text = "Thoát";
            ExtBtn.UseVisualStyleBackColor = false;
            ExtBtn.Click += ExtBtn_Click;
            // 
            // ServerScreen
            // 
            ServerScreen.Location = new Point(12, 101);
            ServerScreen.Multiline = true;
            ServerScreen.Name = "ServerScreen";
            ServerScreen.ScrollBars = ScrollBars.Vertical;
            ServerScreen.Size = new Size(588, 121);
            ServerScreen.TabIndex = 1;
            // 
            // SendMess
            // 
            SendMess.Location = new Point(12, 264);
            SendMess.Multiline = true;
            SendMess.Name = "SendMess";
            SendMess.ScrollBars = ScrollBars.Vertical;
            SendMess.Size = new Size(588, 119);
            SendMess.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(227, 21);
            label1.Name = "label1";
            label1.Size = new Size(113, 38);
            label1.TabIndex = 3;
            label1.Text = "Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(400, 25);
            label2.TabIndex = 4;
            label2.Text = "Hiển thị thông tin clients gửi tới server:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 234);
            label3.Name = "label3";
            label3.Size = new Size(391, 25);
            label3.TabIndex = 5;
            label3.Text = "Hiện thị thông tin server gửi tới client:";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 206, 162);
            ClientSize = new Size(610, 443);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SendMess);
            Controls.Add(ServerScreen);
            Controls.Add(ExtBtn);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExtBtn;
        private TextBox ServerScreen;
        private TextBox SendMess;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}