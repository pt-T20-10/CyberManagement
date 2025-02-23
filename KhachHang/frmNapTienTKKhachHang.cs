using CyberManagementProject.DAO;
using CyberManagementProject.DTO;
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
    public partial class frmNapTienTKKhachHang : Form
    {
        private string tkKhachHang; // Tài khoản khách hàng cần nạp tiền
        public frmNapTienTKKhachHang(string tkKhachHang)
        {
            InitializeComponent();
            this.tkKhachHang = tkKhachHang; // Gán giá trị cho biến tkKhachHang
            cbxAddMoneyUserName.Text = tkKhachHang;
        }

        private void btnAcceptAddMoney_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(nrupNapTienSoTien.Text, out float soTien) || soTien <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi DAO để cập nhật số tiền trong tài khoản khách hàng
            bool result = TKKhachHangDAO.Instance.NapTien(tkKhachHang, soTien);

            if (result)
            {
                MessageBox.Show($"Nạp {soTien:N0} VNĐ vào tài khoản {tkKhachHang} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Nạp tiền thất bại, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
