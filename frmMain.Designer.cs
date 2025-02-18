using CyberManagementProject.DAO;

namespace CyberManagementProject
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            pnlLeft = new Panel();
            pnStatictical = new Panel();
            pictureBox12 = new PictureBox();
            label31 = new Label();
            pnStaff = new Panel();
            pictureBox11 = new PictureBox();
            lblNhanVien = new Label();
            pnServices = new Panel();
            pictureBox10 = new PictureBox();
            label29 = new Label();
            pnAccount = new Panel();
            pictureBox9 = new PictureBox();
            label28 = new Label();
            pnComputer = new Panel();
            pictureBox8 = new PictureBox();
            label27 = new Label();
            panel2 = new Panel();
            timerToggle = new System.Windows.Forms.Timer(components);
            pnlTitleBar = new Panel();
            pbxClose = new PictureBox();
            flpListComputer = new FlowLayoutPanel();
            label1 = new Label();
            tblMain = new DTO.CustomTabControl();
            tbpComputer = new TabPage();
            pnComputerControl = new Panel();
            gbxComputerInfor = new GroupBox();
            lvServices = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            pnStatusCom = new Panel();
            lbStatusCom = new Label();
            tbxComputerStatus = new TextBox();
            pnTimeCom = new Panel();
            lbTimeConLai = new Label();
            tbxTimeLeft = new TextBox();
            pnTongTienCom = new Panel();
            label6 = new Label();
            lbTotalPriceDichVu = new Label();
            tbxMoneyAdd = new TextBox();
            tbxMoneyCost = new TextBox();
            pnUserNameCom = new Panel();
            lbUserNameCom = new Label();
            tbxUserAccount = new TextBox();
            pnComputerButton = new Panel();
            btnExtraMoney = new Button();
            btnManageComputer = new Button();
            btnTrackComputer = new Button();
            btnShutDownComputer = new Button();
            btnAddServices = new Button();
            btnManageAllCom = new Button();
            flpComputer = new FlowLayoutPanel();
            tbpAccount = new TabPage();
            pnButtonAccount = new Panel();
            btnThemKhachHang = new Button();
            btnNhap = new Button();
            button2 = new Button();
            btn_TroChuyen = new Button();
            pnDuongDanAccount = new Panel();
            lbCurrentAccountPage = new Label();
            lbHomeAccountPage = new Label();
            grbKhachHang = new GroupBox();
            pnTimKimAccount = new Panel();
            cbxNhomKhach = new ComboBox();
            txtTimKiemKhachHang = new TextBox();
            pnDisplayAccount = new Panel();
            flpKhachHang = new FlowLayoutPanel();
            tbpServices = new TabPage();
            groupBox1 = new GroupBox();
            cbCategory = new ComboBox();
            panel5 = new Panel();
            flpFoodList = new FlowLayoutPanel();
            txbSearch = new TextBox();
            panel3 = new Panel();
            button1 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            tbpStaff = new TabPage();
            pnDuongDanStaff = new Panel();
            lblQuanLyNhanVien = new Label();
            lblHome = new Label();
            grbQuanLyNhanVien = new GroupBox();
            cbxChucVu = new ComboBox();
            pnDisplayStaff = new Panel();
            flpNhanVien = new FlowLayoutPanel();
            cbxTrangThai = new ComboBox();
            txtTimKiem = new TextBox();
            pnStaffControl = new Panel();
            btnThemMoi = new Button();
            btnXuatFile = new Button();
            btn_ThongKe = new Button();
            tbpStatictical = new TabPage();
            pnJob = new Panel();
            pnTKKhungTK = new Panel();
            gbxThongKe = new GroupBox();
            pnTKNut = new Panel();
            gbxThongKeTongQuan = new GroupBox();
            btnCapNhatThongKe = new Button();
            pbHieuSuat = new ProgressBar();
            txtTongDichVu = new TextBox();
            txtTKTongTienMay = new TextBox();
            txtTongGioSuDung = new TextBox();
            txtTongDoanhThu = new TextBox();
            lbTongGioSuDung = new Label();
            lbTKTongTienMay = new Label();
            lbTongDichVu = new Label();
            lbTongDoanhThu = new Label();
            pnTKView = new Panel();
            dgvAllThongKe = new DataGridView();
            pnTKThongKe = new Panel();
            tbTKMayTram = new TabControl();
            tbTKDoanhThu = new TabPage();
            pnTKCongViec = new Panel();
            pnTKThangDT = new Panel();
            btnTKTongDoanhThuThang = new Button();
            btnTKThangDT = new Button();
            txtTKThangDT = new TextBox();
            lbTKThangDT = new Label();
            lbTittleThangDT = new Label();
            dtpTKThangDT = new DateTimePicker();
            rbtTittleNamDT = new RadioButton();
            rbtTittleThangDT = new RadioButton();
            rbtTittleNgayDT = new RadioButton();
            pnTKNamDT = new Panel();
            btnTKTongDoanhThuNam = new Button();
            btnTKNamDT = new Button();
            txtTKNamDT = new TextBox();
            lbTKNamDT = new Label();
            lbTittleNamDT = new Label();
            dtpTKNamDT = new DateTimePicker();
            pnTKNgayDT = new Panel();
            btnTKTongDoanhThuNgay = new Button();
            btnTKNgayDT = new Button();
            txtTKNgayDT = new TextBox();
            lbTKNgayDT = new Label();
            lbTittleNgayDT = new Label();
            dtpTKNgayDT = new DateTimePicker();
            tabPage2 = new TabPage();
            pnTKTGMayTram = new Panel();
            pnDTTungMT = new Panel();
            pnKhungDTTungMT = new Panel();
            panel6 = new Panel();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnDTTungMT = new Button();
            lbThangDTTungMT = new Label();
            dtpDTTungMT = new DateTimePicker();
            lbDTTungMT = new Label();
            pnTGNhieuItMT = new Panel();
            pnKhungTGNhieuItMT = new Panel();
            txtTGNhieuMT = new TextBox();
            txtTGItMT = new TextBox();
            lbTGItMT = new Label();
            lbTGNhieuMT = new Label();
            lbThangTGNhieuItMT = new Label();
            btnTGNhieuItMT = new Button();
            dtpThangTGNhieuItMT = new DateTimePicker();
            lbTittleTGNhieuItMT = new Label();
            pnTKGioTheoThangMT = new Panel();
            pnKhungGioTheoThangMT = new Panel();
            panel7 = new Panel();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            btnGioTheoThangMT = new Button();
            lbTittleGioTheoThangMT = new Label();
            dtpGioTheoThangMT = new DateTimePicker();
            lbGioTheoThangMT = new Label();
            tbTKThucAn = new TabPage();
            pnTKDoAnTheoTG = new Panel();
            btnTongSLDADaBan = new Button();
            btnDoanhThuTungMonAn = new Button();
            btnTKDoAnBanChayNhat = new Button();
            pnKhungTKDoAnTheoTG = new Panel();
            lbTKDoANNgayKT = new Label();
            lbTKDoAnNgayBD = new Label();
            dtpTKDoAnNgayKT = new DateTimePicker();
            dtpTKDoAnNgayBD = new DateTimePicker();
            lbTKDoAnTheoTG = new Label();
            tnTKKhachHang = new TabPage();
            pnTongTieuKH = new Panel();
            pnKhungTongTieu = new Panel();
            cbxTenKhachHang = new ComboBox();
            btnTKTongTieuKH = new Button();
            lbTenKHTongTieu = new Label();
            lbTKTittleTongTieuKH = new Label();
            pnSLKhachMoiKH = new Panel();
            pnKhungSLKhachMoi = new Panel();
            txtKQThangKhachMoi = new TextBox();
            btnChiTietSLKhachMoi = new Button();
            btnSLKhachMoi = new Button();
            dtpThangKhachMoi = new DateTimePicker();
            lbKQThangKhachMoi = new Label();
            lbThangSLKhachMoi = new Label();
            lbTKTittleSLKhachMoi = new Label();
            pnTKKHVip = new Panel();
            pnTKKhungDVnhieuKH = new Panel();
            btnTGDVnhieuKH = new Button();
            label7 = new Label();
            lbTKTittleSDnhieuKH = new Label();
            pnTKLenhKH = new Panel();
            pnTKKhungThangKH = new Panel();
            btnTKXemKH = new Button();
            StTKEndKH = new Label();
            lbTKStartKH = new Label();
            dtpTKEndKH = new DateTimePicker();
            dtpTKStartKH = new DateTimePicker();
            lbTKTittleThangKH = new Label();
            pnTKNutChucNangTK = new Panel();
            label11 = new Label();
            label12 = new Label();
            btnTKSoDo = new Button();
            btnTKXuatFile = new Button();
            btnTKQLUngDung = new Button();
            cmsKhachHang = new ContextMenuStrip(components);
            cmsKhachHang_Them = new ToolStripMenuItem();
            cmsKhachHang_Nhac = new ToolStripMenuItem();
            cmsKhachHang_TrangChu = new ToolStripMenuItem();
            cmsNhanVien = new ContextMenuStrip(components);
            cmsNhanVien_Them = new ToolStripMenuItem();
            cmsNhanVien_Nhac = new ToolStripMenuItem();
            cmsNhanVien_TrangChu = new ToolStripMenuItem();
            pnlLeft.SuspendLayout();
            pnStatictical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            pnStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            pnServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            pnAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            pnComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxClose).BeginInit();
            tblMain.SuspendLayout();
            tbpComputer.SuspendLayout();
            pnComputerControl.SuspendLayout();
            gbxComputerInfor.SuspendLayout();
            pnStatusCom.SuspendLayout();
            pnTimeCom.SuspendLayout();
            pnTongTienCom.SuspendLayout();
            pnUserNameCom.SuspendLayout();
            pnComputerButton.SuspendLayout();
            tbpAccount.SuspendLayout();
            pnButtonAccount.SuspendLayout();
            pnDuongDanAccount.SuspendLayout();
            grbKhachHang.SuspendLayout();
            pnTimKimAccount.SuspendLayout();
            pnDisplayAccount.SuspendLayout();
            tbpServices.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            tbpStaff.SuspendLayout();
            pnDuongDanStaff.SuspendLayout();
            grbQuanLyNhanVien.SuspendLayout();
            pnDisplayStaff.SuspendLayout();
            pnStaffControl.SuspendLayout();
            tbpStatictical.SuspendLayout();
            pnJob.SuspendLayout();
            pnTKKhungTK.SuspendLayout();
            gbxThongKe.SuspendLayout();
            pnTKNut.SuspendLayout();
            gbxThongKeTongQuan.SuspendLayout();
            pnTKView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllThongKe).BeginInit();
            pnTKThongKe.SuspendLayout();
            tbTKMayTram.SuspendLayout();
            tbTKDoanhThu.SuspendLayout();
            pnTKCongViec.SuspendLayout();
            pnTKThangDT.SuspendLayout();
            pnTKNamDT.SuspendLayout();
            pnTKNgayDT.SuspendLayout();
            tabPage2.SuspendLayout();
            pnTKTGMayTram.SuspendLayout();
            pnDTTungMT.SuspendLayout();
            pnKhungDTTungMT.SuspendLayout();
            panel6.SuspendLayout();
            pnTGNhieuItMT.SuspendLayout();
            pnKhungTGNhieuItMT.SuspendLayout();
            pnTKGioTheoThangMT.SuspendLayout();
            pnKhungGioTheoThangMT.SuspendLayout();
            panel7.SuspendLayout();
            tbTKThucAn.SuspendLayout();
            pnTKDoAnTheoTG.SuspendLayout();
            pnKhungTKDoAnTheoTG.SuspendLayout();
            tnTKKhachHang.SuspendLayout();
            pnTongTieuKH.SuspendLayout();
            pnKhungTongTieu.SuspendLayout();
            pnSLKhachMoiKH.SuspendLayout();
            pnKhungSLKhachMoi.SuspendLayout();
            pnTKKHVip.SuspendLayout();
            pnTKKhungDVnhieuKH.SuspendLayout();
            pnTKLenhKH.SuspendLayout();
            pnTKKhungThangKH.SuspendLayout();
            pnTKNutChucNangTK.SuspendLayout();
            cmsKhachHang.SuspendLayout();
            cmsNhanVien.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.LightCyan;
            pnlLeft.Controls.Add(pnStatictical);
            pnlLeft.Controls.Add(pnStaff);
            pnlLeft.Controls.Add(pnServices);
            pnlLeft.Controls.Add(pnAccount);
            pnlLeft.Controls.Add(pnComputer);
            pnlLeft.Controls.Add(panel2);
            pnlLeft.Location = new Point(0, 67);
            pnlLeft.Margin = new Padding(4, 5, 4, 5);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(309, 1147);
            pnlLeft.TabIndex = 0;
            // 
            // pnStatictical
            // 
            pnStatictical.Controls.Add(pictureBox12);
            pnStatictical.Controls.Add(label31);
            pnStatictical.Location = new Point(11, 920);
            pnStatictical.Margin = new Padding(4, 5, 4, 5);
            pnStatictical.Name = "pnStatictical";
            pnStatictical.Size = new Size(286, 133);
            pnStatictical.TabIndex = 3;
            pnStatictical.Click += pnStatictical_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.bill;
            pictureBox12.Location = new Point(11, 27);
            pictureBox12.Margin = new Padding(4, 5, 4, 5);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(71, 83);
            pictureBox12.TabIndex = 5;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(80, 40);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(173, 48);
            label31.TabIndex = 4;
            label31.Text = "Thống kê";
            label31.Click += label31_Click;
            // 
            // pnStaff
            // 
            pnStaff.Controls.Add(pictureBox11);
            pnStaff.Controls.Add(lblNhanVien);
            pnStaff.Location = new Point(11, 693);
            pnStaff.Margin = new Padding(4, 5, 4, 5);
            pnStaff.Name = "pnStaff";
            pnStaff.Size = new Size(286, 133);
            pnStaff.TabIndex = 3;
            pnStaff.Click += pnStaff_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.staff;
            pictureBox11.Location = new Point(11, 27);
            pictureBox11.Margin = new Padding(4, 5, 4, 5);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(71, 83);
            pictureBox11.TabIndex = 5;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhanVien.Location = new Point(80, 40);
            lblNhanVien.Margin = new Padding(4, 0, 4, 0);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(186, 48);
            lblNhanVien.TabIndex = 4;
            lblNhanVien.Text = "Nhân viên";
            lblNhanVien.Click += lblNhanVien_Click;
            // 
            // pnServices
            // 
            pnServices.Controls.Add(pictureBox10);
            pnServices.Controls.Add(label29);
            pnServices.Location = new Point(11, 467);
            pnServices.Margin = new Padding(4, 5, 4, 5);
            pnServices.Name = "pnServices";
            pnServices.Size = new Size(286, 133);
            pnServices.TabIndex = 3;
            pnServices.Click += pnServices_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.food;
            pictureBox10.Location = new Point(11, 27);
            pictureBox10.Margin = new Padding(4, 5, 4, 5);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(71, 83);
            pictureBox10.TabIndex = 5;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.Location = new Point(80, 40);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(142, 48);
            label29.TabIndex = 4;
            label29.Text = "Dịch vụ";
            label29.Click += label29_Click;
            // 
            // pnAccount
            // 
            pnAccount.Controls.Add(pictureBox9);
            pnAccount.Controls.Add(label28);
            pnAccount.Location = new Point(11, 240);
            pnAccount.Margin = new Padding(4, 5, 4, 5);
            pnAccount.Name = "pnAccount";
            pnAccount.Size = new Size(286, 133);
            pnAccount.TabIndex = 3;
            pnAccount.Click += pnAccount_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.useracount;
            pictureBox9.Location = new Point(11, 27);
            pictureBox9.Margin = new Padding(4, 5, 4, 5);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(71, 83);
            pictureBox9.TabIndex = 5;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(91, 40);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(177, 48);
            label28.TabIndex = 4;
            label28.Text = "Tài khoản";
            label28.Click += label28_Click;
            // 
            // pnComputer
            // 
            pnComputer.Controls.Add(pictureBox8);
            pnComputer.Controls.Add(label27);
            pnComputer.Location = new Point(11, 13);
            pnComputer.Margin = new Padding(4, 5, 4, 5);
            pnComputer.Name = "pnComputer";
            pnComputer.Size = new Size(286, 133);
            pnComputer.TabIndex = 3;
            pnComputer.Click += pnComputer_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.monitor;
            pictureBox8.Location = new Point(11, 27);
            pictureBox8.Margin = new Padding(4, 5, 4, 5);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(71, 83);
            pictureBox8.TabIndex = 5;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(101, 40);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(164, 48);
            label27.TabIndex = 4;
            label27.Text = "Máy tính";
            label27.Click += label27_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(354, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1579, 1053);
            panel2.TabIndex = 2;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.DarkGray;
            pnlTitleBar.Controls.Add(pbxClose);
            pnlTitleBar.Controls.Add(flpListComputer);
            pnlTitleBar.Controls.Add(label1);
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Margin = new Padding(4, 5, 4, 5);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1931, 67);
            pnlTitleBar.TabIndex = 1;
            // 
            // pbxClose
            // 
            pbxClose.Image = Properties.Resources.close;
            pbxClose.Location = new Point(1864, 0);
            pbxClose.Margin = new Padding(4, 5, 4, 5);
            pbxClose.Name = "pbxClose";
            pbxClose.Size = new Size(59, 67);
            pbxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxClose.TabIndex = 3;
            pbxClose.TabStop = false;
            pbxClose.Click += pbxClose_Click;
            pbxClose.MouseDown += pbxClose_MouseDown;
            pbxClose.MouseEnter += pbxClose_MouseEnter_1;
            pbxClose.MouseLeave += pbxClose_MouseLeave;
            pbxClose.MouseUp += pbxClose_MouseUp;
            // 
            // flpListComputer
            // 
            flpListComputer.Location = new Point(341, 93);
            flpListComputer.Margin = new Padding(4, 5, 4, 5);
            flpListComputer.Name = "flpListComputer";
            flpListComputer.Size = new Size(1589, 1120);
            flpListComputer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(629, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(731, 48);
            label1.TabIndex = 1;
            label1.Text = "Ứng dụng quản lí tiệm net Vip PROMAX";
            // 
            // tblMain
            // 
            tblMain.Controls.Add(tbpComputer);
            tblMain.Controls.Add(tbpAccount);
            tblMain.Controls.Add(tbpServices);
            tblMain.Controls.Add(tbpStaff);
            tblMain.Controls.Add(tbpStatictical);
            tblMain.Location = new Point(309, 67);
            tblMain.Margin = new Padding(4, 5, 4, 5);
            tblMain.MaximumSize = new Size(1611, 1120);
            tblMain.MinimumSize = new Size(1611, 1120);
            tblMain.Name = "tblMain";
            tblMain.SelectedIndex = 0;
            tblMain.Size = new Size(1611, 1120);
            tblMain.TabIndex = 2;
            // 
            // tbpComputer
            // 
            tbpComputer.Controls.Add(pnComputerControl);
            tbpComputer.Controls.Add(flpComputer);
            tbpComputer.Location = new Point(0, 0);
            tbpComputer.Margin = new Padding(4, 5, 4, 5);
            tbpComputer.Name = "tbpComputer";
            tbpComputer.Padding = new Padding(4, 5, 4, 5);
            tbpComputer.Size = new Size(1611, 1120);
            tbpComputer.TabIndex = 0;
            tbpComputer.Text = "tabPage1";
            tbpComputer.UseVisualStyleBackColor = true;
            // 
            // pnComputerControl
            // 
            pnComputerControl.BorderStyle = BorderStyle.FixedSingle;
            pnComputerControl.Controls.Add(gbxComputerInfor);
            pnComputerControl.Controls.Add(pnComputerButton);
            pnComputerControl.Location = new Point(1120, -13);
            pnComputerControl.Margin = new Padding(4, 5, 4, 5);
            pnComputerControl.Name = "pnComputerControl";
            pnComputerControl.Size = new Size(491, 1145);
            pnComputerControl.TabIndex = 1;
            // 
            // gbxComputerInfor
            // 
            gbxComputerInfor.Controls.Add(lvServices);
            gbxComputerInfor.Controls.Add(pnStatusCom);
            gbxComputerInfor.Controls.Add(pnTimeCom);
            gbxComputerInfor.Controls.Add(pnTongTienCom);
            gbxComputerInfor.Controls.Add(pnUserNameCom);
            gbxComputerInfor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxComputerInfor.Location = new Point(11, 13);
            gbxComputerInfor.Margin = new Padding(4, 5, 4, 5);
            gbxComputerInfor.Name = "gbxComputerInfor";
            gbxComputerInfor.Padding = new Padding(4, 5, 4, 5);
            gbxComputerInfor.Size = new Size(469, 760);
            gbxComputerInfor.TabIndex = 0;
            gbxComputerInfor.TabStop = false;
            gbxComputerInfor.Text = "Thông tin máy";
            // 
            // lvServices
            // 
            lvServices.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvServices.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvServices.Location = new Point(11, 333);
            lvServices.Margin = new Padding(4, 5, 4, 5);
            lvServices.Name = "lvServices";
            lvServices.Size = new Size(455, 331);
            lvServices.TabIndex = 4;
            lvServices.UseCompatibleStateImageBehavior = false;
            lvServices.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Món ăn";
            columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Giá";
            columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số lượng";
            columnHeader3.Width = 75;
            // 
            // pnStatusCom
            // 
            pnStatusCom.Controls.Add(lbStatusCom);
            pnStatusCom.Controls.Add(tbxComputerStatus);
            pnStatusCom.Location = new Point(11, 240);
            pnStatusCom.Margin = new Padding(4, 5, 4, 5);
            pnStatusCom.Name = "pnStatusCom";
            pnStatusCom.Size = new Size(421, 80);
            pnStatusCom.TabIndex = 3;
            // 
            // lbStatusCom
            // 
            lbStatusCom.AutoSize = true;
            lbStatusCom.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStatusCom.Location = new Point(0, 27);
            lbStatusCom.Margin = new Padding(4, 0, 4, 0);
            lbStatusCom.Name = "lbStatusCom";
            lbStatusCom.Size = new Size(124, 31);
            lbStatusCom.TabIndex = 2;
            lbStatusCom.Text = "Trạng thái:";
            // 
            // tbxComputerStatus
            // 
            tbxComputerStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxComputerStatus.Location = new Point(139, 13);
            tbxComputerStatus.Margin = new Padding(4, 5, 4, 5);
            tbxComputerStatus.Name = "tbxComputerStatus";
            tbxComputerStatus.ReadOnly = true;
            tbxComputerStatus.RightToLeft = RightToLeft.No;
            tbxComputerStatus.Size = new Size(273, 33);
            tbxComputerStatus.TabIndex = 1;
            // 
            // pnTimeCom
            // 
            pnTimeCom.Controls.Add(lbTimeConLai);
            pnTimeCom.Controls.Add(tbxTimeLeft);
            pnTimeCom.Location = new Point(11, 147);
            pnTimeCom.Margin = new Padding(4, 5, 4, 5);
            pnTimeCom.Name = "pnTimeCom";
            pnTimeCom.Size = new Size(421, 80);
            pnTimeCom.TabIndex = 3;
            // 
            // lbTimeConLai
            // 
            lbTimeConLai.AutoSize = true;
            lbTimeConLai.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTimeConLai.Location = new Point(0, 27);
            lbTimeConLai.Margin = new Padding(4, 0, 4, 0);
            lbTimeConLai.Name = "lbTimeConLai";
            lbTimeConLai.Size = new Size(117, 31);
            lbTimeConLai.TabIndex = 2;
            lbTimeConLai.Text = "Thời gian:";
            // 
            // tbxTimeLeft
            // 
            tbxTimeLeft.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxTimeLeft.Location = new Point(139, 13);
            tbxTimeLeft.Margin = new Padding(4, 5, 4, 5);
            tbxTimeLeft.Name = "tbxTimeLeft";
            tbxTimeLeft.ReadOnly = true;
            tbxTimeLeft.Size = new Size(273, 33);
            tbxTimeLeft.TabIndex = 1;
            tbxTimeLeft.Text = "00:00:00";
            // 
            // pnTongTienCom
            // 
            pnTongTienCom.Controls.Add(label6);
            pnTongTienCom.Controls.Add(lbTotalPriceDichVu);
            pnTongTienCom.Controls.Add(tbxMoneyAdd);
            pnTongTienCom.Controls.Add(tbxMoneyCost);
            pnTongTienCom.Location = new Point(11, 667);
            pnTongTienCom.Margin = new Padding(4, 5, 4, 5);
            pnTongTienCom.Name = "pnTongTienCom";
            pnTongTienCom.Size = new Size(456, 93);
            pnTongTienCom.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(251, 13);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 31);
            label6.TabIndex = 3;
            label6.Text = "Tiền nạp";
            // 
            // lbTotalPriceDichVu
            // 
            lbTotalPriceDichVu.AutoSize = true;
            lbTotalPriceDichVu.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalPriceDichVu.Location = new Point(11, 13);
            lbTotalPriceDichVu.Margin = new Padding(4, 0, 4, 0);
            lbTotalPriceDichVu.Name = "lbTotalPriceDichVu";
            lbTotalPriceDichVu.Size = new Size(119, 31);
            lbTotalPriceDichVu.TabIndex = 2;
            lbTotalPriceDichVu.Text = "Tổng tiền:";
            // 
            // tbxMoneyAdd
            // 
            tbxMoneyAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxMoneyAdd.Location = new Point(251, 40);
            tbxMoneyAdd.Margin = new Padding(4, 5, 4, 5);
            tbxMoneyAdd.Name = "tbxMoneyAdd";
            tbxMoneyAdd.ReadOnly = true;
            tbxMoneyAdd.RightToLeft = RightToLeft.No;
            tbxMoneyAdd.Size = new Size(181, 33);
            tbxMoneyAdd.TabIndex = 1;
            tbxMoneyAdd.Text = "0.00";
            tbxMoneyAdd.TextAlign = HorizontalAlignment.Right;
            // 
            // tbxMoneyCost
            // 
            tbxMoneyCost.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxMoneyCost.Location = new Point(11, 40);
            tbxMoneyCost.Margin = new Padding(4, 5, 4, 5);
            tbxMoneyCost.Name = "tbxMoneyCost";
            tbxMoneyCost.ReadOnly = true;
            tbxMoneyCost.RightToLeft = RightToLeft.No;
            tbxMoneyCost.Size = new Size(181, 33);
            tbxMoneyCost.TabIndex = 1;
            tbxMoneyCost.Text = "0.00";
            tbxMoneyCost.TextAlign = HorizontalAlignment.Right;
            // 
            // pnUserNameCom
            // 
            pnUserNameCom.Controls.Add(lbUserNameCom);
            pnUserNameCom.Controls.Add(tbxUserAccount);
            pnUserNameCom.Location = new Point(11, 53);
            pnUserNameCom.Margin = new Padding(4, 5, 4, 5);
            pnUserNameCom.Name = "pnUserNameCom";
            pnUserNameCom.Size = new Size(421, 80);
            pnUserNameCom.TabIndex = 3;
            // 
            // lbUserNameCom
            // 
            lbUserNameCom.AutoSize = true;
            lbUserNameCom.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserNameCom.Location = new Point(0, 27);
            lbUserNameCom.Margin = new Padding(4, 0, 4, 0);
            lbUserNameCom.Name = "lbUserNameCom";
            lbUserNameCom.Size = new Size(146, 31);
            lbUserNameCom.TabIndex = 2;
            lbUserNameCom.Text = "Người dùng:";
            // 
            // tbxUserAccount
            // 
            tbxUserAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUserAccount.Location = new Point(139, 13);
            tbxUserAccount.Margin = new Padding(4, 5, 4, 5);
            tbxUserAccount.Name = "tbxUserAccount";
            tbxUserAccount.ReadOnly = true;
            tbxUserAccount.Size = new Size(273, 39);
            tbxUserAccount.TabIndex = 1;
            // 
            // pnComputerButton
            // 
            pnComputerButton.Controls.Add(btnExtraMoney);
            pnComputerButton.Controls.Add(btnManageComputer);
            pnComputerButton.Controls.Add(btnTrackComputer);
            pnComputerButton.Controls.Add(btnShutDownComputer);
            pnComputerButton.Controls.Add(btnAddServices);
            pnComputerButton.Controls.Add(btnManageAllCom);
            pnComputerButton.Location = new Point(34, 773);
            pnComputerButton.Margin = new Padding(4, 5, 4, 5);
            pnComputerButton.Name = "pnComputerButton";
            pnComputerButton.Size = new Size(421, 347);
            pnComputerButton.TabIndex = 7;
            // 
            // btnExtraMoney
            // 
            btnExtraMoney.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExtraMoney.Location = new Point(229, 140);
            btnExtraMoney.Margin = new Padding(4, 5, 4, 5);
            btnExtraMoney.Name = "btnExtraMoney";
            btnExtraMoney.Size = new Size(181, 80);
            btnExtraMoney.TabIndex = 2;
            btnExtraMoney.Text = "Nạp tiền";
            btnExtraMoney.UseVisualStyleBackColor = true;
            btnExtraMoney.Click += btnExtraMoney_Click;
            // 
            // btnManageComputer
            // 
            btnManageComputer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnManageComputer.Location = new Point(0, 27);
            btnManageComputer.Margin = new Padding(4, 5, 4, 5);
            btnManageComputer.Name = "btnManageComputer";
            btnManageComputer.Size = new Size(181, 80);
            btnManageComputer.TabIndex = 3;
            btnManageComputer.Text = "Mở máy";
            btnManageComputer.UseVisualStyleBackColor = true;
            btnManageComputer.Click += btnManageComputer_Click;
            // 
            // btnTrackComputer
            // 
            btnTrackComputer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTrackComputer.Location = new Point(229, 253);
            btnTrackComputer.Margin = new Padding(4, 5, 4, 5);
            btnTrackComputer.Name = "btnTrackComputer";
            btnTrackComputer.Size = new Size(181, 80);
            btnTrackComputer.TabIndex = 4;
            btnTrackComputer.Text = "Theo dõi";
            btnTrackComputer.UseVisualStyleBackColor = true;
            // 
            // btnShutDownComputer
            // 
            btnShutDownComputer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnShutDownComputer.Location = new Point(229, 27);
            btnShutDownComputer.Margin = new Padding(4, 5, 4, 5);
            btnShutDownComputer.Name = "btnShutDownComputer";
            btnShutDownComputer.Size = new Size(181, 80);
            btnShutDownComputer.TabIndex = 5;
            btnShutDownComputer.Text = "Tắt máy";
            btnShutDownComputer.UseVisualStyleBackColor = true;
            btnShutDownComputer.Click += btnShutDownComputer_Click;
            // 
            // btnAddServices
            // 
            btnAddServices.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddServices.Location = new Point(0, 140);
            btnAddServices.Margin = new Padding(4, 5, 4, 5);
            btnAddServices.Name = "btnAddServices";
            btnAddServices.Size = new Size(181, 80);
            btnAddServices.TabIndex = 6;
            btnAddServices.Text = "Thêm dịch vụ";
            btnAddServices.UseVisualStyleBackColor = true;
            btnAddServices.Click += btnAddServices_Click;
            // 
            // btnManageAllCom
            // 
            btnManageAllCom.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnManageAllCom.Location = new Point(0, 253);
            btnManageAllCom.Margin = new Padding(4, 5, 4, 5);
            btnManageAllCom.Name = "btnManageAllCom";
            btnManageAllCom.Size = new Size(181, 80);
            btnManageAllCom.TabIndex = 7;
            btnManageAllCom.Text = "Quản lí";
            btnManageAllCom.UseVisualStyleBackColor = true;
            btnManageAllCom.Click += btnManageAllCom_Click;
            // 
            // flpComputer
            // 
            flpComputer.BorderStyle = BorderStyle.FixedSingle;
            flpComputer.Location = new Point(0, 0);
            flpComputer.Margin = new Padding(4, 5, 4, 5);
            flpComputer.Name = "flpComputer";
            flpComputer.Size = new Size(1121, 1119);
            flpComputer.TabIndex = 0;
            flpComputer.Click += flpComputer_Click;
            // 
            // tbpAccount
            // 
            tbpAccount.Controls.Add(pnButtonAccount);
            tbpAccount.Controls.Add(pnDuongDanAccount);
            tbpAccount.Controls.Add(grbKhachHang);
            tbpAccount.Location = new Point(0, 0);
            tbpAccount.Margin = new Padding(4, 5, 4, 5);
            tbpAccount.Name = "tbpAccount";
            tbpAccount.Padding = new Padding(4, 5, 4, 5);
            tbpAccount.Size = new Size(1611, 1120);
            tbpAccount.TabIndex = 1;
            tbpAccount.Text = "tabPage1";
            tbpAccount.UseVisualStyleBackColor = true;
            // 
            // pnButtonAccount
            // 
            pnButtonAccount.Controls.Add(btnThemKhachHang);
            pnButtonAccount.Controls.Add(btnNhap);
            pnButtonAccount.Controls.Add(button2);
            pnButtonAccount.Controls.Add(btn_TroChuyen);
            pnButtonAccount.Location = new Point(554, 0);
            pnButtonAccount.Margin = new Padding(4, 5, 4, 5);
            pnButtonAccount.Name = "pnButtonAccount";
            pnButtonAccount.Size = new Size(1046, 93);
            pnButtonAccount.TabIndex = 10;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.BackColor = Color.FromArgb(192, 255, 255);
            btnThemKhachHang.FlatStyle = FlatStyle.Flat;
            btnThemKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemKhachHang.Location = new Point(274, 27);
            btnThemKhachHang.Margin = new Padding(4, 5, 4, 5);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(181, 52);
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
            btnNhap.Location = new Point(480, 27);
            btnNhap.Margin = new Padding(4, 5, 4, 5);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(160, 52);
            btnNhap.TabIndex = 3;
            btnNhap.Text = "Nhập File";
            btnNhap.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(661, 27);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(160, 52);
            button2.TabIndex = 3;
            button2.Text = "Xuất File";
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_TroChuyen
            // 
            btn_TroChuyen.BackColor = Color.FromArgb(192, 255, 255);
            btn_TroChuyen.FlatStyle = FlatStyle.Flat;
            btn_TroChuyen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TroChuyen.Location = new Point(846, 27);
            btn_TroChuyen.Margin = new Padding(4, 5, 4, 5);
            btn_TroChuyen.Name = "btn_TroChuyen";
            btn_TroChuyen.Size = new Size(160, 52);
            btn_TroChuyen.TabIndex = 3;
            btn_TroChuyen.Text = "Trò Chuyện";
            btn_TroChuyen.UseVisualStyleBackColor = false;
            // 
            // pnDuongDanAccount
            // 
            pnDuongDanAccount.Controls.Add(lbCurrentAccountPage);
            pnDuongDanAccount.Controls.Add(lbHomeAccountPage);
            pnDuongDanAccount.Location = new Point(19, 0);
            pnDuongDanAccount.Margin = new Padding(4, 5, 4, 5);
            pnDuongDanAccount.Name = "pnDuongDanAccount";
            pnDuongDanAccount.Size = new Size(411, 80);
            pnDuongDanAccount.TabIndex = 9;
            // 
            // lbCurrentAccountPage
            // 
            lbCurrentAccountPage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCurrentAccountPage.Location = new Point(139, 27);
            lbCurrentAccountPage.Margin = new Padding(4, 0, 4, 0);
            lbCurrentAccountPage.Name = "lbCurrentAccountPage";
            lbCurrentAccountPage.Size = new Size(251, 38);
            lbCurrentAccountPage.TabIndex = 6;
            lbCurrentAccountPage.Text = "Quản lý khách hàng";
            // 
            // lbHomeAccountPage
            // 
            lbHomeAccountPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHomeAccountPage.Location = new Point(11, 27);
            lbHomeAccountPage.Margin = new Padding(4, 0, 4, 0);
            lbHomeAccountPage.Name = "lbHomeAccountPage";
            lbHomeAccountPage.Size = new Size(126, 38);
            lbHomeAccountPage.TabIndex = 6;
            lbHomeAccountPage.Text = "⟲ Home >";
            lbHomeAccountPage.Click += label33_Click;
            // 
            // grbKhachHang
            // 
            grbKhachHang.Controls.Add(pnTimKimAccount);
            grbKhachHang.Controls.Add(pnDisplayAccount);
            grbKhachHang.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbKhachHang.Location = new Point(19, 107);
            grbKhachHang.Margin = new Padding(4, 5, 4, 5);
            grbKhachHang.Name = "grbKhachHang";
            grbKhachHang.Padding = new Padding(4, 5, 4, 5);
            grbKhachHang.Size = new Size(1581, 1027);
            grbKhachHang.TabIndex = 11;
            grbKhachHang.TabStop = false;
            grbKhachHang.Text = "Quản Lý Khách Hàng";
            // 
            // pnTimKimAccount
            // 
            pnTimKimAccount.Controls.Add(cbxNhomKhach);
            pnTimKimAccount.Controls.Add(txtTimKiemKhachHang);
            pnTimKimAccount.Location = new Point(11, 67);
            pnTimKimAccount.Margin = new Padding(4, 5, 4, 5);
            pnTimKimAccount.Name = "pnTimKimAccount";
            pnTimKimAccount.Size = new Size(1566, 80);
            pnTimKimAccount.TabIndex = 8;
            // 
            // cbxNhomKhach
            // 
            cbxNhomKhach.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxNhomKhach.Location = new Point(629, 13);
            cbxNhomKhach.Margin = new Padding(4, 5, 4, 5);
            cbxNhomKhach.Name = "cbxNhomKhach";
            cbxNhomKhach.Size = new Size(173, 48);
            cbxNhomKhach.TabIndex = 5;
            cbxNhomKhach.SelectedIndexChanged += cbxNhomKhach_SelectedIndexChanged;
            // 
            // txtTimKiemKhachHang
            // 
            txtTimKiemKhachHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiemKhachHang.Location = new Point(11, 13);
            txtTimKiemKhachHang.Margin = new Padding(4, 5, 4, 5);
            txtTimKiemKhachHang.Multiline = true;
            txtTimKiemKhachHang.Name = "txtTimKiemKhachHang";
            txtTimKiemKhachHang.Size = new Size(604, 51);
            txtTimKiemKhachHang.TabIndex = 4;
            txtTimKiemKhachHang.TextChanged += txtTimKiemKhachHang_TextChanged;
            // 
            // pnDisplayAccount
            // 
            pnDisplayAccount.Controls.Add(flpKhachHang);
            pnDisplayAccount.Location = new Point(11, 160);
            pnDisplayAccount.Margin = new Padding(4, 5, 4, 5);
            pnDisplayAccount.Name = "pnDisplayAccount";
            pnDisplayAccount.Size = new Size(1566, 853);
            pnDisplayAccount.TabIndex = 7;
            // 
            // flpKhachHang
            // 
            flpKhachHang.AutoScroll = true;
            flpKhachHang.Location = new Point(11, 13);
            flpKhachHang.Margin = new Padding(4, 5, 4, 5);
            flpKhachHang.Name = "flpKhachHang";
            flpKhachHang.Size = new Size(1541, 813);
            flpKhachHang.TabIndex = 0;
            flpKhachHang.MouseDown += flpKhachHang_MouseDown;
            // 
            // tbpServices
            // 
            tbpServices.Controls.Add(groupBox1);
            tbpServices.Controls.Add(panel3);
            tbpServices.Controls.Add(panel1);
            tbpServices.Location = new Point(0, 0);
            tbpServices.Margin = new Padding(4, 5, 4, 5);
            tbpServices.Name = "tbpServices";
            tbpServices.Padding = new Padding(4, 5, 4, 5);
            tbpServices.Size = new Size(1611, 1120);
            tbpServices.TabIndex = 2;
            tbpServices.Text = "tabPage1";
            tbpServices.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(txbSearch);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 90);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1611, 1030);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản Lý Dịch Vụ 1";
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.Location = new Point(779, 67);
            cbCategory.Margin = new Padding(4, 5, 4, 5);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(163, 49);
            cbCategory.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(flpFoodList);
            panel5.Location = new Point(9, 157);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1591, 870);
            panel5.TabIndex = 5;
            // 
            // flpFoodList
            // 
            flpFoodList.Location = new Point(11, 13);
            flpFoodList.Margin = new Padding(4, 5, 4, 5);
            flpFoodList.Name = "flpFoodList";
            flpFoodList.Size = new Size(1566, 840);
            flpFoodList.TabIndex = 4;
            // 
            // txbSearch
            // 
            txbSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSearch.Location = new Point(11, 67);
            txbSearch.Margin = new Padding(4, 5, 4, 5);
            txbSearch.Multiline = true;
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(743, 59);
            txbSearch.TabIndex = 0;
            txbSearch.TextChanged += txbSearch_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(560, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1049, 80);
            panel3.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(610, 10);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(181, 52);
            button1.TabIndex = 3;
            button1.Text = "➕ Thêm Mới";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 255, 255);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(820, 10);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(181, 52);
            button4.TabIndex = 3;
            button4.Text = "Xem";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 80);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(139, 27);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(251, 38);
            label2.TabIndex = 6;
            label2.Text = "Quản lý Dịch Vụ 1";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 27);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 38);
            label3.TabIndex = 6;
            label3.Text = "⟲ Home >";
            // 
            // tbpStaff
            // 
            tbpStaff.Controls.Add(pnDuongDanStaff);
            tbpStaff.Controls.Add(grbQuanLyNhanVien);
            tbpStaff.Controls.Add(pnStaffControl);
            tbpStaff.Location = new Point(0, 0);
            tbpStaff.Margin = new Padding(4, 5, 4, 5);
            tbpStaff.Name = "tbpStaff";
            tbpStaff.Padding = new Padding(4, 5, 4, 5);
            tbpStaff.Size = new Size(1611, 1120);
            tbpStaff.TabIndex = 3;
            tbpStaff.Text = "git b";
            tbpStaff.UseVisualStyleBackColor = true;
            // 
            // pnDuongDanStaff
            // 
            pnDuongDanStaff.Controls.Add(lblQuanLyNhanVien);
            pnDuongDanStaff.Controls.Add(lblHome);
            pnDuongDanStaff.Location = new Point(26, 13);
            pnDuongDanStaff.Margin = new Padding(4, 5, 4, 5);
            pnDuongDanStaff.Name = "pnDuongDanStaff";
            pnDuongDanStaff.Size = new Size(411, 80);
            pnDuongDanStaff.TabIndex = 8;
            // 
            // lblQuanLyNhanVien
            // 
            lblQuanLyNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanLyNhanVien.Location = new Point(126, 27);
            lblQuanLyNhanVien.Margin = new Padding(4, 0, 4, 0);
            lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            lblQuanLyNhanVien.Size = new Size(240, 38);
            lblQuanLyNhanVien.TabIndex = 6;
            lblQuanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // lblHome
            // 
            lblHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHome.Location = new Point(11, 27);
            lblHome.Margin = new Padding(4, 0, 4, 0);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(126, 38);
            lblHome.TabIndex = 6;
            lblHome.Text = "⟲ Home >";
            lblHome.Click += lblHome_Click;
            // 
            // grbQuanLyNhanVien
            // 
            grbQuanLyNhanVien.Controls.Add(cbxChucVu);
            grbQuanLyNhanVien.Controls.Add(pnDisplayStaff);
            grbQuanLyNhanVien.Controls.Add(cbxTrangThai);
            grbQuanLyNhanVien.Controls.Add(txtTimKiem);
            grbQuanLyNhanVien.FlatStyle = FlatStyle.System;
            grbQuanLyNhanVien.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbQuanLyNhanVien.Location = new Point(0, 107);
            grbQuanLyNhanVien.Margin = new Padding(4, 5, 4, 5);
            grbQuanLyNhanVien.Name = "grbQuanLyNhanVien";
            grbQuanLyNhanVien.Padding = new Padding(4, 5, 4, 5);
            grbQuanLyNhanVien.Size = new Size(1611, 1015);
            grbQuanLyNhanVien.TabIndex = 6;
            grbQuanLyNhanVien.TabStop = false;
            grbQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // cbxChucVu
            // 
            cbxChucVu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxChucVu.Location = new Point(779, 67);
            cbxChucVu.Margin = new Padding(4, 5, 4, 5);
            cbxChucVu.Name = "cbxChucVu";
            cbxChucVu.Size = new Size(163, 49);
            cbxChucVu.TabIndex = 2;
            cbxChucVu.SelectedIndexChanged += cbxChucVu_SelectedIndexChanged_1;
            // 
            // pnDisplayStaff
            // 
            pnDisplayStaff.Controls.Add(flpNhanVien);
            pnDisplayStaff.Location = new Point(9, 157);
            pnDisplayStaff.Margin = new Padding(4, 5, 4, 5);
            pnDisplayStaff.Name = "pnDisplayStaff";
            pnDisplayStaff.Size = new Size(1591, 843);
            pnDisplayStaff.TabIndex = 5;
            // 
            // flpNhanVien
            // 
            flpNhanVien.Location = new Point(11, 0);
            flpNhanVien.Margin = new Padding(4, 5, 4, 5);
            flpNhanVien.Name = "flpNhanVien";
            flpNhanVien.Size = new Size(1577, 840);
            flpNhanVien.TabIndex = 4;
            flpNhanVien.MouseDown += flpNhanVien_MouseDown;
            // 
            // cbxTrangThai
            // 
            cbxTrangThai.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxTrangThai.FormattingEnabled = true;
            cbxTrangThai.Location = new Point(960, 67);
            cbxTrangThai.Margin = new Padding(4, 5, 4, 5);
            cbxTrangThai.Name = "cbxTrangThai";
            cbxTrangThai.Size = new Size(173, 49);
            cbxTrangThai.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(11, 67);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(743, 59);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // pnStaffControl
            // 
            pnStaffControl.Controls.Add(btnThemMoi);
            pnStaffControl.Controls.Add(btnXuatFile);
            pnStaffControl.Controls.Add(btn_ThongKe);
            pnStaffControl.Location = new Point(551, 0);
            pnStaffControl.Margin = new Padding(4, 5, 4, 5);
            pnStaffControl.Name = "pnStaffControl";
            pnStaffControl.Size = new Size(1049, 93);
            pnStaffControl.TabIndex = 7;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.FromArgb(128, 255, 255);
            btnThemMoi.FlatStyle = FlatStyle.Flat;
            btnThemMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMoi.Location = new Point(434, 27);
            btnThemMoi.Margin = new Padding(4, 5, 4, 5);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(181, 52);
            btnThemMoi.TabIndex = 3;
            btnThemMoi.Text = "➕ Thêm Mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnXuatFile
            // 
            btnXuatFile.BackColor = Color.FromArgb(128, 255, 255);
            btnXuatFile.FlatStyle = FlatStyle.Flat;
            btnXuatFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatFile.Location = new Point(629, 27);
            btnXuatFile.Margin = new Padding(4, 5, 4, 5);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(181, 52);
            btnXuatFile.TabIndex = 3;
            btnXuatFile.Text = "Xuất File";
            btnXuatFile.UseVisualStyleBackColor = false;
            // 
            // btn_ThongKe
            // 
            btn_ThongKe.BackColor = Color.FromArgb(128, 255, 255);
            btn_ThongKe.FlatStyle = FlatStyle.Flat;
            btn_ThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThongKe.Location = new Point(821, 27);
            btn_ThongKe.Margin = new Padding(4, 5, 4, 5);
            btn_ThongKe.Name = "btn_ThongKe";
            btn_ThongKe.Size = new Size(181, 52);
            btn_ThongKe.TabIndex = 3;
            btn_ThongKe.Text = "Thống Kê";
            btn_ThongKe.UseVisualStyleBackColor = false;
            // 
            // tbpStatictical
            // 
            tbpStatictical.Controls.Add(pnJob);
            tbpStatictical.Location = new Point(0, 0);
            tbpStatictical.Margin = new Padding(4, 5, 4, 5);
            tbpStatictical.Name = "tbpStatictical";
            tbpStatictical.Padding = new Padding(4, 5, 4, 5);
            tbpStatictical.Size = new Size(1611, 1120);
            tbpStatictical.TabIndex = 4;
            tbpStatictical.Text = "tabPage1";
            tbpStatictical.UseVisualStyleBackColor = true;
            // 
            // pnJob
            // 
            pnJob.BorderStyle = BorderStyle.FixedSingle;
            pnJob.Controls.Add(pnTKKhungTK);
            pnJob.Dock = DockStyle.Fill;
            pnJob.Location = new Point(4, 5);
            pnJob.Margin = new Padding(1, 3, 1, 3);
            pnJob.Name = "pnJob";
            pnJob.Size = new Size(1603, 1110);
            pnJob.TabIndex = 4;
            // 
            // pnTKKhungTK
            // 
            pnTKKhungTK.Controls.Add(gbxThongKe);
            pnTKKhungTK.Controls.Add(pnTKNutChucNangTK);
            pnTKKhungTK.Dock = DockStyle.Fill;
            pnTKKhungTK.Location = new Point(0, 0);
            pnTKKhungTK.Name = "pnTKKhungTK";
            pnTKKhungTK.Size = new Size(1601, 1108);
            pnTKKhungTK.TabIndex = 1;
            // 
            // gbxThongKe
            // 
            gbxThongKe.Controls.Add(pnTKNut);
            gbxThongKe.Controls.Add(pnTKView);
            gbxThongKe.Controls.Add(pnTKThongKe);
            gbxThongKe.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxThongKe.Location = new Point(12, 113);
            gbxThongKe.Name = "gbxThongKe";
            gbxThongKe.Size = new Size(1551, 934);
            gbxThongKe.TabIndex = 12;
            gbxThongKe.TabStop = false;
            gbxThongKe.Text = "THỐNG KÊ";
            // 
            // pnTKNut
            // 
            pnTKNut.BorderStyle = BorderStyle.FixedSingle;
            pnTKNut.Controls.Add(gbxThongKeTongQuan);
            pnTKNut.Location = new Point(6, 575);
            pnTKNut.Name = "pnTKNut";
            pnTKNut.Size = new Size(1048, 352);
            pnTKNut.TabIndex = 3;
            // 
            // gbxThongKeTongQuan
            // 
            gbxThongKeTongQuan.Controls.Add(btnCapNhatThongKe);
            gbxThongKeTongQuan.Controls.Add(pbHieuSuat);
            gbxThongKeTongQuan.Controls.Add(txtTongDichVu);
            gbxThongKeTongQuan.Controls.Add(txtTKTongTienMay);
            gbxThongKeTongQuan.Controls.Add(txtTongGioSuDung);
            gbxThongKeTongQuan.Controls.Add(txtTongDoanhThu);
            gbxThongKeTongQuan.Controls.Add(lbTongGioSuDung);
            gbxThongKeTongQuan.Controls.Add(lbTKTongTienMay);
            gbxThongKeTongQuan.Controls.Add(lbTongDichVu);
            gbxThongKeTongQuan.Controls.Add(lbTongDoanhThu);
            gbxThongKeTongQuan.Location = new Point(3, 3);
            gbxThongKeTongQuan.Name = "gbxThongKeTongQuan";
            gbxThongKeTongQuan.Size = new Size(1040, 344);
            gbxThongKeTongQuan.TabIndex = 0;
            gbxThongKeTongQuan.TabStop = false;
            gbxThongKeTongQuan.Text = "Tổng Quan";
            // 
            // btnCapNhatThongKe
            // 
            btnCapNhatThongKe.Location = new Point(388, 205);
            btnCapNhatThongKe.Name = "btnCapNhatThongKe";
            btnCapNhatThongKe.Size = new Size(226, 56);
            btnCapNhatThongKe.TabIndex = 6;
            btnCapNhatThongKe.Text = "Tổng kết";
            btnCapNhatThongKe.UseVisualStyleBackColor = true;
            btnCapNhatThongKe.Click += btnCapNhatThongKe_Click_1;
            // 
            // pbHieuSuat
            // 
            pbHieuSuat.Location = new Point(15, 276);
            pbHieuSuat.Name = "pbHieuSuat";
            pbHieuSuat.Size = new Size(993, 34);
            pbHieuSuat.Style = ProgressBarStyle.Continuous;
            pbHieuSuat.TabIndex = 0;
            // 
            // txtTongDichVu
            // 
            txtTongDichVu.Font = new Font("Segoe UI", 11F);
            txtTongDichVu.Location = new Point(213, 133);
            txtTongDichVu.Name = "txtTongDichVu";
            txtTongDichVu.Size = new Size(238, 37);
            txtTongDichVu.TabIndex = 5;
            // 
            // txtTKTongTienMay
            // 
            txtTKTongTienMay.Font = new Font("Segoe UI", 11F);
            txtTKTongTienMay.Location = new Point(787, 134);
            txtTKTongTienMay.Name = "txtTKTongTienMay";
            txtTKTongTienMay.Size = new Size(238, 37);
            txtTKTongTienMay.TabIndex = 4;
            // 
            // txtTongGioSuDung
            // 
            txtTongGioSuDung.Font = new Font("Segoe UI", 11F);
            txtTongGioSuDung.Location = new Point(787, 68);
            txtTongGioSuDung.Name = "txtTongGioSuDung";
            txtTongGioSuDung.Size = new Size(238, 37);
            txtTongGioSuDung.TabIndex = 4;
            // 
            // txtTongDoanhThu
            // 
            txtTongDoanhThu.Font = new Font("Segoe UI", 11F);
            txtTongDoanhThu.Location = new Point(213, 69);
            txtTongDoanhThu.Name = "txtTongDoanhThu";
            txtTongDoanhThu.Size = new Size(238, 37);
            txtTongDoanhThu.TabIndex = 3;
            // 
            // lbTongGioSuDung
            // 
            lbTongGioSuDung.AutoSize = true;
            lbTongGioSuDung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTongGioSuDung.Location = new Point(503, 69);
            lbTongGioSuDung.Name = "lbTongGioSuDung";
            lbTongGioSuDung.Size = new Size(261, 32);
            lbTongGioSuDung.TabIndex = 0;
            lbTongGioSuDung.Text = "Tổng giờ sử dụng máy:";
            // 
            // lbTKTongTienMay
            // 
            lbTKTongTienMay.AutoSize = true;
            lbTKTongTienMay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTKTongTienMay.Location = new Point(503, 134);
            lbTKTongTienMay.Name = "lbTKTongTienMay";
            lbTKTongTienMay.Size = new Size(174, 32);
            lbTKTongTienMay.TabIndex = 0;
            lbTKTongTienMay.Text = "Tổng tiền máy:";
            // 
            // lbTongDichVu
            // 
            lbTongDichVu.AutoSize = true;
            lbTongDichVu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTongDichVu.Location = new Point(15, 133);
            lbTongDichVu.Name = "lbTongDichVu";
            lbTongDichVu.Size = new Size(159, 32);
            lbTongDichVu.TabIndex = 0;
            lbTongDichVu.Text = "Tổng dịch vụ:";
            // 
            // lbTongDoanhThu
            // 
            lbTongDoanhThu.AutoSize = true;
            lbTongDoanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTongDoanhThu.Location = new Point(15, 69);
            lbTongDoanhThu.Name = "lbTongDoanhThu";
            lbTongDoanhThu.Size = new Size(192, 32);
            lbTongDoanhThu.TabIndex = 0;
            lbTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // pnTKView
            // 
            pnTKView.BorderStyle = BorderStyle.FixedSingle;
            pnTKView.Controls.Add(dgvAllThongKe);
            pnTKView.Location = new Point(6, 51);
            pnTKView.Name = "pnTKView";
            pnTKView.Size = new Size(1048, 518);
            pnTKView.TabIndex = 2;
            // 
            // dgvAllThongKe
            // 
            dgvAllThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllThongKe.Dock = DockStyle.Fill;
            dgvAllThongKe.Location = new Point(0, 0);
            dgvAllThongKe.Name = "dgvAllThongKe";
            dgvAllThongKe.RowHeadersWidth = 62;
            dgvAllThongKe.Size = new Size(1046, 516);
            dgvAllThongKe.TabIndex = 0;
            // 
            // pnTKThongKe
            // 
            pnTKThongKe.Controls.Add(tbTKMayTram);
            pnTKThongKe.Dock = DockStyle.Right;
            pnTKThongKe.Location = new Point(1060, 51);
            pnTKThongKe.Name = "pnTKThongKe";
            pnTKThongKe.Size = new Size(488, 880);
            pnTKThongKe.TabIndex = 0;
            // 
            // tbTKMayTram
            // 
            tbTKMayTram.Controls.Add(tbTKDoanhThu);
            tbTKMayTram.Controls.Add(tabPage2);
            tbTKMayTram.Controls.Add(tbTKThucAn);
            tbTKMayTram.Controls.Add(tnTKKhachHang);
            tbTKMayTram.Dock = DockStyle.Fill;
            tbTKMayTram.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTKMayTram.Location = new Point(0, 0);
            tbTKMayTram.Name = "tbTKMayTram";
            tbTKMayTram.SelectedIndex = 0;
            tbTKMayTram.Size = new Size(488, 880);
            tbTKMayTram.TabIndex = 0;
            // 
            // tbTKDoanhThu
            // 
            tbTKDoanhThu.Controls.Add(pnTKCongViec);
            tbTKDoanhThu.Location = new Point(4, 37);
            tbTKDoanhThu.Name = "tbTKDoanhThu";
            tbTKDoanhThu.Padding = new Padding(3);
            tbTKDoanhThu.Size = new Size(480, 839);
            tbTKDoanhThu.TabIndex = 0;
            tbTKDoanhThu.Text = "Doanh Thu";
            tbTKDoanhThu.UseVisualStyleBackColor = true;
            // 
            // pnTKCongViec
            // 
            pnTKCongViec.BorderStyle = BorderStyle.FixedSingle;
            pnTKCongViec.Controls.Add(pnTKThangDT);
            pnTKCongViec.Controls.Add(rbtTittleNamDT);
            pnTKCongViec.Controls.Add(rbtTittleThangDT);
            pnTKCongViec.Controls.Add(rbtTittleNgayDT);
            pnTKCongViec.Controls.Add(pnTKNamDT);
            pnTKCongViec.Controls.Add(pnTKNgayDT);
            pnTKCongViec.Location = new Point(2, 0);
            pnTKCongViec.Name = "pnTKCongViec";
            pnTKCongViec.Size = new Size(477, 829);
            pnTKCongViec.TabIndex = 5;
            // 
            // pnTKThangDT
            // 
            pnTKThangDT.BorderStyle = BorderStyle.FixedSingle;
            pnTKThangDT.Controls.Add(btnTKTongDoanhThuThang);
            pnTKThangDT.Controls.Add(btnTKThangDT);
            pnTKThangDT.Controls.Add(txtTKThangDT);
            pnTKThangDT.Controls.Add(lbTKThangDT);
            pnTKThangDT.Controls.Add(lbTittleThangDT);
            pnTKThangDT.Controls.Add(dtpTKThangDT);
            pnTKThangDT.Location = new Point(16, 319);
            pnTKThangDT.Name = "pnTKThangDT";
            pnTKThangDT.Size = new Size(431, 201);
            pnTKThangDT.TabIndex = 2;
            // 
            // btnTKTongDoanhThuThang
            // 
            btnTKTongDoanhThuThang.Location = new Point(36, 146);
            btnTKTongDoanhThuThang.Name = "btnTKTongDoanhThuThang";
            btnTKTongDoanhThuThang.Size = new Size(170, 44);
            btnTKTongDoanhThuThang.TabIndex = 3;
            btnTKTongDoanhThuThang.Text = "Tổng doanh thu";
            btnTKTongDoanhThuThang.UseVisualStyleBackColor = true;
            btnTKTongDoanhThuThang.Click += btnTKTongDoanhThuThang_Click_1;
            // 
            // btnTKThangDT
            // 
            btnTKThangDT.Location = new Point(268, 146);
            btnTKThangDT.Name = "btnTKThangDT";
            btnTKThangDT.Size = new Size(112, 44);
            btnTKThangDT.TabIndex = 3;
            btnTKThangDT.Text = "Xem";
            btnTKThangDT.UseVisualStyleBackColor = true;
            btnTKThangDT.Click += btnTKThangDT_Click_1;
            // 
            // txtTKThangDT
            // 
            txtTKThangDT.Font = new Font("Segoe UI", 11F);
            txtTKThangDT.Location = new Point(180, 94);
            txtTKThangDT.Name = "txtTKThangDT";
            txtTKThangDT.Size = new Size(232, 37);
            txtTKThangDT.TabIndex = 2;
            // 
            // lbTKThangDT
            // 
            lbTKThangDT.AutoSize = true;
            lbTKThangDT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTKThangDT.Location = new Point(21, 101);
            lbTKThangDT.Name = "lbTKThangDT";
            lbTKThangDT.Size = new Size(125, 30);
            lbTKThangDT.TabIndex = 1;
            lbTKThangDT.Text = "DoanhThu:";
            // 
            // lbTittleThangDT
            // 
            lbTittleThangDT.AutoSize = true;
            lbTittleThangDT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTittleThangDT.Location = new Point(20, 31);
            lbTittleThangDT.Name = "lbTittleThangDT";
            lbTittleThangDT.Size = new Size(84, 30);
            lbTittleThangDT.TabIndex = 1;
            lbTittleThangDT.Text = "Tháng:";
            // 
            // dtpTKThangDT
            // 
            dtpTKThangDT.CustomFormat = "MM/yyyy";
            dtpTKThangDT.Font = new Font("Segoe UI", 11F);
            dtpTKThangDT.Format = DateTimePickerFormat.Custom;
            dtpTKThangDT.Location = new Point(180, 31);
            dtpTKThangDT.Name = "dtpTKThangDT";
            dtpTKThangDT.ShowUpDown = true;
            dtpTKThangDT.Size = new Size(232, 37);
            dtpTKThangDT.TabIndex = 0;
            // 
            // rbtTittleNamDT
            // 
            rbtTittleNamDT.AutoSize = true;
            rbtTittleNamDT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbtTittleNamDT.ForeColor = SystemColors.HotTrack;
            rbtTittleNamDT.Location = new Point(16, 536);
            rbtTittleNamDT.Name = "rbtTittleNamDT";
            rbtTittleNamDT.Size = new Size(146, 34);
            rbtTittleNamDT.TabIndex = 4;
            rbtTittleNamDT.TabStop = true;
            rbtTittleNamDT.Text = "Theo năm:";
            rbtTittleNamDT.UseVisualStyleBackColor = true;
            rbtTittleNamDT.CheckedChanged += rbtTittleNamDT_CheckedChanged;
            // 
            // rbtTittleThangDT
            // 
            rbtTittleThangDT.AutoSize = true;
            rbtTittleThangDT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbtTittleThangDT.ForeColor = SystemColors.HotTrack;
            rbtTittleThangDT.Location = new Point(16, 279);
            rbtTittleThangDT.Name = "rbtTittleThangDT";
            rbtTittleThangDT.Size = new Size(162, 34);
            rbtTittleThangDT.TabIndex = 4;
            rbtTittleThangDT.TabStop = true;
            rbtTittleThangDT.Text = "Theo tháng:";
            rbtTittleThangDT.UseVisualStyleBackColor = true;
            rbtTittleThangDT.CheckedChanged += rbtTittleThangDT_CheckedChanged;
            // 
            // rbtTittleNgayDT
            // 
            rbtTittleNgayDT.AutoSize = true;
            rbtTittleNgayDT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbtTittleNgayDT.ForeColor = SystemColors.HotTrack;
            rbtTittleNgayDT.Location = new Point(16, 3);
            rbtTittleNgayDT.Name = "rbtTittleNgayDT";
            rbtTittleNgayDT.Size = new Size(152, 34);
            rbtTittleNgayDT.TabIndex = 4;
            rbtTittleNgayDT.TabStop = true;
            rbtTittleNgayDT.Text = "Theo ngày:";
            rbtTittleNgayDT.UseVisualStyleBackColor = true;
            rbtTittleNgayDT.CheckedChanged += rbtTittleNgayDT_CheckedChanged;
            // 
            // pnTKNamDT
            // 
            pnTKNamDT.BorderStyle = BorderStyle.FixedSingle;
            pnTKNamDT.Controls.Add(btnTKTongDoanhThuNam);
            pnTKNamDT.Controls.Add(btnTKNamDT);
            pnTKNamDT.Controls.Add(txtTKNamDT);
            pnTKNamDT.Controls.Add(lbTKNamDT);
            pnTKNamDT.Controls.Add(lbTittleNamDT);
            pnTKNamDT.Controls.Add(dtpTKNamDT);
            pnTKNamDT.Location = new Point(16, 576);
            pnTKNamDT.Name = "pnTKNamDT";
            pnTKNamDT.Size = new Size(431, 214);
            pnTKNamDT.TabIndex = 3;
            // 
            // btnTKTongDoanhThuNam
            // 
            btnTKTongDoanhThuNam.Location = new Point(36, 152);
            btnTKTongDoanhThuNam.Name = "btnTKTongDoanhThuNam";
            btnTKTongDoanhThuNam.Size = new Size(170, 44);
            btnTKTongDoanhThuNam.TabIndex = 3;
            btnTKTongDoanhThuNam.Text = "Tổng doanh thu";
            btnTKTongDoanhThuNam.UseVisualStyleBackColor = true;
            btnTKTongDoanhThuNam.Click += btnTKTongDoanhThuNam_Click_1;
            // 
            // btnTKNamDT
            // 
            btnTKNamDT.Location = new Point(268, 152);
            btnTKNamDT.Name = "btnTKNamDT";
            btnTKNamDT.Size = new Size(112, 44);
            btnTKNamDT.TabIndex = 3;
            btnTKNamDT.Text = "Xem";
            btnTKNamDT.UseVisualStyleBackColor = true;
            btnTKNamDT.Click += btnTKNamDT_Click_1;
            // 
            // txtTKNamDT
            // 
            txtTKNamDT.Font = new Font("Segoe UI", 11F);
            txtTKNamDT.Location = new Point(180, 93);
            txtTKNamDT.Name = "txtTKNamDT";
            txtTKNamDT.Size = new Size(232, 37);
            txtTKNamDT.TabIndex = 2;
            // 
            // lbTKNamDT
            // 
            lbTKNamDT.AutoSize = true;
            lbTKNamDT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTKNamDT.Location = new Point(21, 93);
            lbTKNamDT.Name = "lbTKNamDT";
            lbTKNamDT.Size = new Size(119, 30);
            lbTKNamDT.TabIndex = 1;
            lbTKNamDT.Text = "DoanhThu";
            // 
            // lbTittleNamDT
            // 
            lbTittleNamDT.AutoSize = true;
            lbTittleNamDT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTittleNamDT.Location = new Point(20, 28);
            lbTittleNamDT.Name = "lbTittleNamDT";
            lbTittleNamDT.Size = new Size(68, 30);
            lbTittleNamDT.TabIndex = 1;
            lbTittleNamDT.Text = "Năm:";
            // 
            // dtpTKNamDT
            // 
            dtpTKNamDT.CustomFormat = "yyyy";
            dtpTKNamDT.Font = new Font("Segoe UI", 11F);
            dtpTKNamDT.Format = DateTimePickerFormat.Custom;
            dtpTKNamDT.Location = new Point(180, 28);
            dtpTKNamDT.Name = "dtpTKNamDT";
            dtpTKNamDT.ShowUpDown = true;
            dtpTKNamDT.Size = new Size(232, 37);
            dtpTKNamDT.TabIndex = 0;
            // 
            // pnTKNgayDT
            // 
            pnTKNgayDT.BorderStyle = BorderStyle.FixedSingle;
            pnTKNgayDT.Controls.Add(btnTKTongDoanhThuNgay);
            pnTKNgayDT.Controls.Add(btnTKNgayDT);
            pnTKNgayDT.Controls.Add(txtTKNgayDT);
            pnTKNgayDT.Controls.Add(lbTKNgayDT);
            pnTKNgayDT.Controls.Add(lbTittleNgayDT);
            pnTKNgayDT.Controls.Add(dtpTKNgayDT);
            pnTKNgayDT.Location = new Point(16, 43);
            pnTKNgayDT.Name = "pnTKNgayDT";
            pnTKNgayDT.Size = new Size(431, 214);
            pnTKNgayDT.TabIndex = 1;
            // 
            // btnTKTongDoanhThuNgay
            // 
            btnTKTongDoanhThuNgay.Location = new Point(36, 157);
            btnTKTongDoanhThuNgay.Name = "btnTKTongDoanhThuNgay";
            btnTKTongDoanhThuNgay.Size = new Size(170, 44);
            btnTKTongDoanhThuNgay.TabIndex = 3;
            btnTKTongDoanhThuNgay.Text = "Tổng doanh thu";
            btnTKTongDoanhThuNgay.UseVisualStyleBackColor = true;
            btnTKTongDoanhThuNgay.Click += btnTKTongDoanhThuNgay_Click_1;
            // 
            // btnTKNgayDT
            // 
            btnTKNgayDT.Location = new Point(268, 157);
            btnTKNgayDT.Name = "btnTKNgayDT";
            btnTKNgayDT.Size = new Size(112, 44);
            btnTKNgayDT.TabIndex = 3;
            btnTKNgayDT.Text = "Xem";
            btnTKNgayDT.UseVisualStyleBackColor = true;
            btnTKNgayDT.Click += btnTKNgayDT_Click_1;
            // 
            // txtTKNgayDT
            // 
            txtTKNgayDT.Font = new Font("Segoe UI", 11F);
            txtTKNgayDT.Location = new Point(180, 99);
            txtTKNgayDT.Name = "txtTKNgayDT";
            txtTKNgayDT.Size = new Size(232, 37);
            txtTKNgayDT.TabIndex = 2;
            // 
            // lbTKNgayDT
            // 
            lbTKNgayDT.AutoSize = true;
            lbTKNgayDT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTKNgayDT.Location = new Point(20, 102);
            lbTKNgayDT.Name = "lbTKNgayDT";
            lbTKNgayDT.Size = new Size(131, 30);
            lbTKNgayDT.TabIndex = 1;
            lbTKNgayDT.Text = "Doanh Thu:";
            // 
            // lbTittleNgayDT
            // 
            lbTittleNgayDT.AutoSize = true;
            lbTittleNgayDT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTittleNgayDT.Location = new Point(21, 37);
            lbTittleNgayDT.Name = "lbTittleNgayDT";
            lbTittleNgayDT.Size = new Size(74, 30);
            lbTittleNgayDT.TabIndex = 1;
            lbTittleNgayDT.Text = "Ngày:";
            // 
            // dtpTKNgayDT
            // 
            dtpTKNgayDT.CustomFormat = "dd/MM/yyyy";
            dtpTKNgayDT.Font = new Font("Segoe UI", 11F);
            dtpTKNgayDT.Format = DateTimePickerFormat.Custom;
            dtpTKNgayDT.Location = new Point(180, 37);
            dtpTKNgayDT.Name = "dtpTKNgayDT";
            dtpTKNgayDT.Size = new Size(232, 37);
            dtpTKNgayDT.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pnTKTGMayTram);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(480, 839);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Máy Trạm";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnTKTGMayTram
            // 
            pnTKTGMayTram.BorderStyle = BorderStyle.FixedSingle;
            pnTKTGMayTram.Controls.Add(pnDTTungMT);
            pnTKTGMayTram.Controls.Add(pnTGNhieuItMT);
            pnTKTGMayTram.Controls.Add(pnTKGioTheoThangMT);
            pnTKTGMayTram.Location = new Point(6, 6);
            pnTKTGMayTram.Name = "pnTKTGMayTram";
            pnTKTGMayTram.Size = new Size(468, 827);
            pnTKTGMayTram.TabIndex = 0;
            // 
            // pnDTTungMT
            // 
            pnDTTungMT.BorderStyle = BorderStyle.FixedSingle;
            pnDTTungMT.Controls.Add(pnKhungDTTungMT);
            pnDTTungMT.Controls.Add(lbDTTungMT);
            pnDTTungMT.Location = new Point(12, 503);
            pnDTTungMT.Name = "pnDTTungMT";
            pnDTTungMT.Size = new Size(431, 190);
            pnDTTungMT.TabIndex = 9;
            // 
            // pnKhungDTTungMT
            // 
            pnKhungDTTungMT.BorderStyle = BorderStyle.FixedSingle;
            pnKhungDTTungMT.Controls.Add(panel6);
            pnKhungDTTungMT.Controls.Add(btnDTTungMT);
            pnKhungDTTungMT.Controls.Add(lbThangDTTungMT);
            pnKhungDTTungMT.Controls.Add(dtpDTTungMT);
            pnKhungDTTungMT.Location = new Point(13, 48);
            pnKhungDTTungMT.Name = "pnKhungDTTungMT";
            pnKhungDTTungMT.Size = new Size(401, 127);
            pnKhungDTTungMT.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Controls.Add(label4);
            panel6.Controls.Add(dateTimePicker1);
            panel6.Location = new Point(2, -295);
            panel6.Name = "panel6";
            panel6.Size = new Size(401, 172);
            panel6.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(22, 17);
            label4.Name = "label4";
            label4.Size = new Size(84, 30);
            label4.TabIndex = 1;
            label4.Text = "Tháng:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(140, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 37);
            dateTimePicker1.TabIndex = 0;
            // 
            // btnDTTungMT
            // 
            btnDTTungMT.Location = new Point(119, 77);
            btnDTTungMT.Name = "btnDTTungMT";
            btnDTTungMT.Size = new Size(161, 34);
            btnDTTungMT.TabIndex = 3;
            btnDTTungMT.Text = "Thống kê";
            btnDTTungMT.UseVisualStyleBackColor = true;
            btnDTTungMT.Click += btnDTTungMT_Click;
            // 
            // lbThangDTTungMT
            // 
            lbThangDTTungMT.AutoSize = true;
            lbThangDTTungMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbThangDTTungMT.Location = new Point(21, 20);
            lbThangDTTungMT.Name = "lbThangDTTungMT";
            lbThangDTTungMT.Size = new Size(84, 30);
            lbThangDTTungMT.TabIndex = 1;
            lbThangDTTungMT.Text = "Tháng:";
            // 
            // dtpDTTungMT
            // 
            dtpDTTungMT.CustomFormat = "MM/yyyy";
            dtpDTTungMT.Font = new Font("Segoe UI", 11F);
            dtpDTTungMT.Format = DateTimePickerFormat.Custom;
            dtpDTTungMT.Location = new Point(139, 20);
            dtpDTTungMT.Name = "dtpDTTungMT";
            dtpDTTungMT.Size = new Size(240, 37);
            dtpDTTungMT.TabIndex = 0;
            // 
            // lbDTTungMT
            // 
            lbDTTungMT.AutoSize = true;
            lbDTTungMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbDTTungMT.ForeColor = SystemColors.HotTrack;
            lbDTTungMT.Location = new Point(13, 15);
            lbDTTungMT.Name = "lbDTTungMT";
            lbDTTungMT.Size = new Size(404, 30);
            lbDTTungMT.TabIndex = 1;
            lbDTTungMT.Text = "Doanh thu tháng theo từng máy trạm";
            // 
            // pnTGNhieuItMT
            // 
            pnTGNhieuItMT.BorderStyle = BorderStyle.FixedSingle;
            pnTGNhieuItMT.Controls.Add(pnKhungTGNhieuItMT);
            pnTGNhieuItMT.Controls.Add(lbTittleTGNhieuItMT);
            pnTGNhieuItMT.Location = new Point(12, 13);
            pnTGNhieuItMT.Name = "pnTGNhieuItMT";
            pnTGNhieuItMT.Size = new Size(431, 265);
            pnTGNhieuItMT.TabIndex = 8;
            // 
            // pnKhungTGNhieuItMT
            // 
            pnKhungTGNhieuItMT.BorderStyle = BorderStyle.FixedSingle;
            pnKhungTGNhieuItMT.Controls.Add(txtTGNhieuMT);
            pnKhungTGNhieuItMT.Controls.Add(txtTGItMT);
            pnKhungTGNhieuItMT.Controls.Add(lbTGItMT);
            pnKhungTGNhieuItMT.Controls.Add(lbTGNhieuMT);
            pnKhungTGNhieuItMT.Controls.Add(lbThangTGNhieuItMT);
            pnKhungTGNhieuItMT.Controls.Add(btnTGNhieuItMT);
            pnKhungTGNhieuItMT.Controls.Add(dtpThangTGNhieuItMT);
            pnKhungTGNhieuItMT.Location = new Point(13, 47);
            pnKhungTGNhieuItMT.Name = "pnKhungTGNhieuItMT";
            pnKhungTGNhieuItMT.Size = new Size(401, 203);
            pnKhungTGNhieuItMT.TabIndex = 0;
            // 
            // txtTGNhieuMT
            // 
            txtTGNhieuMT.Location = new Point(21, 152);
            txtTGNhieuMT.Name = "txtTGNhieuMT";
            txtTGNhieuMT.Size = new Size(174, 34);
            txtTGNhieuMT.TabIndex = 5;
            // 
            // txtTGItMT
            // 
            txtTGItMT.Location = new Point(201, 152);
            txtTGItMT.Name = "txtTGItMT";
            txtTGItMT.Size = new Size(179, 34);
            txtTGItMT.TabIndex = 4;
            // 
            // lbTGItMT
            // 
            lbTGItMT.AutoSize = true;
            lbTGItMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTGItMT.Location = new Point(201, 119);
            lbTGItMT.Name = "lbTGItMT";
            lbTGItMT.Size = new Size(88, 30);
            lbTGItMT.TabIndex = 1;
            lbTGItMT.Text = "Ít nhất:";
            // 
            // lbTGNhieuMT
            // 
            lbTGNhieuMT.AutoSize = true;
            lbTGNhieuMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTGNhieuMT.Location = new Point(21, 119);
            lbTGNhieuMT.Name = "lbTGNhieuMT";
            lbTGNhieuMT.Size = new Size(127, 30);
            lbTGNhieuMT.TabIndex = 1;
            lbTGNhieuMT.Text = "Nhiều nhất";
            // 
            // lbThangTGNhieuItMT
            // 
            lbThangTGNhieuItMT.AutoSize = true;
            lbThangTGNhieuItMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbThangTGNhieuItMT.Location = new Point(22, 17);
            lbThangTGNhieuItMT.Name = "lbThangTGNhieuItMT";
            lbThangTGNhieuItMT.Size = new Size(84, 30);
            lbThangTGNhieuItMT.TabIndex = 1;
            lbThangTGNhieuItMT.Text = "Tháng:";
            // 
            // btnTGNhieuItMT
            // 
            btnTGNhieuItMT.Location = new Point(120, 60);
            btnTGNhieuItMT.Name = "btnTGNhieuItMT";
            btnTGNhieuItMT.Size = new Size(161, 34);
            btnTGNhieuItMT.TabIndex = 3;
            btnTGNhieuItMT.Text = "Thống kê";
            btnTGNhieuItMT.UseVisualStyleBackColor = true;
            btnTGNhieuItMT.Click += btnTGNhieuItMT_Click;
            // 
            // dtpThangTGNhieuItMT
            // 
            dtpThangTGNhieuItMT.CustomFormat = "MM/yyyy";
            dtpThangTGNhieuItMT.Font = new Font("Segoe UI", 11F);
            dtpThangTGNhieuItMT.Format = DateTimePickerFormat.Custom;
            dtpThangTGNhieuItMT.Location = new Point(140, 17);
            dtpThangTGNhieuItMT.Name = "dtpThangTGNhieuItMT";
            dtpThangTGNhieuItMT.Size = new Size(240, 37);
            dtpThangTGNhieuItMT.TabIndex = 0;
            // 
            // lbTittleTGNhieuItMT
            // 
            lbTittleTGNhieuItMT.AutoSize = true;
            lbTittleTGNhieuItMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTittleTGNhieuItMT.ForeColor = SystemColors.HotTrack;
            lbTittleTGNhieuItMT.Location = new Point(13, 14);
            lbTittleTGNhieuItMT.Name = "lbTittleTGNhieuItMT";
            lbTittleTGNhieuItMT.Size = new Size(381, 30);
            lbTittleTGNhieuItMT.TabIndex = 1;
            lbTittleTGNhieuItMT.Text = "Số giờ sử dụng theo tháng của máy";
            // 
            // pnTKGioTheoThangMT
            // 
            pnTKGioTheoThangMT.BorderStyle = BorderStyle.FixedSingle;
            pnTKGioTheoThangMT.Controls.Add(pnKhungGioTheoThangMT);
            pnTKGioTheoThangMT.Controls.Add(lbGioTheoThangMT);
            pnTKGioTheoThangMT.Location = new Point(12, 284);
            pnTKGioTheoThangMT.Name = "pnTKGioTheoThangMT";
            pnTKGioTheoThangMT.Size = new Size(431, 190);
            pnTKGioTheoThangMT.TabIndex = 6;
            // 
            // pnKhungGioTheoThangMT
            // 
            pnKhungGioTheoThangMT.BorderStyle = BorderStyle.FixedSingle;
            pnKhungGioTheoThangMT.Controls.Add(panel7);
            pnKhungGioTheoThangMT.Controls.Add(btnGioTheoThangMT);
            pnKhungGioTheoThangMT.Controls.Add(lbTittleGioTheoThangMT);
            pnKhungGioTheoThangMT.Controls.Add(dtpGioTheoThangMT);
            pnKhungGioTheoThangMT.Location = new Point(13, 48);
            pnKhungGioTheoThangMT.Name = "pnKhungGioTheoThangMT";
            pnKhungGioTheoThangMT.Size = new Size(401, 127);
            pnKhungGioTheoThangMT.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Controls.Add(label5);
            panel7.Controls.Add(dateTimePicker2);
            panel7.Location = new Point(2, -295);
            panel7.Name = "panel7";
            panel7.Size = new Size(401, 172);
            panel7.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(22, 17);
            label5.Name = "label5";
            label5.Size = new Size(84, 30);
            label5.TabIndex = 1;
            label5.Text = "Tháng:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "MM/yyyy";
            dateTimePicker2.Font = new Font("Segoe UI", 11F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(140, 17);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(232, 37);
            dateTimePicker2.TabIndex = 0;
            // 
            // btnGioTheoThangMT
            // 
            btnGioTheoThangMT.Location = new Point(119, 77);
            btnGioTheoThangMT.Name = "btnGioTheoThangMT";
            btnGioTheoThangMT.Size = new Size(161, 34);
            btnGioTheoThangMT.TabIndex = 3;
            btnGioTheoThangMT.Text = "Thống kê";
            btnGioTheoThangMT.UseVisualStyleBackColor = true;
            btnGioTheoThangMT.Click += btnGioTheoThangMT_Click;
            // 
            // lbTittleGioTheoThangMT
            // 
            lbTittleGioTheoThangMT.AutoSize = true;
            lbTittleGioTheoThangMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTittleGioTheoThangMT.Location = new Point(21, 20);
            lbTittleGioTheoThangMT.Name = "lbTittleGioTheoThangMT";
            lbTittleGioTheoThangMT.Size = new Size(84, 30);
            lbTittleGioTheoThangMT.TabIndex = 1;
            lbTittleGioTheoThangMT.Text = "Tháng:";
            // 
            // dtpGioTheoThangMT
            // 
            dtpGioTheoThangMT.CustomFormat = "MM/yyyy";
            dtpGioTheoThangMT.Font = new Font("Segoe UI", 11F);
            dtpGioTheoThangMT.Format = DateTimePickerFormat.Custom;
            dtpGioTheoThangMT.Location = new Point(139, 20);
            dtpGioTheoThangMT.Name = "dtpGioTheoThangMT";
            dtpGioTheoThangMT.Size = new Size(240, 37);
            dtpGioTheoThangMT.TabIndex = 0;
            // 
            // lbGioTheoThangMT
            // 
            lbGioTheoThangMT.AutoSize = true;
            lbGioTheoThangMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbGioTheoThangMT.ForeColor = SystemColors.HotTrack;
            lbGioTheoThangMT.Location = new Point(13, 15);
            lbGioTheoThangMT.Name = "lbGioTheoThangMT";
            lbGioTheoThangMT.Size = new Size(407, 30);
            lbGioTheoThangMT.TabIndex = 1;
            lbGioTheoThangMT.Text = "Số giờ hoạt động tháng của từng máy";
            // 
            // tbTKThucAn
            // 
            tbTKThucAn.Controls.Add(pnTKDoAnTheoTG);
            tbTKThucAn.Location = new Point(4, 37);
            tbTKThucAn.Name = "tbTKThucAn";
            tbTKThucAn.Padding = new Padding(3);
            tbTKThucAn.Size = new Size(480, 839);
            tbTKThucAn.TabIndex = 2;
            tbTKThucAn.Text = "Thức Ăn";
            tbTKThucAn.UseVisualStyleBackColor = true;
            // 
            // pnTKDoAnTheoTG
            // 
            pnTKDoAnTheoTG.BorderStyle = BorderStyle.FixedSingle;
            pnTKDoAnTheoTG.Controls.Add(btnTongSLDADaBan);
            pnTKDoAnTheoTG.Controls.Add(btnDoanhThuTungMonAn);
            pnTKDoAnTheoTG.Controls.Add(btnTKDoAnBanChayNhat);
            pnTKDoAnTheoTG.Controls.Add(pnKhungTKDoAnTheoTG);
            pnTKDoAnTheoTG.Controls.Add(lbTKDoAnTheoTG);
            pnTKDoAnTheoTG.Location = new Point(16, 20);
            pnTKDoAnTheoTG.Name = "pnTKDoAnTheoTG";
            pnTKDoAnTheoTG.Size = new Size(444, 461);
            pnTKDoAnTheoTG.TabIndex = 5;
            // 
            // btnTongSLDADaBan
            // 
            btnTongSLDADaBan.Font = new Font("Segoe UI", 11F);
            btnTongSLDADaBan.Location = new Point(13, 363);
            btnTongSLDADaBan.Name = "btnTongSLDADaBan";
            btnTongSLDADaBan.Size = new Size(417, 43);
            btnTongSLDADaBan.TabIndex = 2;
            btnTongSLDADaBan.Text = "Tổng số lượng bán và tổng doanh thu";
            btnTongSLDADaBan.UseVisualStyleBackColor = true;
            btnTongSLDADaBan.Click += btnTongSLDADaBan_Click_1;
            // 
            // btnDoanhThuTungMonAn
            // 
            btnDoanhThuTungMonAn.Font = new Font("Segoe UI", 11F);
            btnDoanhThuTungMonAn.Location = new Point(13, 297);
            btnDoanhThuTungMonAn.Name = "btnDoanhThuTungMonAn";
            btnDoanhThuTungMonAn.Size = new Size(417, 43);
            btnDoanhThuTungMonAn.TabIndex = 2;
            btnDoanhThuTungMonAn.Text = "Doanh thu của từng món ăn";
            btnDoanhThuTungMonAn.UseVisualStyleBackColor = true;
            // 
            // btnTKDoAnBanChayNhat
            // 
            btnTKDoAnBanChayNhat.Font = new Font("Segoe UI", 11F);
            btnTKDoAnBanChayNhat.Location = new Point(13, 235);
            btnTKDoAnBanChayNhat.Name = "btnTKDoAnBanChayNhat";
            btnTKDoAnBanChayNhat.Size = new Size(417, 43);
            btnTKDoAnBanChayNhat.TabIndex = 2;
            btnTKDoAnBanChayNhat.Text = "Món ăn bán chạy nhất";
            btnTKDoAnBanChayNhat.UseVisualStyleBackColor = true;
            // 
            // pnKhungTKDoAnTheoTG
            // 
            pnKhungTKDoAnTheoTG.BorderStyle = BorderStyle.FixedSingle;
            pnKhungTKDoAnTheoTG.Controls.Add(lbTKDoANNgayKT);
            pnKhungTKDoAnTheoTG.Controls.Add(lbTKDoAnNgayBD);
            pnKhungTKDoAnTheoTG.Controls.Add(dtpTKDoAnNgayKT);
            pnKhungTKDoAnTheoTG.Controls.Add(dtpTKDoAnNgayBD);
            pnKhungTKDoAnTheoTG.Location = new Point(13, 44);
            pnKhungTKDoAnTheoTG.Name = "pnKhungTKDoAnTheoTG";
            pnKhungTKDoAnTheoTG.Size = new Size(417, 167);
            pnKhungTKDoAnTheoTG.TabIndex = 2;
            // 
            // lbTKDoANNgayKT
            // 
            lbTKDoANNgayKT.AutoSize = true;
            lbTKDoANNgayKT.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbTKDoANNgayKT.Location = new Point(14, 68);
            lbTKDoANNgayKT.Name = "lbTKDoANNgayKT";
            lbTKDoANNgayKT.Size = new Size(113, 30);
            lbTKDoANNgayKT.TabIndex = 1;
            lbTKDoANNgayKT.Text = "Đến ngày:";
            // 
            // lbTKDoAnNgayBD
            // 
            lbTKDoAnNgayBD.AutoSize = true;
            lbTKDoAnNgayBD.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbTKDoAnNgayBD.Location = new Point(14, 16);
            lbTKDoAnNgayBD.Name = "lbTKDoAnNgayBD";
            lbTKDoAnNgayBD.Size = new Size(98, 30);
            lbTKDoAnNgayBD.TabIndex = 1;
            lbTKDoAnNgayBD.Text = "Từ ngày:";
            // 
            // dtpTKDoAnNgayKT
            // 
            dtpTKDoAnNgayKT.Font = new Font("Segoe UI", 11F);
            dtpTKDoAnNgayKT.Format = DateTimePickerFormat.Custom;
            dtpTKDoAnNgayKT.Location = new Point(148, 63);
            dtpTKDoAnNgayKT.Name = "dtpTKDoAnNgayKT";
            dtpTKDoAnNgayKT.Size = new Size(253, 37);
            dtpTKDoAnNgayKT.TabIndex = 0;
            // 
            // dtpTKDoAnNgayBD
            // 
            dtpTKDoAnNgayBD.Font = new Font("Segoe UI", 11F);
            dtpTKDoAnNgayBD.Format = DateTimePickerFormat.Custom;
            dtpTKDoAnNgayBD.Location = new Point(148, 16);
            dtpTKDoAnNgayBD.Name = "dtpTKDoAnNgayBD";
            dtpTKDoAnNgayBD.Size = new Size(253, 37);
            dtpTKDoAnNgayBD.TabIndex = 0;
            // 
            // lbTKDoAnTheoTG
            // 
            lbTKDoAnTheoTG.AutoSize = true;
            lbTKDoAnTheoTG.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTKDoAnTheoTG.Location = new Point(13, 11);
            lbTKDoAnTheoTG.Name = "lbTKDoAnTheoTG";
            lbTKDoAnTheoTG.Size = new Size(267, 30);
            lbTKDoAnTheoTG.TabIndex = 2;
            lbTKDoAnTheoTG.Text = "Thống kê theo thời gian:";
            // 
            // tnTKKhachHang
            // 
            tnTKKhachHang.Controls.Add(pnTongTieuKH);
            tnTKKhachHang.Controls.Add(pnSLKhachMoiKH);
            tnTKKhachHang.Controls.Add(pnTKKHVip);
            tnTKKhachHang.Controls.Add(pnTKLenhKH);
            tnTKKhachHang.Location = new Point(4, 37);
            tnTKKhachHang.Name = "tnTKKhachHang";
            tnTKKhachHang.Padding = new Padding(3);
            tnTKKhachHang.Size = new Size(480, 839);
            tnTKKhachHang.TabIndex = 3;
            tnTKKhachHang.Text = "Khách Hàng";
            tnTKKhachHang.UseVisualStyleBackColor = true;
            // 
            // pnTongTieuKH
            // 
            pnTongTieuKH.BorderStyle = BorderStyle.FixedSingle;
            pnTongTieuKH.Controls.Add(pnKhungTongTieu);
            pnTongTieuKH.Controls.Add(lbTKTittleTongTieuKH);
            pnTongTieuKH.Location = new Point(13, 639);
            pnTongTieuKH.Name = "pnTongTieuKH";
            pnTongTieuKH.Size = new Size(455, 194);
            pnTongTieuKH.TabIndex = 7;
            // 
            // pnKhungTongTieu
            // 
            pnKhungTongTieu.BorderStyle = BorderStyle.FixedSingle;
            pnKhungTongTieu.Controls.Add(cbxTenKhachHang);
            pnKhungTongTieu.Controls.Add(btnTKTongTieuKH);
            pnKhungTongTieu.Controls.Add(lbTenKHTongTieu);
            pnKhungTongTieu.Location = new Point(13, 38);
            pnKhungTongTieu.Name = "pnKhungTongTieu";
            pnKhungTongTieu.Size = new Size(423, 140);
            pnKhungTongTieu.TabIndex = 5;
            // 
            // cbxTenKhachHang
            // 
            cbxTenKhachHang.FormattingEnabled = true;
            cbxTenKhachHang.Location = new Point(15, 41);
            cbxTenKhachHang.Name = "cbxTenKhachHang";
            cbxTenKhachHang.Size = new Size(386, 36);
            cbxTenKhachHang.TabIndex = 5;
            // 
            // btnTKTongTieuKH
            // 
            btnTKTongTieuKH.Location = new Point(133, 81);
            btnTKTongTieuKH.Name = "btnTKTongTieuKH";
            btnTKTongTieuKH.Size = new Size(146, 43);
            btnTKTongTieuKH.TabIndex = 4;
            btnTKTongTieuKH.Text = "Thống kê";
            btnTKTongTieuKH.UseVisualStyleBackColor = true;
            btnTKTongTieuKH.Click += btnTKTongTieuKH_Click;
            // 
            // lbTenKHTongTieu
            // 
            lbTenKHTongTieu.AutoSize = true;
            lbTenKHTongTieu.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbTenKHTongTieu.Location = new Point(15, 8);
            lbTenKHTongTieu.Name = "lbTenKHTongTieu";
            lbTenKHTongTieu.Size = new Size(174, 30);
            lbTenKHTongTieu.TabIndex = 1;
            lbTenKHTongTieu.Text = "Tên khách hàng:";
            // 
            // lbTKTittleTongTieuKH
            // 
            lbTKTittleTongTieuKH.AutoSize = true;
            lbTKTittleTongTieuKH.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTKTittleTongTieuKH.Location = new Point(13, 5);
            lbTKTittleTongTieuKH.Name = "lbTKTittleTongTieuKH";
            lbTKTittleTongTieuKH.Size = new Size(380, 30);
            lbTKTittleTongTieuKH.TabIndex = 2;
            lbTKTittleTongTieuKH.Text = "Tổng số tiền khách hàng đã chi tiêu";
            // 
            // pnSLKhachMoiKH
            // 
            pnSLKhachMoiKH.BorderStyle = BorderStyle.FixedSingle;
            pnSLKhachMoiKH.Controls.Add(pnKhungSLKhachMoi);
            pnSLKhachMoiKH.Controls.Add(lbTKTittleSLKhachMoi);
            pnSLKhachMoiKH.Location = new Point(13, 417);
            pnSLKhachMoiKH.Name = "pnSLKhachMoiKH";
            pnSLKhachMoiKH.Size = new Size(455, 216);
            pnSLKhachMoiKH.TabIndex = 6;
            // 
            // pnKhungSLKhachMoi
            // 
            pnKhungSLKhachMoi.BorderStyle = BorderStyle.FixedSingle;
            pnKhungSLKhachMoi.Controls.Add(txtKQThangKhachMoi);
            pnKhungSLKhachMoi.Controls.Add(btnChiTietSLKhachMoi);
            pnKhungSLKhachMoi.Controls.Add(btnSLKhachMoi);
            pnKhungSLKhachMoi.Controls.Add(dtpThangKhachMoi);
            pnKhungSLKhachMoi.Controls.Add(lbKQThangKhachMoi);
            pnKhungSLKhachMoi.Controls.Add(lbThangSLKhachMoi);
            pnKhungSLKhachMoi.Location = new Point(13, 44);
            pnKhungSLKhachMoi.Name = "pnKhungSLKhachMoi";
            pnKhungSLKhachMoi.Size = new Size(423, 167);
            pnKhungSLKhachMoi.TabIndex = 4;
            // 
            // txtKQThangKhachMoi
            // 
            txtKQThangKhachMoi.Location = new Point(148, 62);
            txtKQThangKhachMoi.Name = "txtKQThangKhachMoi";
            txtKQThangKhachMoi.Size = new Size(253, 34);
            txtKQThangKhachMoi.TabIndex = 5;
            // 
            // btnChiTietSLKhachMoi
            // 
            btnChiTietSLKhachMoi.Location = new Point(207, 102);
            btnChiTietSLKhachMoi.Name = "btnChiTietSLKhachMoi";
            btnChiTietSLKhachMoi.Size = new Size(182, 46);
            btnChiTietSLKhachMoi.TabIndex = 4;
            btnChiTietSLKhachMoi.Text = "Thông tin chi tiết";
            btnChiTietSLKhachMoi.UseVisualStyleBackColor = true;
            btnChiTietSLKhachMoi.Click += btnChiTietSLKhachMoi_Click;
            // 
            // btnSLKhachMoi
            // 
            btnSLKhachMoi.Location = new Point(34, 102);
            btnSLKhachMoi.Name = "btnSLKhachMoi";
            btnSLKhachMoi.Size = new Size(146, 46);
            btnSLKhachMoi.TabIndex = 4;
            btnSLKhachMoi.Text = "Thống kê";
            btnSLKhachMoi.UseVisualStyleBackColor = true;
            btnSLKhachMoi.Click += btnSLKhachMoi_Click;
            // 
            // dtpThangKhachMoi
            // 
            dtpThangKhachMoi.CustomFormat = "MM/yyyy";
            dtpThangKhachMoi.Font = new Font("Segoe UI", 11F);
            dtpThangKhachMoi.Format = DateTimePickerFormat.Custom;
            dtpThangKhachMoi.Location = new Point(148, 19);
            dtpThangKhachMoi.Name = "dtpThangKhachMoi";
            dtpThangKhachMoi.ShowUpDown = true;
            dtpThangKhachMoi.Size = new Size(253, 37);
            dtpThangKhachMoi.TabIndex = 0;
            // 
            // lbKQThangKhachMoi
            // 
            lbKQThangKhachMoi.AutoSize = true;
            lbKQThangKhachMoi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbKQThangKhachMoi.Location = new Point(14, 62);
            lbKQThangKhachMoi.Name = "lbKQThangKhachMoi";
            lbKQThangKhachMoi.Size = new Size(94, 30);
            lbKQThangKhachMoi.TabIndex = 1;
            lbKQThangKhachMoi.Text = "Kết quả:";
            // 
            // lbThangSLKhachMoi
            // 
            lbThangSLKhachMoi.AutoSize = true;
            lbThangSLKhachMoi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbThangSLKhachMoi.Location = new Point(14, 19);
            lbThangSLKhachMoi.Name = "lbThangSLKhachMoi";
            lbThangSLKhachMoi.Size = new Size(80, 30);
            lbThangSLKhachMoi.TabIndex = 1;
            lbThangSLKhachMoi.Text = "Tháng:";
            // 
            // lbTKTittleSLKhachMoi
            // 
            lbTKTittleSLKhachMoi.AutoSize = true;
            lbTKTittleSLKhachMoi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTKTittleSLKhachMoi.Location = new Point(13, 11);
            lbTKTittleSLKhachMoi.Name = "lbTKTittleSLKhachMoi";
            lbTKTittleSLKhachMoi.Size = new Size(219, 30);
            lbTKTittleSLKhachMoi.TabIndex = 2;
            lbTKTittleSLKhachMoi.Text = "Số lượng khách mới";
            // 
            // pnTKKHVip
            // 
            pnTKKHVip.BorderStyle = BorderStyle.FixedSingle;
            pnTKKHVip.Controls.Add(pnTKKhungDVnhieuKH);
            pnTKKHVip.Controls.Add(lbTKTittleSDnhieuKH);
            pnTKKHVip.Location = new Point(13, 18);
            pnTKKHVip.Name = "pnTKKHVip";
            pnTKKHVip.Size = new Size(455, 137);
            pnTKKHVip.TabIndex = 5;
            // 
            // pnTKKhungDVnhieuKH
            // 
            pnTKKhungDVnhieuKH.BorderStyle = BorderStyle.FixedSingle;
            pnTKKhungDVnhieuKH.Controls.Add(btnTGDVnhieuKH);
            pnTKKhungDVnhieuKH.Controls.Add(label7);
            pnTKKhungDVnhieuKH.Location = new Point(13, 45);
            pnTKKhungDVnhieuKH.Name = "pnTKKhungDVnhieuKH";
            pnTKKhungDVnhieuKH.Size = new Size(423, 77);
            pnTKKhungDVnhieuKH.TabIndex = 3;
            // 
            // btnTGDVnhieuKH
            // 
            btnTGDVnhieuKH.Location = new Point(256, 16);
            btnTGDVnhieuKH.Name = "btnTGDVnhieuKH";
            btnTGDVnhieuKH.Size = new Size(146, 46);
            btnTGDVnhieuKH.TabIndex = 4;
            btnTGDVnhieuKH.Text = "Thống kê";
            btnTGDVnhieuKH.UseVisualStyleBackColor = true;
            btnTGDVnhieuKH.Click += btnTGDVnhieuKH_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(14, 24);
            label7.Name = "label7";
            label7.Size = new Size(235, 30);
            label7.TabIndex = 2;
            label7.Text = "TOP 5 KHÁCH HÀNG:";
            // 
            // lbTKTittleSDnhieuKH
            // 
            lbTKTittleSDnhieuKH.AutoSize = true;
            lbTKTittleSDnhieuKH.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTKTittleSDnhieuKH.Location = new Point(13, 12);
            lbTKTittleSDnhieuKH.Name = "lbTKTittleSDnhieuKH";
            lbTKTittleSDnhieuKH.Size = new Size(297, 30);
            lbTKTittleSDnhieuKH.TabIndex = 2;
            lbTKTittleSDnhieuKH.Text = "Sử dụng dịch vụ nhiều nhất";
            // 
            // pnTKLenhKH
            // 
            pnTKLenhKH.BorderStyle = BorderStyle.FixedSingle;
            pnTKLenhKH.Controls.Add(pnTKKhungThangKH);
            pnTKLenhKH.Controls.Add(lbTKTittleThangKH);
            pnTKLenhKH.Location = new Point(13, 174);
            pnTKLenhKH.Name = "pnTKLenhKH";
            pnTKLenhKH.Size = new Size(455, 226);
            pnTKLenhKH.TabIndex = 4;
            // 
            // pnTKKhungThangKH
            // 
            pnTKKhungThangKH.BorderStyle = BorderStyle.FixedSingle;
            pnTKKhungThangKH.Controls.Add(btnTKXemKH);
            pnTKKhungThangKH.Controls.Add(StTKEndKH);
            pnTKKhungThangKH.Controls.Add(lbTKStartKH);
            pnTKKhungThangKH.Controls.Add(dtpTKEndKH);
            pnTKKhungThangKH.Controls.Add(dtpTKStartKH);
            pnTKKhungThangKH.Location = new Point(13, 42);
            pnTKKhungThangKH.Name = "pnTKKhungThangKH";
            pnTKKhungThangKH.Size = new Size(426, 167);
            pnTKKhungThangKH.TabIndex = 2;
            // 
            // btnTKXemKH
            // 
            btnTKXemKH.Font = new Font("Segoe UI", 11F);
            btnTKXemKH.Location = new Point(133, 106);
            btnTKXemKH.Name = "btnTKXemKH";
            btnTKXemKH.Size = new Size(146, 43);
            btnTKXemKH.TabIndex = 2;
            btnTKXemKH.Text = "Thống kê";
            btnTKXemKH.UseVisualStyleBackColor = true;
            btnTKXemKH.Click += btnTKXemKH_Click;
            // 
            // StTKEndKH
            // 
            StTKEndKH.AutoSize = true;
            StTKEndKH.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            StTKEndKH.Location = new Point(14, 68);
            StTKEndKH.Name = "StTKEndKH";
            StTKEndKH.Size = new Size(113, 30);
            StTKEndKH.TabIndex = 1;
            StTKEndKH.Text = "Đến ngày:";
            // 
            // lbTKStartKH
            // 
            lbTKStartKH.AutoSize = true;
            lbTKStartKH.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbTKStartKH.Location = new Point(14, 16);
            lbTKStartKH.Name = "lbTKStartKH";
            lbTKStartKH.Size = new Size(98, 30);
            lbTKStartKH.TabIndex = 1;
            lbTKStartKH.Text = "Từ ngày:";
            // 
            // dtpTKEndKH
            // 
            dtpTKEndKH.Font = new Font("Segoe UI", 11F);
            dtpTKEndKH.Format = DateTimePickerFormat.Custom;
            dtpTKEndKH.Location = new Point(148, 63);
            dtpTKEndKH.Name = "dtpTKEndKH";
            dtpTKEndKH.Size = new Size(253, 37);
            dtpTKEndKH.TabIndex = 0;
            // 
            // dtpTKStartKH
            // 
            dtpTKStartKH.Font = new Font("Segoe UI", 11F);
            dtpTKStartKH.Format = DateTimePickerFormat.Custom;
            dtpTKStartKH.Location = new Point(148, 16);
            dtpTKStartKH.Name = "dtpTKStartKH";
            dtpTKStartKH.Size = new Size(253, 37);
            dtpTKStartKH.TabIndex = 0;
            // 
            // lbTKTittleThangKH
            // 
            lbTKTittleThangKH.AutoSize = true;
            lbTKTittleThangKH.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTKTittleThangKH.Location = new Point(13, 9);
            lbTKTittleThangKH.Name = "lbTKTittleThangKH";
            lbTKTittleThangKH.Size = new Size(267, 30);
            lbTKTittleThangKH.TabIndex = 2;
            lbTKTittleThangKH.Text = "Thống kê theo thời gian:";
            // 
            // pnTKNutChucNangTK
            // 
            pnTKNutChucNangTK.BorderStyle = BorderStyle.FixedSingle;
            pnTKNutChucNangTK.Controls.Add(label11);
            pnTKNutChucNangTK.Controls.Add(label12);
            pnTKNutChucNangTK.Controls.Add(btnTKSoDo);
            pnTKNutChucNangTK.Controls.Add(btnTKXuatFile);
            pnTKNutChucNangTK.Controls.Add(btnTKQLUngDung);
            pnTKNutChucNangTK.Location = new Point(18, 0);
            pnTKNutChucNangTK.Margin = new Padding(4, 5, 4, 5);
            pnTKNutChucNangTK.Name = "pnTKNutChucNangTK";
            pnTKNutChucNangTK.Size = new Size(1542, 93);
            pnTKNutChucNangTK.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(163, 26);
            label11.Name = "label11";
            label11.Size = new Size(136, 32);
            label11.TabIndex = 6;
            label11.Text = "THỐNG KÊ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(28, 26);
            label12.Name = "label12";
            label12.Size = new Size(129, 32);
            label12.TabIndex = 5;
            label12.Text = "⟲ Home >";
            label12.Click += label12_Click;
            // 
            // btnTKSoDo
            // 
            btnTKSoDo.BackColor = Color.FromArgb(192, 255, 255);
            btnTKSoDo.FlatStyle = FlatStyle.Flat;
            btnTKSoDo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTKSoDo.Location = new Point(841, 16);
            btnTKSoDo.Margin = new Padding(4, 5, 4, 5);
            btnTKSoDo.Name = "btnTKSoDo";
            btnTKSoDo.Size = new Size(160, 52);
            btnTKSoDo.TabIndex = 3;
            btnTKSoDo.Text = "Sơ Đồ";
            btnTKSoDo.UseVisualStyleBackColor = false;
            // 
            // btnTKXuatFile
            // 
            btnTKXuatFile.BackColor = Color.FromArgb(192, 255, 255);
            btnTKXuatFile.FlatStyle = FlatStyle.Flat;
            btnTKXuatFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTKXuatFile.Location = new Point(1053, 16);
            btnTKXuatFile.Margin = new Padding(4, 5, 4, 5);
            btnTKXuatFile.Name = "btnTKXuatFile";
            btnTKXuatFile.Size = new Size(160, 52);
            btnTKXuatFile.TabIndex = 3;
            btnTKXuatFile.Text = "Xuất File";
            btnTKXuatFile.UseVisualStyleBackColor = false;
            btnTKXuatFile.Click += btnTKXuatFile_Click;
            // 
            // btnTKQLUngDung
            // 
            btnTKQLUngDung.BackColor = Color.FromArgb(192, 255, 255);
            btnTKQLUngDung.FlatStyle = FlatStyle.Flat;
            btnTKQLUngDung.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTKQLUngDung.Location = new Point(1253, 16);
            btnTKQLUngDung.Margin = new Padding(4, 5, 4, 5);
            btnTKQLUngDung.Name = "btnTKQLUngDung";
            btnTKQLUngDung.Size = new Size(254, 52);
            btnTKQLUngDung.TabIndex = 3;
            btnTKQLUngDung.Text = "Quản Lý Ứng Dụng";
            btnTKQLUngDung.UseVisualStyleBackColor = false;
            btnTKQLUngDung.Click += btnTKQLUngDung_Click_1;
            // 
            // cmsKhachHang
            // 
            cmsKhachHang.ImageScalingSize = new Size(20, 20);
            cmsKhachHang.Items.AddRange(new ToolStripItem[] { cmsKhachHang_Them, cmsKhachHang_Nhac, cmsKhachHang_TrangChu });
            cmsKhachHang.Name = "cmsKhachHang";
            cmsKhachHang.Size = new Size(289, 100);
            // 
            // cmsKhachHang_Them
            // 
            cmsKhachHang_Them.Name = "cmsKhachHang_Them";
            cmsKhachHang_Them.ShortcutKeys = Keys.Control | Keys.N;
            cmsKhachHang_Them.Size = new Size(288, 32);
            cmsKhachHang_Them.Text = "Thêm khách hàng";
            cmsKhachHang_Them.Click += cmsKhachHang_Them_Click;
            // 
            // cmsKhachHang_Nhac
            // 
            cmsKhachHang_Nhac.Name = "cmsKhachHang_Nhac";
            cmsKhachHang_Nhac.ShortcutKeys = Keys.Control | Keys.M;
            cmsKhachHang_Nhac.Size = new Size(288, 32);
            cmsKhachHang_Nhac.Text = "Nhạc";
            cmsKhachHang_Nhac.Click += cmsKhachHang_Nhac_Click;
            // 
            // cmsKhachHang_TrangChu
            // 
            cmsKhachHang_TrangChu.Name = "cmsKhachHang_TrangChu";
            cmsKhachHang_TrangChu.ShortcutKeys = Keys.Control | Keys.H;
            cmsKhachHang_TrangChu.Size = new Size(288, 32);
            cmsKhachHang_TrangChu.Text = "Trang chủ";
            cmsKhachHang_TrangChu.Click += cmsKhachHang_TrangChu_Click;
            // 
            // cmsNhanVien
            // 
            cmsNhanVien.ImageScalingSize = new Size(20, 20);
            cmsNhanVien.Items.AddRange(new ToolStripItem[] { cmsNhanVien_Them, cmsNhanVien_Nhac, cmsNhanVien_TrangChu });
            cmsNhanVien.Name = "cmsNhanVien";
            cmsNhanVien.Size = new Size(269, 100);
            // 
            // cmsNhanVien_Them
            // 
            cmsNhanVien_Them.Name = "cmsNhanVien_Them";
            cmsNhanVien_Them.ShortcutKeys = Keys.Alt | Keys.N;
            cmsNhanVien_Them.Size = new Size(268, 32);
            cmsNhanVien_Them.Text = "Thêm nhân viên";
            cmsNhanVien_Them.Click += cmsNhanVien_Them_Click;
            // 
            // cmsNhanVien_Nhac
            // 
            cmsNhanVien_Nhac.Name = "cmsNhanVien_Nhac";
            cmsNhanVien_Nhac.ShortcutKeys = Keys.Control | Keys.M;
            cmsNhanVien_Nhac.Size = new Size(268, 32);
            cmsNhanVien_Nhac.Text = "Nhạc";
            cmsNhanVien_Nhac.Click += cmsNhanVien_Nhac_Click;
            // 
            // cmsNhanVien_TrangChu
            // 
            cmsNhanVien_TrangChu.Name = "cmsNhanVien_TrangChu";
            cmsNhanVien_TrangChu.ShortcutKeys = Keys.Control | Keys.H;
            cmsNhanVien_TrangChu.Size = new Size(268, 32);
            cmsNhanVien_TrangChu.Text = "Trang chủ";
            cmsNhanVien_TrangChu.Click += cmsNhanVien_TrangChu_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1921, 1106);
            Controls.Add(tblMain);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1921, 1192);
            MinimumSize = new Size(1918, 1018);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            KeyDown += frmMain_KeyDown;
            pnlLeft.ResumeLayout(false);
            pnStatictical.ResumeLayout(false);
            pnStatictical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            pnStaff.ResumeLayout(false);
            pnStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            pnServices.ResumeLayout(false);
            pnServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            pnAccount.ResumeLayout(false);
            pnAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            pnComputer.ResumeLayout(false);
            pnComputer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxClose).EndInit();
            tblMain.ResumeLayout(false);
            tbpComputer.ResumeLayout(false);
            pnComputerControl.ResumeLayout(false);
            gbxComputerInfor.ResumeLayout(false);
            pnStatusCom.ResumeLayout(false);
            pnStatusCom.PerformLayout();
            pnTimeCom.ResumeLayout(false);
            pnTimeCom.PerformLayout();
            pnTongTienCom.ResumeLayout(false);
            pnTongTienCom.PerformLayout();
            pnUserNameCom.ResumeLayout(false);
            pnUserNameCom.PerformLayout();
            pnComputerButton.ResumeLayout(false);
            tbpAccount.ResumeLayout(false);
            pnButtonAccount.ResumeLayout(false);
            pnDuongDanAccount.ResumeLayout(false);
            grbKhachHang.ResumeLayout(false);
            pnTimKimAccount.ResumeLayout(false);
            pnTimKimAccount.PerformLayout();
            pnDisplayAccount.ResumeLayout(false);
            tbpServices.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tbpStaff.ResumeLayout(false);
            pnDuongDanStaff.ResumeLayout(false);
            grbQuanLyNhanVien.ResumeLayout(false);
            grbQuanLyNhanVien.PerformLayout();
            pnDisplayStaff.ResumeLayout(false);
            pnStaffControl.ResumeLayout(false);
            tbpStatictical.ResumeLayout(false);
            pnJob.ResumeLayout(false);
            pnTKKhungTK.ResumeLayout(false);
            gbxThongKe.ResumeLayout(false);
            pnTKNut.ResumeLayout(false);
            gbxThongKeTongQuan.ResumeLayout(false);
            gbxThongKeTongQuan.PerformLayout();
            pnTKView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllThongKe).EndInit();
            pnTKThongKe.ResumeLayout(false);
            tbTKMayTram.ResumeLayout(false);
            tbTKDoanhThu.ResumeLayout(false);
            pnTKCongViec.ResumeLayout(false);
            pnTKCongViec.PerformLayout();
            pnTKThangDT.ResumeLayout(false);
            pnTKThangDT.PerformLayout();
            pnTKNamDT.ResumeLayout(false);
            pnTKNamDT.PerformLayout();
            pnTKNgayDT.ResumeLayout(false);
            pnTKNgayDT.PerformLayout();
            tabPage2.ResumeLayout(false);
            pnTKTGMayTram.ResumeLayout(false);
            pnDTTungMT.ResumeLayout(false);
            pnDTTungMT.PerformLayout();
            pnKhungDTTungMT.ResumeLayout(false);
            pnKhungDTTungMT.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            pnTGNhieuItMT.ResumeLayout(false);
            pnTGNhieuItMT.PerformLayout();
            pnKhungTGNhieuItMT.ResumeLayout(false);
            pnKhungTGNhieuItMT.PerformLayout();
            pnTKGioTheoThangMT.ResumeLayout(false);
            pnTKGioTheoThangMT.PerformLayout();
            pnKhungGioTheoThangMT.ResumeLayout(false);
            pnKhungGioTheoThangMT.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tbTKThucAn.ResumeLayout(false);
            pnTKDoAnTheoTG.ResumeLayout(false);
            pnTKDoAnTheoTG.PerformLayout();
            pnKhungTKDoAnTheoTG.ResumeLayout(false);
            pnKhungTKDoAnTheoTG.PerformLayout();
            tnTKKhachHang.ResumeLayout(false);
            pnTongTieuKH.ResumeLayout(false);
            pnTongTieuKH.PerformLayout();
            pnKhungTongTieu.ResumeLayout(false);
            pnKhungTongTieu.PerformLayout();
            pnSLKhachMoiKH.ResumeLayout(false);
            pnSLKhachMoiKH.PerformLayout();
            pnKhungSLKhachMoi.ResumeLayout(false);
            pnKhungSLKhachMoi.PerformLayout();
            pnTKKHVip.ResumeLayout(false);
            pnTKKHVip.PerformLayout();
            pnTKKhungDVnhieuKH.ResumeLayout(false);
            pnTKKhungDVnhieuKH.PerformLayout();
            pnTKLenhKH.ResumeLayout(false);
            pnTKLenhKH.PerformLayout();
            pnTKKhungThangKH.ResumeLayout(false);
            pnTKKhungThangKH.PerformLayout();
            pnTKNutChucNangTK.ResumeLayout(false);
            pnTKNutChucNangTK.PerformLayout();
            cmsKhachHang.ResumeLayout(false);
            cmsNhanVien.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private Panel pnlLeft;
        private System.Windows.Forms.Timer timerToggle;
        private Panel pnlTitleBar;
        private Panel panel2;
        private Label label1;
        private FlowLayoutPanel flpListComputer;
        private DTO.CustomTabControl tblMain;
        private TabPage tbpComputer;
        private FlowLayoutPanel flpComputer;
        private Panel pnComputerControl;
        private Panel panel4;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox3;
        private GroupBox gbxComputerInfor;
        private Panel pnTimeCom;
        private Label lbTimeConLai;
        private TextBox tbxTimeLeft;
        private Panel pnUserNameCom;
        private Label lbUserNameCom;
        private TextBox tbxUserAccount;
        private ListView lvServices;
        private Panel pnStatusCom;
        private Label lbStatusCom;
        private TextBox tbxComputerStatus;
        private Panel pnTongTienCom;
        private Label lbTotalPriceDichVu;
        private TextBox tbxMoneyCost;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Panel pnStatictical;
        private Label label31;
        private Panel pnStaff;
        private Label lblNhanVien;
        private Panel pnServices;
        private Label label29;
        private Panel pnAccount;
        private Label label28;
        private Panel pnComputer;
        private Label label27;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private Panel pnComputerButton;
        private Button btnExtraMoney;
        private Button btnManageComputer;
        private Button btnTrackComputer;
        private Button btnShutDownComputer;
        private Button btnAddServices;
        private Button btnManageAllCom;
        private TabPage tbpAccount;
        private TabPage tbpStaff;
        private TabPage tbpStatictical;
        private Panel panel18;
        private GroupBox grbQuanLyNhanVien;
        private Panel pnDisplayStaff;
        private Panel pnStaffControl;
        private Button btnThemMoi;
        private Button btnXuatFile;
        private Button btn_ThongKe;
        private Panel pnButtonAccount;
        private Button btnThemKhachHang;
        private Button btnNhap;
        private Button button2;
        private Button btn_TroChuyen;
        private Panel pnDuongDanAccount;
        private Label lbCurrentAccountPage;
        private Label lbHomeAccountPage;
        private GroupBox grbKhachHang;
        private Panel pnTimKimAccount;
        private Panel panel26;
        private Panel pnDisplayAccount;
        private TabPage tbpServices;
        private Panel pnJob;
        private TextBox txtTimKiemKhachHang;
        private FlowLayoutPanel flpKhachHang;
        private FlowLayoutPanel flpNhanVien;
        private ComboBox cbxNhomKhach;
        private ComboBox cbxChucVu;
        private ComboBox cbxTrangThai;
        private TextBox txtTimKiem;
        private ContextMenuStrip cmsKhachHang;
        private ToolStripMenuItem cmsKhachHang_Them;
        private ToolStripMenuItem cmsKhachHang_Nhac;
        private ToolStripMenuItem cmsKhachHang_TrangChu;
        private ContextMenuStrip cmsNhanVien;
        private ToolStripMenuItem cmsNhanVien_Them;
        private ToolStripMenuItem cmsNhanVien_Nhac;
        private ToolStripMenuItem cmsNhanVien_TrangChu;
        private PictureBox pbxClose;
        private Panel pnDuongDanStaff;
        private Label lblQuanLyNhanVien;
        private Label lblHome;
        private GroupBox groupBox1;
        private ComboBox cbCategory;
        private Panel panel5;
        private FlowLayoutPanel flpFoodList;
        private TextBox txbSearch;
        private Panel panel3;
        private Button button1;
        private Button button4;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox tbxMoneyAdd;
        private Panel pnTKKhungTK;
        private GroupBox gbxThongKe;
        private Panel pnTKNut;
        private GroupBox gbxThongKeTongQuan;
        private Button btnCapNhatThongKe;
        private ProgressBar pbHieuSuat;
        private TextBox txtTongDichVu;
        private TextBox txtTKTongTienMay;
        private TextBox txtTongGioSuDung;
        private TextBox txtTongDoanhThu;
        private Label lbTongGioSuDung;
        private Label lbTKTongTienMay;
        private Label lbTongDichVu;
        private Label lbTongDoanhThu;
        private Panel pnTKView;
        private DataGridView dgvAllThongKe;
        private Panel pnTKThongKe;
        private TabControl tbTKMayTram;
        private TabPage tbTKDoanhThu;
        private Panel pnTKCongViec;
        private Panel pnTKThangDT;
        private Button btnTKTongDoanhThuThang;
        private Button btnTKThangDT;
        private TextBox txtTKThangDT;
        private Label lbTKThangDT;
        private Label lbTittleThangDT;
        private DateTimePicker dtpTKThangDT;
        private RadioButton rbtTittleNamDT;
        private RadioButton rbtTittleThangDT;
        private RadioButton rbtTittleNgayDT;
        private Panel pnTKNamDT;
        private Button btnTKTongDoanhThuNam;
        private Button btnTKNamDT;
        private TextBox txtTKNamDT;
        private Label lbTKNamDT;
        private Label lbTittleNamDT;
        private DateTimePicker dtpTKNamDT;
        private Panel pnTKNgayDT;
        private Button btnTKTongDoanhThuNgay;
        private Button btnTKNgayDT;
        private TextBox txtTKNgayDT;
        private Label lbTKNgayDT;
        private Label lbTittleNgayDT;
        private DateTimePicker dtpTKNgayDT;
        private TabPage tabPage2;
        private Panel pnTKTGMayTram;
        private Panel pnDTTungMT;
        private Panel pnKhungDTTungMT;
        private Panel panel6;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button btnDTTungMT;
        private Label lbThangDTTungMT;
        private DateTimePicker dtpDTTungMT;
        private Label lbDTTungMT;
        private Panel pnTGNhieuItMT;
        private Panel pnKhungTGNhieuItMT;
        private TextBox txtTGNhieuMT;
        private TextBox txtTGItMT;
        private Label lbTGItMT;
        private Label lbTGNhieuMT;
        private Label lbThangTGNhieuItMT;
        private Button btnTGNhieuItMT;
        private DateTimePicker dtpThangTGNhieuItMT;
        private Label lbTittleTGNhieuItMT;
        private Panel pnTKGioTheoThangMT;
        private Panel pnKhungGioTheoThangMT;
        private Panel panel7;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Button btnGioTheoThangMT;
        private Label lbTittleGioTheoThangMT;
        private DateTimePicker dtpGioTheoThangMT;
        private Label lbGioTheoThangMT;
        private TabPage tbTKThucAn;
        private Panel pnTKDoAnTheoTG;
        private Button btnTongSLDADaBan;
        private Button btnDoanhThuTungMonAn;
        private Button btnTKDoAnBanChayNhat;
        private Panel pnKhungTKDoAnTheoTG;
        private Label lbTKDoANNgayKT;
        private Label lbTKDoAnNgayBD;
        private DateTimePicker dtpTKDoAnNgayKT;
        private DateTimePicker dtpTKDoAnNgayBD;
        private Label lbTKDoAnTheoTG;
        private TabPage tnTKKhachHang;
        private Panel pnTongTieuKH;
        private Panel pnKhungTongTieu;
        private Button btnTKTongTieuKH;
        private Label lbTenKHTongTieu;
        private Label lbTKTittleTongTieuKH;
        private Panel pnSLKhachMoiKH;
        private Panel pnKhungSLKhachMoi;
        private TextBox txtKQThangKhachMoi;
        private Button btnChiTietSLKhachMoi;
        private Button btnSLKhachMoi;
        private DateTimePicker dtpThangKhachMoi;
        private Label lbKQThangKhachMoi;
        private Label lbThangSLKhachMoi;
        private Label lbTKTittleSLKhachMoi;
        private Panel pnTKKHVip;
        private Panel pnTKKhungDVnhieuKH;
        private Button btnTGDVnhieuKH;
        private Label label7;
        private Label lbTKTittleSDnhieuKH;
        private Panel pnTKLenhKH;
        private Panel pnTKKhungThangKH;
        private Button btnTKXemKH;
        private Label StTKEndKH;
        private Label lbTKStartKH;
        private DateTimePicker dtpTKEndKH;
        private DateTimePicker dtpTKStartKH;
        private Label lbTKTittleThangKH;
        private Panel pnTKNutChucNangTK;
        private Label label11;
        private Label label12;
        private Button btnTKSoDo;
        private Button btnTKXuatFile;
        private Button btnTKQLUngDung;
        private ComboBox cbxTenKhachHang;
    }
}