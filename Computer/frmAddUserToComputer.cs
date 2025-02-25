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

namespace CyberManagementProject.Computer
{
    public partial class frmAddUserToComputer : Form
    {
        private MayTinhView mayTinh;
        public MayTinhView MayTinh { get => mayTinh; set => mayTinh = value; }
        public frmAddUserToComputer(MayTinhView Com)
        {

            InitializeComponent();
            this.MayTinh = Com;
            Load();

        }
        void Load()
        {
            gbxComputerManager.Text = MayTinh.TenMay;
            cbxAccountUser.DataSource = MayTinhDAO.Instance.LoadListKhachHang();
            cbxAccountUser.ValueMember = "TkKhachHang";
            cbxAccountUser.DisplayMember = "TKKhachHang";
        }

        private void btnMoMay_Click(object sender, EventArgs e)
        {
            string UserName = cbxAccountUser.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("Vui lòng chọn tài khoản.");
                return;
            }

            int idMay = MayTinh.IDMayTinh;
            var userDetails = TKKhachHangDAO.Instance.TKKhachHangDetailsByUserName(UserName);

            if (userDetails == null)
            {
                MessageBox.Show("Tài khoản không tồn tại.");
                return;
            }

            if (MayTinhDAO.Instance.isKhachHangNotAvailable(UserName))
            {
                MessageBox.Show("Tài khoản đã được đăng nhập.");
                return;
            }

            if (userDetails.TienConLai > 0)
            {
                MessageBox.Show("Thêm người dùng vào máy thành công.");
                MayTinhDAO.Instance.InsertUser_Phien(idMay, UserName);
            }
            else
            {
                MessageBox.Show(string.Format("Tài khoản {0} không còn đủ tiền.", UserName));
            }
        }

    }

}
    

