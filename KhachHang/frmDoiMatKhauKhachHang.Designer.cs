namespace CyberManagementProject.KhachHang
{
    partial class frmDoiMatKhauKhachHang
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
            lblTKKhachHang = new Label();
            txtTKKhachHang = new TextBox();
            txtMKKhachHang = new TextBox();
            lblMatKhau = new Label();
            btnCapNhat = new Button();
            btnDong = new Button();
            SuspendLayout();
            // 
            // lblTKKhachHang
            // 
            lblTKKhachHang.Font = new Font("Segoe UI", 14.25F);
            lblTKKhachHang.Location = new Point(8, 24);
            lblTKKhachHang.Name = "lblTKKhachHang";
            lblTKKhachHang.Size = new Size(96, 30);
            lblTKKhachHang.TabIndex = 12;
            lblTKKhachHang.Text = "Tên TK";
            // 
            // txtTKKhachHang
            // 
            txtTKKhachHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTKKhachHang.ForeColor = Color.Black;
            txtTKKhachHang.Location = new Point(120, 16);
            txtTKKhachHang.Multiline = true;
            txtTKKhachHang.Name = "txtTKKhachHang";
            txtTKKhachHang.ReadOnly = true;
            txtTKKhachHang.Size = new Size(272, 40);
            txtTKKhachHang.TabIndex = 11;
            // 
            // txtMKKhachHang
            // 
            txtMKKhachHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMKKhachHang.ForeColor = Color.Black;
            txtMKKhachHang.Location = new Point(120, 72);
            txtMKKhachHang.Multiline = true;
            txtMKKhachHang.Name = "txtMKKhachHang";
            txtMKKhachHang.Size = new Size(272, 40);
            txtMKKhachHang.TabIndex = 11;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Font = new Font("Segoe UI", 14.25F);
            lblMatKhau.Location = new Point(8, 80);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(96, 30);
            lblMatKhau.TabIndex = 12;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 14.25F);
            btnCapNhat.Location = new Point(80, 128);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(104, 40);
            btnCapNhat.TabIndex = 13;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 14.25F);
            btnDong.Location = new Point(224, 128);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(104, 40);
            btnDong.TabIndex = 14;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // frmDoiMatKhauKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 179);
            Controls.Add(btnDong);
            Controls.Add(btnCapNhat);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTKKhachHang);
            Controls.Add(txtMKKhachHang);
            Controls.Add(txtTKKhachHang);
            Name = "frmDoiMatKhauKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu khách hàng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTKKhachHang;
        private TextBox txtTKKhachHang;
        private TextBox txtMKKhachHang;
        private Label lblMatKhau;
        private Button btnCapNhat;
        private Button btnDong;
    }
}