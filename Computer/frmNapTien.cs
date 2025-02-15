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
    public partial class frmNapTien : Form
    {
        private MayTinhView account;
        public MayTinhView Account { get => account; set => account = value; }

        public frmNapTien(MayTinhView? account)
        {
            InitializeComponent();
            if (account != null)
            {
                this.account = account;

            }
            Load(account);
        }
        public frmNapTien() : this(null) { }

        void Load(MayTinhView? account)
        {
            List<TKKhachHang> listAccount = TKKhachHangDAO.Instance.GetListCategory();
            cbxAddMoneyUserName.DataSource = listAccount;
            cbxAddMoneyUserName.DisplayMember = "TKKhachHang"; // Hiển thị tên khách hàng trên ComboBox
            cbxAddMoneyUserName.ValueMember = "UserName"; // Giá trị thực tế là UserName
            if (account?.ThoiGianConLai.HasValue == true)
            {
                TimeSpan timeLeft = TimeSpan.FromMinutes(account.ThoiGianConLai.Value);
                tbxTimeLeft.Text = timeLeft.ToString(@"hh\:mm\:ss");
            }
            else
            {
                tbxTimeLeft.Text = "00:00:00"; // Hiển thị mặc định nếu không có giá trị
            }
            // Nếu account có giá trị thì SelectedValue = UserName, nếu không thì không chọn gì
            cbxAddMoneyUserName.SelectedValue = account != null ? account.TKKhachHang : DBNull.Value;
        }

        private void btnAcceptAddMoney_Click(object sender, EventArgs e)
        {
            string userName = cbxAddMoneyUserName.SelectedValue.ToString();
        
            double tienNap = Convert.ToDouble(nrupNapTienSoTien.Value);
            if (!MayTinhDAO.Instance.isKhachHangNotAvailable(userName))
            {
                if (TKKhachHangDAO.Instance.NapTien((float)tienNap, userName))
                {
                    MessageBox.Show(string.Format("Nạp tiền cho {0} thành công", userName));
                }
                else
                    MessageBox.Show("Có lỗi xảy ra khi nạp tiền");
            }
        }
    }
}
