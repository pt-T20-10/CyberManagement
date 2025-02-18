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
            btnAddFood = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvFood);
            panel1.Location = new Point(0, 42);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 294);
            panel1.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(8, 0);
            dtgvFood.Margin = new Padding(3, 2, 3, 2);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.Size = new Size(680, 288);
            dtgvFood.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddFood);
            panel2.Location = new Point(8, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(680, 42);
            panel2.TabIndex = 1;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(14, 0);
            btnAddFood.Margin = new Padding(3, 2, 3, 2);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(82, 42);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // fViewFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fViewFood";
            Text = "Thực ăn";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dtgvFood;
        private Button btnAddFood;
    }
}