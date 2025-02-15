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
            lbTotalPriceDichVu = new Label();
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
            btnForceStop = new Button();
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
            txtTongGioSuDung = new TextBox();
            txtTongDoanhThu = new TextBox();
            lbTongGioSuDung = new Label();
            lbTongDichVu = new Label();
            lbTongDoanhThu = new Label();
            pnTKView = new Panel();
            dgvAllThongKe = new DataGridView();
            pnTKThongKe = new Panel();
            tbTKMayTram = new TabControl();
            tbTKDoanhThu = new TabPage();
            pnTKCongViec = new Panel();
            pnTKThangDT = new Panel();
            btnTKThangDT = new Button();
            tbTKThangDT = new TextBox();
            lbTKThangDT = new Label();
            lbTittleThangDT = new Label();
            dtpTKThangDT = new DateTimePicker();
            rbtTittleNamDT = new RadioButton();
            rbtTittleThangDT = new RadioButton();
            rbtTittleNgayDT = new RadioButton();
            pnTKNamDT = new Panel();
            btnTKNamDT = new Button();
            tbTKNamDT = new TextBox();
            lbTKNamDT = new Label();
            lbTittleNamDT = new Label();
            dtpTKNamDT = new DateTimePicker();
            pnTKNgayDT = new Panel();
            btnTKNgayDT = new Button();
            tbTKNgayDT = new TextBox();
            lbTKNgayDT = new Label();
            lbTittleNgayDT = new Label();
            dtpTKNgayDT = new DateTimePicker();
            tabPage2 = new TabPage();
            pnTKTGMayTram = new Panel();
            panel6 = new Panel();
            btnTKNamMT = new Button();
            lbTittleNamMT = new Label();
            dtpTKNamMT = new DateTimePicker();
            panel7 = new Panel();
            btnTKThangMT = new Button();
            lbTittleThangMT = new Label();
            dtpTKThangMT = new DateTimePicker();
            panel8 = new Panel();
            btnTKNgayMT = new Button();
            lbTittleNgayMT = new Label();
            dtpTKNgayMT = new DateTimePicker();
            rbtTittleNamMT = new RadioButton();
            rbtTittleThangMT = new RadioButton();
            rbtTittleNgayMT = new RadioButton();
            tbTKThucAn = new TabPage();
            lbLoaiTKThucAn = new Label();
            btnTKChucNangTA = new Button();
            cbxTKThucAn = new ComboBox();
            tnTKKhachHang = new TabPage();
            pnTKChucNangKH = new Panel();
            btnTKKhacKH = new Button();
            lbTKKhacKH = new Label();
            cbxTKKhacKH = new ComboBox();
            pnTKKHVip = new Panel();
            btnTKXemKHTop = new Button();
            lbTKKHVip = new Label();
            pnTKLenhKH = new Panel();
            pnTKKhungThangKH = new Panel();
            btnTKXemKH = new Button();
            StTKEndKH = new Label();
            lbTKStartKH = new Label();
            dtpTKEndKH = new DateTimePicker();
            dtpTKStartKH = new DateTimePicker();
            lbTKTittleThangKH = new Label();
            pnTKNutChucNangTK = new Panel();
            label4 = new Label();
            label5 = new Label();
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
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            tbTKThucAn.SuspendLayout();
            tnTKKhachHang.SuspendLayout();
            pnTKChucNangKH.SuspendLayout();
            pnTKKHVip.SuspendLayout();
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
            pnlLeft.Location = new Point(0, 66);
            pnlLeft.Margin = new Padding(4, 5, 4, 5);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(309, 1146);
            pnlLeft.TabIndex = 0;
            // 
            // pnStatictical
            // 
            pnStatictical.Controls.Add(pictureBox12);
            pnStatictical.Controls.Add(label31);
            pnStatictical.Location = new Point(11, 920);
            pnStatictical.Margin = new Padding(4, 5, 4, 5);
            pnStatictical.Name = "pnStatictical";
            pnStatictical.Size = new Size(286, 134);
            pnStatictical.TabIndex = 3;
            pnStatictical.Click += pnStatictical_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.bill;
            pictureBox12.Location = new Point(11, 26);
            pictureBox12.Margin = new Padding(4, 5, 4, 5);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(71, 84);
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
            pnStaff.Location = new Point(11, 694);
            pnStaff.Margin = new Padding(4, 5, 4, 5);
            pnStaff.Name = "pnStaff";
            pnStaff.Size = new Size(286, 134);
            pnStaff.TabIndex = 3;
            pnStaff.Click += pnStaff_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.staff;
            pictureBox11.Location = new Point(11, 26);
            pictureBox11.Margin = new Padding(4, 5, 4, 5);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(71, 84);
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
            pnServices.Location = new Point(11, 466);
            pnServices.Margin = new Padding(4, 5, 4, 5);
            pnServices.Name = "pnServices";
            pnServices.Size = new Size(286, 134);
            pnServices.TabIndex = 3;
            pnServices.Click += pnServices_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.food;
            pictureBox10.Location = new Point(11, 26);
            pictureBox10.Margin = new Padding(4, 5, 4, 5);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(71, 84);
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
            pnAccount.Size = new Size(286, 134);
            pnAccount.TabIndex = 3;
            pnAccount.Click += pnAccount_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.useracount;
            pictureBox9.Location = new Point(11, 26);
            pictureBox9.Margin = new Padding(4, 5, 4, 5);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(71, 84);
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
            pnComputer.Location = new Point(11, 14);
            pnComputer.Margin = new Padding(4, 5, 4, 5);
            pnComputer.Name = "pnComputer";
            pnComputer.Size = new Size(286, 134);
            pnComputer.TabIndex = 3;
            pnComputer.Click += pnComputer_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.monitor;
            pictureBox8.Location = new Point(11, 26);
            pictureBox8.Margin = new Padding(4, 5, 4, 5);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(71, 84);
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
            panel2.Size = new Size(1579, 1054);
            panel2.TabIndex = 2;
            // 
            // timerToggle
            // 
            timerToggle.Interval = 5;
            timerToggle.Tick += timerToggle_Tick;
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
            pnlTitleBar.Size = new Size(1931, 66);
            pnlTitleBar.TabIndex = 1;
            // 
            // pbxClose
            // 
            pbxClose.Image = Properties.Resources.close;
            pbxClose.Location = new Point(1864, 0);
            pbxClose.Margin = new Padding(4, 5, 4, 5);
            pbxClose.Name = "pbxClose";
            pbxClose.Size = new Size(58, 66);
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
            flpListComputer.Location = new Point(341, 94);
            flpListComputer.Margin = new Padding(4, 5, 4, 5);
            flpListComputer.Name = "flpListComputer";
            flpListComputer.Size = new Size(1589, 1120);
            flpListComputer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(629, 14);
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
            tblMain.Location = new Point(309, 66);
            tblMain.Margin = new Padding(4, 5, 4, 5);
            tblMain.Name = "tblMain";
            tblMain.SelectedIndex = 0;
            tblMain.Size = new Size(1611, 1146);
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
            tbpComputer.Size = new Size(1611, 1146);
            tbpComputer.TabIndex = 0;
            tbpComputer.Text = "tabPage1";
            tbpComputer.UseVisualStyleBackColor = true;
            // 
            // pnComputerControl
            // 
            pnComputerControl.BorderStyle = BorderStyle.FixedSingle;
            pnComputerControl.Controls.Add(gbxComputerInfor);
            pnComputerControl.Controls.Add(pnComputerButton);
            pnComputerControl.Location = new Point(1120, -14);
            pnComputerControl.Margin = new Padding(4, 5, 4, 5);
            pnComputerControl.Name = "pnComputerControl";
            pnComputerControl.Size = new Size(491, 1146);
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
            gbxComputerInfor.Location = new Point(11, 14);
            gbxComputerInfor.Margin = new Padding(4, 5, 4, 5);
            gbxComputerInfor.Name = "gbxComputerInfor";
            gbxComputerInfor.Padding = new Padding(4, 5, 4, 5);
            gbxComputerInfor.Size = new Size(469, 760);
            gbxComputerInfor.TabIndex = 0;
            gbxComputerInfor.TabStop = false;
            gbxComputerInfor.Text = "Máy tính";
            // 
            // lvServices
            // 
            lvServices.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvServices.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvServices.Location = new Point(11, 334);
            lvServices.Margin = new Padding(4, 5, 4, 5);
            lvServices.Name = "lvServices";
            lvServices.Size = new Size(455, 330);
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
            pnStatusCom.Size = new Size(422, 80);
            pnStatusCom.TabIndex = 3;
            // 
            // lbStatusCom
            // 
            lbStatusCom.AutoSize = true;
            lbStatusCom.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStatusCom.Location = new Point(0, 26);
            lbStatusCom.Margin = new Padding(4, 0, 4, 0);
            lbStatusCom.Name = "lbStatusCom";
            lbStatusCom.Size = new Size(124, 31);
            lbStatusCom.TabIndex = 2;
            lbStatusCom.Text = "Trạng thái:";
            // 
            // tbxComputerStatus
            // 
            tbxComputerStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxComputerStatus.Location = new Point(139, 14);
            tbxComputerStatus.Margin = new Padding(4, 5, 4, 5);
            tbxComputerStatus.Name = "tbxComputerStatus";
            tbxComputerStatus.ReadOnly = true;
            tbxComputerStatus.RightToLeft = RightToLeft.No;
            tbxComputerStatus.Size = new Size(272, 33);
            tbxComputerStatus.TabIndex = 1;
            tbxComputerStatus.Text = "Đang sử dụng\r\n\r\n";
            // 
            // pnTimeCom
            // 
            pnTimeCom.Controls.Add(lbTimeConLai);
            pnTimeCom.Controls.Add(tbxTimeLeft);
            pnTimeCom.Location = new Point(11, 146);
            pnTimeCom.Margin = new Padding(4, 5, 4, 5);
            pnTimeCom.Name = "pnTimeCom";
            pnTimeCom.Size = new Size(422, 80);
            pnTimeCom.TabIndex = 3;
            // 
            // lbTimeConLai
            // 
            lbTimeConLai.AutoSize = true;
            lbTimeConLai.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTimeConLai.Location = new Point(0, 26);
            lbTimeConLai.Margin = new Padding(4, 0, 4, 0);
            lbTimeConLai.Name = "lbTimeConLai";
            lbTimeConLai.Size = new Size(117, 31);
            lbTimeConLai.TabIndex = 2;
            lbTimeConLai.Text = "Thời gian:";
            // 
            // tbxTimeLeft
            // 
            tbxTimeLeft.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxTimeLeft.Location = new Point(139, 14);
            tbxTimeLeft.Margin = new Padding(4, 5, 4, 5);
            tbxTimeLeft.Name = "tbxTimeLeft";
            tbxTimeLeft.ReadOnly = true;
            tbxTimeLeft.Size = new Size(272, 33);
            tbxTimeLeft.TabIndex = 1;
            tbxTimeLeft.Text = "00:00:00";
            // 
            // pnTongTienCom
            // 
            pnTongTienCom.Controls.Add(lbTotalPriceDichVu);
            pnTongTienCom.Controls.Add(tbxMoneyCost);
            pnTongTienCom.Location = new Point(22, 666);
            pnTongTienCom.Margin = new Padding(4, 5, 4, 5);
            pnTongTienCom.Name = "pnTongTienCom";
            pnTongTienCom.Size = new Size(446, 80);
            pnTongTienCom.TabIndex = 3;
            // 
            // lbTotalPriceDichVu
            // 
            lbTotalPriceDichVu.AutoSize = true;
            lbTotalPriceDichVu.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalPriceDichVu.Location = new Point(0, 26);
            lbTotalPriceDichVu.Margin = new Padding(4, 0, 4, 0);
            lbTotalPriceDichVu.Name = "lbTotalPriceDichVu";
            lbTotalPriceDichVu.Size = new Size(119, 31);
            lbTotalPriceDichVu.TabIndex = 2;
            lbTotalPriceDichVu.Text = "Tổng tiền:";
            // 
            // tbxMoneyCost
            // 
            tbxMoneyCost.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxMoneyCost.Location = new Point(138, 26);
            tbxMoneyCost.Margin = new Padding(4, 5, 4, 5);
            tbxMoneyCost.Name = "tbxMoneyCost";
            tbxMoneyCost.ReadOnly = true;
            tbxMoneyCost.RightToLeft = RightToLeft.No;
            tbxMoneyCost.Size = new Size(273, 33);
            tbxMoneyCost.TabIndex = 1;
            tbxMoneyCost.Text = "0.00";
            tbxMoneyCost.TextAlign = HorizontalAlignment.Right;
            // 
            // pnUserNameCom
            // 
            pnUserNameCom.Controls.Add(lbUserNameCom);
            pnUserNameCom.Controls.Add(tbxUserAccount);
            pnUserNameCom.Location = new Point(11, 54);
            pnUserNameCom.Margin = new Padding(4, 5, 4, 5);
            pnUserNameCom.Name = "pnUserNameCom";
            pnUserNameCom.Size = new Size(422, 80);
            pnUserNameCom.TabIndex = 3;
            // 
            // lbUserNameCom
            // 
            lbUserNameCom.AutoSize = true;
            lbUserNameCom.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserNameCom.Location = new Point(0, 26);
            lbUserNameCom.Margin = new Padding(4, 0, 4, 0);
            lbUserNameCom.Name = "lbUserNameCom";
            lbUserNameCom.Size = new Size(146, 31);
            lbUserNameCom.TabIndex = 2;
            lbUserNameCom.Text = "Người dùng:";
            // 
            // tbxUserAccount
            // 
            tbxUserAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUserAccount.Location = new Point(139, 14);
            tbxUserAccount.Margin = new Padding(4, 5, 4, 5);
            tbxUserAccount.Name = "tbxUserAccount";
            tbxUserAccount.ReadOnly = true;
            tbxUserAccount.Size = new Size(272, 39);
            tbxUserAccount.TabIndex = 1;
            // 
            // pnComputerButton
            // 
            pnComputerButton.Controls.Add(btnExtraMoney);
            pnComputerButton.Controls.Add(btnManageComputer);
            pnComputerButton.Controls.Add(btnTrackComputer);
            pnComputerButton.Controls.Add(btnShutDownComputer);
            pnComputerButton.Controls.Add(btnAddServices);
            pnComputerButton.Controls.Add(btnForceStop);
            pnComputerButton.Location = new Point(34, 774);
            pnComputerButton.Margin = new Padding(4, 5, 4, 5);
            pnComputerButton.Name = "pnComputerButton";
            pnComputerButton.Size = new Size(422, 346);
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
            btnManageComputer.Location = new Point(0, 26);
            btnManageComputer.Margin = new Padding(4, 5, 4, 5);
            btnManageComputer.Name = "btnManageComputer";
            btnManageComputer.Size = new Size(181, 80);
            btnManageComputer.TabIndex = 3;
            btnManageComputer.Text = "Quản lý";
            btnManageComputer.UseVisualStyleBackColor = true;
            btnManageComputer.Click += btnManageComputer_Click;
            // 
            // btnTrackComputer
            // 
            btnTrackComputer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTrackComputer.Location = new Point(0, 254);
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
            btnShutDownComputer.Location = new Point(229, 26);
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
            // btnForceStop
            // 
            btnForceStop.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnForceStop.Location = new Point(229, 254);
            btnForceStop.Margin = new Padding(4, 5, 4, 5);
            btnForceStop.Name = "btnForceStop";
            btnForceStop.Size = new Size(181, 80);
            btnForceStop.TabIndex = 7;
            btnForceStop.Text = "Đóng ứng dụng";
            btnForceStop.UseVisualStyleBackColor = true;
            btnForceStop.Click += btnForceStop_Click;
            // 
            // flpComputer
            // 
            flpComputer.BorderStyle = BorderStyle.FixedSingle;
            flpComputer.Location = new Point(0, 0);
            flpComputer.Margin = new Padding(4, 5, 4, 5);
            flpComputer.Name = "flpComputer";
            flpComputer.Size = new Size(1120, 1132);
            flpComputer.TabIndex = 0;
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
            tbpAccount.Size = new Size(1611, 1146);
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
            pnButtonAccount.Size = new Size(1046, 94);
            pnButtonAccount.TabIndex = 10;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.BackColor = Color.FromArgb(192, 255, 255);
            btnThemKhachHang.FlatStyle = FlatStyle.Flat;
            btnThemKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemKhachHang.Location = new Point(274, 26);
            btnThemKhachHang.Margin = new Padding(4, 5, 4, 5);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(181, 51);
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
            btnNhap.Location = new Point(480, 26);
            btnNhap.Margin = new Padding(4, 5, 4, 5);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(160, 51);
            btnNhap.TabIndex = 3;
            btnNhap.Text = "Nhập File";
            btnNhap.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(662, 26);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(160, 51);
            button2.TabIndex = 3;
            button2.Text = "Xuất File";
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_TroChuyen
            // 
            btn_TroChuyen.BackColor = Color.FromArgb(192, 255, 255);
            btn_TroChuyen.FlatStyle = FlatStyle.Flat;
            btn_TroChuyen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TroChuyen.Location = new Point(846, 26);
            btn_TroChuyen.Margin = new Padding(4, 5, 4, 5);
            btn_TroChuyen.Name = "btn_TroChuyen";
            btn_TroChuyen.Size = new Size(160, 51);
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
            lbCurrentAccountPage.Location = new Point(139, 26);
            lbCurrentAccountPage.Margin = new Padding(4, 0, 4, 0);
            lbCurrentAccountPage.Name = "lbCurrentAccountPage";
            lbCurrentAccountPage.Size = new Size(251, 39);
            lbCurrentAccountPage.TabIndex = 6;
            lbCurrentAccountPage.Text = "Quản lý khách hàng";
            // 
            // lbHomeAccountPage
            // 
            lbHomeAccountPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHomeAccountPage.Location = new Point(11, 26);
            lbHomeAccountPage.Margin = new Padding(4, 0, 4, 0);
            lbHomeAccountPage.Name = "lbHomeAccountPage";
            lbHomeAccountPage.Size = new Size(126, 39);
            lbHomeAccountPage.TabIndex = 6;
            lbHomeAccountPage.Text = "⟲ Home >";
            lbHomeAccountPage.Click += label33_Click;
            // 
            // grbKhachHang
            // 
            grbKhachHang.Controls.Add(pnTimKimAccount);
            grbKhachHang.Controls.Add(pnDisplayAccount);
            grbKhachHang.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbKhachHang.Location = new Point(19, 106);
            grbKhachHang.Margin = new Padding(4, 5, 4, 5);
            grbKhachHang.Name = "grbKhachHang";
            grbKhachHang.Padding = new Padding(4, 5, 4, 5);
            grbKhachHang.Size = new Size(1581, 1026);
            grbKhachHang.TabIndex = 11;
            grbKhachHang.TabStop = false;
            grbKhachHang.Text = "Quản Lý Khách Hàng";
            // 
            // pnTimKimAccount
            // 
            pnTimKimAccount.Controls.Add(cbxNhomKhach);
            pnTimKimAccount.Controls.Add(txtTimKiemKhachHang);
            pnTimKimAccount.Location = new Point(11, 66);
            pnTimKimAccount.Margin = new Padding(4, 5, 4, 5);
            pnTimKimAccount.Name = "pnTimKimAccount";
            pnTimKimAccount.Size = new Size(1566, 80);
            pnTimKimAccount.TabIndex = 8;
            // 
            // cbxNhomKhach
            // 
            cbxNhomKhach.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxNhomKhach.Location = new Point(629, 14);
            cbxNhomKhach.Margin = new Padding(4, 5, 4, 5);
            cbxNhomKhach.Name = "cbxNhomKhach";
            cbxNhomKhach.Size = new Size(172, 48);
            cbxNhomKhach.TabIndex = 5;
            cbxNhomKhach.SelectedIndexChanged += cbxNhomKhach_SelectedIndexChanged;
            // 
            // txtTimKiemKhachHang
            // 
            txtTimKiemKhachHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiemKhachHang.Location = new Point(11, 14);
            txtTimKiemKhachHang.Margin = new Padding(4, 5, 4, 5);
            txtTimKiemKhachHang.Multiline = true;
            txtTimKiemKhachHang.Name = "txtTimKiemKhachHang";
            txtTimKiemKhachHang.Size = new Size(604, 50);
            txtTimKiemKhachHang.TabIndex = 4;
            txtTimKiemKhachHang.TextChanged += txtTimKiemKhachHang_TextChanged;
            // 
            // pnDisplayAccount
            // 
            pnDisplayAccount.Controls.Add(flpKhachHang);
            pnDisplayAccount.Location = new Point(11, 160);
            pnDisplayAccount.Margin = new Padding(4, 5, 4, 5);
            pnDisplayAccount.Name = "pnDisplayAccount";
            pnDisplayAccount.Size = new Size(1566, 854);
            pnDisplayAccount.TabIndex = 7;
            // 
            // flpKhachHang
            // 
            flpKhachHang.AutoScroll = true;
            flpKhachHang.Location = new Point(11, 14);
            flpKhachHang.Margin = new Padding(4, 5, 4, 5);
            flpKhachHang.Name = "flpKhachHang";
            flpKhachHang.Size = new Size(1542, 814);
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
            tbpServices.Size = new Size(1611, 1146);
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
            groupBox1.Size = new Size(1600, 1015);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản Lý Dịch Vụ 1";
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.Location = new Point(778, 66);
            cbCategory.Margin = new Padding(4, 5, 4, 5);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(163, 49);
            cbCategory.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(flpFoodList);
            panel5.Location = new Point(9, 156);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1569, 844);
            panel5.TabIndex = 5;
            // 
            // flpFoodList
            // 
            flpFoodList.Location = new Point(11, 14);
            flpFoodList.Margin = new Padding(4, 5, 4, 5);
            flpFoodList.Name = "flpFoodList";
            flpFoodList.Size = new Size(1542, 814);
            flpFoodList.TabIndex = 4;
            // 
            // txbSearch
            // 
            txbSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSearch.Location = new Point(11, 66);
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
            button1.Size = new Size(181, 51);
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
            button4.Size = new Size(181, 51);
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
            label2.Location = new Point(139, 26);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(251, 39);
            label2.TabIndex = 6;
            label2.Text = "Quản lý Dịch Vụ 1";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 26);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 39);
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
            tbpStaff.Size = new Size(1611, 1146);
            tbpStaff.TabIndex = 3;
            tbpStaff.Text = "git b";
            tbpStaff.UseVisualStyleBackColor = true;
            // 
            // pnDuongDanStaff
            // 
            pnDuongDanStaff.Controls.Add(lblQuanLyNhanVien);
            pnDuongDanStaff.Controls.Add(lblHome);
            pnDuongDanStaff.Location = new Point(26, 14);
            pnDuongDanStaff.Margin = new Padding(4, 5, 4, 5);
            pnDuongDanStaff.Name = "pnDuongDanStaff";
            pnDuongDanStaff.Size = new Size(411, 80);
            pnDuongDanStaff.TabIndex = 8;
            // 
            // lblQuanLyNhanVien
            // 
            lblQuanLyNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanLyNhanVien.Location = new Point(126, 26);
            lblQuanLyNhanVien.Margin = new Padding(4, 0, 4, 0);
            lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            lblQuanLyNhanVien.Size = new Size(240, 39);
            lblQuanLyNhanVien.TabIndex = 6;
            lblQuanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // lblHome
            // 
            lblHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHome.Location = new Point(11, 26);
            lblHome.Margin = new Padding(4, 0, 4, 0);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(126, 39);
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
            grbQuanLyNhanVien.Location = new Point(0, 106);
            grbQuanLyNhanVien.Margin = new Padding(4, 5, 4, 5);
            grbQuanLyNhanVien.Name = "grbQuanLyNhanVien";
            grbQuanLyNhanVien.Padding = new Padding(4, 5, 4, 5);
            grbQuanLyNhanVien.Size = new Size(1600, 1015);
            grbQuanLyNhanVien.TabIndex = 6;
            grbQuanLyNhanVien.TabStop = false;
            grbQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // cbxChucVu
            // 
            cbxChucVu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxChucVu.Location = new Point(778, 66);
            cbxChucVu.Margin = new Padding(4, 5, 4, 5);
            cbxChucVu.Name = "cbxChucVu";
            cbxChucVu.Size = new Size(163, 49);
            cbxChucVu.TabIndex = 2;
            cbxChucVu.SelectedIndexChanged += cbxChucVu_SelectedIndexChanged_1;
            // 
            // pnDisplayStaff
            // 
            pnDisplayStaff.Controls.Add(flpNhanVien);
            pnDisplayStaff.Location = new Point(9, 156);
            pnDisplayStaff.Margin = new Padding(4, 5, 4, 5);
            pnDisplayStaff.Name = "pnDisplayStaff";
            pnDisplayStaff.Size = new Size(1569, 844);
            pnDisplayStaff.TabIndex = 5;
            // 
            // flpNhanVien
            // 
            flpNhanVien.Location = new Point(11, 14);
            flpNhanVien.Margin = new Padding(4, 5, 4, 5);
            flpNhanVien.Name = "flpNhanVien";
            flpNhanVien.Size = new Size(1542, 814);
            flpNhanVien.TabIndex = 4;
            flpNhanVien.MouseDown += flpNhanVien_MouseDown;
            // 
            // cbxTrangThai
            // 
            cbxTrangThai.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxTrangThai.FormattingEnabled = true;
            cbxTrangThai.Location = new Point(960, 66);
            cbxTrangThai.Margin = new Padding(4, 5, 4, 5);
            cbxTrangThai.Name = "cbxTrangThai";
            cbxTrangThai.Size = new Size(173, 49);
            cbxTrangThai.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(11, 66);
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
            pnStaffControl.Size = new Size(1049, 94);
            pnStaffControl.TabIndex = 7;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.FromArgb(128, 255, 255);
            btnThemMoi.FlatStyle = FlatStyle.Flat;
            btnThemMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMoi.Location = new Point(434, 26);
            btnThemMoi.Margin = new Padding(4, 5, 4, 5);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(181, 51);
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
            btnXuatFile.Location = new Point(629, 26);
            btnXuatFile.Margin = new Padding(4, 5, 4, 5);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(181, 51);
            btnXuatFile.TabIndex = 3;
            btnXuatFile.Text = "Xuất File";
            btnXuatFile.UseVisualStyleBackColor = false;
            // 
            // btn_ThongKe
            // 
            btn_ThongKe.BackColor = Color.FromArgb(128, 255, 255);
            btn_ThongKe.FlatStyle = FlatStyle.Flat;
            btn_ThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThongKe.Location = new Point(821, 26);
            btn_ThongKe.Margin = new Padding(4, 5, 4, 5);
            btn_ThongKe.Name = "btn_ThongKe";
            btn_ThongKe.Size = new Size(181, 51);
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
            tbpStatictical.Size = new Size(1611, 1146);
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
            pnJob.Margin = new Padding(2, 4, 2, 4);
            pnJob.Name = "pnJob";
            pnJob.Size = new Size(1603, 1136);
            pnJob.TabIndex = 4;
            // 
            // pnTKKhungTK
            // 
            pnTKKhungTK.Controls.Add(gbxThongKe);
            pnTKKhungTK.Controls.Add(pnTKNutChucNangTK);
            pnTKKhungTK.Dock = DockStyle.Fill;
            pnTKKhungTK.Location = new Point(0, 0);
            pnTKKhungTK.Name = "pnTKKhungTK";
            pnTKKhungTK.Size = new Size(1601, 1134);
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
            gbxThongKeTongQuan.Controls.Add(txtTongGioSuDung);
            gbxThongKeTongQuan.Controls.Add(txtTongDoanhThu);
            gbxThongKeTongQuan.Controls.Add(lbTongGioSuDung);
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
            btnCapNhatThongKe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhatThongKe.Location = new Point(399, 207);
            btnCapNhatThongKe.Name = "btnCapNhatThongKe";
            btnCapNhatThongKe.Size = new Size(255, 46);
            btnCapNhatThongKe.TabIndex = 7;
            btnCapNhatThongKe.Text = "Tổng quan thống kê";
            btnCapNhatThongKe.UseVisualStyleBackColor = true;
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
            // txtTongGioSuDung
            // 
            txtTongGioSuDung.Font = new Font("Segoe UI", 11F);
            txtTongGioSuDung.Location = new Point(770, 69);
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
            pnTKThangDT.Controls.Add(btnTKThangDT);
            pnTKThangDT.Controls.Add(tbTKThangDT);
            pnTKThangDT.Controls.Add(lbTKThangDT);
            pnTKThangDT.Controls.Add(lbTittleThangDT);
            pnTKThangDT.Controls.Add(dtpTKThangDT);
            pnTKThangDT.Location = new Point(16, 319);
            pnTKThangDT.Name = "pnTKThangDT";
            pnTKThangDT.Size = new Size(431, 201);
            pnTKThangDT.TabIndex = 2;
            // 
            // btnTKThangDT
            // 
            btnTKThangDT.Location = new Point(300, 151);
            btnTKThangDT.Name = "btnTKThangDT";
            btnTKThangDT.Size = new Size(112, 34);
            btnTKThangDT.TabIndex = 3;
            btnTKThangDT.Text = "Xem";
            btnTKThangDT.UseVisualStyleBackColor = true;
            // 
            // tbTKThangDT
            // 
            tbTKThangDT.Font = new Font("Segoe UI", 11F);
            tbTKThangDT.Location = new Point(180, 94);
            tbTKThangDT.Name = "tbTKThangDT";
            tbTKThangDT.Size = new Size(232, 37);
            tbTKThangDT.TabIndex = 2;
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
            dtpTKThangDT.Size = new Size(232, 37);
            dtpTKThangDT.TabIndex = 0;
            // 
            // rbtTittleNamDT
            // 
            rbtTittleNamDT.AutoSize = true;
            rbtTittleNamDT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbtTittleNamDT.Location = new Point(16, 536);
            rbtTittleNamDT.Name = "rbtTittleNamDT";
            rbtTittleNamDT.Size = new Size(146, 34);
            rbtTittleNamDT.TabIndex = 4;
            rbtTittleNamDT.TabStop = true;
            rbtTittleNamDT.Text = "Theo năm:";
            rbtTittleNamDT.UseVisualStyleBackColor = true;
            // 
            // rbtTittleThangDT
            // 
            rbtTittleThangDT.AutoSize = true;
            rbtTittleThangDT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbtTittleThangDT.Location = new Point(16, 279);
            rbtTittleThangDT.Name = "rbtTittleThangDT";
            rbtTittleThangDT.Size = new Size(162, 34);
            rbtTittleThangDT.TabIndex = 4;
            rbtTittleThangDT.TabStop = true;
            rbtTittleThangDT.Text = "Theo tháng:";
            rbtTittleThangDT.UseVisualStyleBackColor = true;
            // 
            // rbtTittleNgayDT
            // 
            rbtTittleNgayDT.AutoSize = true;
            rbtTittleNgayDT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbtTittleNgayDT.Location = new Point(16, 3);
            rbtTittleNgayDT.Name = "rbtTittleNgayDT";
            rbtTittleNgayDT.Size = new Size(152, 34);
            rbtTittleNgayDT.TabIndex = 4;
            rbtTittleNgayDT.TabStop = true;
            rbtTittleNgayDT.Text = "Theo ngày:";
            rbtTittleNgayDT.UseVisualStyleBackColor = true;
            // 
            // pnTKNamDT
            // 
            pnTKNamDT.BorderStyle = BorderStyle.FixedSingle;
            pnTKNamDT.Controls.Add(btnTKNamDT);
            pnTKNamDT.Controls.Add(tbTKNamDT);
            pnTKNamDT.Controls.Add(lbTKNamDT);
            pnTKNamDT.Controls.Add(lbTittleNamDT);
            pnTKNamDT.Controls.Add(dtpTKNamDT);
            pnTKNamDT.Location = new Point(16, 576);
            pnTKNamDT.Name = "pnTKNamDT";
            pnTKNamDT.Size = new Size(431, 214);
            pnTKNamDT.TabIndex = 3;
            // 
            // btnTKNamDT
            // 
            btnTKNamDT.Location = new Point(300, 152);
            btnTKNamDT.Name = "btnTKNamDT";
            btnTKNamDT.Size = new Size(112, 34);
            btnTKNamDT.TabIndex = 3;
            btnTKNamDT.Text = "Xem";
            btnTKNamDT.UseVisualStyleBackColor = true;
            // 
            // tbTKNamDT
            // 
            tbTKNamDT.Font = new Font("Segoe UI", 11F);
            tbTKNamDT.Location = new Point(180, 93);
            tbTKNamDT.Name = "tbTKNamDT";
            tbTKNamDT.Size = new Size(232, 37);
            tbTKNamDT.TabIndex = 2;
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
            dtpTKNamDT.Size = new Size(232, 37);
            dtpTKNamDT.TabIndex = 0;
            // 
            // pnTKNgayDT
            // 
            pnTKNgayDT.BorderStyle = BorderStyle.FixedSingle;
            pnTKNgayDT.Controls.Add(btnTKNgayDT);
            pnTKNgayDT.Controls.Add(tbTKNgayDT);
            pnTKNgayDT.Controls.Add(lbTKNgayDT);
            pnTKNgayDT.Controls.Add(lbTittleNgayDT);
            pnTKNgayDT.Controls.Add(dtpTKNgayDT);
            pnTKNgayDT.Location = new Point(16, 43);
            pnTKNgayDT.Name = "pnTKNgayDT";
            pnTKNgayDT.Size = new Size(431, 214);
            pnTKNgayDT.TabIndex = 1;
            // 
            // btnTKNgayDT
            // 
            btnTKNgayDT.Location = new Point(300, 157);
            btnTKNgayDT.Name = "btnTKNgayDT";
            btnTKNgayDT.Size = new Size(112, 34);
            btnTKNgayDT.TabIndex = 3;
            btnTKNgayDT.Text = "Xem";
            btnTKNgayDT.UseVisualStyleBackColor = true;
            // 
            // tbTKNgayDT
            // 
            tbTKNgayDT.Font = new Font("Segoe UI", 11F);
            tbTKNgayDT.Location = new Point(180, 99);
            tbTKNgayDT.Name = "tbTKNgayDT";
            tbTKNgayDT.Size = new Size(232, 37);
            tbTKNgayDT.TabIndex = 2;
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
            pnTKTGMayTram.Controls.Add(panel6);
            pnTKTGMayTram.Controls.Add(panel7);
            pnTKTGMayTram.Controls.Add(panel8);
            pnTKTGMayTram.Controls.Add(rbtTittleNamMT);
            pnTKTGMayTram.Controls.Add(rbtTittleThangMT);
            pnTKTGMayTram.Controls.Add(rbtTittleNgayMT);
            pnTKTGMayTram.Location = new Point(6, 6);
            pnTKTGMayTram.Name = "pnTKTGMayTram";
            pnTKTGMayTram.Size = new Size(468, 827);
            pnTKTGMayTram.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(btnTKNamMT);
            panel6.Controls.Add(lbTittleNamMT);
            panel6.Controls.Add(dtpTKNamMT);
            panel6.Location = new Point(12, 605);
            panel6.Name = "panel6";
            panel6.Size = new Size(431, 190);
            panel6.TabIndex = 8;
            // 
            // btnTKNamMT
            // 
            btnTKNamMT.Location = new Point(251, 114);
            btnTKNamMT.Name = "btnTKNamMT";
            btnTKNamMT.Size = new Size(161, 34);
            btnTKNamMT.TabIndex = 3;
            btnTKNamMT.Text = "Xem";
            btnTKNamMT.UseVisualStyleBackColor = true;
            // 
            // lbTittleNamMT
            // 
            lbTittleNamMT.AutoSize = true;
            lbTittleNamMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTittleNamMT.Location = new Point(21, 37);
            lbTittleNamMT.Name = "lbTittleNamMT";
            lbTittleNamMT.Size = new Size(68, 30);
            lbTittleNamMT.TabIndex = 1;
            lbTittleNamMT.Text = "Năm:";
            // 
            // dtpTKNamMT
            // 
            dtpTKNamMT.CustomFormat = "yyyy";
            dtpTKNamMT.Font = new Font("Segoe UI", 11F);
            dtpTKNamMT.Format = DateTimePickerFormat.Custom;
            dtpTKNamMT.Location = new Point(180, 37);
            dtpTKNamMT.Name = "dtpTKNamMT";
            dtpTKNamMT.Size = new Size(232, 37);
            dtpTKNamMT.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(btnTKThangMT);
            panel7.Controls.Add(lbTittleThangMT);
            panel7.Controls.Add(dtpTKThangMT);
            panel7.Location = new Point(12, 332);
            panel7.Name = "panel7";
            panel7.Size = new Size(431, 190);
            panel7.TabIndex = 7;
            // 
            // btnTKThangMT
            // 
            btnTKThangMT.Location = new Point(251, 114);
            btnTKThangMT.Name = "btnTKThangMT";
            btnTKThangMT.Size = new Size(161, 34);
            btnTKThangMT.TabIndex = 3;
            btnTKThangMT.Text = "Xem";
            btnTKThangMT.UseVisualStyleBackColor = true;
            // 
            // lbTittleThangMT
            // 
            lbTittleThangMT.AutoSize = true;
            lbTittleThangMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTittleThangMT.Location = new Point(21, 37);
            lbTittleThangMT.Name = "lbTittleThangMT";
            lbTittleThangMT.Size = new Size(84, 30);
            lbTittleThangMT.TabIndex = 1;
            lbTittleThangMT.Text = "Tháng:";
            // 
            // dtpTKThangMT
            // 
            dtpTKThangMT.CustomFormat = "MM/yyyy";
            dtpTKThangMT.Font = new Font("Segoe UI", 11F);
            dtpTKThangMT.Format = DateTimePickerFormat.Custom;
            dtpTKThangMT.Location = new Point(180, 37);
            dtpTKThangMT.Name = "dtpTKThangMT";
            dtpTKThangMT.Size = new Size(232, 37);
            dtpTKThangMT.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(btnTKNgayMT);
            panel8.Controls.Add(lbTittleNgayMT);
            panel8.Controls.Add(dtpTKNgayMT);
            panel8.Location = new Point(12, 57);
            panel8.Name = "panel8";
            panel8.Size = new Size(431, 190);
            panel8.TabIndex = 6;
            // 
            // btnTKNgayMT
            // 
            btnTKNgayMT.Location = new Point(251, 114);
            btnTKNgayMT.Name = "btnTKNgayMT";
            btnTKNgayMT.Size = new Size(161, 34);
            btnTKNgayMT.TabIndex = 3;
            btnTKNgayMT.Text = "Xem";
            btnTKNgayMT.UseVisualStyleBackColor = true;
            // 
            // lbTittleNgayMT
            // 
            lbTittleNgayMT.AutoSize = true;
            lbTittleNgayMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTittleNgayMT.Location = new Point(21, 37);
            lbTittleNgayMT.Name = "lbTittleNgayMT";
            lbTittleNgayMT.Size = new Size(74, 30);
            lbTittleNgayMT.TabIndex = 1;
            lbTittleNgayMT.Text = "Ngày:";
            // 
            // dtpTKNgayMT
            // 
            dtpTKNgayMT.CustomFormat = "dd/MM/yyyy";
            dtpTKNgayMT.Font = new Font("Segoe UI", 11F);
            dtpTKNgayMT.Format = DateTimePickerFormat.Custom;
            dtpTKNgayMT.Location = new Point(180, 37);
            dtpTKNgayMT.Name = "dtpTKNgayMT";
            dtpTKNgayMT.Size = new Size(232, 37);
            dtpTKNgayMT.TabIndex = 0;
            // 
            // rbtTittleNamMT
            // 
            rbtTittleNamMT.AutoSize = true;
            rbtTittleNamMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbtTittleNamMT.Location = new Point(12, 565);
            rbtTittleNamMT.Name = "rbtTittleNamMT";
            rbtTittleNamMT.Size = new Size(146, 34);
            rbtTittleNamMT.TabIndex = 5;
            rbtTittleNamMT.TabStop = true;
            rbtTittleNamMT.Text = "Theo năm:";
            rbtTittleNamMT.UseVisualStyleBackColor = true;
            // 
            // rbtTittleThangMT
            // 
            rbtTittleThangMT.AutoSize = true;
            rbtTittleThangMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbtTittleThangMT.Location = new Point(21, 292);
            rbtTittleThangMT.Name = "rbtTittleThangMT";
            rbtTittleThangMT.Size = new Size(162, 34);
            rbtTittleThangMT.TabIndex = 5;
            rbtTittleThangMT.TabStop = true;
            rbtTittleThangMT.Text = "Theo tháng:";
            rbtTittleThangMT.UseVisualStyleBackColor = true;
            // 
            // rbtTittleNgayMT
            // 
            rbtTittleNgayMT.AutoSize = true;
            rbtTittleNgayMT.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbtTittleNgayMT.Location = new Point(12, 17);
            rbtTittleNgayMT.Name = "rbtTittleNgayMT";
            rbtTittleNgayMT.Size = new Size(152, 34);
            rbtTittleNgayMT.TabIndex = 5;
            rbtTittleNgayMT.TabStop = true;
            rbtTittleNgayMT.Text = "Theo ngày:";
            rbtTittleNgayMT.UseVisualStyleBackColor = true;
            // 
            // tbTKThucAn
            // 
            tbTKThucAn.Controls.Add(lbLoaiTKThucAn);
            tbTKThucAn.Controls.Add(btnTKChucNangTA);
            tbTKThucAn.Controls.Add(cbxTKThucAn);
            tbTKThucAn.Location = new Point(4, 37);
            tbTKThucAn.Name = "tbTKThucAn";
            tbTKThucAn.Padding = new Padding(3);
            tbTKThucAn.Size = new Size(480, 839);
            tbTKThucAn.TabIndex = 2;
            tbTKThucAn.Text = "Thức Ăn";
            tbTKThucAn.UseVisualStyleBackColor = true;
            // 
            // lbLoaiTKThucAn
            // 
            lbLoaiTKThucAn.AutoSize = true;
            lbLoaiTKThucAn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbLoaiTKThucAn.Location = new Point(38, 44);
            lbLoaiTKThucAn.Name = "lbLoaiTKThucAn";
            lbLoaiTKThucAn.Size = new Size(165, 30);
            lbLoaiTKThucAn.TabIndex = 3;
            lbLoaiTKThucAn.Text = "Loại Thống Kê:";
            // 
            // btnTKChucNangTA
            // 
            btnTKChucNangTA.Location = new Point(318, 158);
            btnTKChucNangTA.Name = "btnTKChucNangTA";
            btnTKChucNangTA.Size = new Size(132, 55);
            btnTKChucNangTA.TabIndex = 1;
            btnTKChucNangTA.Text = "Xem";
            btnTKChucNangTA.UseVisualStyleBackColor = true;
            // 
            // cbxTKThucAn
            // 
            cbxTKThucAn.FormattingEnabled = true;
            cbxTKThucAn.Items.AddRange(new object[] { "Số lần sử dụng", "Doanh thu cao nhất" });
            cbxTKThucAn.Location = new Point(35, 103);
            cbxTKThucAn.Name = "cbxTKThucAn";
            cbxTKThucAn.Size = new Size(415, 36);
            cbxTKThucAn.TabIndex = 0;
            // 
            // tnTKKhachHang
            // 
            tnTKKhachHang.Controls.Add(pnTKChucNangKH);
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
            // pnTKChucNangKH
            // 
            pnTKChucNangKH.BorderStyle = BorderStyle.FixedSingle;
            pnTKChucNangKH.Controls.Add(btnTKKhacKH);
            pnTKChucNangKH.Controls.Add(lbTKKhacKH);
            pnTKChucNangKH.Controls.Add(cbxTKKhacKH);
            pnTKChucNangKH.Location = new Point(13, 568);
            pnTKChucNangKH.Name = "pnTKChucNangKH";
            pnTKChucNangKH.Size = new Size(455, 195);
            pnTKChucNangKH.TabIndex = 6;
            // 
            // btnTKKhacKH
            // 
            btnTKKhacKH.Font = new Font("Segoe UI", 11F);
            btnTKKhacKH.Location = new Point(285, 131);
            btnTKKhacKH.Name = "btnTKKhacKH";
            btnTKKhacKH.Size = new Size(155, 46);
            btnTKKhacKH.TabIndex = 2;
            btnTKKhacKH.Text = "Xem";
            btnTKKhacKH.UseVisualStyleBackColor = true;
            // 
            // lbTKKhacKH
            // 
            lbTKKhacKH.AutoSize = true;
            lbTKKhacKH.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTKKhacKH.Location = new Point(14, 25);
            lbTKKhacKH.Name = "lbTKKhacKH";
            lbTKKhacKH.Size = new Size(169, 30);
            lbTKKhacKH.TabIndex = 2;
            lbTKKhacKH.Text = "Thống kê khác:";
            // 
            // cbxTKKhacKH
            // 
            cbxTKKhacKH.FormattingEnabled = true;
            cbxTKKhacKH.Items.AddRange(new object[] { "Khách hàng thân thiết", "Doanh thu cao nhất" });
            cbxTKKhacKH.Location = new Point(14, 76);
            cbxTKKhacKH.Name = "cbxTKKhacKH";
            cbxTKKhacKH.Size = new Size(426, 36);
            cbxTKKhacKH.TabIndex = 0;
            // 
            // pnTKKHVip
            // 
            pnTKKHVip.BorderStyle = BorderStyle.FixedSingle;
            pnTKKHVip.Controls.Add(btnTKXemKHTop);
            pnTKKHVip.Controls.Add(lbTKKHVip);
            pnTKKHVip.Location = new Point(13, 32);
            pnTKKHVip.Name = "pnTKKHVip";
            pnTKKHVip.Size = new Size(455, 112);
            pnTKKHVip.TabIndex = 5;
            // 
            // btnTKXemKHTop
            // 
            btnTKXemKHTop.Font = new Font("Segoe UI", 11F);
            btnTKXemKHTop.Location = new Point(277, 29);
            btnTKXemKHTop.Name = "btnTKXemKHTop";
            btnTKXemKHTop.Size = new Size(155, 46);
            btnTKXemKHTop.TabIndex = 2;
            btnTKXemKHTop.Text = "Xem";
            btnTKXemKHTop.UseVisualStyleBackColor = true;
            // 
            // lbTKKHVip
            // 
            lbTKKHVip.AutoSize = true;
            lbTKKHVip.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTKKHVip.Location = new Point(13, 37);
            lbTKKHVip.Name = "lbTKKHVip";
            lbTKKHVip.Size = new Size(212, 30);
            lbTKKHVip.TabIndex = 2;
            lbTKKHVip.Text = "TOP 5 Khách Hàng:";
            // 
            // pnTKLenhKH
            // 
            pnTKLenhKH.BorderStyle = BorderStyle.FixedSingle;
            pnTKLenhKH.Controls.Add(pnTKKhungThangKH);
            pnTKLenhKH.Controls.Add(lbTKTittleThangKH);
            pnTKLenhKH.Location = new Point(13, 175);
            pnTKLenhKH.Name = "pnTKLenhKH";
            pnTKLenhKH.Size = new Size(455, 360);
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
            pnTKKhungThangKH.Location = new Point(13, 81);
            pnTKKhungThangKH.Name = "pnTKKhungThangKH";
            pnTKKhungThangKH.Size = new Size(426, 257);
            pnTKKhungThangKH.TabIndex = 2;
            // 
            // btnTKXemKH
            // 
            btnTKXemKH.Font = new Font("Segoe UI", 11F);
            btnTKXemKH.Location = new Point(246, 176);
            btnTKXemKH.Name = "btnTKXemKH";
            btnTKXemKH.Size = new Size(155, 46);
            btnTKXemKH.TabIndex = 2;
            btnTKXemKH.Text = "Xem";
            btnTKXemKH.UseVisualStyleBackColor = true;
            // 
            // StTKEndKH
            // 
            StTKEndKH.AutoSize = true;
            StTKEndKH.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            StTKEndKH.Location = new Point(14, 117);
            StTKEndKH.Name = "StTKEndKH";
            StTKEndKH.Size = new Size(113, 30);
            StTKEndKH.TabIndex = 1;
            StTKEndKH.Text = "Đến ngày:";
            // 
            // lbTKStartKH
            // 
            lbTKStartKH.AutoSize = true;
            lbTKStartKH.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbTKStartKH.Location = new Point(14, 43);
            lbTKStartKH.Name = "lbTKStartKH";
            lbTKStartKH.Size = new Size(98, 30);
            lbTKStartKH.TabIndex = 1;
            lbTKStartKH.Text = "Từ ngày:";
            // 
            // dtpTKEndKH
            // 
            dtpTKEndKH.Font = new Font("Segoe UI", 11F);
            dtpTKEndKH.Format = DateTimePickerFormat.Custom;
            dtpTKEndKH.Location = new Point(148, 116);
            dtpTKEndKH.Name = "dtpTKEndKH";
            dtpTKEndKH.Size = new Size(253, 37);
            dtpTKEndKH.TabIndex = 0;
            // 
            // dtpTKStartKH
            // 
            dtpTKStartKH.Font = new Font("Segoe UI", 11F);
            dtpTKStartKH.Format = DateTimePickerFormat.Custom;
            dtpTKStartKH.Location = new Point(148, 42);
            dtpTKStartKH.Name = "dtpTKStartKH";
            dtpTKStartKH.Size = new Size(253, 37);
            dtpTKStartKH.TabIndex = 0;
            // 
            // lbTKTittleThangKH
            // 
            lbTKTittleThangKH.AutoSize = true;
            lbTKTittleThangKH.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTKTittleThangKH.Location = new Point(13, 26);
            lbTKTittleThangKH.Name = "lbTKTittleThangKH";
            lbTKTittleThangKH.Size = new Size(267, 30);
            lbTKTittleThangKH.TabIndex = 2;
            lbTKTittleThangKH.Text = "Thống kê theo thời gian:";
            // 
            // pnTKNutChucNangTK
            // 
            pnTKNutChucNangTK.BorderStyle = BorderStyle.FixedSingle;
            pnTKNutChucNangTK.Controls.Add(label4);
            pnTKNutChucNangTK.Controls.Add(label5);
            pnTKNutChucNangTK.Controls.Add(btnTKSoDo);
            pnTKNutChucNangTK.Controls.Add(btnTKXuatFile);
            pnTKNutChucNangTK.Controls.Add(btnTKQLUngDung);
            pnTKNutChucNangTK.Location = new Point(4, 0);
            pnTKNutChucNangTK.Margin = new Padding(4, 5, 4, 5);
            pnTKNutChucNangTK.Name = "pnTKNutChucNangTK";
            pnTKNutChucNangTK.Size = new Size(1593, 93);
            pnTKNutChucNangTK.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(163, 26);
            label4.Name = "label4";
            label4.Size = new Size(136, 32);
            label4.TabIndex = 6;
            label4.Text = "THỐNG KÊ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 26);
            label5.Name = "label5";
            label5.Size = new Size(129, 32);
            label5.TabIndex = 5;
            label5.Text = "⟲ Home >";
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
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
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
            pnTKTGMayTram.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            tbTKThucAn.ResumeLayout(false);
            tbTKThucAn.PerformLayout();
            tnTKKhachHang.ResumeLayout(false);
            pnTKChucNangKH.ResumeLayout(false);
            pnTKChucNangKH.PerformLayout();
            pnTKKHVip.ResumeLayout(false);
            pnTKKHVip.PerformLayout();
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
        private Button btnForceStop;
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
        private Panel pnTKKhungTK;
        private GroupBox gbxThongKe;
        private Panel pnTKNut;
        private GroupBox gbxThongKeTongQuan;
        private Button btnCapNhatThongKe;
        private ProgressBar pbHieuSuat;
        private TextBox txtTongDichVu;
        private TextBox txtTongGioSuDung;
        private TextBox txtTongDoanhThu;
        private Label lbTongGioSuDung;
        private Label lbTongDichVu;
        private Label lbTongDoanhThu;
        private Panel pnTKView;
        private DataGridView dgvAllThongKe;
        private Panel pnTKThongKe;
        private TabControl tbTKMayTram;
        private TabPage tbTKDoanhThu;
        private Panel pnTKCongViec;
        private Panel pnTKThangDT;
        private Button btnTKThangDT;
        private TextBox tbTKThangDT;
        private Label lbTKThangDT;
        private Label lbTittleThangDT;
        private DateTimePicker dtpTKThangDT;
        private RadioButton rbtTittleNamDT;
        private RadioButton rbtTittleThangDT;
        private RadioButton rbtTittleNgayDT;
        private Panel pnTKNamDT;
        private Button btnTKNamDT;
        private TextBox tbTKNamDT;
        private Label lbTKNamDT;
        private Label lbTittleNamDT;
        private DateTimePicker dtpTKNamDT;
        private Panel pnTKNgayDT;
        private Button btnTKNgayDT;
        private TextBox tbTKNgayDT;
        private Label lbTKNgayDT;
        private Label lbTittleNgayDT;
        private DateTimePicker dtpTKNgayDT;
        private TabPage tabPage2;
        private Panel pnTKTGMayTram;
        private Panel panel6;
        private Button btnTKNamMT;
        private Label lbTittleNamMT;
        private DateTimePicker dtpTKNamMT;
        private Panel panel7;
        private Button btnTKThangMT;
        private Label lbTittleThangMT;
        private DateTimePicker dtpTKThangMT;
        private Panel panel8;
        private Button btnTKNgayMT;
        private Label lbTittleNgayMT;
        private DateTimePicker dtpTKNgayMT;
        private RadioButton rbtTittleNamMT;
        private RadioButton rbtTittleThangMT;
        private RadioButton rbtTittleNgayMT;
        private TabPage tbTKThucAn;
        private Label lbLoaiTKThucAn;
        private Button btnTKChucNangTA;
        private ComboBox cbxTKThucAn;
        private TabPage tnTKKhachHang;
        private Panel pnTKChucNangKH;
        private Button btnTKKhacKH;
        private Label lbTKKhacKH;
        private ComboBox cbxTKKhacKH;
        private Panel pnTKKHVip;
        private Button btnTKXemKHTop;
        private Label lbTKKHVip;
        private Panel pnTKLenhKH;
        private Panel pnTKKhungThangKH;
        private Button btnTKXemKH;
        private Label StTKEndKH;
        private Label lbTKStartKH;
        private DateTimePicker dtpTKEndKH;
        private DateTimePicker dtpTKStartKH;
        private Label lbTKTittleThangKH;
        private Panel pnTKNutChucNangTK;
        private Label label4;
        private Label label5;
        private Button btnTKSoDo;
        private Button btnTKXuatFile;
        private Button btnTKQLUngDung;
    }
}