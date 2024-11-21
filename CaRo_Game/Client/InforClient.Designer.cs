namespace Client
{
    partial class InforClient
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
            label1 = new Label();
            txtInforClient = new TextBox();
            btnVao = new Button();
            btnTimPhong = new Button();
            btnTaoPhong = new Button();
            btnBXH = new Button();
            btnDangXuat = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 33);
            label1.Name = "label1";
            label1.Size = new Size(280, 32);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Người Chơi";
            // 
            // txtInforClient
            // 
            txtInforClient.BackColor = SystemColors.InactiveCaption;
            txtInforClient.Location = new Point(34, 68);
            txtInforClient.Multiline = true;
            txtInforClient.Name = "txtInforClient";
            txtInforClient.Size = new Size(535, 399);
            txtInforClient.TabIndex = 1;
            // 
            // btnVao
            // 
            btnVao.Location = new Point(597, 142);
            btnVao.Name = "btnVao";
            btnVao.Size = new Size(264, 43);
            btnVao.TabIndex = 2;
            btnVao.Text = "Vào Nhanh";
            btnVao.UseVisualStyleBackColor = true;
            // 
            // btnTimPhong
            // 
            btnTimPhong.Location = new Point(597, 211);
            btnTimPhong.Name = "btnTimPhong";
            btnTimPhong.Size = new Size(264, 43);
            btnTimPhong.TabIndex = 3;
            btnTimPhong.Text = "Tìm Phòng";
            btnTimPhong.UseVisualStyleBackColor = true;
            // 
            // btnTaoPhong
            // 
            btnTaoPhong.Location = new Point(597, 283);
            btnTaoPhong.Name = "btnTaoPhong";
            btnTaoPhong.Size = new Size(264, 43);
            btnTaoPhong.TabIndex = 4;
            btnTaoPhong.Text = "Tạo Phòng";
            btnTaoPhong.UseVisualStyleBackColor = true;
            // 
            // btnBXH
            // 
            btnBXH.Location = new Point(597, 357);
            btnBXH.Name = "btnBXH";
            btnBXH.Size = new Size(264, 43);
            btnBXH.TabIndex = 5;
            btnBXH.Text = "Bảng Xếp Hạng";
            btnBXH.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(597, 426);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(264, 43);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // InforClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 623);
            Controls.Add(btnDangXuat);
            Controls.Add(btnBXH);
            Controls.Add(btnTaoPhong);
            Controls.Add(btnTimPhong);
            Controls.Add(btnVao);
            Controls.Add(txtInforClient);
            Controls.Add(label1);
            Name = "InforClient";
            Text = "InforClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInforClient;
        private Button btnVao;
        private Button btnTimPhong;
        private Button btnTaoPhong;
        private Button btnBXH;
        private Button btnDangXuat;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}