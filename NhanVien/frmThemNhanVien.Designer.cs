namespace CyberManagementProject.NhanVien
{
    partial class frmThemNhanVien
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
            btnHuyBo = new Button();
            btnDongY = new Button();
            txtMatKhauNhanVien = new TextBox();
            txtTaiKhoanNhanVien = new TextBox();
            txtIDNhanVien = new TextBox();
            gbxThemKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // gbxThemKhachHang
            // 
            gbxThemKhachHang.Controls.Add(btnHuyBo);
            gbxThemKhachHang.Controls.Add(btnDongY);
            gbxThemKhachHang.Controls.Add(txtMatKhauNhanVien);
            gbxThemKhachHang.Controls.Add(txtTaiKhoanNhanVien);
            gbxThemKhachHang.Controls.Add(txtIDNhanVien);
            gbxThemKhachHang.FlatStyle = FlatStyle.Flat;
            gbxThemKhachHang.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxThemKhachHang.Location = new Point(8, 8);
            gbxThemKhachHang.Name = "gbxThemKhachHang";
            gbxThemKhachHang.Size = new Size(432, 288);
            gbxThemKhachHang.TabIndex = 1;
            gbxThemKhachHang.TabStop = false;
            gbxThemKhachHang.Text = "Thêm Nhân Viên";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Segoe UI", 14.25F);
            btnHuyBo.Location = new Point(216, 232);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 40);
            btnHuyBo.TabIndex = 7;
            btnHuyBo.Text = "Huỷ Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnDongY
            // 
            btnDongY.Font = new Font("Segoe UI", 14.25F);
            btnDongY.Location = new Point(72, 232);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(112, 40);
            btnDongY.TabIndex = 6;
            btnDongY.Text = "Đồng Ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // txtMatKhauNhanVien
            // 
            txtMatKhauNhanVien.Font = new Font("Segoe UI", 14.25F);
            txtMatKhauNhanVien.Location = new Point(24, 160);
            txtMatKhauNhanVien.Multiline = true;
            txtMatKhauNhanVien.Name = "txtMatKhauNhanVien";
            txtMatKhauNhanVien.PasswordChar = '*';
            txtMatKhauNhanVien.Size = new Size(392, 40);
            txtMatKhauNhanVien.TabIndex = 2;
            txtMatKhauNhanVien.Enter += txtMatKhau_Enter;
            txtMatKhauNhanVien.Leave += txtMatKhau_Leave;
            // 
            // txtTaiKhoanNhanVien
            // 
            txtTaiKhoanNhanVien.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoanNhanVien.ForeColor = Color.FromArgb(224, 224, 224);
            txtTaiKhoanNhanVien.Location = new Point(24, 104);
            txtTaiKhoanNhanVien.Multiline = true;
            txtTaiKhoanNhanVien.Name = "txtTaiKhoanNhanVien";
            txtTaiKhoanNhanVien.Size = new Size(392, 40);
            txtTaiKhoanNhanVien.TabIndex = 1;
            txtTaiKhoanNhanVien.Enter += txtTaiKhoan_Enter;
            txtTaiKhoanNhanVien.Leave += txtTaiKhoan_Leave;
            // 
            // txtIDNhanVien
            // 
            txtIDNhanVien.Location = new Point(24, 48);
            txtIDNhanVien.Multiline = true;
            txtIDNhanVien.Name = "txtIDNhanVien";
            txtIDNhanVien.ReadOnly = true;
            txtIDNhanVien.Size = new Size(392, 40);
            txtIDNhanVien.TabIndex = 0;
            // 
            // frmThemNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 309);
            Controls.Add(gbxThemKhachHang);
            Name = "frmThemNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemNhanVien";
            gbxThemKhachHang.ResumeLayout(false);
            gbxThemKhachHang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxThemKhachHang;
        private Button btnHuyBo;
        private Button btnDongY;
        private TextBox txtMatKhauNhanVien;
        private TextBox txtTaiKhoanNhanVien;
        private TextBox txtIDNhanVien;
    }
}