using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanNet.KhachHang
{
    public partial class frmKhachHang_Main : Form
    {
        public frmKhachHang_Main()
        {
            InitializeComponent();
        }

        private void btnLoc_MouseHover(object sender, EventArgs e)
        {
            flpLoc.Visible = true;
            flpLoc.BringToFront();
        }

        //private void btnLoc_MouseLeave(object sender, EventArgs e)
        //{
        //    // Chỉ ẩn panel khi chuột không còn ở trong button và panel
        //    if (!flpLoc.ClientRectangle.Contains(flpLoc.PointToClient(MousePosition)) &&
        //        !btnLoc.ClientRectangle.Contains(btnLoc.PointToClient(MousePosition)))
        //    {
        //        flpLoc.Visible = false;
        //    }
        //}

        private void flpLoc_MouseLeave(object sender, EventArgs e)
        {
            // Kiểm tra nếu chuột không ở trong button và panel, thì ẩn panel
            if (!flpLoc.ClientRectangle.Contains(flpLoc.PointToClient(MousePosition)))
            {
                flpLoc.Visible = false;
            }
        }

        private void flpLoc_MouseHover(object sender, EventArgs e)
        {
            flpLoc.Visible = true; // Giữ panel hiện khi chuột hover vào panel
        }

        int page = 0;
        private void btnLuiTrang_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page -= 1;
                txtTrang.Text = page.ToString() + "/5";
            }
            else
            {

            }
        }

        private void btnNextTrang_Click(object sender, EventArgs e)
        {
            if (page < 5)
            {
                page += 1;
                txtTrang.Text = page.ToString() + "/5";
            }
            else
            {

            }
        }

        private void txtTrang_TextChanged(object sender, EventArgs e)
        {
            txtTrang.Text = page.ToString() + "/5";
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang_Add f = new frmKhachHang_Add();
            f.ShowDialog();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            //frmMain f = new frmMain();
            this.Close();
            //f.show();
        }
    }
}
