using CyberManagementProject;

namespace QuanLyQuanNet
{
    partial class frmQuanLyNhanVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhanVien));
            grbQuanLyNhanVien = new GroupBox();
            panel3 = new Panel();
            dgvDanhSachNhanVien = new DataGridView();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtTimKiem = new TextBox();
            pbxTimKiem = new PictureBox();
            cbxChucVu = new ComboBox();
            cbxTrangThai = new ComboBox();
            panel5 = new Panel();
            txtTrang = new TextBox();
            btnNextTrang = new Button();
            btnLuiTrang = new Button();
            panel4 = new Panel();
            button4 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            btnThongKe = new Button();
            panel2 = new Panel();
            lblQuanLyNhanVien = new Label();
            lblHome = new Label();
            btn_ThongKe = new Button();
            btnXuatFile = new Button();
            btnThemMoi = new Button();
            panel1 = new Panel();
            pnlLeft = new Panel();
            panel17 = new Panel();
            pictureBox12 = new PictureBox();
            label31 = new Label();
            panel16 = new Panel();
            pictureBox11 = new PictureBox();
            label30 = new Label();
            panel15 = new Panel();
            pictureBox10 = new PictureBox();
            label29 = new Label();
            panel14 = new Panel();
            pictureBox9 = new PictureBox();
            label28 = new Label();
            panel13 = new Panel();
            pictureBox8 = new PictureBox();
            label27 = new Label();
            panel6 = new Panel();
            pnlTitleBar = new Panel();
            flpListComputer = new FlowLayoutPanel();
            label1 = new Label();
            btnToggleMenu = new Button();
            grbQuanLyNhanVien.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxTimKiem).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pnlLeft.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // grbQuanLyNhanVien
            // 
            grbQuanLyNhanVien.Controls.Add(panel3);
            grbQuanLyNhanVien.Controls.Add(flowLayoutPanel1);
            grbQuanLyNhanVien.FlatStyle = FlatStyle.System;
            grbQuanLyNhanVien.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbQuanLyNhanVien.Location = new Point(256, 120);
            grbQuanLyNhanVien.Name = "grbQuanLyNhanVien";
            grbQuanLyNhanVien.Size = new Size(1093, 609);
            grbQuanLyNhanVien.TabIndex = 2;
            grbQuanLyNhanVien.TabStop = false;
            grbQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvDanhSachNhanVien);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(6, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(1081, 524);
            panel3.TabIndex = 5;
            // 
            // dgvDanhSachNhanVien
            // 
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhanVien.Location = new Point(0, 0);
            dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            dgvDanhSachNhanVien.Size = new Size(1081, 524);
            dgvDanhSachNhanVien.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(920, 64);
            button1.Name = "button1";
            button1.Size = new Size(112, 39);
            button1.TabIndex = 3;
            button1.Text = "Quay lại";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(128, 255, 255);
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(txtTimKiem);
            flowLayoutPanel1.Controls.Add(pbxTimKiem);
            flowLayoutPanel1.Controls.Add(cbxChucVu);
            flowLayoutPanel1.Controls.Add(cbxTrangThai);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Location = new Point(6, 38);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1081, 50);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Location = new Point(3, 3);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(521, 39);
            txtTimKiem.TabIndex = 0;
            // 
            // pbxTimKiem
            // 
            pbxTimKiem.BackColor = Color.White;
            pbxTimKiem.BackgroundImageLayout = ImageLayout.Center;
            pbxTimKiem.BorderStyle = BorderStyle.FixedSingle;
            pbxTimKiem.Image = (Image)resources.GetObject("pbxTimKiem.Image");
            pbxTimKiem.Location = new Point(530, 3);
            pbxTimKiem.Name = "pbxTimKiem";
            pbxTimKiem.Size = new Size(45, 39);
            pbxTimKiem.SizeMode = PictureBoxSizeMode.Zoom;
            pbxTimKiem.TabIndex = 1;
            pbxTimKiem.TabStop = false;
            pbxTimKiem.Click += pictureBox1_Click;
            // 
            // cbxChucVu
            // 
            cbxChucVu.FormattingEnabled = true;
            cbxChucVu.Location = new Point(581, 3);
            cbxChucVu.Name = "cbxChucVu";
            cbxChucVu.Size = new Size(121, 40);
            cbxChucVu.TabIndex = 0;
            // 
            // cbxTrangThai
            // 
            cbxTrangThai.FormattingEnabled = true;
            cbxTrangThai.Location = new Point(708, 3);
            cbxTrangThai.Name = "cbxTrangThai";
            cbxTrangThai.Size = new Size(121, 40);
            cbxTrangThai.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtTrang);
            panel5.Controls.Add(btnNextTrang);
            panel5.Controls.Add(btnLuiTrang);
            panel5.Location = new Point(835, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(239, 45);
            panel5.TabIndex = 1;
            // 
            // txtTrang
            // 
            txtTrang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTrang.Location = new Point(123, 8);
            txtTrang.Multiline = true;
            txtTrang.Name = "txtTrang";
            txtTrang.ReadOnly = true;
            txtTrang.Size = new Size(53, 31);
            txtTrang.TabIndex = 1;
            txtTrang.TextAlign = HorizontalAlignment.Center;
            txtTrang.TextChanged += txtTrang_TextChanged;
            // 
            // btnNextTrang
            // 
            btnNextTrang.BackColor = Color.White;
            btnNextTrang.FlatStyle = FlatStyle.Flat;
            btnNextTrang.Font = new Font("Segoe UI", 14.25F);
            btnNextTrang.Location = new Point(184, 8);
            btnNextTrang.Name = "btnNextTrang";
            btnNextTrang.Size = new Size(46, 32);
            btnNextTrang.TabIndex = 1;
            btnNextTrang.Text = ">>";
            btnNextTrang.TextAlign = ContentAlignment.TopCenter;
            btnNextTrang.UseVisualStyleBackColor = false;
            btnNextTrang.Click += btnNextTrang_Click;
            // 
            // btnLuiTrang
            // 
            btnLuiTrang.BackColor = Color.White;
            btnLuiTrang.FlatStyle = FlatStyle.Flat;
            btnLuiTrang.Font = new Font("Segoe UI", 14.25F);
            btnLuiTrang.Location = new Point(72, 8);
            btnLuiTrang.Name = "btnLuiTrang";
            btnLuiTrang.Size = new Size(46, 32);
            btnLuiTrang.TabIndex = 1;
            btnLuiTrang.Text = "<<";
            btnLuiTrang.TextAlign = ContentAlignment.TopCenter;
            btnLuiTrang.UseVisualStyleBackColor = false;
            btnLuiTrang.Click += btnLuiTrang_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(241, 47);
            panel4.TabIndex = 2;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(168, 0);
            button4.Name = "button4";
            button4.Size = new Size(30, 45);
            button4.TabIndex = 0;
            button4.Text = ">";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(74, 0);
            button3.Name = "button3";
            button3.Size = new Size(30, 45);
            button3.TabIndex = 0;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(52, 41);
            textBox2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 14);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Trang";
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.ButtonHighlight;
            btnThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongKe.Location = new Point(592, 8);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(112, 39);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblQuanLyNhanVien);
            panel2.Controls.Add(lblHome);
            panel2.Location = new Point(264, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 48);
            panel2.TabIndex = 5;
            // 
            // lblQuanLyNhanVien
            // 
            lblQuanLyNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanLyNhanVien.Location = new Point(88, 16);
            lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            lblQuanLyNhanVien.Size = new Size(168, 23);
            lblQuanLyNhanVien.TabIndex = 6;
            lblQuanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // lblHome
            // 
            lblHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHome.Location = new Point(8, 16);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(88, 23);
            lblHome.TabIndex = 6;
            lblHome.Text = "⟲ Home >";
            lblHome.Click += lblHome_Click;
            // 
            // btn_ThongKe
            // 
            btn_ThongKe.BackColor = Color.FromArgb(128, 255, 255);
            btn_ThongKe.FlatStyle = FlatStyle.Flat;
            btn_ThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThongKe.Location = new Point(576, 16);
            btn_ThongKe.Name = "btn_ThongKe";
            btn_ThongKe.Size = new Size(128, 31);
            btn_ThongKe.TabIndex = 3;
            btn_ThongKe.Text = "Thống Kê";
            btn_ThongKe.UseVisualStyleBackColor = false;
            // 
            // btnXuatFile
            // 
            btnXuatFile.BackColor = Color.FromArgb(128, 255, 255);
            btnXuatFile.FlatStyle = FlatStyle.Flat;
            btnXuatFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatFile.Location = new Point(440, 16);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(128, 31);
            btnXuatFile.TabIndex = 3;
            btnXuatFile.Text = "Xuất File";
            btnXuatFile.UseVisualStyleBackColor = false;
            btnXuatFile.MouseLeave += btnXuatFile_MouseLeave;
            btnXuatFile.MouseHover += btnXuatFile_MouseHover;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.FromArgb(128, 255, 255);
            btnThemMoi.FlatStyle = FlatStyle.Flat;
            btnThemMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMoi.Location = new Point(304, 16);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(128, 31);
            btnThemMoi.TabIndex = 3;
            btnThemMoi.Text = "➕ Thêm Mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThemMoi);
            panel1.Controls.Add(btnXuatFile);
            panel1.Controls.Add(btn_ThongKe);
            panel1.Location = new Point(632, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(712, 56);
            panel1.TabIndex = 4;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.LightCyan;
            pnlLeft.Controls.Add(panel17);
            pnlLeft.Controls.Add(panel16);
            pnlLeft.Controls.Add(panel15);
            pnlLeft.Controls.Add(panel14);
            pnlLeft.Controls.Add(panel13);
            pnlLeft.Controls.Add(panel6);
            pnlLeft.Location = new Point(1, 57);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(240, 672);
            pnlLeft.TabIndex = 6;
            // 
            // panel17
            // 
            panel17.Controls.Add(pictureBox12);
            panel17.Controls.Add(label31);
            panel17.Location = new Point(8, 552);
            panel17.Name = "panel17";
            panel17.Size = new Size(224, 80);
            panel17.TabIndex = 3;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = CyberManagementProject.Properties.Resources.bill;
            pictureBox12.Location = new Point(8, 16);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(50, 50);
            pictureBox12.TabIndex = 5;
            pictureBox12.TabStop = false;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(56, 24);
            label31.Name = "label31";
            label31.Size = new Size(116, 32);
            label31.TabIndex = 4;
            label31.Text = "Thống kê";
            // 
            // panel16
            // 
            panel16.Controls.Add(pictureBox11);
            panel16.Controls.Add(label30);
            panel16.Location = new Point(8, 416);
            panel16.Name = "panel16";
            panel16.Size = new Size(224, 80);
            panel16.TabIndex = 3;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = CyberManagementProject.Properties.Resources.staff;
            pictureBox11.Location = new Point(8, 16);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(50, 50);
            pictureBox11.TabIndex = 5;
            pictureBox11.TabStop = false;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(56, 24);
            label30.Name = "label30";
            label30.Size = new Size(125, 32);
            label30.TabIndex = 4;
            label30.Text = "Nhân viên";
            // 
            // panel15
            // 
            panel15.Controls.Add(pictureBox10);
            panel15.Controls.Add(label29);
            panel15.Location = new Point(8, 280);
            panel15.Name = "panel15";
            panel15.Size = new Size(224, 80);
            panel15.TabIndex = 3;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = CyberManagementProject.Properties.Resources.food;
            pictureBox10.Location = new Point(8, 16);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(50, 50);
            pictureBox10.TabIndex = 5;
            pictureBox10.TabStop = false;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.Location = new Point(56, 24);
            label29.Name = "label29";
            label29.Size = new Size(95, 32);
            label29.TabIndex = 4;
            label29.Text = "Dịch vụ";
            // 
            // panel14
            // 
            panel14.Controls.Add(pictureBox9);
            panel14.Controls.Add(label28);
            panel14.Location = new Point(8, 144);
            panel14.Name = "panel14";
            panel14.Size = new Size(224, 80);
            panel14.TabIndex = 3;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = CyberManagementProject.Properties.Resources.useracount;
            pictureBox9.Location = new Point(8, 16);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(50, 50);
            pictureBox9.TabIndex = 5;
            pictureBox9.TabStop = false;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(64, 24);
            label28.Name = "label28";
            label28.Size = new Size(119, 32);
            label28.TabIndex = 4;
            label28.Text = "Tài khoản";
            // 
            // panel13
            // 
            panel13.Controls.Add(pictureBox8);
            panel13.Controls.Add(label27);
            panel13.Location = new Point(8, 8);
            panel13.Name = "panel13";
            panel13.Size = new Size(224, 80);
            panel13.TabIndex = 3;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = CyberManagementProject.Properties.Resources.monitor;
            pictureBox8.Location = new Point(8, 16);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(50, 50);
            pictureBox8.TabIndex = 5;
            pictureBox8.TabStop = false;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(72, 24);
            label27.Name = "label27";
            label27.Size = new Size(111, 32);
            label27.TabIndex = 4;
            label27.Text = "Máy tính";
            // 
            // panel6
            // 
            panel6.Location = new Point(248, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1104, 632);
            panel6.TabIndex = 2;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.DarkGray;
            pnlTitleBar.Controls.Add(flpListComputer);
            pnlTitleBar.Controls.Add(label1);
            pnlTitleBar.Controls.Add(btnToggleMenu);
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1351, 56);
            pnlTitleBar.TabIndex = 7;
            // 
            // flpListComputer
            // 
            flpListComputer.Location = new Point(240, 56);
            flpListComputer.Name = "flpListComputer";
            flpListComputer.Size = new Size(1112, 672);
            flpListComputer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(440, 16);
            label1.Name = "label1";
            label1.Size = new Size(484, 32);
            label1.TabIndex = 1;
            label1.Text = "Ứng dụng quản lí tiệm net Vip PROMAX";
            // 
            // btnToggleMenu
            // 
            btnToggleMenu.BackColor = Color.DarkGray;
            btnToggleMenu.Location = new Point(8, 8);
            btnToggleMenu.Name = "btnToggleMenu";
            btnToggleMenu.Size = new Size(40, 40);
            btnToggleMenu.TabIndex = 0;
            btnToggleMenu.Text = "☰";
            btnToggleMenu.UseVisualStyleBackColor = false;
            // 
            // frmQuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlLeft);
            Controls.Add(panel2);
            Controls.Add(grbQuanLyNhanVien);
            Controls.Add(panel1);
            Name = "frmQuanLyNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ NHÂN VIÊN";
            FormClosing += frmQuanLyNhanVien_FormClosing;
            Load += frmQuanLyNhanVien_Load;
            grbQuanLyNhanVien.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxTimKiem).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grbQuanLyNhanVien;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtTimKiem;
        private PictureBox pbxTimKiem;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button btnThongKe;
        private Panel panel2;
        private Label lblHome;
        private Label lblQuanLyNhanVien;
        private Button btn_ThongKe;
        private Button btnXuatFile;
        private Button btnThemMoi;
        private Panel panel1;
        private ComboBox cbxChucVu;
        private ComboBox cbxTrangThai;
        private Panel panel5;
        private TextBox txtTrang;
        private Button btnNextTrang;
        private Button btnLuiTrang;
        private Panel panel4;
        private Button button4;
        private Button button3;
        private TextBox textBox2;
        private Label label2;
        private Panel pnlLeft;
        private Panel panel17;
        private PictureBox pictureBox12;
        private Label label31;
        private Panel panel16;
        private PictureBox pictureBox11;
        private Label label30;
        private Panel panel15;
        private PictureBox pictureBox10;
        private Label label29;
        private Panel panel14;
        private PictureBox pictureBox9;
        private Label label28;
        private Panel panel13;
        private PictureBox pictureBox8;
        private Label label27;
        private Panel panel6;
        private DataGridView dgvDanhSachNhanVien;
        private Button button1;
        private Panel pnlTitleBar;
        private FlowLayoutPanel flpListComputer;
        private Label label1;
        private Button btnToggleMenu;
    }
}
