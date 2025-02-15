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
using CyberManagementProject.Computer;
using System.Globalization;
using CyberManagementProject.DichVu;

namespace CyberManagementProject
{
    public partial class frmMain : Form
    {
        BindingSource computuberStatus = new BindingSource();
        public frmMain()
        {
            InitializeComponent();
            LoadHoangNghia();
            LoadTrongThoai();
            LoadFoodList();

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
        //Thêm Food
        private void button1_Click(object sender, EventArgs e)
        {
            fAddFood f = new fAddFood();
            f.ShowDialog();
        }

        //Xem Food
        private void button4_Click(object sender, EventArgs e)
        {
            fViewFood f = new fViewFood();
            f.ShowDialog();
        }

        //Tạo Danh Sách Thức Ăn
        private void LoadFoodList()
        {
            flpFoodList.Controls.Clear(); // Xóa danh sách cũ trước khi load mới

            List<DoAnDTO> foodList = FoodDAO.Instance.GetFoodList();

            foreach (DoAnDTO food in foodList)
            {
                AddFoodToFlowLayout(food);
            }
        }




        //-------------------------------------------
        public void AddFoodToFlowLayout(DoAnDTO food)
        {
            Panel foodPanel = new Panel
            {
                Width = 200,
                Height = 300,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5),
                Tag = food
            };

            PictureBox pictureBox = new PictureBox
            {
                Width = 180,
                Height = 150,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand
            };

            if (!string.IsNullOrEmpty(food.HinhAnh) && File.Exists(food.HinhAnh))
            {
                pictureBox.Image = Image.FromFile(food.HinhAnh);
            }

            Label lblTen = new Label
            {
                Text = food.TenDoAn,
                AutoSize = false,
                Width = 180,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            Label lblGia = new Label
            {
                Text = $"Giá: {food.Gia:N0} VNĐ",
                AutoSize = false,
                Width = 180,
                Height = 25,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10, FontStyle.Regular)
            };

            // Nút sửa (🖊)
            Button btnEdit = new Button
            {
                Text = "🖊",
                Width = 50,
                Height = 35,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.LightGray,
                ForeColor = Color.Black,
                Cursor = Cursors.Hand,
                Tag = food
            };

            // Nút giỏ hàng (🛒) - Chỉ hiển thị, không có sự kiện
            Button btnCart = new Button
            {
                Text = "🛒",
                Width = 50,
                Height = 35,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.LightGray,
                ForeColor = Color.Black,
                Cursor = Cursors.Hand,
                Tag = food
            };

            // Nút xóa (🗑) - Chỉ hiển thị thông báo
            Button btnDelete = new Button
            {
                Text = "🗑",
                Width = 50,
                Height = 35,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.LightGray,
                ForeColor = Color.Black,
                Cursor = Cursors.Hand,
                Tag = food
            };

            // Hiệu ứng hover đổi màu
            btnEdit.MouseEnter += (s, e) => { btnEdit.BackColor = Color.Gray; btnEdit.ForeColor = Color.White; };
            btnEdit.MouseLeave += (s, e) => { btnEdit.BackColor = Color.LightGray; btnEdit.ForeColor = Color.Black; };

            btnCart.MouseEnter += (s, e) => { btnCart.BackColor = Color.Gray; btnCart.ForeColor = Color.White; };
            btnCart.MouseLeave += (s, e) => { btnCart.BackColor = Color.LightGray; btnCart.ForeColor = Color.Black; };

            btnDelete.MouseEnter += (s, e) => { btnDelete.BackColor = Color.Red; btnDelete.ForeColor = Color.White; };
            btnDelete.MouseLeave += (s, e) => { btnDelete.BackColor = Color.LightGray; btnDelete.ForeColor = Color.Black; };

            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;

            // Panel chứa 3 nút
            FlowLayoutPanel buttonPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                Width = 180,
                Height = 40,
                AutoSize = false,
                WrapContents = false,
                Dock = DockStyle.Bottom,
                Padding = new Padding(0),
                Margin = new Padding(0)
            };

            buttonPanel.Controls.Add(btnEdit);
            buttonPanel.Controls.Add(btnCart);
            buttonPanel.Controls.Add(btnDelete);

            FlowLayoutPanel panelContainer = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Width = 200,
                Height = 280,
                WrapContents = false,
                AutoSize = false,
                Dock = DockStyle.Fill,
                Padding = new Padding(5),
                Margin = new Padding(5)
            };

            panelContainer.Controls.Add(pictureBox);
            panelContainer.Controls.Add(lblTen);
            panelContainer.Controls.Add(lblGia);
            panelContainer.Controls.Add(buttonPanel);

