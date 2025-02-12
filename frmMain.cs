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
using QuanLyQuanNet;
using QuanLyQuanNet.KhachHang;
using CyberManagementProject.NhanVien;
using CyberManagementProject.DTO;
using Microsoft.Data.SqlClient;
using System.Collections;
using QuanLyQuanNet.Customer;
using CyberManagementProject.Music;

namespace CyberManagementProject
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            LoadHoangNghia();
            LoadTrongThoai();

        }

        #region Hoàng Nghĩa

        #region Method
        void LoadHoangNghia()
        {
            LoadKhachHang(); //Load danh sách khách hàng khi frmMain load

            LoadNhanVien(); //Load danh sách nhân viên khi frmMain load

            txtTimKiem.TextChanged += txtTimKiem_TextChanged;//Nút tìm kiếm khi frmMain được load

            //Sự kiện cbxTrangThai khi frmMain được load
            cbxTrangThai.Text = "Đang làm";
            cbxTrangThai.ForeColor = Color.Gray;

            LoadChucVuToComboBox(); // gọi phương thức load TenChucVu khi frmMain load

            LoadNhomKhachToComboBox(); // gọi phương thức load NhomKhach khi frmMain load
        }
        //Load thong tin cua Khach Hang
        public void LoadKhachHang()
        {
            // Xóa tất cả các button hiện tại trong flpKhachHangtrước khi thêm mới
            flpKhachHang.Controls.Clear();

            List<KhachHangDTO> khachHangList = KhachHangDAO.Instance.LoadKhachHangList();

            foreach (KhachHangDTO item in khachHangList)
            {
                Button btn = new Button() { Width = KhachHangDAO.KhachHangWidth, Height = KhachHangDAO.KhachHangHeight };

                //btn.Text = item.TKKhachHang + "\n" + item.NhomKhach;
                btn.Name = "btnKhachHang_" + item.TKKhachHang;
                btn.Text = item.TKKhachHang + "\n" + item.NhomKhach;
                btn.Font = new Font(btn.Font.FontFamily, 8, FontStyle.Regular);

                switch (item.NhomKhach)
                {
                    case "Vip":
                        btn.BackColor = Color.Aqua; break;
                    default:
                        btn.BackColor = Color.White; break;
                }

                flpKhachHang.Controls.Add(btn);
                btn.Click += btnKhachHang_Click;

            }
        }

        //Load thong tin cua Nhan Vien
        public void LoadNhanVien()
        {
            // Xóa tất cả các button hiện tại trong flpNhanVien trước khi thêm mới
            flpNhanVien.Controls.Clear();

            List<NhanVienDTO> nhanvienList = NhanVienDAO.Instance.LoadNhanVienList();

            foreach (NhanVienDTO item in nhanvienList)
            {
                Button btn = new Button() { Width = NhanVienDAO.NhanVienWidth, Height = NhanVienDAO.NhanVienHeight };

                //btn.Text = item.TKKhachHang + "\n" + item.NhomKhach;
                btn.Name = "btnNhanVien_" + item.TKNhanVien;
                btn.Text = item.TKNhanVien + "\n" + item.TenChucVu;
                btn.Font = new Font(btn.Font.FontFamily, 8, FontStyle.Regular);

                switch (item.TenChucVu)
                {
                    case "Quản lý":
                        btn.BackColor = Color.Aqua; break;
                    default:
                        btn.BackColor = Color.White; break;
                }

                flpNhanVien.Controls.Add(btn);
                btn.Click += btnNhanVien_Click;

            }
        }

        //Tìm kiếm nhân viên theo TKNhanVien
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower(); // Lấy từ khóa và chuyển thành chữ thường

            foreach (Control control in flpNhanVien.Controls)
            {
                if (control is Button btn) // Kiểm tra nếu control là Button
                {
                    // Tách nội dung của Button (giả sử nội dung là "NV001\nPhục vụ")
                    string[] noiDungButton = btn.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    // Lấy TKNhanVien từ dòng đầu tiên
                    string tkNhanVien = noiDungButton.Length > 0 ? noiDungButton[0].ToLower() : string.Empty;

                    // Hiển thị hoặc ẩn Button dựa trên từ khóa
                    btn.Visible = tkNhanVien.Contains(tuKhoa);
                }
            }
        }

        //Tìm kiếm khách hàng theo TKKhachHang
        private void txtTimKiemKhachHang_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemKhachHang.Text.Trim().ToLower(); // Lấy từ khóa và chuyển thành chữ thường

            foreach (Control control in flpKhachHang.Controls)
            {
                if (control is Button btn) // Kiểm tra nếu control là Button
                {
                    // Tách nội dung của Button (giả sử nội dung là "KH001 \n VIP")
                    string[] noiDungButton = btn.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    // Lấy TKKhachHang từ dòng đầu tiên
                    string tkKhachHang = noiDungButton.Length > 0 ? noiDungButton[0].ToLower() : string.Empty;

                    // Hiển thị hoặc ẩn Button dựa trên từ khóa
                    btn.Visible = tkKhachHang.Contains(tuKhoa);
                }
            }
        }

        //Phương thức load dữ liệu của trường TenChucVu (NhanVien) từ SQL
        private void LoadChucVuToComboBox()
        {
            List<string> danhSachChucVu = NhanVienDAO.Instance.GetDanhSachChucVu();
            cbxChucVu.Items.Clear();
            cbxChucVu.Items.Add("Tất cả"); // Thêm tùy chọn để hiển thị tất cả
            cbxChucVu.Items.AddRange(danhSachChucVu.ToArray());
            cbxChucVu.SelectedIndex = 0; // Chọn mặc định là "Tất cả"
        }

        //Phương thức load dữ liệu của trường NhomKhach (NhanVien) từ SQL
        private void LoadNhomKhachToComboBox()
        {
            List<string> danhSachNhomKhach = KhachHangDAO.Instance.GetDanhSachNhomKhach();
            cbxNhomKhach.Items.Clear();
            cbxNhomKhach.Items.Add("Tất cả"); // Thêm tùy chọn để hiển thị tất cả
            cbxNhomKhach.Items.AddRange(danhSachNhomKhach.ToArray());
            cbxNhomKhach.SelectedIndex = 0; // Chọn mặc định là "Tất cả"
        }
        #endregion
        #region Events
        //thêm nhân viên mới
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmThemNhanVien f = new frmThemNhanVien();
            f.ShowDialog();
        }

        //thêm khách hàng mới
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThemKhachHang f = new frmThemKhachHang();
            f.ShowDialog();
        }

        //Back Home
        private void lblHome_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpComputer;
        }
        private void label33_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpComputer;
        }

        //Loc Khach Hang


        //button Show Khach Hang
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            // Lấy thông tin khách hàng từ button đã click
            Button btn = sender as Button;
            // Tách TKKhachHang và NhomKhach từ button text
            string[] buttonText = btn.Text.Split('\n');
            string tkKhachHang = buttonText[0]; // TKKhachHang là dòng đầu tiên trên button

            // Tạo một đối tượng DTO từ TKKhachHang
            KhachHangDTO khachHang = KhachHangDAO.Instance.GetKhachHangDetailsByUser(tkKhachHang);

            // Nếu lấy được khách hàng, mở form chi tiết và truyền thông tin khách hàng vào
            if (khachHang != null)
            {
                frmThongTinKhachHang frm = new frmThongTinKhachHang(khachHang);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng!");
            }
        }


        //button Show Nhan Vien
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            // Lấy thông tin khách hàng từ button đã click
            Button btn = sender as Button;
            // Tách TKNhanVien va TenChucVu từ button text
            string[] buttonText = btn.Text.Split('\n');
            string tkNhanVien = buttonText[0]; // TKNhanVien là dòng đầu tiên trên button

            // Tạo một đối tượng DTO từ TKKhachHang
            NhanVienDTO nhanvien = NhanVienDAO.Instance.GetNhanVienDetailsByUser(tkNhanVien);

            // Nếu lấy được khách hàng, mở form chi tiết và truyền thông tin khách hàng vào
            if (nhanvien != null)
            {
                frmThongTinNhanVien frm = new frmThongTinNhanVien(nhanvien);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien!");
            }
        }


        //Sự kiện nút cbxChucVu

        private void cbxTrangThai_Enter(object sender, EventArgs e)
        {
            if (cbxTrangThai.Text == "Đang làm")
            {
                cbxTrangThai.Text = ""; // Xóa nội dung mặc định
                cbxTrangThai.ForeColor = Color.Black; // Đổi màu chữ thành đen
            }
        }
        private void cbxTrangThai_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxChucVu.Text)) //Kiểm tra ô textbox rỗng
            {
                cbxTrangThai.Text = "Đang làm"; // Hiển thị lại nội dung mặc định
                cbxTrangThai.ForeColor = Color.Gray; // Đổi màu chữ thành mờ
            }
        }

        //lọc nhân viên theo TenChucVu
        private void cbxChucVu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string chucVuDuocChon = cbxChucVu.SelectedItem.ToString().ToLower();

            foreach (Control control in flpNhanVien.Controls)
            {
                if (control is Button btn)
                {
                    // Tách nội dung của Button
                    string[] noiDungButton = btn.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    // Lấy TenChucVu từ dòng thứ hai
                    string tenChucVu = noiDungButton.Length > 1 ? noiDungButton[1].ToLower() : string.Empty;

                    // Hiển thị hoặc ẩn Button dựa trên chức vụ được chọn
                    btn.Visible = chucVuDuocChon == "tất cả" || tenChucVu == chucVuDuocChon;
                }
            }
        }

        //lọc khách hàng theo NhomKhach
        private void cbxNhomKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nhomKhachDuocChon = cbxNhomKhach.SelectedItem.ToString().ToLower();

            foreach (Control control in flpKhachHang.Controls)
            {
                if (control is Button btn)
                {
                    // Tách nội dung của Button
                    string[] noiDung = btn.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    // Lấy nhomKhach từ dòng thứ hai
                    string nhomKhach = noiDung.Length > 1 ? noiDung[1].ToLower() : string.Empty;

                    // Hiển thị hoặc ẩn Button dựa trên chức vụ được chọn
                    btn.Visible = nhomKhachDuocChon == "tất cả" || nhomKhach == nhomKhachDuocChon;
                }
            }
        }

        //menu chuột phải Khách hàng
        private void flpKhachHang_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsKhachHang.Show(Cursor.Position);
            }
        }
        private void cmsKhachHang_Them_Click(object sender, EventArgs e)
        {
            frmThemKhachHang f = new frmThemKhachHang();
            f.Show();
        }
        private void cmsKhachHang_Nhac_Click(object sender, EventArgs e)
        {
            frmMusic f = new frmMusic();
            f.Show();
        }
        private void cmsKhachHang_TrangChu_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpComputer;
        }

        //menu chuột phải Nhân viên
        private void flpNhanVien_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsNhanVien.Show(Cursor.Position);
            }
        }
        private void cmsNhanVien_Them_Click(object sender, EventArgs e)
        {
            frmThemNhanVien f = new frmThemNhanVien();
            f.Show();
        }
        private void cmsNhanVien_Nhac_Click(object sender, EventArgs e)
        {
            frmMusic f = new frmMusic();
            f.Show();
        }
        private void cmsNhanVien_TrangChu_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpComputer;
        }
        //Tổng hợp phím tắt
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) // Ctrl + N: tạo khách hàng mới
            {
                frmThemKhachHang f = new frmThemKhachHang();
                f.Show();
            }
            else if (e.Alt && e.KeyCode == Keys.N) // Alt + N: tạo nhân viên mới
            {
                frmThemNhanVien f = new frmThemNhanVien();
                f.Show();
            }
            else if (e.Control && e.KeyCode == Keys.M) // Ctrl + M: gọi form Music
            {
                frmMusic f = new frmMusic();
                f.Show();
            }
            else if (e.Control && e.KeyCode == Keys.H) // Ctrl + H: gọi form Main (computer)
            {
                tblMain.SelectedTab = tbpComputer;
            }
        }
        #endregion

        #endregion

        #region Trung Nghĩa
        //
        #endregion

        #region Hoàng Lễ
        //
        #endregion


        #region Trọng Thoại
        #region Events
        private void btnForceStop_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox hỏi người dùng có muốn thoát hay không
            DialogResult result = MessageBox.Show(
                "Đóng ứng dụng máy 1?",
                "Đóng ứng dụng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
        }
        private void timerToggle_Tick(object sender, EventArgs e)
        {
            if (Utilize.isCollapsed)
            {
                pnlLeft.Width += 10; // Mở rộng
                if (pnlLeft.Width >= Utilize.sidebarExpandedWidth)
                {
                    pnlLeft.Width = Utilize.sidebarExpandedWidth; // Đặt giá trị tối đa
                    timerToggle.Stop(); // Dừng Timer
                    Utilize.isCollapsed = false; // Cập nhật trạng thái
                }
            }
            else
            {
                pnlLeft.Width -= 10; // Thu hẹp
                if (pnlLeft.Width <= Utilize.sidebarCollapsedWidth)
                {
                    pnlLeft.Width = Utilize.sidebarCollapsedWidth; // Đặt giá trị tối thiểu
                    timerToggle.Stop(); // Dừng Timer
                    Utilize.isCollapsed = true; // Cập nhật trạng thái
                }
            }
        }
        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            timerToggle.Start();
        }
        private void pnComputer_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpComputer;
        }

        private void pnStaff_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpStaff;
        }
        private void pnAccount_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpAccount;
        }

        private void pnServices_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpServices;
        }

        private void pnStatictical_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpStatictical;
        }
        private void label27_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpComputer;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpComputer;
        }
        private void label28_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpAccount;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpAccount;
        }
        private void label29_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpServices;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpServices;
        }
        private void lblNhanVien_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpStaff;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpStaff;
        }
        private void label31_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpStatictical;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpStatictical;
        }
        #endregion
        #region Method
        void LoadTrongThoai() 
        {
            LoadComputerList();

        }
        void LoadComputerList()
        {
            flpComputer.Controls.Clear();
            List<MayTinh> computers = MayTinhDAO.Instance.LoadComputer();
            foreach (MayTinh com in computers)
            {
                // Tạo Panel chứa từng máy tính
                Panel pnCom = new Panel()
                {
                    Width = MayTinhDAO.TableWidth,
                    Height = MayTinhDAO.TableHeight,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.WhiteSmoke,
                    Padding = new Padding(5) // Thêm padding để tạo khoảng cách bên trong
                };
                string projectPath = AppDomain.CurrentDomain.BaseDirectory;
                string imagePath = Path.Combine(projectPath, @"..\..\..\Resources\Monitor\Offline.png");
                // Tạo PictureBox để hiển thị ảnh máy tính
                PictureBox pbComputer = new PictureBox()
                {
                    
                    Width = MayTinhDAO.PicWidth,
                    Height = MayTinhDAO.PicHeight, // Chiếm nửa trên của panel
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = Image.FromFile(imagePath),
                    Location = new Point((pnCom.Width - MayTinhDAO.PicWidth) / 2, (pnCom.Height - MayTinhDAO.PicHeight) / 2)
                    // Đổi thành đường dẫn ảnh thật
                    //Location = new Point(5, 5) // Đặt vị trí ở góc trên của Panel
                };
                Label lbComputerName = new Label()
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    
                    Text = com.TenMay,

                    Location = new Point(30, pbComputer.Bottom + 5), // Đặt ở giữa theo chiều ngang
                    TextAlign = ContentAlignment.MiddleCenter // Căn giữa chữ theo chiều ngang
                };
                //// Tạo TextBox hiển thị tên máy tính
                //TextBox txtComputerName = new TextBox()
                //{
                //    Text = com.TenMay,
                //    ReadOnly = true,
                //    Width = pnCom.Width - 10,
                //    Height = 25,
                //    Location = new Point(5, pbComputer.Bottom + 5), // Nằm ngay dưới PictureBox
                //    TextAlign = HorizontalAlignment.Center
                //};

                //// Tạo TextBox hiển thị thời gian sử dụng
                //TextBox txtTimeUsed = new TextBox()
                //{
                //    Text = com.ThoiGianSuDung.ToString(), // Giả sử ThoiGianSuDung là kiểu TimeSpan hoặc string
                //    ReadOnly = true,
                //    Width = pnCom.Width - 10,
                //    Height = 25,
                //    Location = new Point(5, txtComputerName.Bottom + 5), // Dưới TextBox tên máy tính
                //    TextAlign = HorizontalAlignment.Center
                //};

                //// Tạo TextBox hiển thị tên người dùng đang sử dụng máy
                //TextBox txtUser = new TextBox()
                //{
                //    Text = com.UserName, // Giả sử UserName là tên người dùng
                //    ReadOnly = true,
                //    Width = pnCom.Width - 10,
                //    Height = 25,
                //    Location = new Point(5, txtTimeUsed.Bottom + 5), // Dưới TextBox thời gian sử dụng
                //    TextAlign = HorizontalAlignment.Center
                //};
                //pbComputer.SizeMode = PictureBoxSizeMode.Zoom;
              
                // Thêm các control vào Panel
                pnCom.Controls.Add(pbComputer);
                pnCom.Controls.Add(lbComputerName);
                //pnCom.Controls.Add(txtTimeUsed);
                //pnCom.Controls.Add(txtUser);

                // Thêm Panel vào FlowLayoutPanel
                flpComputer.Controls.Add(pnCom);
            }
        }
        #endregion
        #endregion

        
    }

}