namespace QuanLyQuanNet.KhachHang
{
    partial class frmKhachHang_Add
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
            btnHuyBo = new Button();
            btnDongY = new Button();
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
            gbxThemKhachHang.Controls.Add(btnHuyBo);
            gbxThemKhachHang.Controls.Add(btnDongY);
            gbxThemKhachHang.Controls.Add(txtDiaChi);
            gbxThemKhachHang.Controls.Add(txtEmail);
            gbxThemKhachHang.Controls.Add(txtSoDT);
            gbxThemKhachHang.Controls.Add(txtTenKhachHang);
            gbxThemKhachHang.Controls.Add(txtID);
            gbxThemKhachHang.FlatStyle = FlatStyle.Flat;
            gbxThemKhachHang.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxThemKhachHang.Location = new Point(8, 8);
            gbxThemKhachHang.Name = "gbxThemKhachHang";
            gbxThemKhachHang.Size = new Size(432, 496);
            gbxThemKhachHang.TabIndex = 0;
            gbxThemKhachHang.TabStop = false;
            gbxThemKhachHang.Text = "Thêm Khách Hàng";
            // 
            // cbxLoaiKhach
            // 
            cbxLoaiKhach.Font = new Font("Segoe UI", 14.25F);
            cbxLoaiKhach.FormattingEnabled = true;
            cbxLoaiKhach.Location = new Point(24, 328);
            cbxLoaiKhach.Name = "cbxLoaiKhach";
            cbxLoaiKhach.Size = new Size(392, 33);
            cbxLoaiKhach.TabIndex = 5;
            cbxLoaiKhach.Enter += cbxLoaiKhach_Enter;
            cbxLoaiKhach.Leave += cbxLoaiKhach_Leave;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Segoe UI", 14.25F);
            btnHuyBo.Location = new Point(240, 392);
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
            btnDongY.Location = new Point(72, 392);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(112, 40);
            btnDongY.TabIndex = 6;
            btnDongY.Text = "Đồng Ý";
            btnDongY.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 14.25F);
            txtDiaChi.Location = new Point(24, 272);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(392, 40);
            txtDiaChi.TabIndex = 4;
            txtDiaChi.Enter += txtDiaChi_Enter;
            txtDiaChi.Leave += txtDiaChi_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F);
            txtEmail.Location = new Point(24, 216);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(392, 40);
            txtEmail.TabIndex = 3;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtSoDT
            // 
            txtSoDT.Font = new Font("Segoe UI", 14.25F);
            txtSoDT.Location = new Point(24, 160);
            txtSoDT.Multiline = true;
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(392, 40);
            txtSoDT.TabIndex = 2;
            txtSoDT.Enter += txtSoDT_Enter;
            txtSoDT.Leave += txtSoDT_Leave;
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
            txtTenKhachHang.TextChanged += txtTenKhachHang_TextChanged;
            txtTenKhachHang.Enter += txtTenKhachHang_Enter;
            txtTenKhachHang.Leave += txtTenKhachHang_Leave;
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
            // frmKhachHang_Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 505);
            Controls.Add(gbxThemKhachHang);
            Name = "frmKhachHang_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmKhachHang_Add";
            gbxThemKhachHang.ResumeLayout(false);
            gbxThemKhachHang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxThemKhachHang;
        private TextBox txtID;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtSoDT;
        private TextBox txtTenKhachHang;
        private Button btnDongY;
        private Button btnHuyBo;
        private ComboBox cbxLoaiKhach;
    }
}