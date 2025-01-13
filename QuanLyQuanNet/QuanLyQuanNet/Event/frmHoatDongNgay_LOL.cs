using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet.Event
{
    public partial class frmHoatDongNgay_LOL : Form
    {


        public frmHoatDongNgay_LOL()
        {
            InitializeComponent();

            //btnTranThang.FlatStyle = FlatStyle.Flat; // Đặt kiểu Button là Flat
            //btnTranThang.BackColor = Color.Transparent; // Nền trong suốt
            //btnTranThang.FlatAppearance.BorderSize = 0; // Xóa viền (nếu cần)

            // Tạo đối tượng CustomPanel
            // Khởi tạo CustomPanel
            CustomPanel customPanel = new CustomPanel
            {
                //PbxBackGround = pbxBackGround, // Gán PictureBox vào CustomPanel
                Width = 400,  // Chiều rộng của panel
                Height = 300  // Chiều cao của panel
            };

            CustomPanel pnHeader = new CustomPanel();
            pnHeader.Size = new Size(790, 56); // Kích thước của panel
            pnHeader.Location = new Point(192, 56); // Vị trí của panel

            // Truyền tham chiếu của pbxBackGround vào CustomPanel
            //customPanel.PbxBackGround = pbxBackGround;

            this.Controls.Add(pnHeader); // Thêm vào form

            pnHeader.SendToBack();
        }

        private void frmHoatDongNgay_LOL_Load(object sender, EventArgs e)
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTranThang_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
