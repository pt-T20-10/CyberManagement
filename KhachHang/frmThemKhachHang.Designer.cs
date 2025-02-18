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
            txtMatKhauKhachHang = new TextBox();
            txtTaiKhoanKhachHang = new TextBox();
            txtIDKhachHang = new TextBox();
            gbxThemKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // gbxThemKhachHang
            // 
            gbxThemKhachHang.Controls.Add(btnHuyBo);
            gbxThemKhachHang.Controls.Add(btnDongY);
            gbxThemKhachHang.Controls.Add(txtMatKhauKhachHang);
            gbxThemKhachHang.Controls.Add(txtTaiKhoanKhachHang);
            gbxThemKhachHang.Controls.Add(txtIDKhachHang);
            gbxThemKhachHang.FlatStyle = FlatStyle.Flat;
            gbxThemKhachHang.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxThemKhachHang.Location = new Point(8, 8);
            gbxThemKhachHang.Name = "gbxThemKhachHang";
            gbxThemKhachHang.Size = new Size(432, 288);
            gbxThemKhachHang.TabIndex = 4;
            gbxThemKhachHang.TabStop = false;
            gbxThemKhachHang.Text = "Thêm Khách Hàng";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Segoe UI", 14.25F);
            btnHuyBo.Location = new Point(216, 232);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 40);
            btnHuyBo.TabIndex = 4;
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
            btnDongY.TabIndex = 3;
            btnDongY.Text = "Đồng Ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // txtMatKhauKhachHang
            // 
            txtMatKhauKhachHang.Font = new Font("Segoe UI", 14.25F);
            txtMatKhauKhachHang.Location = new Point(24, 160);
            txtMatKhauKhachHang.Multiline = true;
            txtMatKhauKhachHang.Name = "txtMatKhauKhachHang";
            txtMatKhauKhachHang.PasswordChar = '*';
            txtMatKhauKhachHang.Size = new Size(392, 40);
            txtMatKhauKhachHang.TabIndex = 2;
            txtMatKhauKhachHang.Text = "1";
            txtMatKhauKhachHang.Enter += txtMatKhau_Enter;
            txtMatKhauKhachHang.Leave += txtMatKhau_Leave;
            // 
            // txtTaiKhoanKhachHang
            // 
            txtTaiKhoanKhachHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoanKhachHang.ForeColor = Color.Black;
            txtTaiKhoanKhachHang.Location = new Point(24, 104);
            txtTaiKhoanKhachHang.Multiline = true;
            txtTaiKhoanKhachHang.Name = "txtTaiKhoanKhachHang";
            txtTaiKhoanKhachHang.Size = new Size(392, 40);
            txtTaiKhoanKhachHang.TabIndex = 1;
            txtTaiKhoanKhachHang.Enter += txtTenKhachHang_Enter;
            txtTaiKhoanKhachHang.Leave += txtTenKhachHang_Leave;
            // 
            // txtIDKhachHang
            // 
            txtIDKhachHang.Location = new Point(24, 48);
            txtIDKhachHang.Multiline = true;
            txtIDKhachHang.Name = "txtIDKhachHang";
            txtIDKhachHang.ReadOnly = true;
            txtIDKhachHang.Size = new Size(392, 40);
            txtIDKhachHang.TabIndex = 5;
            // 
            // frmThemKhachHang
            // 
            AcceptButton = btnDongY;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnHuyBo;
            ClientSize = new Size(446, 309);
            Controls.Add(gbxThemKhachHang);
            Name = "frmThemKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm tài khoản khách hàng";
            gbxThemKhachHang.ResumeLayout(false);
            gbxThemKhachHang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxThemKhachHang;
        private TextBox txtIDKhachHang;
        private TextBox txtMatKhauKhachHang;
        private TextBox txtTaiKhoanKhachHang;
        private Button btnDongY;
        private Button btnHuyBo;
    }
}