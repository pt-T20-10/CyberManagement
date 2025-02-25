namespace CyberManagementProject.DichVu
{
    partial class fAddCategory
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
            panel3 = new Panel();
            label2 = new Label();
            txbCategoryName = new TextBox();
            btnAddCategory = new Button();
            btnDeleteCategory = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txbCategoryName);
            panel3.Controls.Add(btnAddCategory);
            panel3.Controls.Add(btnDeleteCategory);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(304, 120);
            panel3.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 16);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Loại";
            // 
            // txbCategoryName
            // 
            txbCategoryName.Location = new Point(88, 16);
            txbCategoryName.Name = "txbCategoryName";
            txbCategoryName.Size = new Size(208, 27);
            txbCategoryName.TabIndex = 0;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(200, 64);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(94, 29);
            btnAddCategory.TabIndex = 2;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(96, 64);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(94, 29);
            btnDeleteCategory.TabIndex = 2;
            btnDeleteCategory.Text = "Thoát";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // fAddCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 125);
            Controls.Add(panel3);
            Name = "fAddCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Loại Đồ Ăn";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label2;
        private TextBox txbCategoryName;
        private Button btnAddCategory;
        private Button btnDeleteCategory;
    }
}