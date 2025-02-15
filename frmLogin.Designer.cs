namespace CyberManagementProject
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.      
        /// </summary>
        private void InitializeComponent()
        {
            pnUserName = new Panel();
            txbUserName = new TextBox();
            lbUserName = new Label();
            pnPassWord = new Panel();
            txbPassWord = new TextBox();
            lbPassWord = new Label();
            panel3 = new Panel();
            btnLogin = new Button();
            pnLogin = new Panel();
            lbTitle = new Label();
            pnUserName.SuspendLayout();
            pnPassWord.SuspendLayout();
            pnLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnUserName
            // 
            pnUserName.Controls.Add(txbUserName);
            pnUserName.Controls.Add(lbUserName);
            pnUserName.Location = new Point(110, 83);
            pnUserName.Name = "pnUserName";
            pnUserName.Size = new Size(400, 100);
            pnUserName.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(13, 38);
            txbUserName.Multiline = true;
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(358, 30);
            txbUserName.TabIndex = 1;
            txbUserName.Text = "admin1";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(13, 10);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(135, 25);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Tên đăng nhập";
            // 
            // pnPassWord
            // 
            pnPassWord.Controls.Add(txbPassWord);
            pnPassWord.Controls.Add(lbPassWord);
            pnPassWord.Controls.Add(panel3);
            pnPassWord.Location = new Point(110, 189);
            pnPassWord.Name = "pnPassWord";
            pnPassWord.Size = new Size(400, 89);
            pnPassWord.TabIndex = 1;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(13, 52);
            txbPassWord.Multiline = true;
            txbPassWord.Name = "txbPassWord";
            txbPassWord.PasswordChar = '*';
            txbPassWord.Size = new Size(358, 30);
            txbPassWord.TabIndex = 2;
            txbPassWord.Text = "password123";
            // 
            // lbPassWord
            // 
            lbPassWord.AutoSize = true;
            lbPassWord.Font = new Font("Arial Narrow", 15.75F);
            lbPassWord.Location = new Point(13, 11);
            lbPassWord.Name = "lbPassWord";
            lbPassWord.Size = new Size(90, 25);
            lbPassWord.TabIndex = 2;
            lbPassWord.Text = "Mật khẩu";
            // 
            // panel3
            // 
            panel3.Location = new Point(92, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 40);
            panel3.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientActiveCaption;
            btnLogin.Font = new Font("Arial Narrow", 15.75F);
            btnLogin.Location = new Point(202, 295);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(194, 48);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnLogin
            // 
            pnLogin.Controls.Add(lbTitle);
            pnLogin.Controls.Add(btnLogin);
            pnLogin.Controls.Add(pnPassWord);
            pnLogin.Controls.Add(pnUserName);
            pnLogin.Location = new Point(102, 4);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(604, 362);
            pnLogin.TabIndex = 3;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(189, 13);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(213, 44);
            lbTitle.TabIndex = 3;
            lbTitle.Text = "Đăng nhập";
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 378);
            Controls.Add(pnLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cyber Management";
            FormClosing += frmLogin_FormClosing_1;
            pnUserName.ResumeLayout(false);
            pnUserName.PerformLayout();
            pnPassWord.ResumeLayout(false);
            pnPassWord.PerformLayout();
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnUserName;
        private Panel pnPassWord;
        private Panel panel3;
        private Label lbUserName;
        private Label lbPassWord;
        private TextBox txbUserName;
        private TextBox txbPassWord;
        private Button btnLogin;
        private Panel pnLogin;
        private Label lbTitle;
    }
}
