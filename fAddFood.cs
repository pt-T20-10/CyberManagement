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
    public partial class fAddFood : Form
    {
        public fAddFood()
        {
            InitializeComponent();
        }

        private void fAddFood_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Tạo OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Cấu hình OpenFileDialog
                openFileDialog.Title = "Chọn hình ảnh";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Multiselect = false;

                // Hiển thị hộp thoại chọn file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file được chọn
                    string filePath = openFileDialog.FileName;

                    // Hiển thị hình ảnh trong PictureBox ptFood
                    ptFood.Image = Image.FromFile(filePath);
                    ptFood.SizeMode = PictureBoxSizeMode.StretchImage; // Tùy chọn: làm hình vừa khung
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
