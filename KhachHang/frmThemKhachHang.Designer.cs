namespace QuanLyQuanNet.KhachHang
{
    partial class frmThemKhachHang
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
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            txtID = new TextBox();
            gbxThemKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // gbxThemKhachHang
            // 
            gbxThemKhachHang.Controls.Add(btnHuyBo);
            gbxThemKhachHang.Controls.Add(btnDongY);
            gbxThemKhachHang.Controls.Add(txtMatKhau);
            gbxThemKhachHang.Controls.Add(txtTaiKhoan);
            gbxThemKhachHang.Controls.Add(txtID);
            gbxThemKhachHang.FlatStyle = FlatStyle.Flat;
            gbxThemKhachHang.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxThemKhachHang.Location = new Point(8, 8);
            gbxThemKhachHang.Name = "gbxThemKhachHang";
            gbxThemKhachHang.Size = new Size(432, 288);
            gbxThemKhachHang.TabIndex = 0;
            gbxThemKhachHang.TabStop = false;
            gbxThemKhachHang.Text = "Thêm Khách Hàng";
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
            btnHuyBo.Click += btnHuyBo_Click;
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
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 14.25F);
            txtMatKhau.Location = new Point(24, 160);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(392, 40);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.Enter += txtMatKhau_Enter;
            txtMatKhau.Leave += txtMatKhau_Leave;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoan.ForeColor = Color.FromArgb(224, 224, 224);
            txtTaiKhoan.Location = new Point(24, 104);
            txtTaiKhoan.Multiline = true;
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(392, 40);
            txtTaiKhoan.TabIndex = 1;
            txtTaiKhoan.Enter += txtTenKhachHang_Enter;
            txtTaiKhoan.Leave += txtTenKhachHang_Leave;
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
            // frmThemKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 309);
            Controls.Add(gbxThemKhachHang);
            Name = "frmThemKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemKhachHang";
            gbxThemKhachHang.ResumeLayout(false);
            gbxThemKhachHang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxThemKhachHang;
        private TextBox txtID;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Button btnDongY;
        private Button btnHuyBo;
    }
}