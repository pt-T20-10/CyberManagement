using CyberManagementProject;
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

namespace QuanLyQuanNet
{
    public partial class frmThongTinNhanVien : Form
    {
        private string tknv; // Biến để lưu TKNhanVien

        public frmThongTinNhanVien(NhanVienDTO nhanvien)
        {
            InitializeComponent();

            // Hiển thị thông tin khách hàng vào các control trên form
            if (nhanvien != null)
            {
                tknv = nhanvien.TKNhanVien;  // Lưu TKNhanVien

                // Cập nhật thông tin vào form
                txtIDNhanVien.Text = nhanvien.ID.ToString();
                txtTenNhanVien.Text = nhanvien.Ten;
                cbxBoPhanNhanVien.Text = nhanvien.TenBoPhan;
                cbxChucVuNhanVien.Text = nhanvien.TenChucVu;
                cbxKieuLamNhanVien.Text = nhanvien.KieuLam;
                txtDiaChiNhanVien.Text = nhanvien.DiaChi;
                txtSoDTNhanVien.Text = nhanvien.SoDT;
                txtEmailNhanVien.Text = nhanvien.Email;
                txtCCCDNhanVien.Text = nhanvien.CCCD;
                txtGioiTinhNhanVien.Text = nhanvien.GioiTinh;
                txtTonGiaoNhanVien.Text = nhanvien.TonGiao;
                dtpNgaySinhNhanVien.Text = nhanvien.NgaySinh;
                dtpNgayVaoNhanVien.Text = nhanvien.NgayVao;
                dtpNgayRaNhanVien.Text = nhanvien.NgayRa;


                // Cập nhật các control khác nếu cần
            }
            else
                MessageBox.Show("Khong tim thay nhan vien.");

        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            string folderPath = @"D:\LapTrinhNet\CyberManagement\Picture";

            // Kiểm tra thư mục có tồn tại không
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Thư mục không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Tạo hộp thoại chọn file
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Thiết lập thư mục mở ban đầu
                openFileDialog.InitialDirectory = folderPath;

                // Bộ lọc file (chỉ hiện các file ảnh)
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                // Tiêu đề của hộp thoại
                openFileDialog.Title = "Chọn ảnh";

                // Hiển thị hộp thoại và kiểm tra nếu người dùng nhấn OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file đã chọn
                    string selectedFilePath = openFileDialog.FileName;

                    // Hiển thị ảnh trong PictureBox
                    pbxAnhNhanVien.Image = Image.FromFile(selectedFilePath);
                    pbxAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage; // Co giãn ảnh vừa với khung
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở thư mục. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelThemNhanVien_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các textbox
                string ten = txtTenNhanVien.Text;
                string soDT = txtSoDTNhanVien.Text;
                string email = txtEmailNhanVien.Text;
                string diaChi = txtDiaChiNhanVien.Text;
                string tenchucvu = cbxChucVuNhanVien.Text;
                string tenbophan = cbxBoPhanNhanVien.Text;
                string kieulam = cbxKieuLamNhanVien.Text;
                string cccd = txtCCCDNhanVien.Text;
                string gioitinh = txtGioiTinhNhanVien.Text;
                string tongiao = txtTonGiaoNhanVien.Text;
                string ngaysinh = dtpNgaySinhNhanVien.Value.ToString("yyyy-MM-dd");
                string ngayvao = dtpNgayVaoNhanVien.Value.ToString("yyyy-MM-dd");
                string ngayra = dtpNgayRaNhanVien.Value.ToString("yyyy-MM-dd");

                // Gọi DAO để cập nhật thông tin
                bool isUpdated = NhanVienDAO.Instance.UpdateNhanVien(ten, soDT, email, tenchucvu, tenbophan, kieulam, diaChi, cccd, gioitinh, tongiao, ngaysinh, ngayvao, ngayra, tknv);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
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
            // Lấy TKNhanVien từ TextBox hoặc DTO
            string tkNhanVien = tknv;
            // Xác nhận xóa
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    // Gọi DAO để xóa nhân viên
                    bool isDeleted = NhanVienDAO.Instance.DeleteNhanVienByTKNhanVien(tkNhanVien);

                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        frmMain? mainForm = Application.OpenForms["frmMain"] as frmMain;
                        mainForm.LoadNhanVien(); // Gọi trước khi đóng form
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

        private void cbxBoPhanNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            frmMain? mainForm = Application.OpenForms["frmMain"] as frmMain;
            mainForm.LoadNhanVien();
        }

        private void cbxChucVuNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain? mainForm = Application.OpenForms["frmMain"] as frmMain;
            mainForm.LoadNhanVien();
        }

        private void cbxKieuLamNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain? mainForm = Application.OpenForms["frmMain"] as frmMain;
            mainForm.LoadNhanVien();
        }

        
    }
}
