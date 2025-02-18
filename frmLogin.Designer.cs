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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pnUserName = new Panel();
            txbUserName = new TextBox();
            lbUserName = new Label();
            pnPassWord = new Panel();
            txbPassWord = new TextBox();
            lbPassWord = new Label();
            panel3 = new Panel();
            btnLogin = new Button();
            lbTitle = new Label();
            pnLogin = new Panel();
            button1 = new Button();
            pnUserName.SuspendLayout();
            pnPassWord.SuspendLayout();
            pnLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnUserName
            // 
            pnUserName.Controls.Add(txbUserName);
            pnUserName.Controls.Add(lbUserName);
            pnUserName.Location = new Point(112, 104);
            pnUserName.Name = "pnUserName";
            pnUserName.Size = new Size(400, 84);
            pnUserName.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.Font = new Font("Tahoma", 11.25F);
            txbUserName.Location = new Point(13, 38);
            txbUserName.Multiline = true;
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(358, 30);
            txbUserName.TabIndex = 2;
            txbUserName.Text = "admin1";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            lbUserName.ForeColor = Color.Azure;
            lbUserName.Location = new Point(8, 8);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(118, 25);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Username";
            // 
            // pnPassWord
            // 
            pnPassWord.Controls.Add(txbPassWord);
            pnPassWord.Controls.Add(lbPassWord);
            pnPassWord.Controls.Add(panel3);
            pnPassWord.Location = new Point(110, 189);
            pnPassWord.Name = "pnPassWord";
            pnPassWord.Size = new Size(400, 91);
            pnPassWord.TabIndex = 1;
            // 
            // txbPassWord
            // 
            txbPassWord.Font = new Font("Tahoma", 11.25F);
            txbPassWord.Location = new Point(13, 40);
            txbPassWord.Multiline = true;
            txbPassWord.Name = "txbPassWord";
            txbPassWord.PasswordChar = '*';
            txbPassWord.Size = new Size(358, 30);
            txbPassWord.TabIndex = 3;
            txbPassWord.Text = "password123";
            // 
            // lbPassWord
            // 
            lbPassWord.AutoSize = true;
            lbPassWord.BackColor = Color.Transparent;
            lbPassWord.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassWord.ForeColor = Color.WhiteSmoke;
            lbPassWord.Location = new Point(8, 16);
            lbPassWord.Name = "lbPassWord";
            lbPassWord.Size = new Size(115, 25);
            lbPassWord.TabIndex = 2;
            lbPassWord.Text = "Password";
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
            btnLogin.BackColor = Color.BurlyWood;
            btnLogin.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(202, 295);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(194, 48);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(176, 8);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(247, 58);
            lbTitle.TabIndex = 3;
            lbTitle.Text = "Welcome";
            // 
            // pnLogin
            // 
            pnLogin.BackColor = Color.Transparent;
            pnLogin.Controls.Add(lbTitle);
            pnLogin.Controls.Add(btnLogin);
            pnLogin.Controls.Add(pnPassWord);
            pnLogin.Controls.Add(pnUserName);
            pnLogin.Location = new Point(65, 19);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(604, 362);
            pnLogin.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(656, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = button1;
            ClientSize = new Size(734, 400);
            Controls.Add(button1);
            Controls.Add(pnLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cyber Management";
            FormClosing += frmLogin_FormClosing_1;
            KeyDown += frmLogin_KeyDown;
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
        private TextBox txbUserName;
        private Label lbUserName;
        private Panel pnPassWord;
        private TextBox txbPassWord;
        private Label lbPassWord;
        private Panel panel3;
        private Button btnLogin;
        private Label lbTitle;
        private Panel pnLogin;
        private Button button1;
    }
}
