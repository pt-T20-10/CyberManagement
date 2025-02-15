using CyberManagementProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberManagementProject.KhachHang
{
    public partial class frmDoiMatKhauKhachHang : Form
    {
        private string tkKhachHang;
        public frmDoiMatKhauKhachHang(string tkKhachHang)
        {
            InitializeComponent();
            
            this.tkKhachHang = tkKhachHang;
            txtTKKhachHang.Text = tkKhachHang; // Hiển thị tài khoản khách hàng
            txtTKKhachHang.Enabled = false; // Không cho chỉnh sửa
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tkKhachHang = txtTKKhachHang.Text.Trim();
            string matKhauMoi = txtMKKhachHang.Text.Trim();

            if (string.IsNullOrEmpty(matKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TKKhachHangDAO.Instance.DoiMatKhauKhachHang(tkKhachHang, matKhauMoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form đổi mật khẩu
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show(string.Format("Mật khẩu của {0} sau khi đổi là {1} ", tkKhachHang, matKhauMoi));

        }
    }
}
