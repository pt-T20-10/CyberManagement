using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CyberManagementProject.Music
{
    public partial class frmMusic : Form
    {
        public frmMusic()
        {
            InitializeComponent();
        }

        List<string> selectedFilePath = new List<string>();  // Dùng List thay vì mảng
        List<string> fileNames = new List<string>();
        OpenFileDialog openFileDialog = new OpenFileDialog();

        private void btnChooseMusic_Click(object sender, EventArgs e)
        {
            string folderPath = @"D:\LapTrinhNet\CyberManagement\Music\Music";

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Thư mục không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                openFileDialog.InitialDirectory = folderPath;
                openFileDialog.Filter = "Mp3 Files, Mp4 Files|*.mp3;*.mp4;*.mp";
                openFileDialog.Title = "Chọn nhạc";
                openFileDialog.Multiselect = true;  // Cho phép chọn nhiều file

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var file in openFileDialog.FileNames)
                    {
                        if (!selectedFilePath.Contains(file))  // Tránh trùng lặp
                        {
                            selectedFilePath.Add(file);
                            fileNames.Add(Path.GetFileName(file));
                            lbxMusic.Items.Add(Path.GetFileName(file));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở thư mục. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbxMusic_DoubleClick(object sender, EventArgs e)
        {
            if (lbxMusic.SelectedIndex >= 0 && lbxMusic.SelectedIndex < selectedFilePath.Count)
            {
                int choose = lbxMusic.SelectedIndex;
                wmpMusic.URL = selectedFilePath[choose];
                txtMusic.Text = fileNames[choose];
            }
            else
            {
                MessageBox.Show("Không tìm thấy bài hát!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Làm việc không nghe nhạc sẽ bị khùng đó ní. Chắc chưa?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Bye thằng khùng");
                this.Close();
            }
        }
    }
}
