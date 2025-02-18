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

using OfficeOpenXml;
using System.IO;
using QLQuanNET;

using static CyberManagementProject.DAO.FoodDAO;


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

            SetupDataGridView();

            LoadCart();


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

        //Xóa giỏ hàng
        private void btnResetCart_Click(object sender, EventArgs e)
        {
            if (flpCart.Controls.Count == 0)
            {
                MessageBox.Show("Không có gì trong giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            flpCart.Controls.Clear();
            txbTongTien.Text = "0 VNĐ";

            MessageBox.Show("Giỏ hàng đã được đặt lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnCart.Click += btnCart_Click;

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


        // Xử lý khi nhấn nút xóa 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag is DoAnDTO food)
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa {food.TenDoAn} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (FoodDAO.Instance.DeleteFood(food.IDDoAn)) // Xóa trong CSDL
                    {
                        LoadFoodList(); // Cập nhật lại danh sách món ăn
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        void AddToCart(DoAnDTO food)
        {
            foreach (Control control in flpCart.Controls)
            {
                if (control is Panel existingPanel)
                {
                    Label lblFoodName = existingPanel.Controls.OfType<Label>().FirstOrDefault(l => l.Font.Bold);
                    Label lblQuantity = existingPanel.Controls.OfType<Label>().FirstOrDefault(l => l.Text.StartsWith("SL:"));
                    Label lblPrice = existingPanel.Controls.OfType<Label>().FirstOrDefault(l => l.ForeColor == Color.Red);
                

                    if (lblFoodName != null && lblFoodName.Text == food.TenDoAn)
                    {
                        int currentQuantity = int.Parse(lblQuantity.Text.Replace("SL: ", ""));
                        currentQuantity++;
                        lblQuantity.Text = "SL: " + currentQuantity;

                        decimal totalItemPrice = currentQuantity * food.Gia;
                        lblPrice.Text = totalItemPrice.ToString("N0");

                        UpdateTotalPrice();
                        return;
                    }
                }
            }

            // Nếu món chưa có trong giỏ, thêm mới như trước
            Panel panel = new Panel
            {
                Width = flpCart.Width - 5,
                Height = 50,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };

            Label lblFoodNameNew = new Label
            {
                Text = food.TenDoAn,
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(5, 5)
            };

            Label lblQuantityNew = new Label
            {
                Text = "SL: 1",
                Font = new Font("Arial", 10),
                AutoSize = true,
                Location = new Point(5, 25)
            };

            Label lblPriceNew = new Label
            {
                Text = food.Gia.ToString("N0"),
                Font = new Font("Arial", 10),
                AutoSize = true,
                ForeColor = Color.Red,
                Location = new Point(100, 5)
            };

   

            Button btnRemove = new Button
            {
                Text = "X",
                Width = 30,
                Height = 30,
                Location = new Point(panel.Width - 40, 10),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            btnRemove.Click += (s, e) =>
            {
                int currentQuantity = int.Parse(lblQuantityNew.Text.Replace("SL: ", ""));

                if (currentQuantity > 1)
                {
                    currentQuantity--;
                    lblQuantityNew.Text = "SL: " + currentQuantity;

                    // Cập nhật lại giá món này
                    decimal totalItemPrice = currentQuantity * food.Gia;
                    lblPriceNew.Text = totalItemPrice.ToString("N0");
                }
                else
                {
                    flpCart.Controls.Remove(panel);
                }

                UpdateTotalPrice();
            };

            panel.Controls.Add(lblFoodNameNew);
            panel.Controls.Add(lblQuantityNew);
            panel.Controls.Add(lblPriceNew);

            panel.Controls.Add(btnRemove);

            flpCart.Controls.Add(panel);
            UpdateTotalPrice();
        }




        private void UpdateTotalPrice()
        {
            decimal total = 0;

            foreach (Control panel in flpCart.Controls)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is Label lbl && lbl.ForeColor == Color.Red && !string.IsNullOrWhiteSpace(lbl.Text))
                    {
                        string priceText = lbl.Text.Replace(" VNĐ", "").Replace(",", "").Trim();

                        if (decimal.TryParse(priceText, out decimal price))
                        {
                            total += price;
                        }
                    }
                }
            }

            txbTongTien.Text = total.ToString("N0");
        }


        private void btnCart_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            DoAnDTO food = btn.Tag as DoAnDTO;
            if (food == null) return;

            AddToCart(food);
            UpdateTotalPrice(); // Cập nhật tổng tiền
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

        private void LoadCart()
        {
            flpCart.Controls.Clear(); // Xóa dữ liệu cũ
            List<DoAnDTO> cartList = FoodDAO.Instance.GetCartList(); // Lấy danh sách giỏ hàng từ CSDL
            decimal totalPrice = 0;

            foreach (var item in cartList)
            {
                Panel panel = new Panel
                {
                    Width = flpCart.Width - 5,
                    Height = 50,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                Label lblFoodName = new Label
                {
                    Text = item.TenDoAn,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(5, 5)
                };

                Label lblQuantity = new Label
                {
                    // Text = "SL: " + item.Quantity,
                    Font = new Font("Arial", 10),
                    AutoSize = true,
                    Location = new Point(5, 25)
                };

                Label lblPrice = new Label
                {
                    Text = item.Gia.ToString("N0"),
                    Font = new Font("Arial", 10),
                    AutoSize = true,
                    ForeColor = Color.Red,
                    Location = new Point(100, 5)
                };

                //totalPrice += item.ThanhTien;

                panel.Controls.Add(lblFoodName);
                panel.Controls.Add(lblQuantity);
                panel.Controls.Add(lblPrice);

                flpCart.Controls.Add(panel);
            }

            txbTongTien.Text = totalPrice.ToString("N0") ;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            int idHoaDon = HoaDonDAO.Instance.TaoHoaDon(); // Tạo hóa đơn mới và lấy ID
            if (idHoaDon == -1)
            {
                MessageBox.Show("Lỗi khi tạo hóa đơn!");
                return;
            }

            if (decimal.TryParse(txbTongTien.Text, out decimal tongTien))
            {
              
                List<string> tenMonAnList = new List<string>(); // Danh sách tên món ăn
                List<int> SoLuongMonAnList = new List<int>(); // Danh sách số lượng món ăn
                List<decimal> thanhtienmon = new List<decimal>();   
                // Lặp qua các món trong giỏ hàng và lấy tên món từ lblFoodName
                foreach (Control control in flpCart.Controls)
                {
                    if (control is Panel panel)
                    {

                        // Kiểm tra panel có chứa label hay không
                        Label lblFoodName = panel.Controls.OfType<Label>().FirstOrDefault();
                        List<decimal> lblPriviewPrice = panel.Controls
                        .OfType<Label>()
                        .Select(label => decimal.TryParse(label.Text, out decimal price) ? price : (decimal?)null)
                        .Where(price => price.HasValue)
                        .Select(price => price.Value)
                        .ToList();
                        thanhtienmon.AddRange(lblPriviewPrice);
                        Label lblQuantity = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Text.StartsWith("SL:"));
                   
                  



                        if (lblFoodName == null)
                        {
                            MessageBox.Show("Không tìm thấy Label trong Panel", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue; // Bỏ qua panel này
                        }

                        tenMonAnList.Add(lblFoodName.Text); // Lấy tên món ăn
                        if (int.TryParse(lblQuantity.Text.Substring(3), out int quantity))
                        {
                            SoLuongMonAnList.Add(quantity);
                        }
                        else
                        {
                            MessageBox.Show("Số lượng món ăn không hợp lệ: " + lblQuantity.Text);
                        }
                    }
                }

                // Cập nhật tổng tiền và tên món ăn vào cơ sở dữ liệu HoaDon
                bool success = ChiTietHoaDonDAO.Instance.UpdateTotalPrice1(idHoaDon, tongTien, tenMonAnList, SoLuongMonAnList , thanhtienmon);
                if (success)
                {
                    MessageBox.Show($"Hóa đơn {idHoaDon} đã được thêm thành công ");
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật hóa đơn!");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
            }

            LoadCart(); // Cập nhật lại giao diện

        }
        #endregion

        #region Hoàng Lễ
        //
        //--------------------RADIO của Doanh Thu-----------------------------------
        private void rbtTittleNgayDT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTittleNgayDT.Checked)
            {
                pnTKNgayDT.Enabled = true;
                pnTKNgayDT.ForeColor = SystemColors.ControlText;

                pnTKThangDT.Enabled = false;
                pnTKThangDT.ForeColor = Color.Gray;

                pnTKNamDT.Enabled = false;
                pnTKNamDT.ForeColor = Color.Gray;
            }
        }

        private void rbtTittleThangDT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTittleThangDT.Checked)
            {
                pnTKThangDT.Enabled = true;
                pnTKThangDT.ForeColor = SystemColors.ControlText;

                pnTKNgayDT.Enabled = false;
                pnTKNgayDT.ForeColor = Color.Gray;

                pnTKNamDT.Enabled = false;
                pnTKNamDT.ForeColor = Color.Gray;
            }
        }

        private void rbtTittleNamDT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTittleNamDT.Checked)
            {
                pnTKNamDT.Enabled = true;
                pnTKNamDT.ForeColor = SystemColors.ControlText;

                pnTKNgayDT.Enabled = false;
                pnTKNgayDT.ForeColor = Color.Gray;

                pnTKThangDT.Enabled = false;
                pnTKThangDT.ForeColor = Color.Gray;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            tblMain.SelectedTab = tbpComputer;
        }

        private void btnTKXuatFile_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            // Chạy ở chế độ miễn phí

            // Kiểm tra xem DataGridView có dữ liệu không
            if (dgvAllThongKe.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mở hộp thoại lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Lưu file Excel";
            saveFileDialog.FileName = "ThongKe.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Sử dụng thư viện EPPlus để tạo file Excel
                    using (ExcelPackage excel = new ExcelPackage())
                    {
                        excel.Workbook.Worksheets.Add("ThongKe");

                        // Lấy worksheet đầu tiên
                        var worksheet = excel.Workbook.Worksheets[0];
                        worksheet.Name = "ThongKe";
                        worksheet.Cells.Style.Font.Size = 12;

                        // Xuất tiêu đề cột
                        for (int i = 1; i <= dgvAllThongKe.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i].Value = dgvAllThongKe.Columns[i - 1].HeaderText;
                        }

                        // Xuất dữ liệu từ DataGridView
                        for (int i = 0; i < dgvAllThongKe.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvAllThongKe.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dgvAllThongKe.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        // Auto-fit các cột
                        worksheet.Cells.AutoFitColumns();

                        // Lưu file Excel
                        FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                        excel.SaveAs(excelFile);

                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //--------------------RADIO của Máy Trạm-----------------------------------
        //----------Setup datagridview-----------
        private void SetupDataGridView()
        {
            // Tự động thay đổi kích thước các cột theo nội dung
            dgvAllThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tự động thay đổi chiều cao các hàng
            dgvAllThongKe.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // Tắt tiêu đề của hàng (Row Headers) nếu không cần thiết
            dgvAllThongKe.RowHeadersVisible = false;

            // Nếu muốn cột có thể tự động cuộn ngang khi dữ liệu quá dài
            dgvAllThongKe.ScrollBars = ScrollBars.Both;

            // Chỉnh lại cách căn chỉnh nội dung của các cột (có thể thay đổi theo yêu cầu)
            foreach (DataGridViewColumn column in dgvAllThongKe.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa
            }
        }

        private void btnTKQLUngDung_Click_1(object sender, EventArgs e)
        {
            frmQLyUngDung frmQLyUngDung = new frmQLyUngDung();
            frmQLyUngDung.ShowDialog();

        }

        private void dtpTKStartKH_ValueChanged(object sender, EventArgs e)
        {

        }

        //----------------------THONG KE DOANHTHU------------------------//
        // Load thống kê doanh thu theo ngày
        // Load thống kê doanh thu theo ngày
        private void LoadThongKeDoanhThuTheoNgay()
        {
            DateTime ngay = dtpTKNgayDT.Value;
            DataTable dt = DAOThongKe.Instance.GetThongKeDoanhThuTheoNgay(ngay);

            // Kiểm tra nếu có dữ liệu
            if (dt.Rows.Count > 0)
            {
                dgvAllThongKe.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu cho ngày đã chọn.");
            }
        }

        // Load thống kê doanh thu theo tháng
        private void LoadThongKeDoanhThuTheoThang()
        {
            int thang = dtpTKThangDT.Value.Month;
            int nam = dtpTKThangDT.Value.Year;
            DataTable dt = DAOThongKe.Instance.GetThongKeDoanhThuTheoThang(thang, nam);

            // Kiểm tra nếu có dữ liệu
            if (dt.Rows.Count > 0)
            {
                dgvAllThongKe.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu cho tháng đã chọn.");
            }
        }

        // Load thống kê doanh thu theo năm
        private void LoadThongKeDoanhThuTheoNam()
        {
            int nam = dtpTKNamDT.Value.Year;
            DataTable dt = DAOThongKe.Instance.GetThongKeDoanhThuTheoNam(nam);

            // Kiểm tra nếu có dữ liệu
            if (dt.Rows.Count > 0)
            {
                dgvAllThongKe.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu cho năm đã chọn.");
            }
        }




        private void btnTKNgayDT_Click_1(object sender, EventArgs e)
        {
            LoadThongKeDoanhThuTheoNgay();
        }


        private void btnTKThangDT_Click_1(object sender, EventArgs e)
        {
            LoadThongKeDoanhThuTheoThang();
        }


        private void btnTKNamDT_Click_1(object sender, EventArgs e)
        {
            LoadThongKeDoanhThuTheoNam();
        }

        private void btnTKTongDoanhThuNgay_Click_1(object sender, EventArgs e)
        {
            LoadTongThongKeDoanhThuTheoNgay();
        }

        private void btnTKTongDoanhThuThang_Click_1(object sender, EventArgs e)
        {
            LoadTongThongKeDoanhThuTheoThang();
        }

        private void btnTKTongDoanhThuNam_Click_1(object sender, EventArgs e)
        {
            LoadTongThongKeDoanhThuTheoNam();
        }

        // Load tổng thống kê doanh thu theo ngày
        private void LoadTongThongKeDoanhThuTheoNgay()
        {
            // Lấy ngày từ DateTimePicker
            DateTime ngay = dtpTKNgayDT.Value;

            // Gọi DAO để lấy tổng doanh thu theo ngày
            DataTable dt = DAOThongKe.Instance.GetTongDoanhThuTheoNgay(ngay);

            // Debug: In ra số dòng trong DataTable để kiểm tra
            Console.WriteLine($"Số dòng trả về: {dt.Rows.Count}");

            // Kiểm tra nếu có dữ liệu
            if (dt.Rows.Count > 0)
            {
                // Hiển thị tổng doanh thu lên TextBox
                txtTKNgayDT.Text = dt.Rows[0]["TongDoanhThu"].ToString();
            }
            else
            {
                // Nếu không có dữ liệu, hiển thị thông báo
                MessageBox.Show("Không có dữ liệu cho ngày đã chọn.");
            }
        }

        // Load tổng thống kê doanh thu theo tháng
        private void LoadTongThongKeDoanhThuTheoThang()
        {
            // Lấy tháng và năm từ DateTimePicker
            int thang = dtpTKThangDT.Value.Month;
            int nam = dtpTKThangDT.Value.Year;

            // Gọi DAO để lấy tổng doanh thu theo tháng
            DataTable dt = DAOThongKe.Instance.GetTongDoanhThuTheoThang(thang, nam);

            // Debug: In ra số dòng trong DataTable để kiểm tra
            Console.WriteLine($"Số dòng trả về: {dt.Rows.Count}");

            // Kiểm tra nếu có dữ liệu
            if (dt.Rows.Count > 0)
            {
                // Hiển thị tổng doanh thu lên TextBox
                txtTKThangDT.Text = dt.Rows[0]["TongDoanhThu"].ToString();
            }
            else
            {
                // Nếu không có dữ liệu, hiển thị thông báo
                MessageBox.Show("Không có dữ liệu cho tháng đã chọn.");
            }
        }

        // Load tổng thống kê doanh thu theo năm
        private void LoadTongThongKeDoanhThuTheoNam()
        {
            // Lấy năm từ DateTimePicker
            int nam = dtpTKNamDT.Value.Year;

            // Gọi DAO để lấy tổng doanh thu theo năm
            DataTable dt = DAOThongKe.Instance.GetTongDoanhThuTheoNam(nam);

            // Debug: In ra số dòng trong DataTable để kiểm tra
            Console.WriteLine($"Số dòng trả về: {dt.Rows.Count}");

            // Kiểm tra nếu có dữ liệu
            if (dt.Rows.Count > 0)
            {
                // Hiển thị tổng doanh thu lên TextBox
                txtTKNamDT.Text = dt.Rows[0]["TongDoanhThu"].ToString();
            }
            else
            {
                // Nếu không có dữ liệu, hiển thị thông báo
                MessageBox.Show("Không có dữ liệu cho năm đã chọn.");
            }
        }


        // Tổng thống kê doanh thu theo ngày


        // Tổng thống kê doanh thu theo tháng


        // Tổng thống kê doanh thu theo năm



        //---------------------------------MAY TRAM-------------------------------//
        //Máy nào có số giờ sử dụng nhiều nhất/ít nhất
        private void btnTGNhieuItMT_Click(object sender, EventArgs e)
        {
            // Lấy tháng và năm từ các điều khiển (ví dụ: DateTimePicker)
            int thang = dtpThangTGNhieuItMT.Value.Month;
            int nam = dtpThangTGNhieuItMT.Value.Year;

            // Gọi phương thức từ DAOThongKe để lấy dữ liệu
            string mayTinhSuDungNhieuNhat = DAOThongKe.Instance.GetMayTinhSuDungNhieuNhat(thang, nam);
            string mayTinhSuDungItNhat = DAOThongKe.Instance.GetMayTinhSuDungItNhat(thang, nam);

            // Hiển thị kết quả lên giao diện
            if (!string.IsNullOrEmpty(mayTinhSuDungNhieuNhat))
            {
                txtTGNhieuMT.Text = mayTinhSuDungNhieuNhat;
            }
            else
            {
                txtTGNhieuMT.Text = "Không có dữ liệu";
            }

            if (!string.IsNullOrEmpty(mayTinhSuDungItNhat))
            {
                txtTGItMT.Text = mayTinhSuDungItNhat;
            }
            else
            {
                txtTGItMT.Text = "Không có dữ liệu";
            }
        }

        //Số giờ hoạt động của từng máy trong ngày/tháng
        private void LoadSoGioHoatDongMayTinh()
        {
            // Lấy tháng và năm từ các điều khiển (ví dụ: DateTimePicker)
            int thang = dtpGioTheoThangMT.Value.Month;
            int nam = dtpGioTheoThangMT.Value.Year;

            // Gọi phương thức từ DAOThongKe để lấy số giờ hoạt động của từng máy
            DataTable dt = DAOThongKe.Instance.GetSoGioHoatDongMayTinh(thang, nam);

            // Kiểm tra nếu không có dữ liệu
            if (dt.Rows.Count > 0)
            {
                // Hiển thị dữ liệu lên DataGridView
                dgvAllThongKe.DataSource = dt;
            }
            else
            {
                // Hiển thị thông báo nếu không có dữ liệu
                MessageBox.Show("Không có dữ liệu cho tháng đã chọn.");
            }
        }


        private void btnGioTheoThangMT_Click(object sender, EventArgs e)
        {
            LoadSoGioHoatDongMayTinh();
        }

        //Doanh thu theo từng máy trạm
        private void LoadDoanhThuMayTinh()
        {

            // Lấy tháng và năm từ các điều khiển (ví dụ: DateTimePicker)
            int thang = dtpDTTungMT.Value.Month;
            int nam = dtpDTTungMT.Value.Year;

            // Gọi phương thức từ DAOThongKe để lấy doanh thu theo từng máy
            DataTable dt = DAOThongKe.Instance.GetDoanhThuMayTinh(thang, nam);

            // Hiển thị dữ liệu lên DataGridView
            dgvAllThongKe.DataSource = dt;
        }

        private void btnDTTungMT_Click(object sender, EventArgs e)
        {
            LoadDoanhThuMayTinh();
        }

        //----------------------DO AN--------------------------------//
        private void LoadTongSoLuongDoAn()
        {
            DateTime startDate = dtpTKDoAnNgayBD.Value; // Lấy giá trị từ DateTimePicker bắt đầu
            DateTime endDate = dtpTKDoAnNgayKT.Value;   // Lấy giá trị từ DateTimePicker kết thúc

            // Kiểm tra nếu ngày kết thúc phải lớn hơn ngày bắt đầu
            if (endDate < startDate)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi phương thức từ DAO để lấy dữ liệu thống kê
            DataTable thongKeData = DAOThongKe.Instance.GetThongKeTongSoLuongDoAn(startDate, endDate);

            // Kiểm tra xem có dữ liệu hay không
            if (thongKeData == null || thongKeData.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu thống kê trong khoảng thời gian này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị kết quả lên DataGridView
            dgvAllThongKe.DataSource = thongKeData;
        }


        private void btnTongSLDADaBan_Click_1(object sender, EventArgs e)
        {
            LoadTongSoLuongDoAn();
        }

        //----------------------KHACH HANG----------------------------//
        private void LoadTenKhachHang()
        {
            // Gọi phương thức từ DAOThongKe để lấy danh sách tên khách hàng
            DataTable dt = DAOThongKe.Instance.GetAllTenKhachHang();

            // Kiểm tra nếu có dữ liệu
            if (dt.Rows.Count > 0)
            {
                // Lấy dữ liệu tên khách hàng và thêm vào ComboBox
                cbxTenKhachHang.DataSource = dt;
                cbxTenKhachHang.DisplayMember = "TenKhachHang";  // Tên hiển thị trong ComboBox
                cbxTenKhachHang.ValueMember = "TenKhachHang";  // Giá trị của ComboBox
            }
            else
            {
                // Nếu không có khách hàng, thông báo
                MessageBox.Show("Không có dữ liệu khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Ban đầu vô hiệu hóa cả 3 panel
            pnTKNgayDT.Enabled = false;
            pnTKThangDT.Enabled = false;
            pnTKNamDT.Enabled = false;

            // Đặt màu chữ mờ cho cả 3 panel
            pnTKNgayDT.ForeColor = Color.Gray;
            pnTKThangDT.ForeColor = Color.Gray;
            pnTKNamDT.ForeColor = Color.Gray;

            LoadTenKhachHang();
        }

        //Khách hàng thường xuyên sử dụng dịch vụ nhất
        private void LoadKhachHangThuongXuyen()
        {
            // Gọi phương thức từ DAOThongKe để lấy danh sách khách hàng sử dụng dịch vụ nhiều nhất
            DataTable dt = DAOThongKe.Instance.GetKhachHangThuongXuyen();

            // Kiểm tra nếu DataTable không rỗng
            if (dt.Rows.Count > 0)
            {
                // Hiển thị dữ liệu lên DataGridView
                dgvAllThongKe.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu.");
            }
        }


        private void btnTGDVnhieuKH_Click(object sender, EventArgs e)
        {
            LoadKhachHangThuongXuyen();
        }

        //Tổng số tiền khách hàng đã chi tiêu tại quán
        private void LoadTongTienChiTieuKhachHang()
        {
            // Lấy tên khách hàng từ ComboBox
            string tenKhachHang = cbxTenKhachHang.SelectedValue.ToString();

            // Gọi phương thức từ DAOThongKe để lấy tổng số tiền chi tiêu của khách hàng
            DataTable dt = DAOThongKe.Instance.GetTongTienChiTieuKhachHang(tenKhachHang);

            // Kiểm tra nếu có dữ liệu
            if (dt.Rows.Count > 0)
            {
                // Hiển thị dữ liệu lên DataGridView
                dgvAllThongKe.DataSource = dt;
            }
            else
            {
                // Hiển thị thông báo nếu không có dữ liệu
                MessageBox.Show("Không có dữ liệu cho khách hàng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadKhachHangTheoThoiGian()
        {
            DateTime startDate = dtpTKStartKH.Value; // Lấy giá trị từ DateTimePicker bắt đầu
            DateTime endDate = dtpTKEndKH.Value;  // Lấy giá trị từ DateTimePicker kết thúc

            // Kiểm tra nếu ngày kết thúc phải lớn hơn ngày bắt đầu
            if (endDate < startDate)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi DAO để lấy dữ liệu thống kê
            DataTable thongKeData = DAOThongKe.Instance.GetThongKeDoanhThuKhachHang(startDate, endDate);

            // Kiểm tra xem có dữ liệu không
            if (thongKeData.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu thống kê trong khoảng thời gian này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hiển thị dữ liệu lên DataGridView
                dgvAllThongKe.DataSource = thongKeData;
            }
        }

        private void btnTKXemKH_Click(object sender, EventArgs e)
        {
            LoadKhachHangTheoThoiGian();
        }


        //-------------------------------Tong ket--------------------------//
        private void btnTKTongTieuKH_Click(object sender, EventArgs e)
        {
            LoadTongTienChiTieuKhachHang();
        }

        //
        private void LoadSoLuongKhachMoi()
        {
            int thang = dtpThangKhachMoi.Value.Month;
            int nam = dtpThangKhachMoi.Value.Year;

            int soLuongKhachMoi = DAOThongKe.Instance.GetSoLuongKhachMoi(thang, nam);

            // Kiểm tra nếu không có khách mới
            if (soLuongKhachMoi == 0)
            {
                MessageBox.Show("Không có khách hàng mới trong tháng đã chọn.");
            }
            else
            {
                // Hiển thị kết quả lên TextBox
                txtKQThangKhachMoi.Text = soLuongKhachMoi.ToString();
            }
        }


        private void btnSLKhachMoi_Click(object sender, EventArgs e)
        {
            LoadSoLuongKhachMoi();
        }

        //Lấy danh sách tên khách hàng mới
        private void LoadDanhSachKhachHangMoi()
        {
            int thang = dtpThangKhachMoi.Value.Month;
            int nam = dtpThangKhachMoi.Value.Year;

            DataTable dt = DAOThongKe.Instance.GetDanhSachKhachHangMoi(thang, nam);

            if (dt.Rows.Count > 0)
            {
                dgvAllThongKe.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có khách hàng mới trong tháng/năm này.");
            }
        }

        private void btnChiTietSLKhachMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachKhachHangMoi();
        }



        private void btnTongKet_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhatThongKe_Click_1(object sender, EventArgs e)
        {

            // Khởi tạo ProgressBar
            pbHieuSuat.Minimum = 0;
            pbHieuSuat.Maximum = 100;
            pbHieuSuat.Step = 20;
            pbHieuSuat.Value = 0;

            // Bắt đầu chạy ProgressBar
            for (int i = 0; i <= 100; i += 20)
            {
                pbHieuSuat.Value = i;
                Thread.Sleep(100); // Giả lập quá trình load dữ liệu
            }

            // Lấy dữ liệu từ các stored procedures và cập nhật vào các TextBox
            try
            {
                // Lấy Tổng doanh thu
                string queryDoanhThu = "EXEC sp_TongDoanhThu";
                DataTable dtDoanhThu = DataProvider.Instance.ExcuteQuery(queryDoanhThu);
                if (dtDoanhThu.Rows.Count > 0)
                {
                    txtTongDoanhThu.Text = dtDoanhThu.Rows[0]["TongDoanhThu"].ToString();
                }

                // Lấy Tổng giờ sử dụng máy
                string queryGioSuDung = "EXEC sp_TongGioSuDungMay";
                DataTable dtGioSuDung = DataProvider.Instance.ExcuteQuery(queryGioSuDung);
                if (dtGioSuDung.Rows.Count > 0)
                {
                    txtTongGioSuDung.Text = dtGioSuDung.Rows[0]["TongGioSuDungMay"].ToString();
                }

                // Lấy Tổng tiền đồ ăn
                string queryTienDoAn = "EXEC sp_TongTienDoAn";
                DataTable dtTienDoAn = DataProvider.Instance.ExcuteQuery(queryTienDoAn);
                if (dtTienDoAn.Rows.Count > 0)
                {
                    txtTongDichVu.Text = dtTienDoAn.Rows[0]["TongTienDoAn"].ToString();
                }

                // Lấy Tổng tiền máy
                string queryTienMay = "EXEC sp_TongTienMay";
                DataTable dtTienMay = DataProvider.Instance.ExcuteQuery(queryTienMay);
                if (dtTienMay.Rows.Count > 0)
                {
                    txtTKTongTienMay.Text = dtTienMay.Rows[0]["TongTienMay"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



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
            MayTinhView computer = flpComputer.Tag as MayTinhView;
            if (computer != null)
            {
                frmNapTien f = new frmNapTien(computer);
                f.ShowDialog();
                LoadComputerBindingByComputer(computer);
                LoadComputerList();
            }
            else
            {
                frmNapTien f = new frmNapTien();
                f.ShowDialog();

                LoadComputerBindingByComputer(computer);
                LoadComputerList();
            }


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

            if (com == null)
            {
                MessageBox.Show("Vui lòng chọn máy!");
                return;
            }

            if (com.TrangThai == "Trống")
            {
                MessageBox.Show("Máy hiện chưa mở!");
                return;
            }

            string tenMay = com.TenMay;
            int idPhien = com.IDPhien ?? -1;
            DateTime timeKetThuc = DateTime.Now;
            double tongTienDoAn = Double.Parse(tbxMoneyCost.Text.Split(' ')[0].Replace(".", ""));
            double tongTienNap = (double)CyberManager.GetTongTienNap(idPhien); // Đồng bộ với CyberManager

            if (MessageBox.Show($"Bạn có thực sự muốn tắt máy {tenMay}?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                CyberManager.KetThucPhien(idPhien, timeKetThuc, (float)tongTienNap, (float)tongTienDoAn);
                MessageBox.Show($"Đã tắt máy {tenMay}");

                // Cập nhật giao diện
                LoadComputerBindingByComputer(com);
                LoadComputerList();

                tbxMoneyAdd.Text = "0 VNĐ"; // Reset tiền nạp về 0
            }
        }
        private void btnAddServices_Click(object sender, EventArgs e)
        {
            MayTinhView com = flpComputer.Tag as MayTinhView;
            if (com != null)
            {
                if (com.TrangThai == "Trống")
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
            CyberManager.KhoiPhucPhienDangChay();

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

            gbxComputerInfor.DataBindings.Clear();
            tbxUserAccount.DataBindings.Clear();
            tbxComputerStatus.DataBindings.Clear();
            tbxTimeLeft.DataBindings.Clear();
            tbxMoneyAdd.Clear();

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

                // Lấy ID phiên của khách hàng trong máy tính hiện tại
                int idPhien = (int)data.IDPhien;
                tbxMoneyAdd.Text = idPhien > 0
                    ? $"{CyberManager.GetTongTienNap(idPhien):N0} đ"
                    : "0 đ";
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


