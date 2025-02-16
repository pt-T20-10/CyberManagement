using CyberManagementProject;
using CyberManagementProject.DAO;
using CyberManagementProject.DTO;
using CyberManagementProject.KhachHang;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanNet.Customer
{
    public partial class frmThongTinKhachHang : Form
    {
        private string tkkh;
        public frmThongTinKhachHang(KhachHangDTO khachHang)
        {
            InitializeComponent();

            LoadLoaiKhach();

            // Hiển thị thông tin khách hàng vào các control trên form
            if (khachHang != null)
            {
                tkkh = khachHang.TKKhachHang;  // Lưu TKKhachHang

                // Cập nhật thông tin vào form
                txtIDKhachHang.Text = tkkh; //khachHang.ID.ToString();
                txtTenKhachHang.Text = khachHang.Ten;
                txtSoDTKhachHang.Text = khachHang.SoDT;
                txtEmailKhachHang.Text = khachHang.Email;
                txtDiaChiKhachHang.Text = khachHang.DiaChi;
                cbxLoaiKhachHang.Text = khachHang.NhomKhach;
                // Cập nhật các control khác nếu cần
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng.");
            }

            //txtTenKhachHang.Text = "Họ và Tên";
            //txtTenKhachHang.ForeColor = Color.Gray;

            //txtSoDTKhachHang.Text = "Số điện thoại";
            //txtSoDTKhachHang.ForeColor = Color.Gray;

            //txtEmailKhachHang.Text = "Email";
            //txtEmailKhachHang.ForeColor = Color.Gray;

            //txtDiaChiKhachHang.Text = "Địa chỉ";
            //txtDiaChiKhachHang.ForeColor = Color.Gray;

            //cbxLoaiKhachHang.Text = "Nhóm khách";
            //cbxLoaiKhachHang.ForeColor = Color.Gray;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenKhachHang_Enter(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "Họ và Tên")
            {
                txtTenKhachHang.Text = ""; // Xóa nội dung mặc định
                txtTenKhachHang.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }

        private void txtTenKhachHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text)) //Kiểm tra ô textbox rỗng
            {
                txtTenKhachHang.Text = "Họ và Tên"; // Hiển thị lại nội dung mặc định
                txtTenKhachHang.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void txtSoDTKhachHang_Enter(object sender, EventArgs e)
        {
            if (txtSoDTKhachHang.Text == "Số điện thoại")
            {
                txtSoDTKhachHang.Text = ""; // Xóa nội dung mặc định
                txtSoDTKhachHang.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }

        private void txtSoDTKhachHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoDTKhachHang.Text)) //Kiểm tra ô textbox rỗng
            {
                txtSoDTKhachHang.Text = "Tài khoản"; // Hiển thị lại nội dung mặc định
                txtSoDTKhachHang.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void txtEmailKhachHang_Enter(object sender, EventArgs e)
        {
            if (txtEmailKhachHang.Text == "Số điện thoại")
            {
                txtEmailKhachHang.Text = ""; // Xóa nội dung mặc định
                txtEmailKhachHang.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }

        private void txtEmailKhachHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailKhachHang.Text)) //Kiểm tra ô textbox rỗng
            {
                txtEmailKhachHang.Text = "Email"; // Hiển thị lại nội dung mặc định
                txtEmailKhachHang.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void txtDiaChiKhachHang_Enter(object sender, EventArgs e)
        {
            if (txtDiaChiKhachHang.Text == "Email")
            {
                txtDiaChiKhachHang.Text = ""; // Xóa nội dung mặc định
                txtDiaChiKhachHang.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }

        private void txtDiaChiKhachHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiaChiKhachHang.Text)) //Kiểm tra ô textbox rỗng
            {
                txtDiaChiKhachHang.Text = "Địa chỉ"; // Hiển thị lại nội dung mặc định
                txtDiaChiKhachHang.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void cbxLoaiKhachHang_Enter(object sender, EventArgs e)
        {
            if (cbxLoaiKhachHang.Text == "Nhóm khách")
            {
                cbxLoaiKhachHang.Text = ""; // Xóa nội dung mặc định
                cbxLoaiKhachHang.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }

        private void cbxLoaiKhachHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxLoaiKhachHang.Text)) //Kiểm tra ô textbox rỗng
            {
                cbxLoaiKhachHang.Text = "Nhóm khách"; // Hiển thị lại nội dung mặc định
                cbxLoaiKhachHang.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {

                // Lấy thông tin từ các textbox
                string ten = txtTenKhachHang.Text;
                string soDT = txtSoDTKhachHang.Text;
                string email = txtEmailKhachHang.Text;
                string diaChi = txtDiaChiKhachHang.Text;
                string nhomkhach = cbxLoaiKhachHang.Text;


                // Gọi DAO để cập nhật thông tin
                bool isUpdated = KhachHangDAO.Instance.UpdateKhachHang(tkkh, ten, soDT, email, diaChi, nhomkhach);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại thông tin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy TKKhachHang từ TextBox hoặc DTO
            string TKKhachHang = tkkh;

            if (MayTinhDAO.Instance.isKhachHangNotAvailable(tkkh))
            {
                MessageBox.Show("Tài khoản đã được đăng nhập");
            }
            else
            {
                // Xác nhận xóa
                DialogResult dialogResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa khách hàng này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        // Gọi DAO để xóa khách hàng
                        bool isDeleted = KhachHangDAO.Instance.DeleteKhachHangByTKKhachHang((TKKhachHang));

                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa khách hàng thành công!");
                            frmMain? mainForm = Application.OpenForms["frmMain"] as frmMain;
                            mainForm.LoadKhachHang(); // Gọi trước khi đóng form
                            this.Close(); // Đóng form thông tin sau khi xóa
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại. Vui lòng thử lại!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}");
                    }
                }
            }


        }

        private void cbxLoaiKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain? mainForm = Application.OpenForms["frmMain"] as frmMain;
            mainForm.LoadKhachHang();
        }

        private void LoadLoaiKhach()
        {
            cbxLoaiKhachHang.Items.Clear(); // Xóa dữ liệu cũ

            List<string> danhSachNhomKhach = KhachHangDAO.Instance.GetDanhSachNhomKhach();

            foreach (string nhomKhach in danhSachNhomKhach)
            {
                cbxLoaiKhachHang.Items.Add(nhomKhach);
            }

            if (cbxLoaiKhachHang.Items.Count > 0)
            {
                cbxLoaiKhachHang.SelectedIndex = 0; // Chọn mặc định dòng đầu tiên
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {

            // Tách nội dung của button (giống phương thức tìm kiếm)
            string noiDungButton = txtIDKhachHang.Text;

            // Lấy TKKhachHang từ dòng đầu tiên
            string tkKhachHang = noiDungButton.Length > 0 ? noiDungButton.Trim() : string.Empty;

            if (string.IsNullOrEmpty(tkKhachHang))
            {
                MessageBox.Show("Không tìm thấy tài khoản khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mở form đổi mật khẩu và truyền TKKhachHang
            frmDoiMatKhauKhachHang f = new frmDoiMatKhauKhachHang(tkKhachHang);
            f.ShowDialog();
        }

    }
}
