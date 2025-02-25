namespace CyberManagementProject.DichVu
{
    partial class fEditCategory
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
            label2 = new Label();
            label1 = new Label();
            txbCategoryName = new TextBox();
            txbCategoryID = new TextBox();
            panel2 = new Panel();
            dtgvCategory = new DataGridView();
            btnAddCategory = new Button();
            btnEditCategory = new Button();
            btnDeleteCategory = new Button();
            label3 = new Label();
            cbNewCategory = new ComboBox();
            btnTransferFood = new Button();
            btnExit = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 72);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "ID Loại";
            // 
            // txbCategoryName
            // 
            txbCategoryName.Location = new Point(88, 16);
            txbCategoryName.Name = "txbCategoryName";
            txbCategoryName.Size = new Size(168, 27);
            txbCategoryName.TabIndex = 0;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(88, 72);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.Size = new Size(168, 27);
            txbCategoryID.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvCategory);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 360);
            panel2.TabIndex = 1;
            // 
            // dtgvCategory
            // 
            dtgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(8, 8);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 51;
            dtgvCategory.Size = new Size(416, 344);
            dtgvCategory.TabIndex = 0;
            dtgvCategory.VirtualMode = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(16, 128);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(94, 29);
            btnAddCategory.TabIndex = 2;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(128, 128);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(94, 29);
            btnEditCategory.TabIndex = 2;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = true;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(240, 128);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(94, 29);
            btnDeleteCategory.TabIndex = 2;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 16);
            label3.Name = "label3";
            label3.Size = new Size(175, 20);
            label3.TabIndex = 3;
            label3.Text = "Chuyển món ăn sang loại";
            // 
            // cbNewCategory
            // 
            cbNewCategory.FormattingEnabled = true;
            cbNewCategory.Location = new Point(56, 40);
            cbNewCategory.Name = "cbNewCategory";
            cbNewCategory.Size = new Size(200, 28);
            cbNewCategory.TabIndex = 4;
            // 
            // btnTransferFood
            // 
            btnTransferFood.Location = new Point(160, 88);
            btnTransferFood.Name = "btnTransferFood";
            btnTransferFood.Size = new Size(94, 29);
            btnTransferFood.TabIndex = 5;
            btnTransferFood.Text = "Chuyển";
            btnTransferFood.UseVisualStyleBackColor = true;
            btnTransferFood.Click += btnTransferFood_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(688, 368);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txbCategoryID);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txbCategoryName);
            panel3.Controls.Add(btnAddCategory);
            panel3.Controls.Add(btnDeleteCategory);
            panel3.Controls.Add(btnEditCategory);
            panel3.Location = new Point(440, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(344, 184);
            panel3.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnTransferFood);
            panel1.Controls.Add(cbNewCategory);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(440, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 160);
            panel1.TabIndex = 8;
            // 
            // fEditCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 415);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Name = "fEditCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loại Đồ Ăn";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txbCategoryID;
        private Panel panel2;
        private Label label1;
        private TextBox txbCategoryName;
        private Label label2;
        private DataGridView dtgvCategory;
        private Button btnAddCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Label label3;
        private ComboBox cbNewCategory;
        private Button btnTransferFood;
        private Button btnExit;
        private Panel panel3;
        private Panel panel1;
    }
}