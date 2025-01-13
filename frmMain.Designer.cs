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
            panel2 = new Panel();
            btnToggleMenu = new Button();
            timerToggle = new System.Windows.Forms.Timer(components);
            pnlTitleBar = new Panel();
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
            panel12 = new Panel();
            label26 = new Label();
            tbxComputerStatus = new TextBox();
            panel11 = new Panel();
            label25 = new Label();
            tbxMoneyCost = new TextBox();
            panel10 = new Panel();
            label23 = new Label();
            tbxTimeLeft = new TextBox();
            panel9 = new Panel();
            label24 = new Label();
            tbxUserAccount = new TextBox();
            pnComputerButton = new Panel();
            btnExtraMoney = new Button();
            btnManageComputer = new Button();
            btnTrackComputer = new Button();
            btnShutDownComputer = new Button();
            btnAddServices = new Button();
            btnForceStop = new Button();
            flpComputer = new FlowLayoutPanel();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            pictureBox5 = new PictureBox();
            panel7 = new Panel();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            pictureBox6 = new PictureBox();
            panel8 = new Panel();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            pictureBox7 = new PictureBox();
            tbpAccount = new TabPage();
            tbpServices = new TabPage();
            tbpStaff = new TabPage();
            tbpStatictical = new TabPage();
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
            tblMain.SuspendLayout();
            tbpComputer.SuspendLayout();
            pnComputerControl.SuspendLayout();
            gbxComputerInfor.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            pnComputerButton.SuspendLayout();
            flpComputer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.LightCyan;
            pnlLeft.Controls.Add(panel17);
            pnlLeft.Controls.Add(panel16);
            pnlLeft.Controls.Add(panel15);
            pnlLeft.Controls.Add(panel14);
            pnlLeft.Controls.Add(panel13);
            pnlLeft.Controls.Add(panel2);
            pnlLeft.Location = new Point(0, 56);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(240, 672);
            pnlLeft.TabIndex = 0;
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
            pictureBox12.Image = Properties.Resources.bill;
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
            pictureBox11.Image = Properties.Resources.staff;
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
            pictureBox10.Image = Properties.Resources.food;
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
            pictureBox9.Image = Properties.Resources.useracount;
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
            pictureBox8.Image = Properties.Resources.monitor;
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
            // panel2
            // 
            panel2.Location = new Point(248, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1104, 632);
            panel2.TabIndex = 2;
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
            btnToggleMenu.Click += btnToggleMenu_Click;
            // 
            // timerToggle
            // 
            timerToggle.Interval = 5;
            timerToggle.Tick += timerToggle_Tick;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.DarkGray;
            pnlTitleBar.Controls.Add(flpListComputer);
            pnlTitleBar.Controls.Add(label1);
            pnlTitleBar.Controls.Add(btnToggleMenu);
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1352, 56);
            pnlTitleBar.TabIndex = 1;
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
            // tblMain
            // 
            tblMain.Controls.Add(tbpComputer);
            tblMain.Controls.Add(tbpAccount);
            tblMain.Controls.Add(tbpServices);
            tblMain.Controls.Add(tbpStaff);
            tblMain.Controls.Add(tbpStatictical);
            tblMain.Location = new Point(240, 56);
            tblMain.Name = "tblMain";
            tblMain.SelectedIndex = 0;
            tblMain.Size = new Size(1112, 672);
            tblMain.TabIndex = 2;
            // 
            // tbpComputer
            // 
            tbpComputer.Controls.Add(pnComputerControl);
            tbpComputer.Controls.Add(flpComputer);
            tbpComputer.Location = new Point(0, 0);
            tbpComputer.Name = "tbpComputer";
            tbpComputer.Padding = new Padding(3);
            tbpComputer.Size = new Size(1112, 672);
            tbpComputer.TabIndex = 0;
            tbpComputer.Text = "tabPage1";
            tbpComputer.UseVisualStyleBackColor = true;
            // 
            // pnComputerControl
            // 
            pnComputerControl.BorderStyle = BorderStyle.FixedSingle;
            pnComputerControl.Controls.Add(gbxComputerInfor);
            pnComputerControl.Controls.Add(pnComputerButton);
            pnComputerControl.Location = new Point(800, 0);
            pnComputerControl.Name = "pnComputerControl";
            pnComputerControl.Size = new Size(312, 672);
            pnComputerControl.TabIndex = 1;
            // 
            // gbxComputerInfor
            // 
            gbxComputerInfor.Controls.Add(lvServices);
            gbxComputerInfor.Controls.Add(panel12);
            gbxComputerInfor.Controls.Add(panel11);
            gbxComputerInfor.Controls.Add(panel10);
            gbxComputerInfor.Controls.Add(panel9);
            gbxComputerInfor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxComputerInfor.Location = new Point(8, 8);
            gbxComputerInfor.Name = "gbxComputerInfor";
            gbxComputerInfor.Size = new Size(288, 440);
            gbxComputerInfor.TabIndex = 0;
            gbxComputerInfor.TabStop = false;
            gbxComputerInfor.Text = "Máy tính 01";
            // 
            // lvServices
            // 
            lvServices.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvServices.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvServices.Location = new Point(8, 264);
            lvServices.Name = "lvServices";
            lvServices.Size = new Size(272, 160);
            lvServices.TabIndex = 4;
            lvServices.UseCompatibleStateImageBehavior = false;
            lvServices.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Món ăn";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Giá";
            columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số lượng";
            columnHeader3.Width = 80;
            // 
            // panel12
            // 
            panel12.Controls.Add(label26);
            panel12.Controls.Add(tbxComputerStatus);
            panel12.Location = new Point(8, 200);
            panel12.Name = "panel12";
            panel12.Size = new Size(272, 48);
            panel12.TabIndex = 3;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(0, 16);
            label26.Name = "label26";
            label26.Size = new Size(82, 20);
            label26.TabIndex = 2;
            label26.Text = "Trạng thái:";
            // 
            // tbxComputerStatus
            // 
            tbxComputerStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxComputerStatus.Location = new Point(96, 8);
            tbxComputerStatus.Name = "tbxComputerStatus";
            tbxComputerStatus.ReadOnly = true;
            tbxComputerStatus.RightToLeft = RightToLeft.No;
            tbxComputerStatus.Size = new Size(168, 25);
            tbxComputerStatus.TabIndex = 1;
            tbxComputerStatus.Text = "Đang sử dụng\r\n\r\n";
            // 
            // panel11
            // 
            panel11.Controls.Add(label25);
            panel11.Controls.Add(tbxMoneyCost);
            panel11.Location = new Point(8, 144);
            panel11.Name = "panel11";
            panel11.Size = new Size(272, 48);
            panel11.TabIndex = 3;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(0, 16);
            label25.Name = "label25";
            label25.Size = new Size(93, 20);
            label25.TabIndex = 2;
            label25.Text = "Tiền đã nạp:";
            // 
            // tbxMoneyCost
            // 
            tbxMoneyCost.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxMoneyCost.Location = new Point(96, 8);
            tbxMoneyCost.Name = "tbxMoneyCost";
            tbxMoneyCost.ReadOnly = true;
            tbxMoneyCost.RightToLeft = RightToLeft.No;
            tbxMoneyCost.Size = new Size(168, 25);
            tbxMoneyCost.TabIndex = 1;
            tbxMoneyCost.Text = "70.000đ";
            tbxMoneyCost.TextAlign = HorizontalAlignment.Right;
            // 
            // panel10
            // 
            panel10.Controls.Add(label23);
            panel10.Controls.Add(tbxTimeLeft);
            panel10.Location = new Point(8, 88);
            panel10.Name = "panel10";
            panel10.Size = new Size(272, 48);
            panel10.TabIndex = 3;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(0, 16);
            label23.Name = "label23";
            label23.Size = new Size(77, 20);
            label23.TabIndex = 2;
            label23.Text = "Thời gian:";
            // 
            // tbxTimeLeft
            // 
            tbxTimeLeft.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxTimeLeft.Location = new Point(96, 8);
            tbxTimeLeft.Name = "tbxTimeLeft";
            tbxTimeLeft.ReadOnly = true;
            tbxTimeLeft.Size = new Size(168, 25);
            tbxTimeLeft.TabIndex = 1;
            tbxTimeLeft.Text = "1:30:52";
            // 
            // panel9
            // 
            panel9.Controls.Add(label24);
            panel9.Controls.Add(tbxUserAccount);
            panel9.Location = new Point(8, 32);
            panel9.Name = "panel9";
            panel9.Size = new Size(272, 48);
            panel9.TabIndex = 3;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(0, 16);
            label24.Name = "label24";
            label24.Size = new Size(96, 20);
            label24.TabIndex = 2;
            label24.Text = "Người dùng:";
            // 
            // tbxUserAccount
            // 
            tbxUserAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUserAccount.Location = new Point(88, 8);
            tbxUserAccount.Name = "tbxUserAccount";
            tbxUserAccount.ReadOnly = true;
            tbxUserAccount.Size = new Size(168, 29);
            tbxUserAccount.TabIndex = 1;
            tbxUserAccount.Text = "User01";
            // 
            // pnComputerButton
            // 
            pnComputerButton.Controls.Add(btnExtraMoney);
            pnComputerButton.Controls.Add(btnManageComputer);
            pnComputerButton.Controls.Add(btnTrackComputer);
            pnComputerButton.Controls.Add(btnShutDownComputer);
            pnComputerButton.Controls.Add(btnAddServices);
            pnComputerButton.Controls.Add(btnForceStop);
            pnComputerButton.Location = new Point(8, 448);
            pnComputerButton.Name = "pnComputerButton";
            pnComputerButton.Size = new Size(288, 216);
            pnComputerButton.TabIndex = 7;
            // 
            // btnExtraMoney
            // 
            btnExtraMoney.Location = new Point(152, 16);
            btnExtraMoney.Name = "btnExtraMoney";
            btnExtraMoney.Size = new Size(128, 48);
            btnExtraMoney.TabIndex = 2;
            btnExtraMoney.Text = "Nạp tiền";
            btnExtraMoney.UseVisualStyleBackColor = true;
            // 
            // btnManageComputer
            // 
            btnManageComputer.Location = new Point(152, 152);
            btnManageComputer.Name = "btnManageComputer";
            btnManageComputer.Size = new Size(128, 48);
            btnManageComputer.TabIndex = 3;
            btnManageComputer.Text = "Quản lý";
            btnManageComputer.UseVisualStyleBackColor = true;
            // 
            // btnTrackComputer
            // 
            btnTrackComputer.Location = new Point(0, 152);
            btnTrackComputer.Name = "btnTrackComputer";
            btnTrackComputer.Size = new Size(128, 48);
            btnTrackComputer.TabIndex = 4;
            btnTrackComputer.Text = "Theo dõi";
            btnTrackComputer.UseVisualStyleBackColor = true;
            // 
            // btnShutDownComputer
            // 
            btnShutDownComputer.Location = new Point(152, 80);
            btnShutDownComputer.Name = "btnShutDownComputer";
            btnShutDownComputer.Size = new Size(128, 48);
            btnShutDownComputer.TabIndex = 5;
            btnShutDownComputer.Text = "Tắt máy";
            btnShutDownComputer.UseVisualStyleBackColor = true;
            // 
            // btnAddServices
            // 
            btnAddServices.Location = new Point(0, 80);
            btnAddServices.Name = "btnAddServices";
            btnAddServices.Size = new Size(128, 48);
            btnAddServices.TabIndex = 6;
            btnAddServices.Text = "Thêm dịch vụ";
            btnAddServices.UseVisualStyleBackColor = true;
            // 
            // btnForceStop
            // 
            btnForceStop.Location = new Point(0, 16);
            btnForceStop.Name = "btnForceStop";
            btnForceStop.Size = new Size(128, 48);
            btnForceStop.TabIndex = 7;
            btnForceStop.Text = "Đóng ứng dụng";
            btnForceStop.UseVisualStyleBackColor = true;
            btnForceStop.Click += btnForceStop_Click;
            // 
            // flpComputer
            // 
            flpComputer.BorderStyle = BorderStyle.FixedSingle;
            flpComputer.Controls.Add(panel1);
            flpComputer.Controls.Add(panel3);
            flpComputer.Controls.Add(panel4);
            flpComputer.Controls.Add(panel5);
            flpComputer.Controls.Add(panel6);
            flpComputer.Controls.Add(panel7);
            flpComputer.Controls.Add(panel8);
            flpComputer.Location = new Point(0, 0);
            flpComputer.Name = "flpComputer";
            flpComputer.Size = new Size(800, 672);
            flpComputer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 213);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 184);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "user01";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 160);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "1:30:52";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 136);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Máy tính 01";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Online;
            pictureBox1.Location = new Point(16, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(158, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(149, 213);
            panel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(48, 184);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 3;
            label5.Text = "user01";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(48, 160);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 2;
            label6.Text = "1:30:52";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 136);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 1;
            label7.Text = "Máy tính 02";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Offline;
            pictureBox2.Location = new Point(16, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(313, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(149, 213);
            panel4.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(48, 184);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 3;
            label8.Text = "user01";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(48, 160);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 2;
            label9.Text = "1:30:52";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(32, 136);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 1;
            label10.Text = "Máy tính 03";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Online;
            pictureBox3.Location = new Point(16, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(468, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(149, 213);
            panel5.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(48, 184);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 3;
            label11.Text = "user01";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(48, 160);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 2;
            label12.Text = "1:30:52";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(32, 136);
            label13.Name = "label13";
            label13.Size = new Size(90, 20);
            label13.TabIndex = 1;
            label13.Text = "Máy tính 02";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Offline;
            pictureBox4.Location = new Point(16, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 120);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(pictureBox5);
            panel6.Location = new Point(623, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(149, 213);
            panel6.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(48, 184);
            label14.Name = "label14";
            label14.Size = new Size(52, 20);
            label14.TabIndex = 3;
            label14.Text = "user01";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(48, 160);
            label15.Name = "label15";
            label15.Size = new Size(55, 20);
            label15.TabIndex = 2;
            label15.Text = "1:30:52";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(32, 136);
            label16.Name = "label16";
            label16.Size = new Size(90, 20);
            label16.TabIndex = 1;
            label16.Text = "Máy tính 03";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Online;
            pictureBox5.Location = new Point(16, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(120, 120);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.WhiteSmoke;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label17);
            panel7.Controls.Add(label18);
            panel7.Controls.Add(label19);
            panel7.Controls.Add(pictureBox6);
            panel7.Location = new Point(3, 222);
            panel7.Name = "panel7";
            panel7.Size = new Size(149, 213);
            panel7.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(48, 184);
            label17.Name = "label17";
            label17.Size = new Size(52, 20);
            label17.TabIndex = 3;
            label17.Text = "user01";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(48, 160);
            label18.Name = "label18";
            label18.Size = new Size(55, 20);
            label18.TabIndex = 2;
            label18.Text = "1:30:52";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(32, 136);
            label19.Name = "label19";
            label19.Size = new Size(90, 20);
            label19.TabIndex = 1;
            label19.Text = "Máy tính 03";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Online;
            pictureBox6.Location = new Point(16, 8);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(120, 120);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.WhiteSmoke;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label20);
            panel8.Controls.Add(label21);
            panel8.Controls.Add(label22);
            panel8.Controls.Add(pictureBox7);
            panel8.Location = new Point(158, 222);
            panel8.Name = "panel8";
            panel8.Size = new Size(149, 213);
            panel8.TabIndex = 5;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(48, 184);
            label20.Name = "label20";
            label20.Size = new Size(52, 20);
            label20.TabIndex = 3;
            label20.Text = "user01";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(48, 160);
            label21.Name = "label21";
            label21.Size = new Size(55, 20);
            label21.TabIndex = 2;
            label21.Text = "1:30:52";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(32, 136);
            label22.Name = "label22";
            label22.Size = new Size(90, 20);
            label22.TabIndex = 1;
            label22.Text = "Máy tính 03";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Online;
            pictureBox7.Location = new Point(16, 8);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(120, 120);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // tbpAccount
            // 
            tbpAccount.Location = new Point(0, 0);
            tbpAccount.Name = "tbpAccount";
            tbpAccount.Padding = new Padding(3);
            tbpAccount.Size = new Size(1112, 672);
            tbpAccount.TabIndex = 1;
            tbpAccount.Text = "tabPage1";
            tbpAccount.UseVisualStyleBackColor = true;
            // 
            // tbpServices
            // 
            tbpServices.Location = new Point(0, 0);
            tbpServices.Name = "tbpServices";
            tbpServices.Padding = new Padding(3);
            tbpServices.Size = new Size(1112, 672);
            tbpServices.TabIndex = 2;
            tbpServices.Text = "tabPage1";
            tbpServices.UseVisualStyleBackColor = true;
            // 
            // tbpStaff
            // 
            tbpStaff.Location = new Point(0, 0);
            tbpStaff.Name = "tbpStaff";
            tbpStaff.Padding = new Padding(3);
            tbpStaff.Size = new Size(1112, 672);
            tbpStaff.TabIndex = 3;
            tbpStaff.Text = "tabPage1";
            tbpStaff.UseVisualStyleBackColor = true;
            // 
            // tbpStatictical
            // 
            tbpStatictical.Location = new Point(0, 0);
            tbpStatictical.Name = "tbpStatictical";
            tbpStatictical.Padding = new Padding(3);
            tbpStatictical.Size = new Size(1112, 672);
            tbpStatictical.TabIndex = 4;
            tbpStatictical.Text = "tabPage1";
            tbpStatictical.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(tblMain);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
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
            tblMain.ResumeLayout(false);
            tbpComputer.ResumeLayout(false);
            pnComputerControl.ResumeLayout(false);
            gbxComputerInfor.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            pnComputerButton.ResumeLayout(false);
            flpComputer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel pnlLeft;
        private Button btnToggleMenu;
        private System.Windows.Forms.Timer timerToggle;
        private Panel pnlTitleBar;
        private Panel panel2;
        private Label label1;
        private FlowLayoutPanel flpListComputer;
        private DTO.CustomTabControl tblMain;
        private TabPage tbpComputer;
        private FlowLayoutPanel flpComputer;
        private Panel pnComputerControl;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox3;
        private Panel panel5;
        private Label label11;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox4;
        private Panel panel6;
        private Label label14;
        private Label label15;
        private Label label16;
        private PictureBox pictureBox5;
        private Panel panel7;
        private Label label17;
        private Label label18;
        private Label label19;
        private PictureBox pictureBox6;
        private Panel panel8;
        private Label label20;
        private Label label21;
        private Label label22;
        private PictureBox pictureBox7;
        private GroupBox gbxComputerInfor;
        private Panel panel10;
        private Label label23;
        private TextBox tbxTimeLeft;
        private Panel panel9;
        private Label label24;
        private TextBox tbxUserAccount;
        private ListView lvServices;
        private Panel panel12;
        private Label label26;
        private TextBox tbxComputerStatus;
        private Panel panel11;
        private Label label25;
        private TextBox tbxMoneyCost;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Panel panel17;
        private Label label31;
        private Panel panel16;
        private Label label30;
        private Panel panel15;
        private Label label29;
        private Panel panel14;
        private Label label28;
        private Panel panel13;
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
        private TabPage tbpServices;
        private TabPage tbpStaff;
        private TabPage tbpStatictical;
    }
}