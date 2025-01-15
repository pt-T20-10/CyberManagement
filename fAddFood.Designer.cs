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
            btnAdd = new Button();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            ptFood = new PictureBox();
            label6 = new Label();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptFood).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExt);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ptFood);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 280);
            panel1.TabIndex = 0;
            // 
            // btnExt
            // 
            btnExt.Location = new Point(472, 224);
            btnExt.Name = "btnExt";
            btnExt.Size = new Size(94, 29);
            btnExt.TabIndex = 6;
            btnExt.Text = "Thoát";
            btnExt.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(600, 224);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(360, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(336, 28);
            comboBox1.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(360, 128);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(333, 27);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(360, 48);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(333, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(360, 8);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(333, 27);
            textBox1.TabIndex = 1;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(64, 136);
            label5.Name = "label5";
            label5.Size = new Size(75, 22);
            label5.TabIndex = 1;
            label5.Text = "Chọn Ảnh";
            label5.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 16);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            label1.Click += label1_Click;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 176);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 1;
            label6.Text = "Số Lượng";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(360, 168);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(333, 27);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox4_TextChanged;
            // 
            // fAddFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 267);
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
        private Label label1;
        private PictureBox ptFood;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnExt;
        private Button btnAdd;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox3;
    }
}