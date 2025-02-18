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

            txtMatKhauKhachHang.PasswordChar = '*';//'\0';
            txtMatKhauKhachHang.Text = "1";
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
            try
            {
                string tkKhachHang = txtTaiKhoanKhachHang.Text.Trim();
                string mkKhachHang = txtMatKhauKhachHang.Text;

                //Kiểm tra nếu tài khoản rỗng
                if (string.IsNullOrWhiteSpace(tkKhachHang) || string.IsNullOrWhiteSpace(mkKhachHang) || (tkKhachHang == "Tài khoản") || (mkKhachHang == "Mật khẩu"))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra xem tài khoản khách hàng đã tồn tại hay chưa
                if (KhachHangDAO.Instance.IsKhachHangExists(tkKhachHang))
                {
                    MessageBox.Show("Tài khoản khách hàng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nếu tài khoản chưa tồn tại, tiến hành thêm vào database
                if(KhachHangDAO.Instance.AddKhachHang(tkKhachHang, mkKhachHang))
                {
                        MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cập nhật danh sách khách hàng trên form chính
                        var mainForm = (frmMain)Application.OpenForms["frmMain"];
                        mainForm.LoadKhachHang();
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
