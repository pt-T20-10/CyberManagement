using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberManagementProject.Music
{
    public partial class frmMusic : Form
    {
        public frmMusic()
        {
            InitializeComponent();
        }

        string[] selectedFilePath;
        // Tạo hộp thoại chọn file
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string[] fileNames;

        private void btnChooseMusic_Click(object sender, EventArgs e)
        {
            string folderPath = @"D:\LapTrinhNet\CyberManagement\Music\Music";

            // Kiểm tra thư mục có tồn tại không
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Thư mục không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {


                // Thiết lập thư mục mở ban đầu
                openFileDialog.InitialDirectory = folderPath;

                // Bộ lọc file (chỉ hiện các file ảnh)
                openFileDialog.Filter = "Mp3 Files, Mp4 Files|*.mp3;*.mp4;*.mp";

                // Tiêu đề của hộp thoại
                openFileDialog.Title = "Chọn nhạc";

                // Hiển thị hộp thoại và kiểm tra nếu người dùng nhấn OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file đã chọn
                    selectedFilePath = openFileDialog.FileNames;

                    //lấy tên file
                    fileNames = openFileDialog.SafeFileNames;

                    foreach (var item in fileNames)
                    {
                        this.lbxMusic.Items.Add(item);

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
            if (lbxMusic.SelectedIndex != -1)
            {
                int choose = lbxMusic.SelectedIndex;
                wmpMusic.URL = selectedFilePath[choose];
                this.txtMusic.Text = fileNames[choose];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
