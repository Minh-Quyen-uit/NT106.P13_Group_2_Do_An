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
            ClientBtn.Location = new Point(112, 163);
            ClientBtn.Name = "ClientBtn";
            ClientBtn.Size = new Size(118, 60);
            ClientBtn.TabIndex = 0;
            ClientBtn.Text = "clients";
            ClientBtn.UseVisualStyleBackColor = true;
            ClientBtn.Click += ClientBtn_Click;
            // 
            // ServerBtn
            // 
            ServerBtn.Location = new Point(401, 163);
            ServerBtn.Name = "ServerBtn";
            ServerBtn.Size = new Size(135, 60);
            ServerBtn.TabIndex = 1;
            ServerBtn.Text = "Server";
            ServerBtn.UseVisualStyleBackColor = true;
            ServerBtn.Click += ServerBtn_Click;
            // 
            // Client_Server
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 349);
            Controls.Add(ServerBtn);
            Controls.Add(ClientBtn);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Client_Server";
            Text = "Client_Server";
            ResumeLayout(false);
        }

        #endregion

        private Button ClientBtn;
        private Button ServerBtn;
    }
}