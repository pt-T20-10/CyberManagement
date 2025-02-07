using CyberManagementProject.DAO;
using CyberManagementProject;
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
    public partial class frmThemKhachHang : Form
    {
        public frmThemKhachHang()
        {
            InitializeComponent();

            //khởi tạo text mặc định cho các ô textbox

            txtTaiKhoanKhachHang.Text = "Tài khoản";
            txtTaiKhoanKhachHang.ForeColor = Color.Gray;

            txtMatKhauKhachHang.PasswordChar = '\0';
            txtMatKhauKhachHang.Text = "Mật khẩu";
            txtMatKhauKhachHang.ForeColor = Color.Gray;

        }

        private void txtTenKhachHang_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoanKhachHang.Text == "Tài khoản")
            {
                txtTaiKhoanKhachHang.Text = ""; // Xóa nội dung mặc định
                txtTaiKhoanKhachHang.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }

        private void txtTenKhachHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoanKhachHang.Text)) //Kiểm tra ô textbox rỗng
            {
                txtTaiKhoanKhachHang.Text = "Tài khoản"; // Hiển thị lại nội dung mặc định
                txtTaiKhoanKhachHang.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhauKhachHang.Text == "Mật khẩu")
            {
                txtMatKhauKhachHang.PasswordChar = '*';
                txtMatKhauKhachHang.Text = ""; // Xóa nội dung mặc định
                txtMatKhauKhachHang.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhauKhachHang.Text)) //Kiểm tra ô textbox rỗng
            {
                txtMatKhauKhachHang.PasswordChar = '\0';
                txtMatKhauKhachHang.Text = "Mật khẩu"; // Hiển thị lại nội dung mặc định
                txtMatKhauKhachHang.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Main f = new frmKhachHang_Main();
            DialogResult dialog = MessageBox.Show("Ban co muon thoat?",
                            "Thong Bao",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string tkKhachHang = txtTaiKhoanKhachHang.Text;
            string mkKhachHang = txtMatKhauKhachHang.Text;

            if (KhachHangDAO.Instance.AddKhachHang(tkKhachHang, mkKhachHang))
            {
                MessageBox.Show("Thêm khách hàng thành công!");

                // Cập nhật danh sách nhân viên ở Main
               
                var mainForm = (frmMain)Application.OpenForms["frmMain"];
                mainForm.LoadKhachHang();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại!");
            }
        }
    }
}
