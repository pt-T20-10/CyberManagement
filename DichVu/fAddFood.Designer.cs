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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 144);
            panel1.TabIndex = 0;
            // 
            // btnExt
            // 
            btnExt.Location = new Point(413, 108);
            btnExt.Margin = new Padding(3, 2, 3, 2);
            btnExt.Name = "btnExt";
            btnExt.Size = new Size(82, 22);
            btnExt.TabIndex = 6;
            btnExt.Text = "Thoát";
            btnExt.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(525, 108);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(82, 22);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnAdd_Click;
            // 
            // cbLoai
            // 
            cbLoai.FormattingEnabled = true;
            cbLoai.Location = new Point(315, 42);
            cbLoai.Margin = new Padding(3, 2, 3, 2);
            cbLoai.Name = "cbLoai";
            cbLoai.Size = new Size(294, 23);
            cbLoai.TabIndex = 3;
            // 
            // txbGia
            // 
            txbGia.Location = new Point(315, 72);
            txbGia.Margin = new Padding(3, 2, 3, 2);
            txbGia.Name = "txbGia";
            txbGia.Size = new Size(292, 23);
            txbGia.TabIndex = 4;
            txbGia.TextChanged += textBox4_TextChanged;
            // 
            // txbTenMonAn
            // 
            txbTenMonAn.Location = new Point(315, 12);
            txbTenMonAn.Margin = new Padding(3, 2, 3, 2);
            txbTenMonAn.Name = "txbTenMonAn";
            txbTenMonAn.Size = new Size(292, 23);
            txbTenMonAn.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 78);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 1;
            label4.Text = "Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 48);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 1;
            label3.Text = "Loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 18);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên Món Ăn";
            // 
            // btnChonAnh
            // 
            btnChonAnh.AutoSize = true;
            btnChonAnh.BorderStyle = BorderStyle.FixedSingle;
            btnChonAnh.Location = new Point(56, 102);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(63, 17);
            btnChonAnh.TabIndex = 1;
            btnChonAnh.Text = "Chọn Ảnh";
            btnChonAnh.Click += label1_Click;
            // 
            // ptFood
            // 
            ptFood.BackColor = SystemColors.ActiveCaption;
            ptFood.Location = new Point(35, 12);
            ptFood.Margin = new Padding(3, 2, 3, 2);
            ptFood.Name = "ptFood";
            ptFood.Size = new Size(105, 78);
            ptFood.TabIndex = 0;
            ptFood.TabStop = false;
            // 
            // fAddFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 148);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fAddFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm đồ ăn";
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