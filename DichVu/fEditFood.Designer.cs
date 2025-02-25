namespace CyberManagementProject.DichVu
{
    partial class fEditFood
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
            btnXoa = new Button();
            btnExt = new Button();
            btnCapNhat = new Button();
            cbLoai = new ComboBox();
            txbGia = new TextBox();
            txbTenMonAn = new TextBox();
            txbID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnChonAnh = new Label();
            label1 = new Label();
            ptFood = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptFood).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnExt);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(cbLoai);
            panel1.Controls.Add(txbGia);
            panel1.Controls.Add(txbTenMonAn);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnChonAnh);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ptFood);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 240);
            panel1.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(480, 184);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnExt_Click;
            // 
            // btnExt
            // 
            btnExt.Location = new Point(360, 184);
            btnExt.Name = "btnExt";
            btnExt.Size = new Size(94, 29);
            btnExt.TabIndex = 6;
            btnExt.Text = "Thoát";
            btnExt.UseVisualStyleBackColor = true;
            btnExt.Click += btnExt_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(600, 184);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 5;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // cbLoai
            // 
            cbLoai.FormattingEnabled = true;
            cbLoai.Location = new Point(360, 88);
            cbLoai.Name = "cbLoai";
            cbLoai.Size = new Size(335, 28);
            cbLoai.TabIndex = 3;
            // 
            // txbGia
            // 
            txbGia.Location = new Point(360, 128);
            txbGia.Name = "txbGia";
            txbGia.Size = new Size(333, 27);
            txbGia.TabIndex = 4;
            // 
            // txbTenMonAn
            // 
            txbTenMonAn.Location = new Point(360, 48);
            txbTenMonAn.Name = "txbTenMonAn";
            txbTenMonAn.Size = new Size(333, 27);
            txbTenMonAn.TabIndex = 2;
            // 
            // txbID
            // 
            txbID.Location = new Point(360, 8);
            txbID.Name = "txbID";
            txbID.ReadOnly = true;
            txbID.Size = new Size(333, 27);
            txbID.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 136);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 1;
            label4.Text = "Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 96);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 1;
            label3.Text = "Loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 56);
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
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 16);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
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
            // fEditFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 241);
            Controls.Add(panel1);
            Name = "fEditFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chỉnh sửa đồ ăn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExt;
        private Button btnCapNhat;
        private ComboBox cbLoai;
        private TextBox txbGia;
        private TextBox txbTenMonAn;
        private TextBox txbID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label btnChonAnh;
        private Label label1;
        private PictureBox ptFood;
        private Button btnXoa;
    }
}