            foodPanel.Controls.Add(panelContainer);
            flpFoodList.Controls.Add(foodPanel);
        }

        // Xử lý khi nhấn nút sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag is DoAnDTO food)
            {
                fEditFood editForm = new fEditFood(food);
                editForm.FoodUpdated += LoadFoodList; // Load lại danh sách sau khi sửa
                editForm.ShowDialog();
            }
        }


        // Xử lý khi nhấn nút xóa (Chỉ hiển thị thông báo, không xóa thực sự)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag is DoAnDTO food)
            {
                MessageBox.Show($"Bạn muốn xóa {food.TenDoAn} nhưng tính năng này chưa được kích hoạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Chức năng tìm kiếm
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txbSearch.Text.ToLower();

            foreach (Control control in flpFoodList.Controls)
            {
                if (control is Panel panel)
                {
                    // Tìm FlowLayoutPanel chứa label
                    FlowLayoutPanel panelContainer = panel.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
                    if (panelContainer != null)
                    {
                        // Tìm label chứa tên món ăn
                        Label lblTen = panelContainer.Controls.OfType<Label>().FirstOrDefault();
                        if (lblTen != null)
                        {
                            panel.Visible = lblTen.Text.ToLower().Contains(searchText);
                        }
                    }
                }
            }
        }


        #endregion

        #region Hoàng Lễ
        //
        #endregion


        #region Trọng Thoại
        #region Events
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
        private void btnExtraMoney_Click(object sender, EventArgs e)
        {

            frmNapTien f = new frmNapTien();
            f.ShowDialog();

        }
        private void btnManageAllCom_Click(object sender, EventArgs e)
        {
            MayTinhView computer = flpComputer.Tag as MayTinhView;
            if (computer != null)
            {
                MayTinh com = MayTinhDAO.Instance.LoadComputerById(computer.IDMayTinh);
                frmManageComputers frm = new frmManageComputers(com);
                frm.ShowDialog();
                LoadComputerList();
            }
            else
            {
                frmManageComputers frm = new frmManageComputers();
                frm.ShowDialog();
                LoadComputerList();
            }
        }
        private void btnManageComputer_Click(object sender, EventArgs e)
        {
            MayTinhView computer = flpComputer.Tag as MayTinhView;

            frmAddUserToComputer f = new frmAddUserToComputer(computer);
            f.ShowDialog();
            LoadComputerList();

        }
        private void btnShutDownComputer_Click(object sender, EventArgs e)
        {
            MayTinhView com = flpComputer.Tag as MayTinhView;

            if (com != null)
            {
                if (com.TrangThai == "Trống")
                {
                    MessageBox.Show("Máy hiện chưa mở!");
                    return;
                }
                string tenMay = com.TenMay.ToString();
                int idPhien = (int)com.IDPhien;
                DateTime timeKetThuc = DateTime.Now;
                double TongTien = Convert.ToDouble(tbxMoneyCost.Text.Split(' ')[0].Replace(".", ""));
                if (MessageBox.Show(string.Format("Bạn có thục sự muốn tắt máy {0}?", tenMay), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MayTinhDAO.Instance.AddThoiGianKetThucPhien(idPhien, timeKetThuc, (float)TongTien);
                    MessageBox.Show("Đã tắt máy {0}", tenMay);
                    LoadComputerBindingByComputer(com);
                    LoadComputerList();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn máy!");
                return;
            }
        }
        private void btnAddServices_Click(object sender, EventArgs e)
        {
            MayTinhView com = flpComputer.Tag as MayTinhView;
            if (com != null)
            {
                if(com.TrangThai == "Trống")
                {
                    MessageBox.Show("Máy chưa được mở!");
                    return; 
                }

                frmAddDichVuToCom f = new frmAddDichVuToCom(com);
                f.ShowDialog();
                LoadComputerBindingByComputer(com);
                LoadComputerList();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn máy!");
                return;
            }

        }
        private void flpComputer_Click(object sender, EventArgs e)
        {
            // Xóa tag của flpComputer
            flpComputer.Tag = null;

            // Kiểm tra nếu computuberStatus.DataSource không phải là danh sách hoặc null
            if (computuberStatus.DataSource != null)
            {
                // Đặt lại dữ liệu nguồn về một danh sách trống thay vì null
                computuberStatus.DataSource = new List<MayTinhView>();
            }

            // Xóa tất cả Binding cũ
            gbxComputerInfor.DataBindings.Clear();
            tbxUserAccount.DataBindings.Clear();
            tbxComputerStatus.DataBindings.Clear();
            tbxTimeLeft.DataBindings.Clear();

            // Đặt lại giá trị trống cho các textbox
            gbxComputerInfor.Text = "Thông tin máy";
            tbxUserAccount.Text = "";
            tbxComputerStatus.Text = "";
            tbxTimeLeft.Text = "00:00:00";
            LoadButton();
        }

        #region CloseButton
        private void pbxClose_MouseEnter_1(object sender, EventArgs e)
        {
            pbxClose.BackColor = Color.Red;
            pbxClose.Image = Properties.Resources.close_hover;
        }
        private void pbxClose_MouseLeave(object sender, EventArgs e)
        {
            pbxClose.BackColor = Color.Transparent;
            pbxClose.Image = Properties.Resources.close;
        }

        private void pbxClose_MouseUp(object sender, MouseEventArgs e)
        {
            pbxClose.BackColor = Color.Red;
        }

        private void pbxClose_MouseDown(object sender, MouseEventArgs e)
        {
            pbxClose.BackColor = Color.DarkRed;
        }
        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Binding Click
        private void LbUserName_Click(object? sender, EventArgs e)
        {
            if (sender is Label lb)
            {
                MayTinhView computer = lb.Tag as MayTinhView;
                if (computer != null)
                {
                    flpComputer.Tag = computer;
                    LoadComputerBindingByComputer(computer);
                    LoadButton();
                }
            }
        }

        private void LbTimeUsed_Click(object? sender, EventArgs e)
        {
            if (sender is Label lb)
            {
                MayTinhView computer = lb.Tag as MayTinhView;
                if (computer != null)
                {
                    flpComputer.Tag = computer;
                    LoadComputerBindingByComputer(computer);
                    LoadButton();
                }
            }
        }

        private void LbComputerName_Click(object? sender, EventArgs e)
        {
            if (sender is Label lb)
            {
                MayTinhView computer = lb.Tag as MayTinhView;
                if (computer != null)
                {
                    flpComputer.Tag = computer;
                    LoadComputerBindingByComputer(computer);
                    LoadButton();
                }
            }
        }

        private void PbComputer_Click(object? sender, EventArgs e)
        {
            if (sender is PictureBox pbx)
            {
                MayTinhView computer = pbx.Tag as MayTinhView;
                if (computer != null)
                {
                    flpComputer.Tag = computer;
                    LoadComputerBindingByComputer(computer);
                    LoadButton();
                }
            }
        }

        private void ContainerPanel_Click(object? sender, EventArgs e)
        {
            if (sender is Panel pn)
            {
                MayTinhView computer = pn.Tag as MayTinhView;
                if (computer != null)
                {
                    flpComputer.Tag = computer;
                    LoadComputerBindingByComputer(computer);
                    LoadButton();
                }
            }
        }

        private void PnCom_Click(object? sender, EventArgs e)
        {
            if (sender is Panel pn)
            {
                MayTinhView computer = pn.Tag as MayTinhView;
                if (computer != null)
                {
                    flpComputer.Tag = computer;
                    LoadComputerBindingByComputer(computer);
                    LoadButton();
                }
            }
        }

        #endregion
        #endregion
        #region Method
        void LoadTrongThoai()
        {
            LoadComputerList();
            LoadButton();

        }
        void LoadButton()
        {
            bool isEnabled = flpComputer.Tag != null;

            btnAddServices.Enabled = isEnabled;
            btnManageComputer.Enabled = isEnabled;
            btnShutDownComputer.Enabled = isEnabled;


        }
        public void LoadComputerList()
        {
            flpComputer.Controls.Clear();
            List<MayTinhView> computers = MayTinhDAO.Instance.LoadComputerStatus();

            foreach (MayTinhView com in computers)
            {
                Panel pnCom = new Panel()
                {
                    Width = MayTinhDAO.TableWidth,
                    Height = MayTinhDAO.TableHeight,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.WhiteSmoke,
                    Padding = new Padding(5),

                };

                // Thêm sự kiện Click vào Panel chính (click ở đâu cũng được)
                pnCom.Click += PnCom_Click;

                // Tạo một Panel chứa toàn bộ các control
                Panel containerPanel = new Panel()
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.Transparent,
                    Tag = com
                };

                // Gọi sự kiện Click của pnCom khi click vào containerPanel
                containerPanel.Click += ContainerPanel_Click;

                // Đường dẫn ảnh
                string projectPath = AppDomain.CurrentDomain.BaseDirectory;
                string imageOfflinePath = Path.Combine(projectPath, @"..\..\..\Resources\Monitor\Offline.png");
                string imageOnlinePath = Path.Combine(projectPath, @"..\..\..\Resources\Monitor\Online.png");

                // Tạo PictureBox để hiển thị trạng thái máy tính
                PictureBox pbComputer = new PictureBox()
                {
                    Width = MayTinhDAO.PicWidth,
                    Height = MayTinhDAO.PicHeight,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = com.TrangThai == "Trống" ? Image.FromFile(imageOfflinePath) : Image.FromFile(imageOnlinePath),
                    Location = new Point((pnCom.Width - MayTinhDAO.PicWidth) / 2, 0),
                    Tag = com
                };
                pbComputer.Click += PbComputer_Click;
                // Tạo Label hiển thị tên máy tính
                Label lbComputerName = new Label()
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold),
                    Text = com.TenMay,
                    Location = new Point(30, pbComputer.Bottom + 5),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                lbComputerName.Click += LbComputerName_Click;
                // Tạo Label hiển thị thời gian còn lại
                Label lbTimeUsed = new Label()
                {
                    Text = com.ThoiGianConLai.HasValue ? TimeSpan.FromMinutes(com.ThoiGianConLai.Value).ToString(@"hh\:mm\:ss") : "00:00:00",
                    Width = pnCom.Width - 10,
                    Height = 25,
                    Location = new Point(5, lbComputerName.Bottom + 5),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                lbTimeUsed.Click += LbTimeUsed_Click;
                // Tạo Label hiển thị tên khách hàng
                Label lbUserName = new Label()
                {
                    Text = string.IsNullOrEmpty(com.TKKhachHang) ? "Trống" : com.TKKhachHang,
                    Width = pnCom.Width - 10,
                    Height = 25,
                    Location = new Point(5, lbTimeUsed.Bottom + 5),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                lbUserName.Click += LbUserName_Click;
                // Thêm các control vào Panel chứa

                pnCom.Controls.Add(pbComputer);
                pnCom.Controls.Add(lbComputerName);
                pnCom.Controls.Add(lbTimeUsed);
                pnCom.Controls.Add(lbUserName);

                // Thêm Panel chứa vào Panel chính

                pnCom.Controls.Add(containerPanel);
                // Thêm Panel chính vào FlowLayoutPanel
                flpComputer.Controls.Add(pnCom);
            }
        }

        void LoadComputerBindingByComputer(MayTinhView data)
        {
            LoadButton();
            computuberStatus.DataSource = data;

            // Xóa tất cả Binding cũ
            gbxComputerInfor.DataBindings.Clear();
            tbxUserAccount.DataBindings.Clear();
            tbxComputerStatus.DataBindings.Clear();
            tbxTimeLeft.DataBindings.Clear();

            // Thêm Binding mới
            gbxComputerInfor.DataBindings.Add(new Binding("Text", computuberStatus, "TenMay"));
            tbxComputerStatus.DataBindings.Add(new Binding("Text", computuberStatus, "TrangThai"));
            ShowOrderedFood(data.IDMayTinh);

            if (data.TrangThai != "Trống")
            {
                tbxUserAccount.DataBindings.Add(new Binding("Text", computuberStatus, "TKKhachHang"));

                Binding timeBinding = new Binding("Text", computuberStatus, "ThoiGianConLai", true, DataSourceUpdateMode.OnPropertyChanged);
                timeBinding.Format += (s, e) =>
                {
                    if (e.Value != null && int.TryParse(e.Value.ToString(), out int totalMinutes))
                    {
                        TimeSpan timeLeft = TimeSpan.FromMinutes(totalMinutes);
                        e.Value = timeLeft.ToString(@"hh\:mm\:ss");
                    }
                };
                tbxTimeLeft.DataBindings.Add(timeBinding);
            }
        }
        void ShowOrderedFood(int id)
        {
            lvServices.Items.Clear();
            CultureInfo culture = new CultureInfo("vi-VN");
            List<OrderedFood> listOrderedFood = OrderedFoodDAO.Instance.GetListOrderedFoodByComputer(id);
            float totalPrice = 0;
            foreach (OrderedFood item in listOrderedFood)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("c", culture));
                lsvItem.SubItems.Add(item.Count.ToString());

                lvServices.Items.Add(lsvItem);
                totalPrice += item.TotalPrice;
            }

            tbxMoneyCost.Text = totalPrice.ToString("c", culture);
        }

       
    }
    #endregion

    #endregion
}


