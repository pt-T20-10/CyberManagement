namespace QuanLyQuanNet
{
    partial class frmThongTinNhanVien
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
            panel1 = new Panel();
            btnChonAnh = new Button();
            pbxAnhNhanVien = new PictureBox();
            panel2 = new Panel();
            cbxKieuLamNhanVien = new ComboBox();
            cbxChucVuNhanVien = new ComboBox();
            cbxBoPhanNhanVien = new ComboBox();
            txtIDNhanVien = new TextBox();
            lblIDNhanVien = new Label();
            lblTenNhanVien = new Label();
            lblKieuLamNhanVien = new Label();
            txtTenNhanVien = new TextBox();
            lblBoPhanNhanVien = new Label();
            lblChucVuNhanVien = new Label();
            panel3 = new Panel();
            tclProfileNhanVien = new TabControl();
            tbThongTinCoBanNhanVien = new TabPage();
            pnThongTinCoBanNhanVien = new Panel();
            panel4 = new Panel();
            btnHuy = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            dtpNgayRaNhanVien = new DateTimePicker();
            dtpNgayVaoNhanVien = new DateTimePicker();
            dtpNgaySinhNhanVien = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDiaChiNhanVien = new TextBox();
            txtGioiTinhNhanVien = new TextBox();
            txtCCCDNhanVien = new TextBox();
            txtEmailNhanVien = new TextBox();
            txtTonGiaoNhanVien = new TextBox();
            label7 = new Label();
            txtSoDTNhanVien = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnCancelThemNhanVien = new Button();
            btnAcceptThemNhanVien = new Button();
            tpThongTinKhacNhanVien = new TabPage();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxAnhNhanVien).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tclProfileNhanVien.SuspendLayout();
            tbThongTinCoBanNhanVien.SuspendLayout();
            pnThongTinCoBanNhanVien.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnChonAnh);
            panel1.Controls.Add(pbxAnhNhanVien);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 227);
            panel1.TabIndex = 0;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(78, 187);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(75, 23);
            btnChonAnh.TabIndex = 1;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // pbxAnhNhanVien
            // 
            pbxAnhNhanVien.BorderStyle = BorderStyle.FixedSingle;
            pbxAnhNhanVien.Location = new Point(41, 9);
            pbxAnhNhanVien.Name = "pbxAnhNhanVien";
            pbxAnhNhanVien.Size = new Size(156, 168);
            pbxAnhNhanVien.TabIndex = 0;
            pbxAnhNhanVien.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbxKieuLamNhanVien);
            panel2.Controls.Add(cbxChucVuNhanVien);
            panel2.Controls.Add(cbxBoPhanNhanVien);
            panel2.Controls.Add(txtIDNhanVien);
            panel2.Controls.Add(lblIDNhanVien);
            panel2.Controls.Add(lblTenNhanVien);
            panel2.Controls.Add(lblKieuLamNhanVien);
            panel2.Controls.Add(txtTenNhanVien);
            panel2.Controls.Add(lblBoPhanNhanVien);
            panel2.Controls.Add(lblChucVuNhanVien);
            panel2.Location = new Point(249, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(553, 227);
            panel2.TabIndex = 1;
            // 
            // cbxKieuLamNhanVien
            // 
            cbxKieuLamNhanVien.FormattingEnabled = true;
            cbxKieuLamNhanVien.Location = new Point(128, 176);
            cbxKieuLamNhanVien.Name = "cbxKieuLamNhanVien";
            cbxKieuLamNhanVien.Size = new Size(416, 23);
            cbxKieuLamNhanVien.TabIndex = 4;
            // 
            // cbxChucVuNhanVien
            // 
            cbxChucVuNhanVien.FormattingEnabled = true;
            cbxChucVuNhanVien.Location = new Point(128, 136);
            cbxChucVuNhanVien.Name = "cbxChucVuNhanVien";
            cbxChucVuNhanVien.Size = new Size(416, 23);
            cbxChucVuNhanVien.TabIndex = 3;
            // 
            // cbxBoPhanNhanVien
            // 
            cbxBoPhanNhanVien.FormattingEnabled = true;
            cbxBoPhanNhanVien.Location = new Point(128, 96);
            cbxBoPhanNhanVien.Name = "cbxBoPhanNhanVien";
            cbxBoPhanNhanVien.Size = new Size(416, 23);
            cbxBoPhanNhanVien.TabIndex = 2;
            // 
            // txtIDNhanVien
            // 
            txtIDNhanVien.Location = new Point(128, 16);
            txtIDNhanVien.Name = "txtIDNhanVien";
            txtIDNhanVien.ReadOnly = true;
            txtIDNhanVien.Size = new Size(195, 23);
            txtIDNhanVien.TabIndex = 17;
            // 
            // lblIDNhanVien
            // 
            lblIDNhanVien.Font = new Font("Segoe UI", 12F);
            lblIDNhanVien.Location = new Point(24, 16);
            lblIDNhanVien.Name = "lblIDNhanVien";
            lblIDNhanVien.Size = new Size(83, 30);
            lblIDNhanVien.TabIndex = 1;
            lblIDNhanVien.Text = "ID";
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.Font = new Font("Segoe UI", 12F);
            lblTenNhanVien.Location = new Point(24, 56);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(83, 30);
            lblTenNhanVien.TabIndex = 1;
            lblTenNhanVien.Text = "Họ và tên";
            // 
            // lblKieuLamNhanVien
            // 
            lblKieuLamNhanVien.Font = new Font("Segoe UI", 12F);
            lblKieuLamNhanVien.Location = new Point(24, 176);
            lblKieuLamNhanVien.Name = "lblKieuLamNhanVien";
            lblKieuLamNhanVien.Size = new Size(70, 30);
            lblKieuLamNhanVien.TabIndex = 1;
            lblKieuLamNhanVien.Text = "Kiểu làm";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(128, 56);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(417, 23);
            txtTenNhanVien.TabIndex = 1;
            // 
            // lblBoPhanNhanVien
            // 
            lblBoPhanNhanVien.Font = new Font("Segoe UI", 12F);
            lblBoPhanNhanVien.Location = new Point(24, 96);
            lblBoPhanNhanVien.Name = "lblBoPhanNhanVien";
            lblBoPhanNhanVien.Size = new Size(70, 30);
            lblBoPhanNhanVien.TabIndex = 1;
            lblBoPhanNhanVien.Text = "Bộ phận";
            lblBoPhanNhanVien.Click += label3_Click;
            // 
            // lblChucVuNhanVien
            // 
            lblChucVuNhanVien.Font = new Font("Segoe UI", 12F);
            lblChucVuNhanVien.Location = new Point(24, 136);
            lblChucVuNhanVien.Name = "lblChucVuNhanVien";
            lblChucVuNhanVien.Size = new Size(70, 30);
            lblChucVuNhanVien.TabIndex = 1;
            lblChucVuNhanVien.Text = "Chức vụ";
            // 
            // panel3
            // 
            panel3.Controls.Add(tclProfileNhanVien);
            panel3.Location = new Point(3, 236);
            panel3.Name = "panel3";
            panel3.Size = new Size(799, 393);
            panel3.TabIndex = 2;
            // 
            // tclProfileNhanVien
            // 
            tclProfileNhanVien.Controls.Add(tbThongTinCoBanNhanVien);
            tclProfileNhanVien.Controls.Add(tpThongTinKhacNhanVien);
            tclProfileNhanVien.Location = new Point(9, 16);
            tclProfileNhanVien.Name = "tclProfileNhanVien";
            tclProfileNhanVien.SelectedIndex = 0;
            tclProfileNhanVien.Size = new Size(780, 374);
            tclProfileNhanVien.TabIndex = 0;
            // 
            // tbThongTinCoBanNhanVien
            // 
            tbThongTinCoBanNhanVien.Controls.Add(pnThongTinCoBanNhanVien);
            tbThongTinCoBanNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbThongTinCoBanNhanVien.Location = new Point(4, 24);
            tbThongTinCoBanNhanVien.Name = "tbThongTinCoBanNhanVien";
            tbThongTinCoBanNhanVien.Padding = new Padding(3);
            tbThongTinCoBanNhanVien.Size = new Size(772, 346);
            tbThongTinCoBanNhanVien.TabIndex = 0;
            tbThongTinCoBanNhanVien.Text = "Thông tin cơ bản";
            tbThongTinCoBanNhanVien.UseVisualStyleBackColor = true;
            // 
            // pnThongTinCoBanNhanVien
            // 
            pnThongTinCoBanNhanVien.Controls.Add(panel4);
            pnThongTinCoBanNhanVien.Controls.Add(btnCancelThemNhanVien);
            pnThongTinCoBanNhanVien.Controls.Add(btnAcceptThemNhanVien);
            pnThongTinCoBanNhanVien.Location = new Point(6, 6);
            pnThongTinCoBanNhanVien.Name = "pnThongTinCoBanNhanVien";
            pnThongTinCoBanNhanVien.Size = new Size(760, 334);
            pnThongTinCoBanNhanVien.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnHuy);
            panel4.Controls.Add(btnXoa);
            panel4.Controls.Add(btnCapNhat);
            panel4.Controls.Add(dtpNgayRaNhanVien);
            panel4.Controls.Add(dtpNgayVaoNhanVien);
            panel4.Controls.Add(dtpNgaySinhNhanVien);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtDiaChiNhanVien);
            panel4.Controls.Add(txtGioiTinhNhanVien);
            panel4.Controls.Add(txtCCCDNhanVien);
            panel4.Controls.Add(txtEmailNhanVien);
            panel4.Controls.Add(txtTonGiaoNhanVien);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtSoDTNhanVien);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(8, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(760, 334);
            panel4.TabIndex = 16;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 14.25F);
            btnHuy.Location = new Point(312, 272);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(122, 39);
            btnHuy.TabIndex = 15;
            btnHuy.Text = "Huỷ bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 14.25F);
            btnXoa.Location = new Point(472, 272);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(122, 39);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 14.25F);
            btnCapNhat.Location = new Point(152, 272);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(122, 39);
            btnCapNhat.TabIndex = 14;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // dtpNgayRaNhanVien
            // 
            dtpNgayRaNhanVien.Format = DateTimePickerFormat.Custom;
            dtpNgayRaNhanVien.Location = new Point(480, 210);
            dtpNgayRaNhanVien.Name = "dtpNgayRaNhanVien";
            dtpNgayRaNhanVien.Size = new Size(256, 29);
            dtpNgayRaNhanVien.TabIndex = 13;
            // 
            // dtpNgayVaoNhanVien
            // 
            dtpNgayVaoNhanVien.Format = DateTimePickerFormat.Custom;
            dtpNgayVaoNhanVien.Location = new Point(480, 168);
            dtpNgayVaoNhanVien.Name = "dtpNgayVaoNhanVien";
            dtpNgayVaoNhanVien.Size = new Size(256, 29);
            dtpNgayVaoNhanVien.TabIndex = 12;
            // 
            // dtpNgaySinhNhanVien
            // 
            dtpNgaySinhNhanVien.Format = DateTimePickerFormat.Custom;
            dtpNgaySinhNhanVien.Location = new Point(480, 125);
            dtpNgaySinhNhanVien.Name = "dtpNgaySinhNhanVien";
            dtpNgaySinhNhanVien.Size = new Size(256, 29);
            dtpNgaySinhNhanVien.TabIndex = 11;
            dtpNgaySinhNhanVien.Value = new DateTime(2025, 1, 25, 20, 53, 2, 0);
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(382, 212);
            label1.Name = "label1";
            label1.Size = new Size(116, 30);
            label1.TabIndex = 1;
            label1.Text = "Ngày ra";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(22, 212);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 1;
            label2.Text = "Giới tính";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(382, 170);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 1;
            label3.Text = "Ngày vào";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(22, 170);
            label4.Name = "label4";
            label4.Size = new Size(79, 30);
            label4.TabIndex = 1;
            label4.Text = "Số CCCD";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(382, 128);
            label5.Name = "label5";
            label5.Size = new Size(123, 30);
            label5.TabIndex = 1;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(22, 128);
            label6.Name = "label6";
            label6.Size = new Size(70, 30);
            label6.TabIndex = 1;
            label6.Text = "Email";
            // 
            // txtDiaChiNhanVien
            // 
            txtDiaChiNhanVien.Location = new Point(120, 24);
            txtDiaChiNhanVien.Multiline = true;
            txtDiaChiNhanVien.Name = "txtDiaChiNhanVien";
            txtDiaChiNhanVien.Size = new Size(643, 23);
            txtDiaChiNhanVien.TabIndex = 5;
            // 
            // txtGioiTinhNhanVien
            // 
            txtGioiTinhNhanVien.Location = new Point(120, 208);
            txtGioiTinhNhanVien.Multiline = true;
            txtGioiTinhNhanVien.Name = "txtGioiTinhNhanVien";
            txtGioiTinhNhanVien.Size = new Size(190, 23);
            txtGioiTinhNhanVien.TabIndex = 9;
            // 
            // txtCCCDNhanVien
            // 
            txtCCCDNhanVien.Location = new Point(120, 168);
            txtCCCDNhanVien.Multiline = true;
            txtCCCDNhanVien.Name = "txtCCCDNhanVien";
            txtCCCDNhanVien.Size = new Size(190, 23);
            txtCCCDNhanVien.TabIndex = 8;
            // 
            // txtEmailNhanVien
            // 
            txtEmailNhanVien.Location = new Point(120, 128);
            txtEmailNhanVien.Multiline = true;
            txtEmailNhanVien.Name = "txtEmailNhanVien";
            txtEmailNhanVien.Size = new Size(190, 23);
            txtEmailNhanVien.TabIndex = 7;
            // 
            // txtTonGiaoNhanVien
            // 
            txtTonGiaoNhanVien.Location = new Point(480, 88);
            txtTonGiaoNhanVien.Multiline = true;
            txtTonGiaoNhanVien.Name = "txtTonGiaoNhanVien";
            txtTonGiaoNhanVien.Size = new Size(256, 23);
            txtTonGiaoNhanVien.TabIndex = 10;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(382, 90);
            label7.Name = "label7";
            label7.Size = new Size(107, 30);
            label7.TabIndex = 1;
            label7.Text = "Tôn giáo";
            // 
            // txtSoDTNhanVien
            // 
            txtSoDTNhanVien.Location = new Point(120, 88);
            txtSoDTNhanVien.Multiline = true;
            txtSoDTNhanVien.Name = "txtSoDTNhanVien";
            txtSoDTNhanVien.Size = new Size(190, 23);
            txtSoDTNhanVien.TabIndex = 6;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(22, 90);
            label8.Name = "label8";
            label8.Size = new Size(70, 30);
            label8.TabIndex = 1;
            label8.Text = "Số ĐT";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(22, 24);
            label9.Name = "label9";
            label9.Size = new Size(70, 30);
            label9.TabIndex = 1;
            label9.Text = "Địa chỉ";
            // 
            // btnCancelThemNhanVien
            // 
            btnCancelThemNhanVien.Font = new Font("Segoe UI", 14.25F);
            btnCancelThemNhanVien.Location = new Point(408, 274);
            btnCancelThemNhanVien.Name = "btnCancelThemNhanVien";
            btnCancelThemNhanVien.Size = new Size(122, 39);
            btnCancelThemNhanVien.TabIndex = 15;
            btnCancelThemNhanVien.Text = "Huỷ bỏ";
            btnCancelThemNhanVien.UseVisualStyleBackColor = true;
            btnCancelThemNhanVien.Click += btnCancelThemNhanVien_Click_1;
            // 
            // btnAcceptThemNhanVien
            // 
            btnAcceptThemNhanVien.Font = new Font("Segoe UI", 14.25F);
            btnAcceptThemNhanVien.Location = new Point(227, 274);
            btnAcceptThemNhanVien.Name = "btnAcceptThemNhanVien";
            btnAcceptThemNhanVien.Size = new Size(122, 39);
            btnAcceptThemNhanVien.TabIndex = 14;
            btnAcceptThemNhanVien.Text = "Đồng ý";
            btnAcceptThemNhanVien.UseVisualStyleBackColor = true;
            // 
            // tpThongTinKhacNhanVien
            // 
            tpThongTinKhacNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tpThongTinKhacNhanVien.Location = new Point(4, 24);
            tpThongTinKhacNhanVien.Name = "tpThongTinKhacNhanVien";
            tpThongTinKhacNhanVien.Padding = new Padding(3);
            tpThongTinKhacNhanVien.Size = new Size(772, 346);
            tpThongTinKhacNhanVien.TabIndex = 1;
            tpThongTinKhacNhanVien.Text = "Thông tin khác";
            tpThongTinKhacNhanVien.UseVisualStyleBackColor = true;
            // 
            // frmThongTinNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 631);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmThongTinNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THÔNG TIN NHÂN VIÊN";
            Load += frmThemNhanVien_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxAnhNhanVien).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            tclProfileNhanVien.ResumeLayout(false);
            tbThongTinCoBanNhanVien.ResumeLayout(false);
            pnThongTinCoBanNhanVien.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pbxAnhNhanVien;
        private Label lblIDNhanVien;
        private TextBox txtIDNhanVien;
        private Button btnChonAnh;
        private ComboBox cbxKieuLamNhanVien;
        private ComboBox cbxChucVuNhanVien;
        private ComboBox cbxBoPhanNhanVien;
        private Label lblTenNhanVien;
        private Label lblKieuLamNhanVien;
        private TextBox txtTenNhanVien;
        private Label lblBoPhanNhanVien;
        private Label lblChucVuNhanVien;
        private TabControl tclProfileNhanVien;
        private TabPage tbThongTinCoBanNhanVien;
        private Panel pnThongTinCoBanNhanVien;
        private Button btnCancelThemNhanVien;
        private Button btnAcceptThemNhanVien;
        private TabPage tpThongTinKhacNhanVien;
        private Panel panel4;
        private Button btnHuy;
        private Button btnCapNhat;
        private DateTimePicker dtpNgayRaNhanVien;
        private DateTimePicker dtpNgayVaoNhanVien;
        private DateTimePicker dtpNgaySinhNhanVien;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDiaChiNhanVien;
        private TextBox txtGioiTinhNhanVien;
        private TextBox txtCCCDNhanVien;
        private TextBox txtEmailNhanVien;
        private TextBox txtTonGiaoNhanVien;
        private Label label7;
        private TextBox txtSoDTNhanVien;
        private Label label8;
        private Label label9;
        private Button btnXoa;
    }
}