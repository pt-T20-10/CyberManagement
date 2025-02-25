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
    public partial class fEditCategory : Form
    {
        public fEditCategory()
        {
            InitializeComponent();
            LoadCategoryList();
            LoadCategoryComboBox();
        }
        private void fEditCategory_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
            LoadCategoryComboBox();
        }

        private void LoadCategoryList()
        {
            string query = "SELECT IDLoai, TenLoai FROM LoaiDoAn";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgvCategory.DataSource = data;

            BindCategoryData();
        }


        private void BindCategoryData()
        {
            txbCategoryID.DataBindings.Clear();
            txbCategoryName.DataBindings.Clear();

            // Thêm Binding mới
            txbCategoryID.DataBindings.Add("Text", dtgvCategory.DataSource, "IDLoai", true, DataSourceUpdateMode.Never);
            txbCategoryName.DataBindings.Add("Text", dtgvCategory.DataSource, "TenLoai", true, DataSourceUpdateMode.Never);
        }
        private void fCategory_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
        }


        // Load danh sách loại vào ComboBox để chuyển món ăn
        private void LoadCategoryComboBox()
        {
            string query = "SELECT IDLoai, TenLoai FROM LoaiDoAn";
            cbNewCategory.DataSource = DataProvider.Instance.ExcuteQuery(query);
            cbNewCategory.DisplayMember = "TenLoai";
            cbNewCategory.ValueMember = "IDLoai";
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            fAddCategory f = new fAddCategory();
            f.ShowDialog();
            LoadCategoryList();
            LoadCategoryComboBox();
        }


        // Sửa tên loại thức ăn
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string tenLoai = txbCategoryName.Text.Trim();
            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Tên loại không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE LoaiDoAn SET TenLoai = @tenLoai WHERE IDLoai = @idLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenLoai, txbCategoryID.Text });

            MessageBox.Show(result > 0 ? "Cập nhật thành công!" : "Không có bản ghi nào được cập nhật!","Thông báo", MessageBoxButtons.OK, result > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (result > 0)
            {
                LoadCategoryList();
                LoadCategoryComboBox();
            }
        }

        // Xóa loại thức ăn
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int idLoai = Convert.ToInt32(txbCategoryID.Text);

            string checkQuery = "SELECT COUNT(*) FROM DoAn WHERE IDLoai = @idLoai ";
            int count = (int)DataProvider.Instance.ExcuteScalar(checkQuery, new object[] { idLoai });

            if (count > 0)
            {
                MessageBox.Show("Không thể xóa! Loại thức ăn này đang có món ăn. Hãy chuyển hoặc xóa món ăn trước!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "DELETE FROM LoaiDoAn WHERE IDLoai = @idLoai" ;
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idLoai });

            if (result > 0)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo");
                LoadCategoryList();
                LoadCategoryComboBox();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chuyển thức ăn sang loại khác
        private void btnTransferFood_Click(object sender, EventArgs e)
        {
            int oldCategoryID = Convert.ToInt32(txbCategoryID.Text);
            int newCategoryID = Convert.ToInt32(cbNewCategory.SelectedValue);

            if (oldCategoryID == newCategoryID)
            {
                MessageBox.Show("Loại mới phải khác loại cũ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE DoAn SET IDLoai = @newCategory WHERE IDLoai = @oldCategory ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { newCategoryID, oldCategoryID });

            if (result > 0)
            {
                MessageBox.Show("Chuyển món ăn thành công!", "Thông báo");

                cbNewCategory.SelectedValue = newCategoryID;
            }
            else
            {
                MessageBox.Show("Chuyển thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dtgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Đảm bảo người dùng không click vào tiêu đề cột
            {
                DataGridViewRow row = dtgvCategory.Rows[e.RowIndex];

                if (row.Cells["IDLoai"].Value != null && row.Cells["TenLoai"].Value != null)
                {
                    txbCategoryID.Text = row.Cells["IDLoai"].Value.ToString();
                    txbCategoryName.Text = row.Cells["TenLoai"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }


}
