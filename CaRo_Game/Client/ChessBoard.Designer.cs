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
            panel_Board = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            FullName = new TextBox();
            panel4 = new Panel();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Board
            // 
            panel_Board.BackColor = Color.FromArgb(255, 255, 192);
            panel_Board.Font = new Font("Times New Roman", 13.8F);
            panel_Board.Location = new Point(14, 21);
            panel_Board.Margin = new Padding(5, 4, 5, 4);
            panel_Board.Name = "panel_Board";
            panel_Board.Size = new Size(810, 630);
            panel_Board.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Font = new Font("Times New Roman", 13.8F);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 392);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(FullName);
            panel3.Font = new Font("Times New Roman", 13.8F);
            panel3.Location = new Point(3, 400);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 230);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 48);
            label2.Name = "label2";
            label2.Size = new Size(67, 26);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(60, 26);
            label1.TabIndex = 1;
            label1.Text = "Tên: ";
            // 
            // FullName
            // 
            FullName.Font = new Font("Times New Roman", 13.8F);
            FullName.Location = new Point(194, 4);
            FullName.Margin = new Padding(5, 4, 5, 4);
            FullName.Name = "FullName";
            FullName.Size = new Size(201, 34);
            FullName.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(826, 21);
            panel4.Name = "panel4";
            panel4.Size = new Size(408, 630);
            panel4.TabIndex = 3;
            // 
            // ChessBoard
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 669);
            Controls.Add(panel4);
            Controls.Add(panel_Board);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ChessBoard";
            Text = "ChessBoard";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Board;
        private Panel panel2;
        private Panel panel3;
        private TextBox FullName;
        private Label label1;
        private Label label2;
        private Panel panel4;
    }
}