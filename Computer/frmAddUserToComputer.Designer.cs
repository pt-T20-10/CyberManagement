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
            gbxComputerManager = new GroupBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            label2 = new Label();
            lbNameToAdd = new Label();
            gbxComputerManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // gbxComputerManager
            // 
            gbxComputerManager.Controls.Add(button1);
            gbxComputerManager.Controls.Add(numericUpDown1);
            gbxComputerManager.Controls.Add(comboBox1);
            gbxComputerManager.Controls.Add(label2);
            gbxComputerManager.Controls.Add(lbNameToAdd);
            gbxComputerManager.Location = new Point(8, 8);
            gbxComputerManager.Name = "gbxComputerManager";
            gbxComputerManager.Size = new Size(200, 248);
            gbxComputerManager.TabIndex = 0;
            gbxComputerManager.TabStop = false;
            gbxComputerManager.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(48, 192);
            button1.Name = "button1";
            button1.Size = new Size(100, 38);
            button1.TabIndex = 4;
            button1.Text = "Mở máy";
            button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(16, 144);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(168, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 23);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(16, 112);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Tiền nạp";
            // 
            // lbNameToAdd
            // 
            lbNameToAdd.AutoSize = true;
            lbNameToAdd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lbNameToAdd.Location = new Point(16, 40);
            lbNameToAdd.Name = "lbNameToAdd";
            lbNameToAdd.Size = new Size(75, 20);
            lbNameToAdd.TabIndex = 0;
            lbNameToAdd.Text = "Tài khoản";
            // 
            // frmAddUserToComputer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 261);
            Controls.Add(gbxComputerManager);
            Name = "frmAddUserToComputer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddUserToComputer";
            gbxComputerManager.ResumeLayout(false);
            gbxComputerManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxComputerManager;
        private Label label2;
        private Label lbNameToAdd;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Button button1;
    }
}