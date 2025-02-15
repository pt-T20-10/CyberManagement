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

            // Nếu account có giá trị thì SelectedValue = UserName, nếu không thì không chọn gì
            cbxAddMoneyUserName.SelectedValue = account != null ? account.TKKhachHang : DBNull.Value;
        }

        private void btnAcceptAddMoney_Click(object sender, EventArgs e)
        {
            string userName = cbxAddMoneyUserName.ValueMember;
        }
    }
}
