namespace CyberManagementProject
{
    partial class fViewFood
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
            dtgvFood = new DataGridView();
            panel2 = new Panel();
            btnViewFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            panel3 = new Panel();
            panel32 = new Panel();
            textBox6 = new TextBox();
            label40 = new Label();
            panel33 = new Panel();
            textBox7 = new TextBox();
            label41 = new Label();
            panel4 = new Panel();
            btnSeach = new Button();
            panel14 = new Panel();
            textBox4 = new TextBox();
            panel30 = new Panel();
            comboBox1 = new ComboBox();
            label38 = new Label();
            panel31 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label39 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel32.SuspendLayout();
            panel33.SuspendLayout();
            panel4.SuspendLayout();
            panel14.SuspendLayout();
            panel30.SuspendLayout();
            panel31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvFood);
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 392);
            panel1.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(0, 0);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.Size = new Size(456, 392);
            dtgvFood.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnViewFood);
            panel2.Controls.Add(btnEditFood);
            panel2.Controls.Add(btnDeleteFood);
            panel2.Controls.Add(btnAddFood);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 56);
            panel2.TabIndex = 1;
            // 
            // btnViewFood
            // 
            btnViewFood.Location = new Point(344, 0);
            btnViewFood.Name = "btnViewFood";
            btnViewFood.Size = new Size(94, 56);
            btnViewFood.TabIndex = 0;
            btnViewFood.Text = "Xem";
            btnViewFood.UseVisualStyleBackColor = true;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(232, 0);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(94, 56);
            btnEditFood.TabIndex = 0;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(120, 0);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(94, 56);
            btnDeleteFood.TabIndex = 0;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(16, 0);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 56);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel32);
            panel3.Controls.Add(panel33);
            panel3.Location = new Point(464, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(328, 368);
            panel3.TabIndex = 0;
            // 
            // panel32
            // 
            panel32.Controls.Add(textBox6);
            panel32.Controls.Add(label40);
            panel32.Location = new Point(0, 48);
            panel32.Name = "panel32";
            panel32.Size = new Size(328, 36);
            panel32.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(89, 8);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(236, 27);
            textBox6.TabIndex = 1;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Arial", 10F, FontStyle.Bold);
            label40.ForeColor = SystemColors.ControlText;
            label40.Location = new Point(5, 9);
            label40.Name = "label40";
            label40.Size = new Size(38, 19);
            label40.TabIndex = 0;
            label40.Text = "Tên";
            // 
            // panel33
            // 
            panel33.Controls.Add(textBox7);
            panel33.Controls.Add(label41);
            panel33.Location = new Point(0, 0);
            panel33.Name = "panel33";
            panel33.Size = new Size(328, 37);
            panel33.TabIndex = 2;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(89, 9);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(236, 27);
            textBox7.TabIndex = 1;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Arial", 10F, FontStyle.Bold);
            label41.ForeColor = SystemColors.ControlText;
            label41.Location = new Point(5, 9);
            label41.Name = "label41";
            label41.Size = new Size(36, 19);
            label41.TabIndex = 0;
            label41.Text = "ID: ";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSeach);
            panel4.Location = new Point(464, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(328, 72);
            panel4.TabIndex = 1;
            // 
            // btnSeach
            // 
            btnSeach.Location = new Point(240, 8);
            btnSeach.Name = "btnSeach";
            btnSeach.Size = new Size(80, 56);
            btnSeach.TabIndex = 0;
            btnSeach.Text = "Tìm";
            btnSeach.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            panel14.Controls.Add(textBox4);
            panel14.Location = new Point(464, 16);
            panel14.Name = "panel14";
            panel14.Size = new Size(232, 35);
            panel14.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 27);
            textBox4.TabIndex = 1;
            // 
            // panel30
            // 
            panel30.Controls.Add(comboBox1);
            panel30.Controls.Add(label38);
            panel30.Location = new Point(464, 176);
            panel30.Name = "panel30";
            panel30.Size = new Size(328, 36);
            panel30.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(89, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 28);
            comboBox1.TabIndex = 1;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Arial", 10F, FontStyle.Bold);
            label38.ForeColor = SystemColors.ControlText;
            label38.Location = new Point(5, 9);
            label38.Name = "label38";
            label38.Size = new Size(87, 19);
            label38.TabIndex = 0;
            label38.Text = "Danh Mục";
            // 
            // panel31
            // 
            panel31.Controls.Add(numericUpDown1);
            panel31.Controls.Add(label39);
            panel31.Location = new Point(464, 224);
            panel31.Name = "panel31";
            panel31.Size = new Size(329, 36);
            panel31.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(91, 9);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(235, 27);
            numericUpDown1.TabIndex = 1;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Arial", 10F, FontStyle.Bold);
            label39.ForeColor = SystemColors.ControlText;
            label39.Location = new Point(5, 9);
            label39.Name = "label39";
            label39.Size = new Size(35, 19);
            label39.TabIndex = 0;
            label39.Text = "Giá";
            // 
            // fViewFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel31);
            Controls.Add(panel30);
            Controls.Add(panel14);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fViewFood";
            Text = "fViewFood";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel32.ResumeLayout(false);
            panel32.PerformLayout();
            panel33.ResumeLayout(false);
            panel33.PerformLayout();
            panel4.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel30.ResumeLayout(false);
            panel30.PerformLayout();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dtgvFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private Panel panel4;
        private Button btnEditFood;
        private Button btnViewFood;
        private Button btnSeach;
        private Panel panel14;
        private TextBox textBox4;
        private Panel panel33;
        private TextBox textBox7;
        private Label label41;
        private Panel panel32;
        private TextBox textBox6;
        private Label label40;
        private Panel panel30;
        private ComboBox comboBox1;
        private Label label38;
        private Panel panel31;
        private NumericUpDown numericUpDown1;
        private Label label39;
    }
}