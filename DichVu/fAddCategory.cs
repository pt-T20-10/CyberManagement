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

namespace CyberManagementProject.DichVu
{
    public partial class fAddCategory : Form
    {
        public fAddCategory()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string tenLoai = txbCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Vui lòng nhập tên loại thức ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem tên loại đã tồn tại chưa
            string checkQuery = "SELECT COUNT(*) FROM LoaiDoAn WHERE TenLoai = @tenLoai";
            int count = (int)DataProvider.Instance.ExcuteScalar(checkQuery, new object[] { tenLoai });

            if (count > 0)
            {
                MessageBox.Show("Tên loại thức ăn đã tồn tại! Vui lòng nhập tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu không trùng thì thêm mới
            string query = "INSERT INTO LoaiDoAn (TenLoai) VALUES (@tenLoai)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenLoai });

            if (result > 0)
            {
                MessageBox.Show("Thêm loại thức ăn thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm loại thức ăn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
