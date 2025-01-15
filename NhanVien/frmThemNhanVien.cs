using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet
{
    public partial class frmThemNhanVien : Form
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelThemNhanVien_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban co chac chan muon thoat chuong trinh khong?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show("Hen gap lai ban");
                this.Close();
            }
            else
            {

            }
        }

       

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            string folderPath = @"D:\LapTrinhNet\TEST_PULL_PUSH\Picture";

            // Kiểm tra thư mục có tồn tại không
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Thư mục không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Tạo hộp thoại chọn file
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Thiết lập thư mục mở ban đầu
                openFileDialog.InitialDirectory = folderPath;

                // Bộ lọc file (chỉ hiện các file ảnh)
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                // Tiêu đề của hộp thoại
                openFileDialog.Title = "Chọn ảnh";

                // Hiển thị hộp thoại và kiểm tra nếu người dùng nhấn OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file đã chọn
                    string selectedFilePath = openFileDialog.FileName;

                    // Hiển thị ảnh trong PictureBox
                    pbxAnhNhanVien.Image = Image.FromFile(selectedFilePath);
                    pbxAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage; // Co giãn ảnh vừa với khung
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở thư mục. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
