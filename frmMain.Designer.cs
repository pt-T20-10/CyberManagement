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
            customTabControl1 = new DTO.CustomTabControl();
            pnlLeft.SuspendLayout();
            pnlTitleBar.SuspendLayout();
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
            // customTabControl1
            // 
            customTabControl1.Location = new Point(240, 56);
            customTabControl1.Name = "customTabControl1";
            customTabControl1.SelectedIndex = 0;
            customTabControl1.Size = new Size(1112, 672);
            customTabControl1.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(customTabControl1);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            pnlLeft.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
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
        private DTO.CustomTabControl customTabControl1;
    }
}