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

namespace CyberManagementProject
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();

            LoadKhachHang(); //Hoang Nghia

            LoadNhanVien();
        }

        #region Hoàng Nghĩa
        
        #region Method

        //Load thong tin cua Khach Hang
        public void LoadKhachHang()
        {
            // Xóa tất cả các button hiện tại trong flpKhachHangtrước khi thêm mới
            flpKhachHang.Controls.Clear();

            List<KhachHangDTO> khachHangList = KhachHangDAO.Instance.LoadKhachHangList();

            foreach (KhachHangDTO item in khachHangList) 
            {
                Button btn = new Button() { Width = KhachHangDAO.KhachHangWidth, Height = KhachHangDAO.KhachHangHeight};

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


        ////button them moi nhan vien
        //private void BtnNhanVien_Click(object sender, EventArgs e)
        //{
        //    Button btn = sender as Button;
        //    string tkNhanVien = btn.Text;

        //    NhanVienDTO nhanVien = NhanVienDAO.Instance.GetNhanVienDetailsByUser(tkNhanVien);

        //    if (nhanVien != null)
        //    {
        //        frmThongTinNhanVien frm = new frmThongTinNhanVien(nhanVien);
        //        frm.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không tìm thấy thông tin nhân viên!");
        //    }
        //}


        #endregion

        #endregion

        #region Trung Nghĩa
        //
        #endregion
        private void label29_Click(object sender, EventArgs e)
        {

        }

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

        #endregion
        #region Method
        #endregion
        #endregion
    }

}