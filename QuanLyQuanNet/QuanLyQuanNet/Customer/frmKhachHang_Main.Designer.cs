namespace QuanLyQuanNet.KhachHang
{
    partial class frmKhachHang_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang_Main));
            pnNavigation = new Panel();
            pnHeader = new Panel();
            pbxLogNhanVien = new PictureBox();
            panel2 = new Panel();
            lblQuanLyNhanVien = new Label();
            lblHome = new Label();
            panel1 = new Panel();
            btnThemKhachHang = new Button();
            btnNhap = new Button();
            btnXuatFile = new Button();
            btnLoc = new Button();
            btn_TroChuyen = new Button();
            flpLoc = new FlowLayoutPanel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            grbKhachHang = new GroupBox();
            panel4 = new Panel();
            panel5 = new Panel();
            txtTrang = new TextBox();
            btnNextTrang = new Button();
            btnLuiTrang = new Button();
            pbxTimKiem = new PictureBox();
            txtTimKiem = new TextBox();
            panel3 = new Panel();
            dgvDanhSachNhanVien = new DataGridView();
            pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogNhanVien).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            flpLoc.SuspendLayout();
            grbKhachHang.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxTimKiem).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).BeginInit();
            SuspendLayout();
            // 
            // pnNavigation
            // 
            pnNavigation.BorderStyle = BorderStyle.FixedSingle;
            pnNavigation.Location = new Point(0, 56);
            pnNavigation.Name = "pnNavigation";
            pnNavigation.Size = new Size(250, 672);
            pnNavigation.TabIndex = 1;
            // 
            // pnHeader
            // 
            pnHeader.BorderStyle = BorderStyle.FixedSingle;
            pnHeader.Controls.Add(pbxLogNhanVien);
            pnHeader.Location = new Point(1, 1);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(1349, 51);
            pnHeader.TabIndex = 2;
            // 
            // pbxLogNhanVien
            // 
            pbxLogNhanVien.Image = Properties.Resources.Sample_User_Icon;
            pbxLogNhanVien.Location = new Point(1287, -1);
            pbxLogNhanVien.Name = "pbxLogNhanVien";
            pbxLogNhanVien.Size = new Size(61, 51);
            pbxLogNhanVien.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogNhanVien.TabIndex = 0;
            pbxLogNhanVien.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblQuanLyNhanVien);
            panel2.Controls.Add(lblHome);
            panel2.Location = new Point(256, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 48);
            panel2.TabIndex = 6;
            // 
            // lblQuanLyNhanVien
            // 
            lblQuanLyNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanLyNhanVien.Location = new Point(96, 16);
            lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            lblQuanLyNhanVien.Size = new Size(176, 23);
            lblQuanLyNhanVien.TabIndex = 6;
            lblQuanLyNhanVien.Text = "Quản lý khách hàng";
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
            // panel1
            // 
            panel1.Controls.Add(btnThemKhachHang);
            panel1.Controls.Add(btnNhap);
            panel1.Controls.Add(btnXuatFile);
            panel1.Controls.Add(btnLoc);
            panel1.Controls.Add(btn_TroChuyen);
            panel1.Location = new Point(632, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(712, 56);
            panel1.TabIndex = 7;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.BackColor = Color.FromArgb(192, 255, 255);
            btnThemKhachHang.FlatStyle = FlatStyle.Flat;
            btnThemKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemKhachHang.Location = new Point(40, 16);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(128, 31);
            btnThemKhachHang.TabIndex = 3;
            btnThemKhachHang.Text = "➕ Thêm Mới";
            btnThemKhachHang.UseVisualStyleBackColor = false;
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.FromArgb(192, 255, 255);
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhap.Location = new Point(192, 16);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(112, 31);
            btnNhap.TabIndex = 3;
            btnNhap.Text = "Nhập File";
            btnNhap.UseVisualStyleBackColor = false;
            // 
            // btnXuatFile
            // 
            btnXuatFile.BackColor = Color.FromArgb(192, 255, 255);
            btnXuatFile.FlatStyle = FlatStyle.Flat;
            btnXuatFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatFile.Location = new Point(328, 16);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(112, 31);
            btnXuatFile.TabIndex = 3;
            btnXuatFile.Text = "Xuất File";
            btnXuatFile.UseVisualStyleBackColor = false;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(192, 255, 255);
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoc.Location = new Point(600, 16);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(112, 31);
            btnLoc.TabIndex = 3;
            btnLoc.Text = "Lọc ⟱";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.MouseHover += btnLoc_MouseHover;
            // 
            // btn_TroChuyen
            // 
            btn_TroChuyen.BackColor = Color.FromArgb(192, 255, 255);
            btn_TroChuyen.FlatStyle = FlatStyle.Flat;
            btn_TroChuyen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TroChuyen.Location = new Point(464, 16);
            btn_TroChuyen.Name = "btn_TroChuyen";
            btn_TroChuyen.Size = new Size(112, 31);
            btn_TroChuyen.TabIndex = 3;
            btn_TroChuyen.Text = "Trò Chuyện";
            btn_TroChuyen.UseVisualStyleBackColor = false;
            // 
            // flpLoc
            // 
            flpLoc.Controls.Add(checkBox1);
            flpLoc.Controls.Add(checkBox2);
            flpLoc.Controls.Add(checkBox3);
            flpLoc.Controls.Add(checkBox4);
            flpLoc.Controls.Add(checkBox5);
            flpLoc.Controls.Add(checkBox6);
            flpLoc.Controls.Add(checkBox7);
            flpLoc.Controls.Add(checkBox8);
            flpLoc.Controls.Add(checkBox9);
            flpLoc.Location = new Point(872, -32);
            flpLoc.Margin = new Padding(20);
            flpLoc.Name = "flpLoc";
            flpLoc.Size = new Size(216, 296);
            flpLoc.TabIndex = 0;
            flpLoc.Visible = false;
            flpLoc.MouseLeave += flpLoc_MouseLeave;
            flpLoc.MouseHover += flpLoc_MouseHover;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(111, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(102, 25);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "checkBox1";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox3.Location = new Point(3, 34);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(102, 25);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "checkBox1";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox4.Location = new Point(111, 34);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(102, 25);
            checkBox4.TabIndex = 0;
            checkBox4.Text = "checkBox1";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox5.Location = new Point(3, 65);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(102, 25);
            checkBox5.TabIndex = 0;
            checkBox5.Text = "checkBox1";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox6.Location = new Point(111, 65);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(102, 25);
            checkBox6.TabIndex = 0;
            checkBox6.Text = "checkBox1";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox7.Location = new Point(3, 96);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(102, 25);
            checkBox7.TabIndex = 0;
            checkBox7.Text = "checkBox1";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox8.Location = new Point(111, 96);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(102, 25);
            checkBox8.TabIndex = 0;
            checkBox8.Text = "checkBox1";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox9.Location = new Point(3, 127);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(102, 25);
            checkBox9.TabIndex = 0;
            checkBox9.Text = "checkBox1";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // grbKhachHang
            // 
            grbKhachHang.Controls.Add(panel4);
            grbKhachHang.Controls.Add(panel3);
            grbKhachHang.Controls.Add(flpLoc);
            grbKhachHang.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbKhachHang.Location = new Point(256, 136);
            grbKhachHang.Name = "grbKhachHang";
            grbKhachHang.Size = new Size(1088, 592);
            grbKhachHang.TabIndex = 8;
            grbKhachHang.TabStop = false;
            grbKhachHang.Text = "Quản Lý Khách Hàng";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(pbxTimKiem);
            panel4.Controls.Add(txtTimKiem);
            panel4.Location = new Point(8, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(1080, 48);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtTrang);
            panel5.Controls.Add(btnNextTrang);
            panel5.Controls.Add(btnLuiTrang);
            panel5.Location = new Point(448, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(212, 45);
            panel5.TabIndex = 3;
            // 
            // txtTrang
            // 
            txtTrang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTrang.Location = new Point(64, 8);
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
            btnNextTrang.Font = new Font("Segoe UI", 14.25F);
            btnNextTrang.Location = new Point(128, 8);
            btnNextTrang.Name = "btnNextTrang";
            btnNextTrang.Size = new Size(46, 32);
            btnNextTrang.TabIndex = 1;
            btnNextTrang.Text = ">>";
            btnNextTrang.TextAlign = ContentAlignment.TopCenter;
            btnNextTrang.UseVisualStyleBackColor = true;
            btnNextTrang.Click += btnNextTrang_Click;
            // 
            // btnLuiTrang
            // 
            btnLuiTrang.Font = new Font("Segoe UI", 14.25F);
            btnLuiTrang.Location = new Point(8, 8);
            btnLuiTrang.Name = "btnLuiTrang";
            btnLuiTrang.Size = new Size(46, 32);
            btnLuiTrang.TabIndex = 1;
            btnLuiTrang.Text = "<<";
            btnLuiTrang.TextAlign = ContentAlignment.TopCenter;
            btnLuiTrang.UseVisualStyleBackColor = true;
            btnLuiTrang.Click += btnLuiTrang_Click;
            // 
            // pbxTimKiem
            // 
            pbxTimKiem.BackgroundImageLayout = ImageLayout.Center;
            pbxTimKiem.BorderStyle = BorderStyle.FixedSingle;
            pbxTimKiem.ErrorImage = Properties.Resources.icon_search;
            pbxTimKiem.Image = (Image)resources.GetObject("pbxTimKiem.Image");
            pbxTimKiem.Location = new Point(376, 8);
            pbxTimKiem.Name = "pbxTimKiem";
            pbxTimKiem.Size = new Size(45, 32);
            pbxTimKiem.SizeMode = PictureBoxSizeMode.Zoom;
            pbxTimKiem.TabIndex = 2;
            pbxTimKiem.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Location = new Point(8, 8);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(360, 31);
            txtTimKiem.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvDanhSachNhanVien);
            panel3.Location = new Point(8, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(1073, 560);
            panel3.TabIndex = 7;
            // 
            // dgvDanhSachNhanVien
            // 
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhanVien.Location = new Point(8, 8);
            dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            dgvDanhSachNhanVien.Size = new Size(1056, 488);
            dgvDanhSachNhanVien.TabIndex = 0;
            // 
            // frmKhachHang_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnHeader);
            Controls.Add(pnNavigation);
            Controls.Add(grbKhachHang);
            Name = "frmKhachHang_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmKhachHang_Main";
            pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxLogNhanVien).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            flpLoc.ResumeLayout(false);
            flpLoc.PerformLayout();
            grbKhachHang.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxTimKiem).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnNavigation;
        private Panel pnHeader;
        private PictureBox pbxLogNhanVien;
        private Panel panel2;
        private Label lblQuanLyNhanVien;
        private Label lblHome;
        private Panel panel1;
        private Button btnNhap;
        private Button btnXuatFile;
        private Button btn_TroChuyen;
        private Button btnThemKhachHang;
        private Button btnLoc;
        private GroupBox grbKhachHang;
        private FlowLayoutPanel flpLoc;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private Panel panel3;
        private DataGridView dgvDanhSachNhanVien;
        private Panel panel4;
        private TextBox txtTimKiem;
        private PictureBox pbxTimKiem;
        private Panel panel5;
        private TextBox txtTrang;
        private Button btnNextTrang;
        private Button btnLuiTrang;
    }
}