namespace Client
{
    partial class Client_Server
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
            ClientBtn = new Button();
            ServerBtn = new Button();
            SuspendLayout();
            // 
            // ClientBtn
            // 
            ClientBtn.BackColor = Color.DodgerBlue;
            ClientBtn.ForeColor = Color.AliceBlue;
            ClientBtn.Location = new Point(154, 151);
            ClientBtn.Margin = new Padding(4, 4, 4, 4);
            ClientBtn.Name = "ClientBtn";
            ClientBtn.Size = new Size(152, 84);
            ClientBtn.TabIndex = 0;
            ClientBtn.Text = "clients";
            ClientBtn.UseVisualStyleBackColor = false;
            ClientBtn.Click += ClientBtn_Click;
            // 
            // ServerBtn
            // 
            ServerBtn.BackColor = Color.FromArgb(0, 192, 0);
            ServerBtn.ForeColor = SystemColors.ButtonHighlight;
            ServerBtn.Location = new Point(461, 151);
            ServerBtn.Margin = new Padding(4, 4, 4, 4);
            ServerBtn.Name = "ServerBtn";
            ServerBtn.Size = new Size(174, 84);
            ServerBtn.TabIndex = 1;
            ServerBtn.Text = "Server";
            ServerBtn.UseVisualStyleBackColor = false;
            ServerBtn.Click += ServerBtn_Click;
            // 
            // Client_Server
            // 
            AutoScaleDimensions = new SizeF(18F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 364);
            Controls.Add(ServerBtn);
            Controls.Add(ClientBtn);
            Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Client_Server";
            Padding = new Padding(26, 84, 26, 28);
            Text = "Client_Server";
            ResumeLayout(false);
        }

        #endregion

        private Button ClientBtn;
        private Button ServerBtn;
    }
}