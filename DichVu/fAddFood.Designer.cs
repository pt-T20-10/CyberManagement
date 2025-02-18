namespace QuanLyQuanNet
{
    partial class fAddFood
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
            btnExt = new Button();
            btnLuu = new Button();
            cbLoai = new ComboBox();
            txbGia = new TextBox();
            txbTenMonAn = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnChonAnh = new Label();
            ptFood = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptFood).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExt);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(cbLoai);
            panel1.Controls.Add(txbGia);
            panel1.Controls.Add(txbTenMonAn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnChonAnh);
            panel1.Controls.Add(ptFood);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 192);
            panel1.TabIndex = 0;
            // 
            // btnExt
            // 
            btnExt.Location = new Point(472, 144);
            btnExt.Name = "btnExt";
            btnExt.Size = new Size(94, 29);
            btnExt.TabIndex = 6;
            btnExt.Text = "Thoát";
            btnExt.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(600, 144);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnAdd_Click;
            // 
            // cbLoai
            // 
            cbLoai.FormattingEnabled = true;
            cbLoai.Location = new Point(360, 56);
            cbLoai.Name = "cbLoai";
            cbLoai.Size = new Size(336, 28);
            cbLoai.TabIndex = 3;
            // 
            // txbGia
            // 
            txbGia.Location = new Point(360, 96);
            txbGia.Name = "txbGia";
            txbGia.Size = new Size(333, 27);
            txbGia.TabIndex = 4;
            txbGia.TextChanged += textBox4_TextChanged;
            // 
            // txbTenMonAn
            // 
            txbTenMonAn.Location = new Point(360, 16);
            txbTenMonAn.Name = "txbTenMonAn";
            txbTenMonAn.Size = new Size(333, 27);
            txbTenMonAn.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 104);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 1;
            label4.Text = "Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 64);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 1;
            label3.Text = "Loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 24);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Món Ăn";
            // 
            // btnChonAnh
            // 
            btnChonAnh.AutoSize = true;
            btnChonAnh.BorderStyle = BorderStyle.FixedSingle;
            btnChonAnh.Location = new Point(64, 136);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(75, 22);
            btnChonAnh.TabIndex = 1;
            btnChonAnh.Text = "Chọn Ảnh";
            btnChonAnh.Click += label1_Click;
            // 
            // ptFood
            // 
            ptFood.BackColor = SystemColors.ActiveCaption;
            ptFood.Location = new Point(40, 16);
            ptFood.Name = "ptFood";
            ptFood.Size = new Size(120, 104);
            ptFood.TabIndex = 0;
            ptFood.TabStop = false;
            // 
            // fAddFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 197);
            Controls.Add(panel1);
            Name = "fAddFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAddFood";
            Load += fAddFood_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox ptFood;
        private Label btnChonAnh;
        private TextBox txbGia;
        private TextBox txbTenMonAn;
        private Button btnExt;
        private Button btnLuu;
        private ComboBox cbLoai;
    }
}