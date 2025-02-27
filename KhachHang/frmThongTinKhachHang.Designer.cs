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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinKhachHang));
            gbxThemKhachHang = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbxLoaiKhachHang = new ComboBox();
            txtDiaChiKhachHang = new TextBox();
            txtEmailKhachHang = new TextBox();
            txtSoDTKhachHang = new TextBox();
            txtTenKhachHang = new TextBox();
            label1 = new Label();
            btnDong = new Button();
            btnXoa = new Button();
            btnDoiMK = new Button();
            btnCapNhat = new Button();
            txtIDKhachHang = new TextBox();
            gbxInfoAccount = new GroupBox();
            llbMoneyAccount = new Label();
            tbxMoneyTK = new TextBox();
            gbxThemKhachHang.SuspendLayout();
            gbxInfoAccount.SuspendLayout();
            SuspendLayout();
            // 
            // gbxThemKhachHang
            // 
            gbxThemKhachHang.Controls.Add(label6);
            gbxThemKhachHang.Controls.Add(label5);
            gbxThemKhachHang.Controls.Add(label4);
            gbxThemKhachHang.Controls.Add(label3);
            gbxThemKhachHang.Controls.Add(label2);
            gbxThemKhachHang.Controls.Add(cbxLoaiKhachHang);
            gbxThemKhachHang.Controls.Add(txtDiaChiKhachHang);
            gbxThemKhachHang.Controls.Add(txtEmailKhachHang);
            gbxThemKhachHang.Controls.Add(txtSoDTKhachHang);
            gbxThemKhachHang.Controls.Add(txtTenKhachHang);
            gbxThemKhachHang.FlatStyle = FlatStyle.Flat;
            gbxThemKhachHang.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxThemKhachHang.Location = new Point(7, 8);
            gbxThemKhachHang.Name = "gbxThemKhachHang";
            gbxThemKhachHang.Size = new Size(432, 352);
            gbxThemKhachHang.TabIndex = 1;
            gbxThemKhachHang.TabStop = false;
            gbxThemKhachHang.Text = "Thông tin cá nhân";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 280);
            label6.Name = "label6";
            label6.Size = new Size(81, 30);
            label6.TabIndex = 9;
            label6.Text = "Nhóm:";
            // 
            // label5
            // 
            label5.Location = new Point(15, 224);
            label5.Name = "label5";
            label5.Size = new Size(88, 30);
            label5.TabIndex = 9;
            label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 168);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 112);
            label3.Name = "label3";
            label3.Size = new Size(77, 30);
            label3.TabIndex = 9;
            label3.Text = "Số ĐT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 48);
            label2.Name = "label2";
            label2.Size = new Size(53, 30);
            label2.TabIndex = 9;
            label2.Text = "Tên:";
            // 
            // cbxLoaiKhachHang
            // 
            cbxLoaiKhachHang.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            cbxLoaiKhachHang.FormattingEnabled = true;
            cbxLoaiKhachHang.Location = new Point(120, 280);
            cbxLoaiKhachHang.Name = "cbxLoaiKhachHang";
            cbxLoaiKhachHang.Size = new Size(296, 27);
            cbxLoaiKhachHang.TabIndex = 5;
            cbxLoaiKhachHang.SelectedIndexChanged += cbxLoaiKhachHang_SelectedIndexChanged;
            cbxLoaiKhachHang.Enter += cbxLoaiKhachHang_Enter;
            cbxLoaiKhachHang.Leave += cbxLoaiKhachHang_Leave;
            // 
            // txtDiaChiKhachHang
            // 
            txtDiaChiKhachHang.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            txtDiaChiKhachHang.Location = new Point(120, 224);
            txtDiaChiKhachHang.Multiline = true;
            txtDiaChiKhachHang.Name = "txtDiaChiKhachHang";
            txtDiaChiKhachHang.Size = new Size(296, 27);
            txtDiaChiKhachHang.TabIndex = 4;
            txtDiaChiKhachHang.Enter += txtDiaChiKhachHang_Enter;
            txtDiaChiKhachHang.Leave += txtDiaChiKhachHang_Leave;
            // 
            // txtEmailKhachHang
            // 
            txtEmailKhachHang.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            txtEmailKhachHang.Location = new Point(120, 168);
            txtEmailKhachHang.Multiline = true;
            txtEmailKhachHang.Name = "txtEmailKhachHang";
            txtEmailKhachHang.Size = new Size(296, 27);
            txtEmailKhachHang.TabIndex = 3;
            txtEmailKhachHang.Enter += txtEmailKhachHang_Enter;
            txtEmailKhachHang.Leave += txtEmailKhachHang_Leave;
            // 
            // txtSoDTKhachHang
            // 
            txtSoDTKhachHang.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            txtSoDTKhachHang.Location = new Point(120, 112);
            txtSoDTKhachHang.Multiline = true;
            txtSoDTKhachHang.Name = "txtSoDTKhachHang";
            txtSoDTKhachHang.Size = new Size(296, 27);
            txtSoDTKhachHang.TabIndex = 2;
            txtSoDTKhachHang.Enter += txtSoDTKhachHang_Enter;
            txtSoDTKhachHang.Leave += txtSoDTKhachHang_Leave;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            txtTenKhachHang.ForeColor = Color.Black;
            txtTenKhachHang.Location = new Point(120, 48);
            txtTenKhachHang.Multiline = true;
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(296, 27);
            txtTenKhachHang.TabIndex = 1;
            txtTenKhachHang.Enter += txtTenKhachHang_Enter;
            txtTenKhachHang.Leave += txtTenKhachHang_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 40);
            label1.Name = "label1";
            label1.Size = new Size(41, 30);
            label1.TabIndex = 9;
            label1.Text = "ID:";
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 14.25F);
            btnDong.Location = new Point(600, 264);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(144, 40);
            btnDong.TabIndex = 8;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 14.25F);
            btnXoa.Location = new Point(448, 264);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(144, 40);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDoiMK
            // 
            btnDoiMK.Font = new Font("Segoe UI", 14.25F);
            btnDoiMK.Location = new Point(600, 208);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(144, 40);
            btnDoiMK.TabIndex = 6;
            btnDoiMK.Text = "Đổi Pass";
            btnDoiMK.UseVisualStyleBackColor = true;
            btnDoiMK.Click += btnDoiMK_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 14.25F);
            btnCapNhat.Location = new Point(448, 208);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(144, 40);
            btnCapNhat.TabIndex = 6;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtIDKhachHang
            // 
            txtIDKhachHang.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIDKhachHang.Location = new Point(88, 48);
            txtIDKhachHang.Multiline = true;
            txtIDKhachHang.Name = "txtIDKhachHang";
            txtIDKhachHang.ReadOnly = true;
            txtIDKhachHang.Size = new Size(200, 27);
            txtIDKhachHang.TabIndex = 0;
            // 
            // gbxInfoAccount
            // 
            gbxInfoAccount.Controls.Add(llbMoneyAccount);
            gbxInfoAccount.Controls.Add(tbxMoneyTK);
            gbxInfoAccount.Controls.Add(txtIDKhachHang);
            gbxInfoAccount.Controls.Add(label1);
            gbxInfoAccount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            gbxInfoAccount.Location = new Point(448, 8);
            gbxInfoAccount.Name = "gbxInfoAccount";
            gbxInfoAccount.Size = new Size(296, 152);
            gbxInfoAccount.TabIndex = 2;
            gbxInfoAccount.TabStop = false;
            gbxInfoAccount.Text = "Tài khoản";
            // 
            // llbMoneyAccount
            // 
            llbMoneyAccount.AutoSize = true;
            llbMoneyAccount.Location = new Point(8, 88);
            llbMoneyAccount.Name = "llbMoneyAccount";
            llbMoneyAccount.Size = new Size(77, 30);
            llbMoneyAccount.TabIndex = 11;
            llbMoneyAccount.Text = "Số dư:";
            // 
            // tbxMoneyTK
            // 
            tbxMoneyTK.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            tbxMoneyTK.Location = new Point(88, 88);
            tbxMoneyTK.Name = "tbxMoneyTK";
            tbxMoneyTK.ReadOnly = true;
            tbxMoneyTK.Size = new Size(200, 27);
            tbxMoneyTK.TabIndex = 10;
            // 
            // frmThongTinKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 363);
            Controls.Add(gbxInfoAccount);
            Controls.Add(gbxThemKhachHang);
            Controls.Add(btnCapNhat);
            Controls.Add(btnDoiMK);
            Controls.Add(btnXoa);
            Controls.Add(btnDong);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmThongTinKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Khách Hàng";
            gbxThemKhachHang.ResumeLayout(false);
            gbxThemKhachHang.PerformLayout();
            gbxInfoAccount.ResumeLayout(false);
            gbxInfoAccount.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxThemKhachHang;
        private ComboBox cbxLoaiKhachHang;
        private Button btnDong;
        private Button btnCapNhat;
        private TextBox txtDiaChiKhachHang;
        private TextBox txtEmailKhachHang;
        private TextBox txtSoDTKhachHang;
        private TextBox txtTenKhachHang;
        private TextBox txtIDKhachHang;
        private Button btnXoa;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnDoiMK;
        private GroupBox gbxInfoAccount;
        private Label llbMoneyAccount;
        private TextBox tbxMoneyTK;
    }
}