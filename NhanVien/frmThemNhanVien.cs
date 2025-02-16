using CyberManagementProject.DAO;
using CyberManagementProject.DTO;
using QuanLyQuanNet.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberManagementProject.NhanVien
{
    public partial class frmThemNhanVien : Form
    {
        public frmThemNhanVien()
        {
            InitializeComponent();

            //khởi tạo text mặc định cho các ô textbox

            txtTaiKhoanNhanVien.Text = "Tài khoản";
            txtTaiKhoanNhanVien.ForeColor = Color.Gray;


            txtMatKhauNhanVien.PasswordChar = '\0';
            txtMatKhauNhanVien.Text = "Mật khẩu";
            txtMatKhauNhanVien.ForeColor = Color.Gray;
        }

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoanNhanVien.Text == "Tài khoản")
            {
                txtTaiKhoanNhanVien.Text = ""; // Xóa nội dung mặc định
                txtTaiKhoanNhanVien.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoanNhanVien.Text)) //Kiểm tra ô textbox rỗng
            {
                txtTaiKhoanNhanVien.Text = "Tài khoản"; // Hiển thị lại nội dung mặc định
                txtTaiKhoanNhanVien.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhauNhanVien.Text == "Mật khẩu")
            {
                txtMatKhauNhanVien.PasswordChar = '*';
                txtMatKhauNhanVien.Text = ""; // Xóa nội dung mặc định
                txtMatKhauNhanVien.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhauNhanVien.Text)) //Kiểm tra ô textbox rỗng
            {
                txtMatKhauNhanVien.PasswordChar = '\0';
                txtMatKhauNhanVien.Text = "Mật khẩu"; // Hiển thị lại nội dung mặc định
                txtMatKhauNhanVien.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
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



        //thủ tục thêm mới nhân viên
        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                string tkNhanVien = txtTaiKhoanNhanVien.Text.Trim();
                string mkNhanVien = txtMatKhauNhanVien.Text;


                //Kiểm tra nếu tài khoản rỗng
                if (string.IsNullOrWhiteSpace(tkNhanVien) || string.IsNullOrWhiteSpace(mkNhanVien) || (tkNhanVien == "Tài khoản") || (mkNhanVien == "Mật khẩu"))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra xem tài khoản nhân viên đã tồn tại chưa
                if (NhanVienDAO.Instance.IsNhanVienExists(tkNhanVien))
                {
                    MessageBox.Show("Tài khoản nhân viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nếu tài khoản chưa tồn tại, tiến hành thêm vào database
                if (NhanVienDAO.Instance.AddNhanVien(tkNhanVien, mkNhanVien))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật danh sách nhân viên trên form chính
                    frmMain? mainForm = Application.OpenForms["frmMain"] as frmMain;
                    mainForm?.LoadNhanVien(); // Gọi trước khi đóng form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
