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
using CyberManagementProject.DTO;

namespace QuanLyQuanNet
{
    public partial class fAddFood : Form
    {
        public fAddFood()
        {
            InitializeComponent();
            LoadLoaiDoAn();
        }

        private void fAddFood_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Tạo OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Cấu hình OpenFileDialog
                openFileDialog.Title = "Chọn hình ảnh";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Multiselect = false;

                // Hiển thị hộp thoại chọn file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file được chọn
                    string filePath = openFileDialog.FileName;

                    // Hiển thị hình ảnh trong PictureBox ptFood
                    ptFood.Image = Image.FromFile(filePath);
                    ptFood.SizeMode = PictureBoxSizeMode.StretchImage; // Tùy chọn: làm hình vừa khung
                }
            }
        }

        private void LoadLoaiDoAn()
        {
            string query = "SELECT IDLoai, TenLoai FROM LoaiDoAn";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            cbLoai.DataSource = data;
            cbLoai.DisplayMember = "TenLoai"; // Hiển thị tên loại
            cbLoai.ValueMember = "IDLoai";   // Giá trị là ID
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox và ComboBox
            string tenMonAn = txbTenMonAn.Text;
            decimal gia;
            int idLoai;

            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(tenMonAn))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txbGia.Text, out gia) || gia <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbLoai.SelectedValue == null || !int.TryParse(cbLoai.SelectedValue.ToString(), out idLoai))
            {
                MessageBox.Show("Vui lòng chọn loại món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo DTO cho món ăn mới
            DoAnDTO newFood = new DoAnDTO
            {
                TenDoAn = tenMonAn,
                Gia = gia,
                IDLoai = idLoai,
                HinhAnh = "Chưa cập nhật hình ảnh"
            };

            // Gọi DAO để thêm món ăn
            try
            {
                bool isSuccess = FoodDAO.Instance.InSertFood(newFood);

                if (isSuccess)
                {
                    MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật danh sách món ăn ở form fViewFood
                    var viewFoodForm = (fViewFood)Application.OpenForms["fViewFood"];
                    if (viewFoodForm != null)
                    {
                        viewFoodForm.LoadFoodList(); // Gọi phương thức cập nhật danh sách món ăn
                    }

                    this.Close(); // Đóng form thêm món ăn
                }
                else
                {
                    MessageBox.Show("Thêm món ăn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món ăn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
