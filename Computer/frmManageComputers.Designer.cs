namespace CyberManagementProject.Computer
{
    partial class frmManageComputers
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
            btnAddComputer = new Button();
            btnUpdateComputer = new Button();
            btnDeleteComputer = new Button();
            btnCancelfrm = new Button();
            tbxIDComputer = new TextBox();
            tbxNameComputer = new TextBox();
            tbxPriceComputer = new TextBox();
            tbxNoteComputer = new TextBox();
            lbIDComputer = new Label();
            lbNameComputer = new Label();
            lbPriceComputer = new Label();
            lbNoteComputer = new Label();
            SuspendLayout();
            // 
            // btnAddComputer
            // 
            btnAddComputer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddComputer.Location = new Point(16, 376);
            btnAddComputer.Name = "btnAddComputer";
            btnAddComputer.Size = new Size(115, 40);
            btnAddComputer.TabIndex = 4;
            btnAddComputer.Text = "Thêm";
            btnAddComputer.UseVisualStyleBackColor = true;
            btnAddComputer.Click += btnAddComputer_Click;
            // 
            // btnUpdateComputer
            // 
            btnUpdateComputer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdateComputer.Location = new Point(16, 440);
            btnUpdateComputer.Name = "btnUpdateComputer";
            btnUpdateComputer.Size = new Size(115, 40);
            btnUpdateComputer.TabIndex = 6;
            btnUpdateComputer.Text = "Cập nhật";
            btnUpdateComputer.UseVisualStyleBackColor = true;
            btnUpdateComputer.Click += btnUpdateComputer_Click;
            // 
            // btnDeleteComputer
            // 
            btnDeleteComputer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeleteComputer.Location = new Point(184, 376);
            btnDeleteComputer.Name = "btnDeleteComputer";
            btnDeleteComputer.Size = new Size(115, 40);
            btnDeleteComputer.TabIndex = 5;
            btnDeleteComputer.Text = "Xóa";
            btnDeleteComputer.UseVisualStyleBackColor = true;
            btnDeleteComputer.Click += btnDeleteComputer_Click;
            // 
            // btnCancelfrm
            // 
            btnCancelfrm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelfrm.Location = new Point(184, 440);
            btnCancelfrm.Name = "btnCancelfrm";
            btnCancelfrm.Size = new Size(115, 40);
            btnCancelfrm.TabIndex = 7;
            btnCancelfrm.Text = "Thoát";
            btnCancelfrm.UseVisualStyleBackColor = true;
            btnCancelfrm.Click += btnCancelfrm_Click;
            // 
            // tbxIDComputer
            // 
            tbxIDComputer.Font = new Font("Segoe UI", 14.25F);
            tbxIDComputer.Location = new Point(88, 34);
            tbxIDComputer.Multiline = true;
            tbxIDComputer.Name = "tbxIDComputer";
            tbxIDComputer.PlaceholderText = "ID máy tính";
            tbxIDComputer.ReadOnly = true;
            tbxIDComputer.Size = new Size(224, 32);
            tbxIDComputer.TabIndex = 1;
            // 
            // tbxNameComputer
            // 
            tbxNameComputer.Font = new Font("Segoe UI", 14.25F);
            tbxNameComputer.Location = new Point(88, 106);
            tbxNameComputer.Multiline = true;
            tbxNameComputer.Name = "tbxNameComputer";
            tbxNameComputer.PlaceholderText = "Tên máy tính";
            tbxNameComputer.Size = new Size(224, 32);
            tbxNameComputer.TabIndex = 1;
            // 
            // tbxPriceComputer
            // 
            tbxPriceComputer.Font = new Font("Segoe UI", 14.25F);
            tbxPriceComputer.Location = new Point(88, 178);
            tbxPriceComputer.Multiline = true;
            tbxPriceComputer.Name = "tbxPriceComputer";
            tbxPriceComputer.PlaceholderText = "Giá cho 1 giờ";
            tbxPriceComputer.Size = new Size(224, 32);
            tbxPriceComputer.TabIndex = 2;
            // 
            // tbxNoteComputer
            // 
            tbxNoteComputer.Font = new Font("Segoe UI", 14.25F);
            tbxNoteComputer.Location = new Point(88, 232);
            tbxNoteComputer.Multiline = true;
            tbxNoteComputer.Name = "tbxNoteComputer";
            tbxNoteComputer.PlaceholderText = "...";
            tbxNoteComputer.Size = new Size(224, 112);
            tbxNoteComputer.TabIndex = 3;
            // 
            // lbIDComputer
            // 
            lbIDComputer.AutoSize = true;
            lbIDComputer.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbIDComputer.Location = new Point(16, 40);
            lbIDComputer.Name = "lbIDComputer";
            lbIDComputer.Size = new Size(28, 20);
            lbIDComputer.TabIndex = 2;
            lbIDComputer.Text = "ID:";
            // 
            // lbNameComputer
            // 
            lbNameComputer.AutoSize = true;
            lbNameComputer.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbNameComputer.Location = new Point(16, 112);
            lbNameComputer.Name = "lbNameComputer";
            lbNameComputer.Size = new Size(70, 20);
            lbNameComputer.TabIndex = 2;
            lbNameComputer.Text = "Tên máy:";
            // 
            // lbPriceComputer
            // 
            lbPriceComputer.AutoSize = true;
            lbPriceComputer.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbPriceComputer.Location = new Point(16, 184);
            lbPriceComputer.Name = "lbPriceComputer";
            lbPriceComputer.Size = new Size(35, 20);
            lbPriceComputer.TabIndex = 2;
            lbPriceComputer.Text = "Giá:";
            // 
            // lbNoteComputer
            // 
            lbNoteComputer.AutoSize = true;
            lbNoteComputer.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbNoteComputer.Location = new Point(16, 272);
            lbNoteComputer.Name = "lbNoteComputer";
            lbNoteComputer.Size = new Size(65, 20);
            lbNoteComputer.TabIndex = 2;
            lbNoteComputer.Text = "Ghi chú:";
            // 
            // frmManageComputers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelfrm;
            ClientSize = new Size(334, 501);
            Controls.Add(lbNoteComputer);
            Controls.Add(lbPriceComputer);
            Controls.Add(lbNameComputer);
            Controls.Add(lbIDComputer);
            Controls.Add(tbxNoteComputer);
            Controls.Add(tbxPriceComputer);
            Controls.Add(tbxNameComputer);
            Controls.Add(tbxIDComputer);
            Controls.Add(btnCancelfrm);
            Controls.Add(btnDeleteComputer);
            Controls.Add(btnUpdateComputer);
            Controls.Add(btnAddComputer);
            Name = "frmManageComputers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý máy";
            FormClosing += frmManageComputers_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddComputer;
        private Button btnUpdateComputer;
        private Button btnDeleteComputer;
        private Button btnCancelfrm;
        private TextBox tbxIDComputer;
        private TextBox tbxNameComputer;
        private TextBox tbxPriceComputer;
        private TextBox tbxNoteComputer;
        private Label lbIDComputer;
        private Label lbNameComputer;
        private Label lbPriceComputer;
        private Label lbNoteComputer;
    }
}