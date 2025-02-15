using CyberManagementProject.DAO;
using CyberManagementProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CyberManagementProject.DichVu
{
    public partial class fEditFood : Form
    {
        private DoAnDTO food; // Lưu thông tin món ăn hiện tại
        public event Action FoodUpdated; // Sự kiện cập nhật danh sách món ăn

        public fEditFood(DoAnDTO food)
        {
            InitializeComponent();
            this.food = food;
            LoadCategories(); // Tải danh sách loại món ăn
            LoadFoodData();   // Tải dữ liệu lên form
        }

        // Load danh mục loại món ăn
        private void LoadCategories()
        {
            DataTable categories = FoodDAO.Instance.GetCategories();
            cbLoai.DataSource = categories;
            cbLoai.DisplayMember = "TenLoai";  // Hiển thị tên loại
            cbLoai.ValueMember = "IDLoai";    // Giá trị là ID
        }

        // Load dữ liệu món ăn
        private void LoadFoodData()
        {
            if (food != null)
            {
                txbID.Text = food.IDDoAn.ToString();
                txbTenMonAn.Text = food.TenDoAn;
                cbLoai.SelectedValue = food.IDLoai;
                txbGia.Text = food.Gia.ToString();

                // Kiểm tra nếu có ảnh thì hiển thị
                if (!string.IsNullOrEmpty(food.HinhAnh) && File.Exists(food.HinhAnh))
                {
                    ptFood.Image = Image.FromFile(food.HinhAnh);
                    ptFood.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptFood.Tag = food.HinhAnh;
                }
            }
        }

        // Xử lý khi bấm nút Lưu
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbTenMonAn.Text) || string.IsNullOrWhiteSpace(txbGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                food.TenDoAn = txbTenMonAn.Text;
                food.IDLoai = Convert.ToInt32(cbLoai.SelectedValue);
                food.Gia = Convert.ToDecimal(txbGia.Text);

                // Kiểm tra nếu có ảnh mới
                if (ptFood.Tag != null)
                {
                    food.HinhAnh = ptFood.Tag.ToString();
                }

                bool isUpdated = FoodDAO.Instance.UpdateFood(food);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FoodUpdated?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện chọn ảnh
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn hình ảnh";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    ptFood.Image = Image.FromFile(filePath);
                    ptFood.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptFood.Tag = filePath; // Lưu đường dẫn ảnh
                }
            }
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
