﻿namespace Client
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
            panel_Board = new Panel();
            panel2 = new Panel();
            Send_Btn = new Button();
            ChatTxt = new TextBox();
            Message_Box = new TextBox();
            Avatar_Player = new PictureBox();
            panel3 = new Panel();
            ExitBtn = new Button();
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
            panel2.Controls.Add(Send_Btn);
            panel2.Controls.Add(ChatTxt);
            panel2.Controls.Add(Message_Box);
            panel2.Font = new Font("Times New Roman", 13.8F);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 333);
            panel2.TabIndex = 1;
            // 
            // Send_Btn
            // 
            Send_Btn.BackColor = Color.Lime;
            Send_Btn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Send_Btn.ForeColor = Color.Navy;
            Send_Btn.Location = new Point(287, 284);
            Send_Btn.Name = "Send_Btn";
            Send_Btn.Size = new Size(110, 41);
            Send_Btn.TabIndex = 8;
            Send_Btn.Text = "Gửi";
            Send_Btn.UseVisualStyleBackColor = false;
            Send_Btn.Click += Send_Btn_Click;
            // 
            // ChatTxt
            // 
            ChatTxt.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChatTxt.Location = new Point(3, 284);
            ChatTxt.Name = "ChatTxt";
            ChatTxt.Size = new Size(276, 39);
            ChatTxt.TabIndex = 7;
            // 
            // Message_Box
            // 
            Message_Box.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Message_Box.Location = new Point(3, 3);
            Message_Box.Multiline = true;
            Message_Box.Name = "Message_Box";
            Message_Box.ScrollBars = ScrollBars.Vertical;
            Message_Box.Size = new Size(394, 275);
            Message_Box.TabIndex = 6;
            // 
            // Avatar_Player
            // 
            Avatar_Player.Location = new Point(11, 87);
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
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.OrangeRed;
            ExitBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.ForeColor = SystemColors.ButtonFace;
            ExitBtn.Location = new Point(219, 223);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(178, 47);
            ExitBtn.TabIndex = 6;
            ExitBtn.Text = "Thoát";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // IPMessage
            // 
            IPMessage.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IPMessage.Location = new Point(219, 89);
            IPMessage.Name = "IPMessage";
            IPMessage.Size = new Size(178, 39);
            IPMessage.TabIndex = 5;
            // 
            // LAN_Btn
            // 
            LAN_Btn.BackColor = Color.Yellow;
            LAN_Btn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LAN_Btn.ForeColor = Color.FromArgb(0, 0, 192);
            LAN_Btn.Location = new Point(219, 135);
            LAN_Btn.Name = "LAN_Btn";
            LAN_Btn.Size = new Size(178, 50);
            LAN_Btn.TabIndex = 4;
            LAN_Btn.Text = "LAN";
            LAN_Btn.UseVisualStyleBackColor = false;
            LAN_Btn.Click += LAN_Btn_Click;
            // 
            // PrcBCoolDown
            // 
            PrcBCoolDown.Location = new Point(219, 51);
            PrcBCoolDown.Name = "PrcBCoolDown";
            PrcBCoolDown.Size = new Size(178, 29);
            PrcBCoolDown.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 52);
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
            FullName.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FullName.Location = new Point(219, 4);
            FullName.Margin = new Padding(5, 4, 5, 4);
            FullName.Name = "FullName";
            FullName.Size = new Size(178, 39);
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
        private TextBox Message_Box;
        private Button ExitBtn;
        private TextBox ChatTxt;
        private Button Send_Btn;
    }
}