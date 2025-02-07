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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbxLoaiKhachHang = new ComboBox();
            btnDong = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            txtDiaChiKhachHang = new TextBox();
            txtEmailKhachHang = new TextBox();
            txtSoDTKhachHang = new TextBox();
            txtTenKhachHang = new TextBox();
            txtIDKhachHang = new TextBox();
            gbxThemKhachHang.SuspendLayout();
            SuspendLayout();
            // 
            // gbxThemKhachHang
            // 
            gbxThemKhachHang.Controls.Add(label6);
            gbxThemKhachHang.Controls.Add(label5);
            gbxThemKhachHang.Controls.Add(label4);
            gbxThemKhachHang.Controls.Add(label3);
            gbxThemKhachHang.Controls.Add(label2);
            gbxThemKhachHang.Controls.Add(label1);
            gbxThemKhachHang.Controls.Add(cbxLoaiKhachHang);
            gbxThemKhachHang.Controls.Add(btnDong);
            gbxThemKhachHang.Controls.Add(btnXoa);
            gbxThemKhachHang.Controls.Add(btnCapNhat);
            gbxThemKhachHang.Controls.Add(txtDiaChiKhachHang);
            gbxThemKhachHang.Controls.Add(txtEmailKhachHang);
            gbxThemKhachHang.Controls.Add(txtSoDTKhachHang);
            gbxThemKhachHang.Controls.Add(txtTenKhachHang);
            gbxThemKhachHang.Controls.Add(txtIDKhachHang);
            gbxThemKhachHang.FlatStyle = FlatStyle.Flat;
            gbxThemKhachHang.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxThemKhachHang.Location = new Point(7, 4);
            gbxThemKhachHang.Name = "gbxThemKhachHang";
            gbxThemKhachHang.Size = new Size(432, 496);
            gbxThemKhachHang.TabIndex = 1;
            gbxThemKhachHang.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 328);
            label6.Name = "label6";
            label6.Size = new Size(75, 30);
            label6.TabIndex = 9;
            label6.Text = "Nhóm";
            // 
            // label5
            // 
            label5.Location = new Point(24, 280);
            label5.Name = "label5";
            label5.Size = new Size(88, 30);
            label5.TabIndex = 9;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 224);
            label4.Name = "label4";
            label4.Size = new Size(66, 30);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 168);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 9;
            label3.Text = "Số ĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 112);
            label2.Name = "label2";
            label2.Size = new Size(47, 30);
            label2.TabIndex = 9;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 56);
            label1.Name = "label1";
            label1.Size = new Size(35, 30);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // cbxLoaiKhachHang
            // 
            cbxLoaiKhachHang.Font = new Font("Segoe UI", 14.25F);
            cbxLoaiKhachHang.FormattingEnabled = true;
            cbxLoaiKhachHang.Items.AddRange(new object[] { "VIP", "Thường" });
            cbxLoaiKhachHang.Location = new Point(120, 328);
            cbxLoaiKhachHang.Name = "cbxLoaiKhachHang";
            cbxLoaiKhachHang.Size = new Size(296, 33);
            cbxLoaiKhachHang.TabIndex = 5;
            cbxLoaiKhachHang.Enter += cbxLoaiKhachHang_Enter;
            cbxLoaiKhachHang.Leave += cbxLoaiKhachHang_Leave;
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
            btnDong.Click += btnDong_Click;
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
            btnXoa.Click += btnXoa_Click;
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
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtDiaChiKhachHang
            // 
            txtDiaChiKhachHang.Font = new Font("Segoe UI", 14.25F);
            txtDiaChiKhachHang.Location = new Point(120, 272);
            txtDiaChiKhachHang.Multiline = true;
            txtDiaChiKhachHang.Name = "txtDiaChiKhachHang";
            txtDiaChiKhachHang.Size = new Size(296, 40);
            txtDiaChiKhachHang.TabIndex = 4;
            txtDiaChiKhachHang.Enter += txtDiaChiKhachHang_Enter;
            txtDiaChiKhachHang.Leave += txtDiaChiKhachHang_Leave;
            // 
            // txtEmailKhachHang
            // 
            txtEmailKhachHang.Font = new Font("Segoe UI", 14.25F);
            txtEmailKhachHang.Location = new Point(120, 216);
            txtEmailKhachHang.Multiline = true;
            txtEmailKhachHang.Name = "txtEmailKhachHang";
            txtEmailKhachHang.Size = new Size(296, 40);
            txtEmailKhachHang.TabIndex = 3;
            txtEmailKhachHang.Enter += txtEmailKhachHang_Enter;
            txtEmailKhachHang.Leave += txtEmailKhachHang_Leave;
            // 
            // txtSoDTKhachHang
            // 
            txtSoDTKhachHang.Font = new Font("Segoe UI", 14.25F);
            txtSoDTKhachHang.Location = new Point(120, 160);
            txtSoDTKhachHang.Multiline = true;
            txtSoDTKhachHang.Name = "txtSoDTKhachHang";
            txtSoDTKhachHang.Size = new Size(296, 40);
            txtSoDTKhachHang.TabIndex = 2;
            txtSoDTKhachHang.Enter += txtSoDTKhachHang_Enter;
            txtSoDTKhachHang.Leave += txtSoDTKhachHang_Leave;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenKhachHang.ForeColor = Color.Black;
            txtTenKhachHang.Location = new Point(120, 104);
            txtTenKhachHang.Multiline = true;
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(296, 40);
            txtTenKhachHang.TabIndex = 1;
            txtTenKhachHang.Enter += txtTenKhachHang_Enter;
            txtTenKhachHang.Leave += txtTenKhachHang_Leave;
            // 
            // txtIDKhachHang
            // 
            txtIDKhachHang.Location = new Point(120, 48);
            txtIDKhachHang.Multiline = true;
            txtIDKhachHang.Name = "txtIDKhachHang";
            txtIDKhachHang.ReadOnly = true;
            txtIDKhachHang.Size = new Size(296, 40);
            txtIDKhachHang.TabIndex = 0;
            // 
            // frmThongTinKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 505);
            Controls.Add(gbxThemKhachHang);
            Name = "frmThongTinKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Khách Hàng";
            gbxThemKhachHang.ResumeLayout(false);
            gbxThemKhachHang.PerformLayout();
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
    }
}