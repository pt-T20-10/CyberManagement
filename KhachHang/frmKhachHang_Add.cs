using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanNet.KhachHang
{
    public partial class frmKhachHang_Add : Form
    {
        public frmKhachHang_Add()
        {
            InitializeComponent();

            //khởi tạo text mặc định cho các ô textbox

            txtTenKhachHang.Text = "Họ tên";
            txtTenKhachHang.ForeColor = Color.Gray;

            txtSoDT.Text = "Số điện thoại";
            txtSoDT.ForeColor = Color.Gray;

            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Gray;

            txtDiaChi.Text = "Địa chỉ";
            txtDiaChi.ForeColor = Color.Gray;

            cbxLoaiKhach.Text = "Nhóm khách hàng";
            cbxLoaiKhach.ForeColor = Color.Gray;
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKhachHang_Enter(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "Họ tên")
            {
                txtTenKhachHang.Text = ""; // Xóa nội dung mặc định
                txtTenKhachHang.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }

        private void txtTenKhachHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text)) //Kiểm tra ô textbox rỗng
            {
                txtTenKhachHang.Text = "Họ Tên"; // Hiển thị lại nội dung mặc định
                txtTenKhachHang.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void txtSoDT_Enter(object sender, EventArgs e)
        {
            if (txtSoDT.Text == "Số điện thoại")
            {
                txtSoDT.Text = "";
                txtSoDT.ForeColor = Color.Black;
            }
        }

        private void txtSoDT_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoDT.Text)) //Kiểm tra ô textbox rỗng
            {
                txtSoDT.Text = "Số điện thoại"; // Hiển thị lại nội dung mặc định
                txtSoDT.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) //Kiểm tra ô textbox rỗng
            {
                txtEmail.Text = "Email"; // Hiển thị lại nội dung mặc định
                txtEmail.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "Địa chỉ")
            {
                txtDiaChi.Text = "";
                txtDiaChi.ForeColor = Color.Black;
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text)) //Kiểm tra ô textbox rỗng
            {
                txtDiaChi.Text = "Địa chỉ"; // Hiển thị lại nội dung mặc định
                txtDiaChi.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void cbxLoaiKhach_Enter(object sender, EventArgs e)
        {
            if (cbxLoaiKhach.Text == "Nhóm khách hàng")
            {
                cbxLoaiKhach.Text = "";
                cbxLoaiKhach.ForeColor = Color.Black;
            }
        }

        private void cbxLoaiKhach_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxLoaiKhach.Text)) //Kiểm tra ô textbox rỗng
            {
                cbxLoaiKhach.Text = "Nhóm khách hàng"; // Hiển thị lại nội dung mặc định
                cbxLoaiKhach.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Main f = new frmKhachHang_Main();
            DialogResult dialog = MessageBox.Show("Ban co muon thoat?",
                            "Thong Bao",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question);
            if (dialog == DialogResult.OK) {
                this.Close();
            }
            else
            {

            }

        }
    }
}
