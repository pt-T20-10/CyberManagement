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
    public partial class frmNhanVienDetail : Form
    {
        public frmNhanVienDetail()
        {
            InitializeComponent();
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            // btnSuaNhanVien.Text = "Đồng ý";
            // btnXoaNhanVien.Text = "Huỷ";
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban co muon xoa Nhan vien nay?");
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien f = new frmQuanLyNhanVien();
            this.Close();
            f.ShowDialog();
        }
    }
}
