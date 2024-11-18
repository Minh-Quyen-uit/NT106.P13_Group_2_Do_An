namespace Client
{
    partial class ChessBoard
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel_Board = new Panel();
            panel2 = new Panel();
            Message_Box = new TextBox();
            Send_Btn = new Guna.UI2.WinForms.Guna2Button();
            ChatTxt = new Guna.UI2.WinForms.Guna2TextBox();
            Avatar_Player = new PictureBox();
            panel3 = new Panel();
            IPMessage = new TextBox();
            LAN_Btn = new Button();
            PrcBCoolDown = new ProgressBar();
            label2 = new Label();
            label1 = new Label();
            FullName = new TextBox();
            panel4 = new Panel();
            tmCoolDown = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            ExitBtn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Avatar_Player).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Board
            // 
            panel_Board.BackColor = Color.FromArgb(128, 255, 255);
            panel_Board.Font = new Font("Times New Roman", 13.8F);
            panel_Board.Location = new Point(20, 92);
            panel_Board.Margin = new Padding(5, 4, 5, 4);
            panel_Board.Name = "panel_Board";
            panel_Board.Size = new Size(810, 630);
            panel_Board.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(Message_Box);
            panel2.Controls.Add(Send_Btn);
            panel2.Controls.Add(ChatTxt);
            panel2.Font = new Font("Times New Roman", 13.8F);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 333);
            panel2.TabIndex = 1;
            // 
            // Message_Box
            // 
            Message_Box.Location = new Point(5, 3);
            Message_Box.Multiline = true;
            Message_Box.Name = "Message_Box";
            Message_Box.ScrollBars = ScrollBars.Vertical;
            Message_Box.Size = new Size(392, 275);
            Message_Box.TabIndex = 6;
            // 
            // Send_Btn
            // 
            Send_Btn.CustomizableEdges = customizableEdges1;
            Send_Btn.DisabledState.BorderColor = Color.DarkGray;
            Send_Btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Send_Btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Send_Btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Send_Btn.FillColor = Color.Aquamarine;
            Send_Btn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Send_Btn.ForeColor = Color.DimGray;
            Send_Btn.Location = new Point(287, 286);
            Send_Btn.Name = "Send_Btn";
            Send_Btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Send_Btn.Size = new Size(110, 41);
            Send_Btn.TabIndex = 5;
            Send_Btn.Text = "Gửi";
            Send_Btn.Click += Send_Btn_Click_1;
            // 
            // ChatTxt
            // 
            ChatTxt.CustomizableEdges = customizableEdges3;
            ChatTxt.DefaultText = "";
            ChatTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            ChatTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            ChatTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            ChatTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            ChatTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ChatTxt.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChatTxt.ForeColor = Color.Black;
            ChatTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            ChatTxt.Location = new Point(5, 286);
            ChatTxt.Margin = new Padding(5);
            ChatTxt.Name = "ChatTxt";
            ChatTxt.PasswordChar = '\0';
            ChatTxt.PlaceholderText = "";
            ChatTxt.SelectedText = "";
            ChatTxt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ChatTxt.Size = new Size(274, 41);
            ChatTxt.TabIndex = 4;
            // 
            // Avatar_Player
            // 
            Avatar_Player.Location = new Point(19, 80);
            Avatar_Player.Name = "Avatar_Player";
            Avatar_Player.Size = new Size(183, 183);
            Avatar_Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Avatar_Player.TabIndex = 0;
            Avatar_Player.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(ExitBtn);
            panel3.Controls.Add(Avatar_Player);
            panel3.Controls.Add(IPMessage);
            panel3.Controls.Add(LAN_Btn);
            panel3.Controls.Add(PrcBCoolDown);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(FullName);
            panel3.Font = new Font("Times New Roman", 13.8F);
            panel3.Location = new Point(3, 345);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 285);
            panel3.TabIndex = 2;
            // 
            // IPMessage
            // 
            IPMessage.Location = new Point(219, 80);
            IPMessage.Name = "IPMessage";
            IPMessage.Size = new Size(178, 34);
            IPMessage.TabIndex = 5;
            // 
            // LAN_Btn
            // 
            LAN_Btn.BackColor = Color.Yellow;
            LAN_Btn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LAN_Btn.Location = new Point(219, 121);
            LAN_Btn.Name = "LAN_Btn";
            LAN_Btn.Size = new Size(178, 38);
            LAN_Btn.TabIndex = 4;
            LAN_Btn.Text = "LAN";
            LAN_Btn.UseVisualStyleBackColor = false;
            LAN_Btn.Click += LAN_Btn_Click;
            // 
            // PrcBCoolDown
            // 
            PrcBCoolDown.Location = new Point(219, 45);
            PrcBCoolDown.Name = "PrcBCoolDown";
            PrcBCoolDown.Size = new Size(178, 29);
            PrcBCoolDown.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 48);
            label2.Name = "label2";
            label2.Size = new Size(197, 26);
            label2.TabIndex = 2;
            label2.Text = "Thời gian mỗi lượt: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 12);
            label1.Name = "label1";
            label1.Size = new Size(165, 26);
            label1.TabIndex = 1;
            label1.Text = "Tên người chơi: ";
            // 
            // FullName
            // 
            FullName.Font = new Font("Times New Roman", 13.8F);
            FullName.Location = new Point(219, 4);
            FullName.Margin = new Padding(5, 4, 5, 4);
            FullName.Name = "FullName";
            FullName.Size = new Size(178, 34);
            FullName.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(837, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(408, 630);
            panel4.TabIndex = 3;
            // 
            // tmCoolDown
            // 
            tmCoolDown.Tick += tmCoolDown_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(20, 60);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1205, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(86, 29);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            newGameToolStripMenuItem.Size = new Size(289, 30);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            quitToolStripMenuItem.Size = new Size(289, 30);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.OrangeRed;
            ExitBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.ForeColor = SystemColors.ButtonFace;
            ExitBtn.Location = new Point(219, 165);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(178, 38);
            ExitBtn.TabIndex = 6;
            ExitBtn.Text = "Thoát";
            ExitBtn.UseVisualStyleBackColor = false;
            // 
            // ChessBoard
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(1245, 754);
            Controls.Add(panel4);
            Controls.Add(panel_Board);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "ChessBoard";
            Text = "ChessBoard";
            FormClosing += ChessBoard_FormClosing;
            Shown += ChessBoard_Shown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Avatar_Player).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Board;
        private Panel panel2;
        private Panel panel3;
        private TextBox FullName;
        private Label label1;
        private Label label2;
        private Panel panel4;
        private PictureBox Avatar_Player;
        private ProgressBar PrcBCoolDown;
        private System.Windows.Forms.Timer tmCoolDown;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Button LAN_Btn;
        private TextBox IPMessage;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox ChatTxt;
        private Guna.UI2.WinForms.Guna2Button Send_Btn;
        private TextBox Message_Box;
        private Button ExitBtn;
    }
}