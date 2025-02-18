using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberManagementProject.DAO;
using CyberManagementProject.DTO;

namespace QLQuanNET
{
    public partial class frmQLyUngDung : Form
    {
        public frmQLyUngDung()
        {
            InitializeComponent();
            LoadLoaiUngDung();
            LoadUngDung();
        }

        // Load danh sách loại ứng dụng vào ComboBox
        void LoadLoaiUngDung()
        {
            string query = "SELECT * FROM LoaiUngDung";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            cbxLoaiUngDung.DataSource = data;
            cbxLoaiUngDung.DisplayMember = "TenLoai";  // Hiển thị tên loại
            cbxLoaiUngDung.ValueMember = "ID";  // Lưu ID
        }

        private void btnThemUngDung_Click(object sender, EventArgs e)
        {
            string tenUngDung = txtCapNhatTenUngDung.Text;
            int loaiUngDungID = Convert.ToInt32(cbxLoaiUngDung.SelectedValue);
            string moTa = txtCapNhatMoTaUngDung.Text;
            string duongDan = txtCapNhatDuongDanUD.Text;

            if (QLUngDungDAO.Instance.ThemUngDung(tenUngDung, loaiUngDungID, moTa, duongDan))
            {
                MessageBox.Show("Thêm ứng dụng thành công!");
                LoadUngDung();
            }
            else
            {
                MessageBox.Show("Thêm ứng dụng thất bại!");
            }
        }

        public void LoadUngDung()
        {
            List<UngDungDTO> danhSachUngDung = QLUngDungDAO.Instance.LayDanhSachUngDung();
            dgvViewUngDung.DataSource = danhSachUngDung;
        }

        private void btnCapNhatUngDung_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCapNhatIDUngDung.Text);
            string tenUngDung = txtCapNhatTenUngDung.Text;
            int loaiUngDungID = Convert.ToInt32(cbxLoaiUngDung.SelectedValue);
            string moTa = txtCapNhatMoTaUngDung.Text;
            string duongDan = txtCapNhatDuongDanUD.Text;

            if (QLUngDungDAO.Instance.CapNhatUngDung(id, tenUngDung, loaiUngDungID, moTa, duongDan))
            {
                MessageBox.Show("Cập nhật ứng dụng thành công!");
                LoadUngDung();
            }
            else
            {
                MessageBox.Show("Cập nhật ứng dụng thất bại!");
            }
        }

        private void btnXoaUngDung_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCapNhatIDUngDung.Text);

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ứng dụng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (QLUngDungDAO.Instance.XoaUngDung(id))
                {
                    MessageBox.Show("Xóa ứng dụng thành công!");
                    LoadUngDung();
                }
                else
                {
                    MessageBox.Show("Xóa ứng dụng thất bại!");
                }
            }
        }

        private void dgvViewUngDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Kiểm tra xem hàng được click có hợp lệ không
            //if (e.RowIndex >= 0 && e.RowIndex < dgvViewUngDung.Rows.Count)
            //{
            //    // Lấy dữ liệu của hàng đang chọn
            //    DataGridViewRow row = dgvViewUngDung.Rows[e.RowIndex];

            //    // Gán giá trị từng ô vào các TextBox
            //    txtCapNhatIDUngDung.Text = row.Cells["ID"].Value?.ToString() ?? string.Empty;
            //    txtCapNhatTenUngDung.Text = row.Cells["TenUngDung"].Value?.ToString() ?? string.Empty;
            //    cbxLoaiUngDung.SelectedValue = row.Cells["LoaiUngDungID"].Value ?? -1;
            //    txtCapNhatMoTaUngDung.Text = row.Cells["MoTa"].Value?.ToString() ?? string.Empty;
            //    txtCapNhatDuongDanUD.Text = row.Cells["DuongDan"].Value?.ToString() ?? string.Empty;
            //}
        }

        //event
        private void dgvViewUngDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo không click vào tiêu đề hoặc vùng trống
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Chọn nguyên hàng khi click
                dgvViewUngDung.Rows[e.RowIndex].Selected = true;

                DataGridViewRow row = dgvViewUngDung.Rows[e.RowIndex];

                // Đổ dữ liệu từ DataGridView vào các TextBox
                txtCapNhatIDUngDung.Text = row.Cells["ID"].Value?.ToString() ?? string.Empty;
                txtCapNhatTenUngDung.Text = row.Cells["TenUngDung"].Value?.ToString() ?? string.Empty;
                cbxLoaiUngDung.SelectedValue = row.Cells["LoaiUngDungID"].Value ?? -1;
                txtCapNhatMoTaUngDung.Text = row.Cells["MoTa"].Value?.ToString() ?? string.Empty;
                txtCapNhatDuongDanUD.Text = row.Cells["DuongDan"].Value?.ToString() ?? string.Empty;
            }

        }

        private void frmQLyUngDung_Load(object sender, EventArgs e)
        {
            dgvViewUngDung.CellClick += dgvViewUngDung_CellClick;
        }

        private void btnResetUngDung_Click(object sender, EventArgs e)
        {
            // Xóa trắng tất cả các textbox
            txtCapNhatIDUngDung.Text = string.Empty;
            txtCapNhatTenUngDung.Text = string.Empty;
            cbxLoaiUngDung.SelectedIndex = -1; // Bỏ chọn combobox
            txtCapNhatMoTaUngDung.Text = string.Empty;
            txtCapNhatDuongDanUD.Text = string.Empty;

            // Hoặc dùng Clear() nếu là TextBox
            // txtCapNhatIDUngDung.Clear();
            // txtCapNhatTenUngDung.Clear();
            // txtCapNhatMoTaUngDung.Clear();
            // txtCapNhatDuongDanUD.Clear();
        }
    }
}
