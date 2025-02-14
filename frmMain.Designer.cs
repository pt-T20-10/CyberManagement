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
            tbpStaff.SuspendLayout();
            pnDuongDanStaff.SuspendLayout();
            grbQuanLyNhanVien.SuspendLayout();
            pnDisplayStaff.SuspendLayout();
            pnStaffControl.SuspendLayout();
            tbpStatictical.SuspendLayout();
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
            pnlLeft.Location = new Point(0, 40);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(216, 688);
            pnlLeft.TabIndex = 0;
            // 
            // pnStatictical
            // 
            pnStatictical.Controls.Add(pictureBox12);
            pnStatictical.Controls.Add(label31);
            pnStatictical.Location = new Point(8, 552);
            pnStatictical.Name = "pnStatictical";
            pnStatictical.Size = new Size(200, 80);
            pnStatictical.TabIndex = 3;
            pnStatictical.Click += pnStatictical_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.bill;
            pictureBox12.Location = new Point(8, 16);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(50, 50);
            pictureBox12.TabIndex = 5;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
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
            label31.Click += label31_Click;
            // 
            // pnStaff
            // 
            pnStaff.Controls.Add(pictureBox11);
            pnStaff.Controls.Add(lblNhanVien);
            pnStaff.Location = new Point(8, 416);
            pnStaff.Name = "pnStaff";
            pnStaff.Size = new Size(200, 80);
            pnStaff.TabIndex = 3;
            pnStaff.Click += pnStaff_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.staff;
            pictureBox11.Location = new Point(8, 16);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(50, 50);
            pictureBox11.TabIndex = 5;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhanVien.Location = new Point(56, 24);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(125, 32);
            lblNhanVien.TabIndex = 4;
            lblNhanVien.Text = "Nhân viên";
            lblNhanVien.Click += lblNhanVien_Click;
            // 
            // pnServices
            // 
            pnServices.Controls.Add(pictureBox10);
            pnServices.Controls.Add(label29);
            pnServices.Location = new Point(8, 280);
            pnServices.Name = "pnServices";
            pnServices.Size = new Size(200, 80);
            pnServices.TabIndex = 3;
            pnServices.Click += pnServices_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.food;
            pictureBox10.Location = new Point(8, 16);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(50, 50);
            pictureBox10.TabIndex = 5;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
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
            label29.Click += label29_Click;
            // 
            // pnAccount
            // 
            pnAccount.Controls.Add(pictureBox9);
            pnAccount.Controls.Add(label28);
            pnAccount.Location = new Point(8, 144);
            pnAccount.Name = "pnAccount";
            pnAccount.Size = new Size(200, 80);
            pnAccount.TabIndex = 3;
            pnAccount.Click += pnAccount_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.useracount;
            pictureBox9.Location = new Point(8, 16);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(50, 50);
            pictureBox9.TabIndex = 5;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
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
            label28.Click += label28_Click;
            // 
            // pnComputer
            // 
            pnComputer.Controls.Add(pictureBox8);
            pnComputer.Controls.Add(label27);
            pnComputer.Location = new Point(8, 8);
            pnComputer.Name = "pnComputer";
            pnComputer.Size = new Size(200, 80);
            pnComputer.TabIndex = 3;
            pnComputer.Click += pnComputer_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.monitor;
            pictureBox8.Location = new Point(8, 16);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(50, 50);
            pictureBox8.TabIndex = 5;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(71, 24);
            label27.Name = "label27";
            label27.Size = new Size(111, 32);
            label27.TabIndex = 4;
            label27.Text = "Máy tính";
            label27.Click += label27_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(248, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1105, 632);
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
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1352, 40);
            pnlTitleBar.TabIndex = 1;
            // 
            // pbxClose
            // 
            pbxClose.Image = Properties.Resources.close;
            pbxClose.Location = new Point(1305, 0);
            pbxClose.Name = "pbxClose";
            pbxClose.Size = new Size(40, 40);
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
            flpListComputer.Location = new Point(239, 56);
            flpListComputer.Name = "flpListComputer";
            flpListComputer.Size = new Size(1112, 672);
            flpListComputer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(440, 8);
            label1.Name = "label1";
            label1.Size = new Size(484, 32);
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
            tblMain.Location = new Point(216, 40);
            tblMain.Name = "tblMain";
            tblMain.SelectedIndex = 0;
            tblMain.Size = new Size(1128, 688);
            tblMain.TabIndex = 2;
            // 
            // tbpComputer
            // 
            tbpComputer.Controls.Add(pnComputerControl);
            tbpComputer.Controls.Add(flpComputer);
            tbpComputer.Location = new Point(0, 0);
            tbpComputer.Name = "tbpComputer";
            tbpComputer.Padding = new Padding(3);
            tbpComputer.Size = new Size(1128, 688);
            tbpComputer.TabIndex = 0;
            tbpComputer.Text = "tabPage1";
            tbpComputer.UseVisualStyleBackColor = true;
            // 
            // pnComputerControl
            // 
            pnComputerControl.BorderStyle = BorderStyle.FixedSingle;
            pnComputerControl.Controls.Add(gbxComputerInfor);
            pnComputerControl.Controls.Add(pnComputerButton);
            pnComputerControl.Location = new Point(784, -8);
            pnComputerControl.Name = "pnComputerControl";
            pnComputerControl.Size = new Size(344, 688);
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
            gbxComputerInfor.Location = new Point(8, 8);
            gbxComputerInfor.Name = "gbxComputerInfor";
            gbxComputerInfor.Size = new Size(328, 456);
            gbxComputerInfor.TabIndex = 0;
            gbxComputerInfor.TabStop = false;
            gbxComputerInfor.Text = "Máy tính";
            // 
            // lvServices
            // 
            lvServices.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvServices.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvServices.Location = new Point(8, 200);
            lvServices.Name = "lvServices";
            lvServices.Size = new Size(320, 200);
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
            pnStatusCom.Location = new Point(8, 144);
            pnStatusCom.Name = "pnStatusCom";
            pnStatusCom.Size = new Size(296, 48);
            pnStatusCom.TabIndex = 3;
            // 
            // lbStatusCom
            // 
            lbStatusCom.AutoSize = true;
            lbStatusCom.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStatusCom.Location = new Point(0, 16);
            lbStatusCom.Name = "lbStatusCom";
            lbStatusCom.Size = new Size(82, 20);
            lbStatusCom.TabIndex = 2;
            lbStatusCom.Text = "Trạng thái:";
            // 
            // tbxComputerStatus
            // 
            tbxComputerStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxComputerStatus.Location = new Point(97, 8);
            tbxComputerStatus.Name = "tbxComputerStatus";
            tbxComputerStatus.ReadOnly = true;
            tbxComputerStatus.RightToLeft = RightToLeft.No;
            tbxComputerStatus.Size = new Size(191, 25);
            tbxComputerStatus.TabIndex = 1;
            tbxComputerStatus.Text = "Đang sử dụng\r\n\r\n";
            // 
            // pnTimeCom
            // 
            pnTimeCom.Controls.Add(lbTimeConLai);
            pnTimeCom.Controls.Add(tbxTimeLeft);
            pnTimeCom.Location = new Point(8, 88);
            pnTimeCom.Name = "pnTimeCom";
            pnTimeCom.Size = new Size(296, 48);
            pnTimeCom.TabIndex = 3;
            // 
            // lbTimeConLai
            // 
            lbTimeConLai.AutoSize = true;
            lbTimeConLai.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTimeConLai.Location = new Point(0, 16);
            lbTimeConLai.Name = "lbTimeConLai";
            lbTimeConLai.Size = new Size(77, 20);
            lbTimeConLai.TabIndex = 2;
            lbTimeConLai.Text = "Thời gian:";
            // 
            // tbxTimeLeft
            // 
            tbxTimeLeft.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxTimeLeft.Location = new Point(97, 8);
            tbxTimeLeft.Name = "tbxTimeLeft";
            tbxTimeLeft.ReadOnly = true;
            tbxTimeLeft.Size = new Size(191, 25);
            tbxTimeLeft.TabIndex = 1;
            tbxTimeLeft.Text = "00:00:00";
            // 
            // pnTongTienCom
            // 
            pnTongTienCom.Controls.Add(lbTotalPriceDichVu);
            pnTongTienCom.Controls.Add(tbxMoneyCost);
            pnTongTienCom.Location = new Point(16, 400);
            pnTongTienCom.Name = "pnTongTienCom";
            pnTongTienCom.Size = new Size(312, 48);
            pnTongTienCom.TabIndex = 3;
            // 
            // lbTotalPriceDichVu
            // 
            lbTotalPriceDichVu.AutoSize = true;
            lbTotalPriceDichVu.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalPriceDichVu.Location = new Point(0, 16);
            lbTotalPriceDichVu.Name = "lbTotalPriceDichVu";
            lbTotalPriceDichVu.Size = new Size(78, 20);
            lbTotalPriceDichVu.TabIndex = 2;
            lbTotalPriceDichVu.Text = "Tổng tiền:";
            // 
            // tbxMoneyCost
            // 
            tbxMoneyCost.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxMoneyCost.Location = new Point(96, 16);
            tbxMoneyCost.Name = "tbxMoneyCost";
            tbxMoneyCost.ReadOnly = true;
            tbxMoneyCost.RightToLeft = RightToLeft.No;
            tbxMoneyCost.Size = new Size(192, 25);
            tbxMoneyCost.TabIndex = 1;
            tbxMoneyCost.Text = "0.00";
            tbxMoneyCost.TextAlign = HorizontalAlignment.Right;
            // 
            // pnUserNameCom
            // 
            pnUserNameCom.Controls.Add(lbUserNameCom);
            pnUserNameCom.Controls.Add(tbxUserAccount);
            pnUserNameCom.Location = new Point(8, 32);
            pnUserNameCom.Name = "pnUserNameCom";
            pnUserNameCom.Size = new Size(296, 48);
            pnUserNameCom.TabIndex = 3;
            // 
            // lbUserNameCom
            // 
            lbUserNameCom.AutoSize = true;
            lbUserNameCom.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserNameCom.Location = new Point(0, 16);
            lbUserNameCom.Name = "lbUserNameCom";
            lbUserNameCom.Size = new Size(96, 20);
            lbUserNameCom.TabIndex = 2;
            lbUserNameCom.Text = "Người dùng:";
            // 
            // tbxUserAccount
            // 
            tbxUserAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUserAccount.Location = new Point(97, 8);
            tbxUserAccount.Name = "tbxUserAccount";
            tbxUserAccount.ReadOnly = true;
            tbxUserAccount.Size = new Size(191, 29);
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
            pnComputerButton.Location = new Point(24, 464);
            pnComputerButton.Name = "pnComputerButton";
            pnComputerButton.Size = new Size(296, 208);
            pnComputerButton.TabIndex = 7;
            // 
            // btnExtraMoney
            // 
            btnExtraMoney.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExtraMoney.Location = new Point(160, 84);
            btnExtraMoney.Name = "btnExtraMoney";
            btnExtraMoney.Size = new Size(127, 48);
            btnExtraMoney.TabIndex = 2;
            btnExtraMoney.Text = "Nạp tiền";
            btnExtraMoney.UseVisualStyleBackColor = true;
            btnExtraMoney.Click += btnExtraMoney_Click;
            // 
            // btnManageComputer
            // 
            btnManageComputer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnManageComputer.Location = new Point(0, 16);
            btnManageComputer.Name = "btnManageComputer";
            btnManageComputer.Size = new Size(127, 48);
            btnManageComputer.TabIndex = 3;
            btnManageComputer.Text = "Quản lý";
            btnManageComputer.UseVisualStyleBackColor = true;
            btnManageComputer.Click += btnManageComputer_Click;
            // 
            // btnTrackComputer
            // 
            btnTrackComputer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTrackComputer.Location = new Point(0, 152);
            btnTrackComputer.Name = "btnTrackComputer";
            btnTrackComputer.Size = new Size(127, 48);
            btnTrackComputer.TabIndex = 4;
            btnTrackComputer.Text = "Theo dõi";
            btnTrackComputer.UseVisualStyleBackColor = true;
            // 
            // btnShutDownComputer
            // 
            btnShutDownComputer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnShutDownComputer.Location = new Point(160, 16);
            btnShutDownComputer.Name = "btnShutDownComputer";
            btnShutDownComputer.Size = new Size(127, 48);
            btnShutDownComputer.TabIndex = 5;
            btnShutDownComputer.Text = "Tắt máy";
            btnShutDownComputer.UseVisualStyleBackColor = true;
            btnShutDownComputer.Click += btnShutDownComputer_Click;
            // 
            // btnAddServices
            // 
            btnAddServices.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddServices.Location = new Point(0, 84);
            btnAddServices.Name = "btnAddServices";
            btnAddServices.Size = new Size(127, 48);
            btnAddServices.TabIndex = 6;
            btnAddServices.Text = "Thêm dịch vụ";
            btnAddServices.UseVisualStyleBackColor = true;
            btnAddServices.Click += btnAddServices_Click;
            // 
            // btnForceStop
            // 
            btnForceStop.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnForceStop.Location = new Point(160, 152);
            btnForceStop.Name = "btnForceStop";
            btnForceStop.Size = new Size(127, 48);
            btnForceStop.TabIndex = 7;
            btnForceStop.Text = "Đóng ứng dụng";
            btnForceStop.UseVisualStyleBackColor = true;
            btnForceStop.Click += btnForceStop_Click;
            // 
            // flpComputer
            // 
            flpComputer.BorderStyle = BorderStyle.FixedSingle;
            flpComputer.Location = new Point(0, 0);
            flpComputer.Name = "flpComputer";
            flpComputer.Size = new Size(784, 680);
            flpComputer.TabIndex = 0;
            // 
            // tbpAccount
            // 
            tbpAccount.Controls.Add(pnButtonAccount);
            tbpAccount.Controls.Add(pnDuongDanAccount);
            tbpAccount.Controls.Add(grbKhachHang);
            tbpAccount.Location = new Point(0, 0);
            tbpAccount.Name = "tbpAccount";
            tbpAccount.Padding = new Padding(3);
            tbpAccount.Size = new Size(1128, 688);
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
            pnButtonAccount.Location = new Point(388, 0);
            pnButtonAccount.Name = "pnButtonAccount";
            pnButtonAccount.Size = new Size(732, 56);
            pnButtonAccount.TabIndex = 10;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.BackColor = Color.FromArgb(192, 255, 255);
            btnThemKhachHang.FlatStyle = FlatStyle.Flat;
            btnThemKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemKhachHang.Location = new Point(192, 16);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(127, 31);
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
            btnNhap.Location = new Point(336, 16);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(112, 31);
            btnNhap.TabIndex = 3;
            btnNhap.Text = "Nhập File";
            btnNhap.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(464, 16);
            button2.Name = "button2";
            button2.Size = new Size(112, 31);
            button2.TabIndex = 3;
            button2.Text = "Xuất File";
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_TroChuyen
            // 
            btn_TroChuyen.BackColor = Color.FromArgb(192, 255, 255);
            btn_TroChuyen.FlatStyle = FlatStyle.Flat;
            btn_TroChuyen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TroChuyen.Location = new Point(592, 16);
            btn_TroChuyen.Name = "btn_TroChuyen";
            btn_TroChuyen.Size = new Size(112, 31);
            btn_TroChuyen.TabIndex = 3;
            btn_TroChuyen.Text = "Trò Chuyện";
            btn_TroChuyen.UseVisualStyleBackColor = false;
            // 
            // pnDuongDanAccount
            // 
            pnDuongDanAccount.Controls.Add(lbCurrentAccountPage);
            pnDuongDanAccount.Controls.Add(lbHomeAccountPage);
            pnDuongDanAccount.Location = new Point(13, 0);
            pnDuongDanAccount.Name = "pnDuongDanAccount";
            pnDuongDanAccount.Size = new Size(288, 48);
            pnDuongDanAccount.TabIndex = 9;
            // 
            // lbCurrentAccountPage
            // 
            lbCurrentAccountPage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCurrentAccountPage.Location = new Point(97, 16);
            lbCurrentAccountPage.Name = "lbCurrentAccountPage";
            lbCurrentAccountPage.Size = new Size(176, 23);
            lbCurrentAccountPage.TabIndex = 6;
            lbCurrentAccountPage.Text = "Quản lý khách hàng";
            // 
            // lbHomeAccountPage
            // 
            lbHomeAccountPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHomeAccountPage.Location = new Point(8, 16);
            lbHomeAccountPage.Name = "lbHomeAccountPage";
            lbHomeAccountPage.Size = new Size(88, 23);
            lbHomeAccountPage.TabIndex = 6;
            lbHomeAccountPage.Text = "⟲ Home >";
            lbHomeAccountPage.Click += label33_Click;
            // 
            // grbKhachHang
            // 
            grbKhachHang.Controls.Add(pnTimKimAccount);
            grbKhachHang.Controls.Add(pnDisplayAccount);
            grbKhachHang.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbKhachHang.Location = new Point(13, 64);
            grbKhachHang.Name = "grbKhachHang";
            grbKhachHang.Size = new Size(1107, 616);
            grbKhachHang.TabIndex = 11;
            grbKhachHang.TabStop = false;
            grbKhachHang.Text = "Quản Lý Khách Hàng";
            // 
            // pnTimKimAccount
            // 
            pnTimKimAccount.Controls.Add(cbxNhomKhach);
            pnTimKimAccount.Controls.Add(txtTimKiemKhachHang);
            pnTimKimAccount.Location = new Point(8, 40);
            pnTimKimAccount.Name = "pnTimKimAccount";
            pnTimKimAccount.Size = new Size(1096, 48);
            pnTimKimAccount.TabIndex = 8;
            // 
            // cbxNhomKhach
            // 
            cbxNhomKhach.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxNhomKhach.Location = new Point(440, 8);
            cbxNhomKhach.Name = "cbxNhomKhach";
            cbxNhomKhach.Size = new Size(121, 33);
            cbxNhomKhach.TabIndex = 5;
            cbxNhomKhach.SelectedIndexChanged += cbxNhomKhach_SelectedIndexChanged;
            // 
            // txtTimKiemKhachHang
            // 
            txtTimKiemKhachHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiemKhachHang.Location = new Point(8, 8);
            txtTimKiemKhachHang.Multiline = true;
            txtTimKiemKhachHang.Name = "txtTimKiemKhachHang";
            txtTimKiemKhachHang.Size = new Size(424, 32);
            txtTimKiemKhachHang.TabIndex = 4;
            txtTimKiemKhachHang.TextChanged += txtTimKiemKhachHang_TextChanged;
            // 
            // pnDisplayAccount
            // 
            pnDisplayAccount.Controls.Add(flpKhachHang);
            pnDisplayAccount.Location = new Point(8, 96);
            pnDisplayAccount.Name = "pnDisplayAccount";
            pnDisplayAccount.Size = new Size(1096, 512);
            pnDisplayAccount.TabIndex = 7;
            // 
            // flpKhachHang
            // 
            flpKhachHang.AutoScroll = true;
            flpKhachHang.Location = new Point(8, 8);
            flpKhachHang.Name = "flpKhachHang";
            flpKhachHang.Size = new Size(1080, 488);
            flpKhachHang.TabIndex = 0;
            flpKhachHang.MouseDown += flpKhachHang_MouseDown;
            // 
            // tbpServices
            // 
            tbpServices.Location = new Point(0, 0);
            tbpServices.Name = "tbpServices";
            tbpServices.Padding = new Padding(3);
            tbpServices.Size = new Size(1128, 688);
            tbpServices.TabIndex = 2;
            tbpServices.Text = "tabPage1";
            tbpServices.UseVisualStyleBackColor = true;
            // 
            // tbpStaff
            // 
            tbpStaff.Controls.Add(pnDuongDanStaff);
            tbpStaff.Controls.Add(grbQuanLyNhanVien);
            tbpStaff.Controls.Add(pnStaffControl);
            tbpStaff.Location = new Point(0, 0);
            tbpStaff.Name = "tbpStaff";
            tbpStaff.Padding = new Padding(3);
            tbpStaff.Size = new Size(1128, 688);
            tbpStaff.TabIndex = 3;
            tbpStaff.Text = "git b";
            tbpStaff.UseVisualStyleBackColor = true;
            // 
            // pnDuongDanStaff
            // 
            pnDuongDanStaff.Controls.Add(lblQuanLyNhanVien);
            pnDuongDanStaff.Controls.Add(lblHome);
            pnDuongDanStaff.Location = new Point(18, 8);
            pnDuongDanStaff.Name = "pnDuongDanStaff";
            pnDuongDanStaff.Size = new Size(288, 48);
            pnDuongDanStaff.TabIndex = 8;
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
            // grbQuanLyNhanVien
            // 
            grbQuanLyNhanVien.Controls.Add(cbxChucVu);
            grbQuanLyNhanVien.Controls.Add(pnDisplayStaff);
            grbQuanLyNhanVien.Controls.Add(cbxTrangThai);
            grbQuanLyNhanVien.Controls.Add(txtTimKiem);
            grbQuanLyNhanVien.FlatStyle = FlatStyle.System;
            grbQuanLyNhanVien.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbQuanLyNhanVien.Location = new Point(0, 64);
            grbQuanLyNhanVien.Name = "grbQuanLyNhanVien";
            grbQuanLyNhanVien.Size = new Size(1120, 609);
            grbQuanLyNhanVien.TabIndex = 6;
            grbQuanLyNhanVien.TabStop = false;
            grbQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // cbxChucVu
            // 
            cbxChucVu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxChucVu.Location = new Point(544, 40);
            cbxChucVu.Name = "cbxChucVu";
            cbxChucVu.Size = new Size(115, 36);
            cbxChucVu.TabIndex = 2;
            cbxChucVu.SelectedIndexChanged += cbxChucVu_SelectedIndexChanged_1;
            // 
            // pnDisplayStaff
            // 
            pnDisplayStaff.Controls.Add(flpNhanVien);
            pnDisplayStaff.Location = new Point(6, 94);
            pnDisplayStaff.Name = "pnDisplayStaff";
            pnDisplayStaff.Size = new Size(1098, 506);
            pnDisplayStaff.TabIndex = 5;
            // 
            // flpNhanVien
            // 
            flpNhanVien.Location = new Point(8, 8);
            flpNhanVien.Name = "flpNhanVien";
            flpNhanVien.Size = new Size(1080, 488);
            flpNhanVien.TabIndex = 4;
            flpNhanVien.MouseDown += flpNhanVien_MouseDown;
            // 
            // cbxTrangThai
            // 
            cbxTrangThai.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxTrangThai.FormattingEnabled = true;
            cbxTrangThai.Location = new Point(672, 40);
            cbxTrangThai.Name = "cbxTrangThai";
            cbxTrangThai.Size = new Size(122, 36);
            cbxTrangThai.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(8, 40);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(521, 37);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // pnStaffControl
            // 
            pnStaffControl.Controls.Add(btnThemMoi);
            pnStaffControl.Controls.Add(btnXuatFile);
            pnStaffControl.Controls.Add(btn_ThongKe);
            pnStaffControl.Location = new Point(386, 0);
            pnStaffControl.Name = "pnStaffControl";
            pnStaffControl.Size = new Size(734, 56);
            pnStaffControl.TabIndex = 7;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.FromArgb(128, 255, 255);
            btnThemMoi.FlatStyle = FlatStyle.Flat;
            btnThemMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMoi.Location = new Point(304, 16);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(127, 31);
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
            btnXuatFile.Location = new Point(440, 16);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(127, 31);
            btnXuatFile.TabIndex = 3;
            btnXuatFile.Text = "Xuất File";
            btnXuatFile.UseVisualStyleBackColor = false;
            // 
            // btn_ThongKe
            // 
            btn_ThongKe.BackColor = Color.FromArgb(128, 255, 255);
            btn_ThongKe.FlatStyle = FlatStyle.Flat;
            btn_ThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThongKe.Location = new Point(575, 16);
            btn_ThongKe.Name = "btn_ThongKe";
            btn_ThongKe.Size = new Size(127, 31);
            btn_ThongKe.TabIndex = 3;
            btn_ThongKe.Text = "Thống Kê";
            btn_ThongKe.UseVisualStyleBackColor = false;
            // 
            // tbpStatictical
            // 
            tbpStatictical.Controls.Add(pnJob);
            tbpStatictical.Location = new Point(0, 0);
            tbpStatictical.Name = "tbpStatictical";
            tbpStatictical.Padding = new Padding(3);
            tbpStatictical.Size = new Size(1128, 688);
            tbpStatictical.TabIndex = 4;
            tbpStatictical.Text = "tabPage1";
            tbpStatictical.UseVisualStyleBackColor = true;
            // 
            // pnJob
            // 
            pnJob.BorderStyle = BorderStyle.FixedSingle;
            pnJob.Dock = DockStyle.Fill;
            pnJob.Location = new Point(3, 3);
            pnJob.Margin = new Padding(2);
            pnJob.Name = "pnJob";
            pnJob.Size = new Size(1122, 682);
            pnJob.TabIndex = 4;
            // 
            // cmsKhachHang
            // 
            cmsKhachHang.Items.AddRange(new ToolStripItem[] { cmsKhachHang_Them, cmsKhachHang_Nhac, cmsKhachHang_TrangChu });
            cmsKhachHang.Name = "cmsKhachHang";
            cmsKhachHang.Size = new Size(214, 70);
            // 
            // cmsKhachHang_Them
            // 
            cmsKhachHang_Them.Name = "cmsKhachHang_Them";
            cmsKhachHang_Them.ShortcutKeys = Keys.Control | Keys.N;
            cmsKhachHang_Them.Size = new Size(213, 22);
            cmsKhachHang_Them.Text = "Thêm khách hàng";
            cmsKhachHang_Them.Click += cmsKhachHang_Them_Click;
            // 
            // cmsKhachHang_Nhac
            // 
            cmsKhachHang_Nhac.Name = "cmsKhachHang_Nhac";
            cmsKhachHang_Nhac.ShortcutKeys = Keys.Control | Keys.M;
            cmsKhachHang_Nhac.Size = new Size(213, 22);
            cmsKhachHang_Nhac.Text = "Nhạc";
            cmsKhachHang_Nhac.Click += cmsKhachHang_Nhac_Click;
            // 
            // cmsKhachHang_TrangChu
            // 
            cmsKhachHang_TrangChu.Name = "cmsKhachHang_TrangChu";
            cmsKhachHang_TrangChu.ShortcutKeys = Keys.Control | Keys.H;
            cmsKhachHang_TrangChu.Size = new Size(213, 22);
            cmsKhachHang_TrangChu.Text = "Trang chủ";
            cmsKhachHang_TrangChu.Click += cmsKhachHang_TrangChu_Click;
            // 
            // cmsNhanVien
            // 
            cmsNhanVien.Items.AddRange(new ToolStripItem[] { cmsNhanVien_Them, cmsNhanVien_Nhac, cmsNhanVien_TrangChu });
            cmsNhanVien.Name = "cmsNhanVien";
            cmsNhanVien.Size = new Size(200, 70);
            // 
            // cmsNhanVien_Them
            // 
            cmsNhanVien_Them.Name = "cmsNhanVien_Them";
            cmsNhanVien_Them.ShortcutKeys = Keys.Alt | Keys.N;
            cmsNhanVien_Them.Size = new Size(199, 22);
            cmsNhanVien_Them.Text = "Thêm nhân viên";
            cmsNhanVien_Them.Click += cmsNhanVien_Them_Click;
            // 
            // cmsNhanVien_Nhac
            // 
            cmsNhanVien_Nhac.Name = "cmsNhanVien_Nhac";
            cmsNhanVien_Nhac.ShortcutKeys = Keys.Control | Keys.M;
            cmsNhanVien_Nhac.Size = new Size(199, 22);
            cmsNhanVien_Nhac.Text = "Nhạc";
            cmsNhanVien_Nhac.Click += cmsNhanVien_Nhac_Click;
            // 
            // cmsNhanVien_TrangChu
            // 
            cmsNhanVien_TrangChu.Name = "cmsNhanVien_TrangChu";
            cmsNhanVien_TrangChu.ShortcutKeys = Keys.Control | Keys.H;
            cmsNhanVien_TrangChu.Size = new Size(199, 22);
            cmsNhanVien_TrangChu.Text = "Trang chủ";
            cmsNhanVien_TrangChu.Click += cmsNhanVien_TrangChu_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 728);
            Controls.Add(tblMain);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
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
            tbpStaff.ResumeLayout(false);
            pnDuongDanStaff.ResumeLayout(false);
            grbQuanLyNhanVien.ResumeLayout(false);
            grbQuanLyNhanVien.PerformLayout();
            pnDisplayStaff.ResumeLayout(false);
            pnStaffControl.ResumeLayout(false);
            tbpStatictical.ResumeLayout(false);
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
    }
}