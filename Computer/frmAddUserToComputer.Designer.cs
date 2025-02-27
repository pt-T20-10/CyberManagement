namespace CyberManagementProject.Computer
{
    partial class frmAddUserToComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUserToComputer));
            gbxComputerManager = new GroupBox();
            btnMoMay = new Button();
            cbxAccountUser = new ComboBox();
            lbNameToAdd = new Label();
            gbxComputerManager.SuspendLayout();
            SuspendLayout();
            // 
            // gbxComputerManager
            // 
            gbxComputerManager.Controls.Add(btnMoMay);
            gbxComputerManager.Controls.Add(cbxAccountUser);
            gbxComputerManager.Controls.Add(lbNameToAdd);
            gbxComputerManager.Location = new Point(8, 8);
            gbxComputerManager.Name = "gbxComputerManager";
            gbxComputerManager.Size = new Size(200, 152);
            gbxComputerManager.TabIndex = 0;
            gbxComputerManager.TabStop = false;
            gbxComputerManager.Text = "groupBox1";
            // 
            // btnMoMay
            // 
            btnMoMay.Location = new Point(48, 96);
            btnMoMay.Name = "btnMoMay";
            btnMoMay.Size = new Size(100, 38);
            btnMoMay.TabIndex = 4;
            btnMoMay.Text = "Mở máy";
            btnMoMay.UseVisualStyleBackColor = true;
            btnMoMay.Click += btnMoMay_Click;
            // 
            // cbxAccountUser
            // 
            cbxAccountUser.FormattingEnabled = true;
            cbxAccountUser.Location = new Point(16, 56);
            cbxAccountUser.Name = "cbxAccountUser";
            cbxAccountUser.Size = new Size(168, 23);
            cbxAccountUser.TabIndex = 2;
            // 
            // lbNameToAdd
            // 
            lbNameToAdd.AutoSize = true;
            lbNameToAdd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbNameToAdd.Location = new Point(16, 32);
            lbNameToAdd.Name = "lbNameToAdd";
            lbNameToAdd.Size = new Size(75, 20);
            lbNameToAdd.TabIndex = 0;
            lbNameToAdd.Text = "Tài khoản";
            // 
            // frmAddUserToComputer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 174);
            Controls.Add(gbxComputerManager);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAddUserToComputer";
            StartPosition = FormStartPosition.CenterParent;
            gbxComputerManager.ResumeLayout(false);
            gbxComputerManager.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxComputerManager;
        private Label lbNameToAdd;
        private ComboBox cbxAccountUser;
        private Button btnMoMay;
    }
}