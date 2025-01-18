namespace QuanLyQuanNet.Customer
{
    partial class frmThongTinKhachHang
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
            gbxThemKhachHang = new GroupBox();
            cbxLoaiKhach = new ComboBox();
            btnDong = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtSoDT = new TextBox();
            txtTenKhachHang = new TextBox();
            txtID = new TextBox();
            gbxThemKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // gbxThemKhachHang
            // 
            gbxThemKhachHang.Controls.Add(cbxLoaiKhach);
            gbxThemKhachHang.Controls.Add(btnDong);
            gbxThemKhachHang.Controls.Add(btnXoa);
            gbxThemKhachHang.Controls.Add(btnCapNhat);
            gbxThemKhachHang.Controls.Add(txtDiaChi);
            gbxThemKhachHang.Controls.Add(txtEmail);
            gbxThemKhachHang.Controls.Add(txtSoDT);
            gbxThemKhachHang.Controls.Add(txtTenKhachHang);
            gbxThemKhachHang.Controls.Add(txtID);
            gbxThemKhachHang.FlatStyle = FlatStyle.Flat;
            gbxThemKhachHang.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxThemKhachHang.Location = new Point(7, 4);
            gbxThemKhachHang.Name = "gbxThemKhachHang";
            gbxThemKhachHang.Size = new Size(432, 496);
            gbxThemKhachHang.TabIndex = 1;
            gbxThemKhachHang.TabStop = false;
            // 
            // cbxLoaiKhach
            // 
            cbxLoaiKhach.Font = new Font("Segoe UI", 14.25F);
            cbxLoaiKhach.FormattingEnabled = true;
            cbxLoaiKhach.Location = new Point(24, 328);
            cbxLoaiKhach.Name = "cbxLoaiKhach";
            cbxLoaiKhach.Size = new Size(392, 33);
            cbxLoaiKhach.TabIndex = 5;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 14.25F);
            btnDong.Location = new Point(296, 400);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(112, 40);
            btnDong.TabIndex = 8;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 14.25F);
            btnXoa.Location = new Point(160, 400);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 40);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 14.25F);
            btnCapNhat.Location = new Point(24, 400);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(112, 40);
            btnCapNhat.TabIndex = 6;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 14.25F);
            txtDiaChi.Location = new Point(24, 272);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(392, 40);
            txtDiaChi.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F);
            txtEmail.Location = new Point(24, 216);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(392, 40);
            txtEmail.TabIndex = 3;
            // 
            // txtSoDT
            // 
            txtSoDT.Font = new Font("Segoe UI", 14.25F);
            txtSoDT.Location = new Point(24, 160);
            txtSoDT.Multiline = true;
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(392, 40);
            txtSoDT.TabIndex = 2;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenKhachHang.ForeColor = Color.FromArgb(224, 224, 224);
            txtTenKhachHang.Location = new Point(24, 104);
            txtTenKhachHang.Multiline = true;
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(392, 40);
            txtTenKhachHang.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(24, 48);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(392, 40);
            txtID.TabIndex = 0;
            // 
            // frmThongTinKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 505);
            Controls.Add(gbxThemKhachHang);
            Name = "frmThongTinKhachHang";
            Text = "Thông Tin Khách Hàng";
            gbxThemKhachHang.ResumeLayout(false);
            gbxThemKhachHang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxThemKhachHang;
        private ComboBox cbxLoaiKhach;
        private Button btnDong;
        private Button btnCapNhat;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtSoDT;
        private TextBox txtTenKhachHang;
        private TextBox txtID;
        private Button btnXoa;
    }
}