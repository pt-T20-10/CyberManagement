namespace CyberManagementProject.Music
{
    partial class frmMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusic));
            pictureBox1 = new PictureBox();
            wmpMusic = new AxWMPLib.AxWindowsMediaPlayer();
            grbListMusic = new GroupBox();
            lbxMusic = new ListBox();
            btnChooseMusic = new Button();
            btnClose = new Button();
            txtMusic = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wmpMusic).BeginInit();
            grbListMusic.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 456);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // wmpMusic
            // 
            wmpMusic.Enabled = true;
            wmpMusic.Location = new Point(8, 16);
            wmpMusic.Name = "wmpMusic";
            wmpMusic.OcxState = (AxHost.State)resources.GetObject("wmpMusic.OcxState");
            wmpMusic.Size = new Size(576, 360);
            wmpMusic.TabIndex = 1;
            // 
            // grbListMusic
            // 
            grbListMusic.Controls.Add(lbxMusic);
            grbListMusic.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbListMusic.Location = new Point(592, 16);
            grbListMusic.Name = "grbListMusic";
            grbListMusic.Size = new Size(200, 360);
            grbListMusic.TabIndex = 2;
            grbListMusic.TabStop = false;
            grbListMusic.Text = "Danh sách phát";
            // 
            // lbxMusic
            // 
            lbxMusic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxMusic.FormattingEnabled = true;
            lbxMusic.ItemHeight = 21;
            lbxMusic.Location = new Point(8, 32);
            lbxMusic.Name = "lbxMusic";
            lbxMusic.Size = new Size(184, 319);
            lbxMusic.TabIndex = 6;
            lbxMusic.DoubleClick += lbxMusic_DoubleClick;
            // 
            // btnChooseMusic
            // 
            btnChooseMusic.Location = new Point(512, 392);
            btnChooseMusic.Name = "btnChooseMusic";
            btnChooseMusic.Size = new Size(72, 39);
            btnChooseMusic.TabIndex = 3;
            btnChooseMusic.Text = "......";
            btnChooseMusic.UseVisualStyleBackColor = true;
            btnChooseMusic.Click += btnChooseMusic_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(656, 392);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(72, 39);
            btnClose.TabIndex = 4;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // txtMusic
            // 
            txtMusic.Location = new Point(8, 392);
            txtMusic.Multiline = true;
            txtMusic.Name = "txtMusic";
            txtMusic.Size = new Size(496, 40);
            txtMusic.TabIndex = 7;
            // 
            // frmMusic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMusic);
            Controls.Add(btnClose);
            Controls.Add(btnChooseMusic);
            Controls.Add(grbListMusic);
            Controls.Add(wmpMusic);
            Controls.Add(pictureBox1);
            Name = "frmMusic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)wmpMusic).EndInit();
            grbListMusic.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer wmpMusic;
        private GroupBox grbListMusic;
        private ListBox lbxMusic;
        private Button btnChooseMusic;
        private Button btnClose;
        private TextBox txtMusic;
    }
}