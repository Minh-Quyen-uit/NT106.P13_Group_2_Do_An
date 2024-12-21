namespace Client.Server
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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ExtBtn
            // 
            ExtBtn.BackColor = Color.Red;
            ExtBtn.ForeColor = SystemColors.ButtonHighlight;
            ExtBtn.Location = new Point(626, 625);
            ExtBtn.Name = "ExtBtn";
            ExtBtn.Size = new Size(128, 42);
            ExtBtn.TabIndex = 0;
            ExtBtn.Text = "Thoát";
            ExtBtn.UseVisualStyleBackColor = false;
            ExtBtn.Click += ExtBtn_Click;
            // 
            // ServerScreen
            // 
            ServerScreen.Location = new Point(10, 90);
            ServerScreen.Multiline = true;
            ServerScreen.Name = "ServerScreen";
            ServerScreen.ScrollBars = ScrollBars.Vertical;
            ServerScreen.Size = new Size(773, 231);
            ServerScreen.TabIndex = 1;
            // 
            // SendMess
            // 
            SendMess.Location = new Point(9, 376);
            SendMess.Multiline = true;
            SendMess.Name = "SendMess";
            SendMess.ScrollBars = ScrollBars.Vertical;
            SendMess.Size = new Size(774, 231);
            SendMess.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 2);
            label1.Name = "label1";
            label1.Size = new Size(113, 38);
            label1.TabIndex = 3;
            label1.Text = "Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 52);
            label2.Name = "label2";
            label2.Size = new Size(486, 32);
            label2.TabIndex = 4;
            label2.Text = "Hiển thị thông tin clients gửi tới server:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 337);
            label3.Name = "label3";
            label3.Size = new Size(474, 32);
            label3.TabIndex = 5;
            label3.Text = "Hiện thị thông tin server gửi tới client:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.BackgroundMain;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SendMess);
            panel1.Controls.Add(ServerScreen);
            panel1.Controls.Add(ExtBtn);
            panel1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.Yellow;
            panel1.Location = new Point(10, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 692);
            panel1.TabIndex = 6;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            BackgroundImage = Properties.Resources.BackgroundMain;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(816, 730);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Server";
            Text = "Server";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ExtBtn;
        private TextBox ServerScreen;
        private TextBox SendMess;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
    }
}