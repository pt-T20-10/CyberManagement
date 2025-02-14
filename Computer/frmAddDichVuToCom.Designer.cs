namespace CyberManagementProject.Computer
{
    partial class frmAddDichVuToCom
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
            btnAcceptAddDVtoCom = new Button();
            btnCancelAddDVtoCom = new Button();
            cbxAddToComLoaiMon = new ComboBox();
            cbxAddToComMon = new ComboBox();
            nrudAddToComCount = new NumericUpDown();
            lbAddToComLoaiMon = new Label();
            lbAddToComMon = new Label();
            lbAddToComCount = new Label();
            ((System.ComponentModel.ISupportInitialize)nrudAddToComCount).BeginInit();
            SuspendLayout();
            // 
            // btnAcceptAddDVtoCom
            // 
            btnAcceptAddDVtoCom.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAcceptAddDVtoCom.Location = new Point(16, 224);
            btnAcceptAddDVtoCom.Name = "btnAcceptAddDVtoCom";
            btnAcceptAddDVtoCom.Size = new Size(100, 35);
            btnAcceptAddDVtoCom.TabIndex = 0;
            btnAcceptAddDVtoCom.Text = "Thêm ";
            btnAcceptAddDVtoCom.UseVisualStyleBackColor = true;
            btnAcceptAddDVtoCom.Click += btnAcceptAddDVtoCom_Click;
            // 
            // btnCancelAddDVtoCom
            // 
            btnCancelAddDVtoCom.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelAddDVtoCom.Location = new Point(160, 224);
            btnCancelAddDVtoCom.Name = "btnCancelAddDVtoCom";
            btnCancelAddDVtoCom.Size = new Size(100, 35);
            btnCancelAddDVtoCom.TabIndex = 1;
            btnCancelAddDVtoCom.Text = "Thoát";
            btnCancelAddDVtoCom.UseVisualStyleBackColor = true;
            // 
            // cbxAddToComLoaiMon
            // 
            cbxAddToComLoaiMon.FormattingEnabled = true;
            cbxAddToComLoaiMon.Location = new Point(40, 40);
            cbxAddToComLoaiMon.Name = "cbxAddToComLoaiMon";
            cbxAddToComLoaiMon.Size = new Size(160, 23);
            cbxAddToComLoaiMon.TabIndex = 2;
            cbxAddToComLoaiMon.SelectedIndexChanged += cbxAddToComLoaiMon_SelectedIndexChanged;
            // 
            // cbxAddToComMon
            // 
            cbxAddToComMon.FormattingEnabled = true;
            cbxAddToComMon.Location = new Point(40, 112);
            cbxAddToComMon.Name = "cbxAddToComMon";
            cbxAddToComMon.Size = new Size(160, 23);
            cbxAddToComMon.TabIndex = 3;
            // 
            // nrudAddToComCount
            // 
            nrudAddToComCount.Location = new Point(136, 168);
            nrudAddToComCount.Name = "nrudAddToComCount";
            nrudAddToComCount.Size = new Size(56, 23);
            nrudAddToComCount.TabIndex = 4;
            nrudAddToComCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbAddToComLoaiMon
            // 
            lbAddToComLoaiMon.AutoSize = true;
            lbAddToComLoaiMon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbAddToComLoaiMon.Location = new Point(40, 8);
            lbAddToComLoaiMon.Name = "lbAddToComLoaiMon";
            lbAddToComLoaiMon.Size = new Size(46, 21);
            lbAddToComLoaiMon.TabIndex = 5;
            lbAddToComLoaiMon.Text = "Loại ";
            // 
            // lbAddToComMon
            // 
            lbAddToComMon.AutoSize = true;
            lbAddToComMon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbAddToComMon.Location = new Point(40, 80);
            lbAddToComMon.Name = "lbAddToComMon";
            lbAddToComMon.Size = new Size(45, 21);
            lbAddToComMon.TabIndex = 5;
            lbAddToComMon.Text = "Món";
            // 
            // lbAddToComCount
            // 
            lbAddToComCount.AutoSize = true;
            lbAddToComCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbAddToComCount.Location = new Point(40, 168);
            lbAddToComCount.Name = "lbAddToComCount";
            lbAddToComCount.Size = new Size(79, 21);
            lbAddToComCount.TabIndex = 5;
            lbAddToComCount.Text = "Số lượng";
            // 
            // frmAddDichVuToCom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 286);
            Controls.Add(lbAddToComCount);
            Controls.Add(lbAddToComMon);
            Controls.Add(lbAddToComLoaiMon);
            Controls.Add(nrudAddToComCount);
            Controls.Add(cbxAddToComMon);
            Controls.Add(cbxAddToComLoaiMon);
            Controls.Add(btnCancelAddDVtoCom);
            Controls.Add(btnAcceptAddDVtoCom);
            Name = "frmAddDichVuToCom";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm dịch vụ";
            ((System.ComponentModel.ISupportInitialize)nrudAddToComCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcceptAddDVtoCom;
        private Button btnCancelAddDVtoCom;
        private ComboBox cbxAddToComLoaiMon;
        private ComboBox cbxAddToComMon;
        private NumericUpDown nrudAddToComCount;
        private Label lbAddToComLoaiMon;
        private Label lbAddToComMon;
        private Label lbAddToComCount;
    }
}