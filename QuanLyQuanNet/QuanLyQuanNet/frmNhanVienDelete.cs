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
    public partial class frmNhanVienDelete : Form
    {
        public frmNhanVienDelete()
        {
            InitializeComponent();

            // Tạo đối tượng ParallelogramPictureBox
            ParallelogramPictureBox parallelogramPictureBox = new ParallelogramPictureBox
            {
                Width = 50,
                Height = 50,
                ShearFactor = 30, // Độ nghiêng của hình bình hành
                Image = Image.FromFile(@"D:\LapTrinhNet\QuanLyQuanNet\Picture\icon_search.png"), // Đường dẫn ảnh
                SizeMode = PictureBoxSizeMode.StretchImage, // Kiểu hiển thị ảnh
                Location = new Point(50, 50) // Vị trí trên Form
            };

            // Thêm vào form
            this.Controls.Add(parallelogramPictureBox);
        }

        private void frmNhanVienDelete_Load(object sender, EventArgs e)
        {

        }

        private void pbxAnhNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
