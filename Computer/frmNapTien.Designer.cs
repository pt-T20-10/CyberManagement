namespace CyberManagementProject.Computer
{
    partial class frmNapTien
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            nrupNapTienSoTien = new NumericUpDown();
            lbNapTienSoTien = new Label();
            textBox2 = new TextBox();
            lbNapTienThoiGianConLai = new Label();
            lbUserNameNapTien = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nrupNapTienSoTien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(nrupNapTienSoTien);
            groupBox1.Controls.Add(lbNapTienSoTien);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(lbNapTienThoiGianConLai);
            groupBox1.Controls.Add(lbUserNameNapTien);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(8, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 296);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nạp tiền";
            // 
            // button1
            // 
            button1.Location = new Point(72, 248);
            button1.Name = "button1";
            button1.Size = new Size(104, 40);
            button1.TabIndex = 6;
            button1.Text = "Nạp tiền";
            button1.UseVisualStyleBackColor = true;
            // 
            // nrupNapTienSoTien
            // 
            nrupNapTienSoTien.Location = new Point(40, 208);
            nrupNapTienSoTien.Name = "nrupNapTienSoTien";
            nrupNapTienSoTien.Size = new Size(178, 23);
            nrupNapTienSoTien.TabIndex = 5;
            // 
            // lbNapTienSoTien
            // 
            lbNapTienSoTien.AutoSize = true;
            lbNapTienSoTien.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbNapTienSoTien.Location = new Point(40, 176);
            lbNapTienSoTien.Name = "lbNapTienSoTien";
            lbNapTienSoTien.Size = new Size(86, 20);
            lbNapTienSoTien.TabIndex = 4;
            lbNapTienSoTien.Text = "Số tiền nạp";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 3;
            // 
            // lbNapTienThoiGianConLai
            // 
            lbNapTienThoiGianConLai.AutoSize = true;
            lbNapTienThoiGianConLai.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbNapTienThoiGianConLai.Location = new Point(40, 104);
            lbNapTienThoiGianConLai.Name = "lbNapTienThoiGianConLai";
            lbNapTienThoiGianConLai.Size = new Size(122, 20);
            lbNapTienThoiGianConLai.TabIndex = 2;
            lbNapTienThoiGianConLai.Text = "Thời gian còn lại";
            // 
            // lbUserNameNapTien
            // 
            lbUserNameNapTien.AutoSize = true;
            lbUserNameNapTien.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbUserNameNapTien.Location = new Point(32, 32);
            lbUserNameNapTien.Name = "lbUserNameNapTien";
            lbUserNameNapTien.Size = new Size(75, 20);
            lbUserNameNapTien.TabIndex = 1;
            lbUserNameNapTien.Text = "Tài khoản";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 64);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 0;
            // 
            // frmNapTien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 304);
            Controls.Add(groupBox1);
            Name = "frmNapTien";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmNapTien";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nrupNapTienSoTien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label lbNapTienThoiGianConLai;
        private Label lbUserNameNapTien;
        private TextBox textBox1;
        private Label lbNapTienSoTien;
        private Button button1;
        private NumericUpDown nrupNapTienSoTien;
    }
}