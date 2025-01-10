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
            panel2 = new Panel();
            btnToggleMenu = new Button();
            timerToggle = new System.Windows.Forms.Timer(components);
            pnlTitleBar = new Panel();
            flpListComputer = new FlowLayoutPanel();
            label1 = new Label();
            tblMain = new DTO.CustomTabControl();
            tbpComputer = new TabPage();
            pnComputerControl = new Panel();
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label24 = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            label23 = new Label();
            textBox2 = new TextBox();
            panel11 = new Panel();
            label25 = new Label();
            textBox3 = new TextBox();
            panel12 = new Panel();
            label26 = new Label();
            textBox4 = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pnlLeft.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            tblMain.SuspendLayout();
            tbpComputer.SuspendLayout();
            pnComputerControl.SuspendLayout();
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
            groupBox1.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.LightCyan;
            pnlLeft.Controls.Add(panel2);
            pnlLeft.Location = new Point(0, 56);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(240, 672);
            pnlLeft.TabIndex = 0;
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
            pnComputerControl.Controls.Add(button2);
            pnComputerControl.Controls.Add(button6);
            pnComputerControl.Controls.Add(button5);
            pnComputerControl.Controls.Add(button4);
            pnComputerControl.Controls.Add(button3);
            pnComputerControl.Controls.Add(button1);
            pnComputerControl.Controls.Add(groupBox1);
            pnComputerControl.Location = new Point(800, 0);
            pnComputerControl.Name = "pnComputerControl";
            pnComputerControl.Size = new Size(312, 672);
            pnComputerControl.TabIndex = 1;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(panel12);
            groupBox1.Controls.Add(panel11);
            groupBox1.Controls.Add(panel10);
            groupBox1.Controls.Add(panel9);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 440);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Máy tính 01";
   
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(96, 8);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(168, 29);
            textBox1.TabIndex = 1;
            textBox1.Text = "User01";
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
            // panel9
            // 
            panel9.Controls.Add(label24);
            panel9.Controls.Add(textBox1);
            panel9.Location = new Point(8, 32);
            panel9.Name = "panel9";
            panel9.Size = new Size(272, 48);
            panel9.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Controls.Add(label23);
            panel10.Controls.Add(textBox2);
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
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(96, 8);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(168, 25);
            textBox2.TabIndex = 1;
            textBox2.Text = "1:30:52";
            // 
            // panel11
            // 
            panel11.Controls.Add(label25);
            panel11.Controls.Add(textBox3);
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
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(96, 8);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.RightToLeft = RightToLeft.No;
            textBox3.Size = new Size(168, 25);
            textBox3.TabIndex = 1;
            textBox3.Text = "70.000đ";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // panel12
            // 
            panel12.Controls.Add(label26);
            panel12.Controls.Add(textBox4);
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
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(96, 8);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.RightToLeft = RightToLeft.No;
            textBox4.Size = new Size(168, 25);
            textBox4.TabIndex = 1;
            textBox4.Text = "Đang sử dụng\r\n\r\n";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(8, 264);
            listView1.Name = "listView1";
            listView1.Size = new Size(272, 160);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // button1
            // 
            button1.Location = new Point(16, 456);
            button1.Name = "button1";
            button1.Size = new Size(128, 48);
            button1.TabIndex = 1;
            button1.Text = "Đóng ứng dụng";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(168, 456);
            button2.Name = "button2";
            button2.Size = new Size(128, 48);
            button2.TabIndex = 1;
            button2.Text = "Nạp tiền";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(16, 512);
            button3.Name = "button3";
            button3.Size = new Size(128, 48);
            button3.TabIndex = 1;
            button3.Text = "Thêm dịch vụ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(168, 512);
            button4.Name = "button4";
            button4.Size = new Size(128, 48);
            button4.TabIndex = 1;
            button4.Text = "Tắt máy";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(16, 576);
            button5.Name = "button5";
            button5.Size = new Size(128, 48);
            button5.TabIndex = 1;
            button5.Text = "Theo dõi";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(168, 576);
            button6.Name = "button6";
            button6.Size = new Size(128, 48);
            button6.TabIndex = 1;
            button6.Text = "Quản lý";
            button6.UseVisualStyleBackColor = true;
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
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            tblMain.ResumeLayout(false);
            tbpComputer.ResumeLayout(false);
            pnComputerControl.ResumeLayout(false);
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
            groupBox1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
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
        private GroupBox groupBox1;
        private Panel panel10;
        private Label label23;
        private TextBox textBox2;
        private Panel panel9;
        private Label label24;
        private TextBox textBox1;
        private ListView listView1;
        private Panel panel12;
        private Label label26;
        private TextBox textBox4;
        private Panel panel11;
        private Label label25;
        private TextBox textBox3;
        private Button button2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}