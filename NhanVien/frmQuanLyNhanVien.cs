using CyberManagementProject;
using QuanLyQuanNet.KhachHang;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace QuanLyQuanNet
{
    public partial class frmQuanLyNhanVien : Form
    {
        private ToolTip toolTip;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();

            toolTip = new ToolTip();

            //pbxAddNhanVien.MouseHover += new EventHandler(pbxAddNhanVien_MouseHover);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StartSearch();
        }
        private void StartSearch()
        {
            MessageBox.Show("Dang tim kiem.....");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            frmThemNhanVien f = new frmThemNhanVien();
            //this.Hide();
            f.ShowDialog();
            //this.Show();
        }

        private void frmQuanLyNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Ban co chac chan muon thoat chuong trinh khong?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.OK)
            //{
            //    e.Cancel = false;
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void pbxAddNhanVien_MouseHover(object sender, EventArgs e)
        {
            // Thiết lập nội dung ToolTip
            //toolTip.SetToolTip(pbxAddNhanVien, "Thêm nhân viên mới");
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmThemNhanVien Add = new frmThemNhanVien();
            Add.ShowDialog();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Close();
            f.Show();
        }

        private void btnXuatFile_MouseHover(object sender, EventArgs e)
        {
            // Hiển thị Panel gần Button
            //pnXuatFile.Visible = true;
            ////pnXuatFile.BringToFront();
            //lblExcel.Visible = true;
            //lblPDF.Visible = true;
        }

        private void pnXuatFile_MouseLeave(object sender, EventArgs e)
        {
            // Ẩn Panel khi chuột rời khỏi Panel
            //pnXuatFile.Visible = false;
        }

        private void btnXuatFile_MouseLeave(object sender, EventArgs e)
        {
            //// Ẩn Panel khi chuột rời khỏi Button
            //if (!pnXuatFile.Bounds.Contains(Cursor.Position))
            //{
            //   pnXuatFile.Visible = false;
            //}
            //else
            //{
            //    pnXuatFile.Visible = true;
            //}
        }

        private void lblExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Excel");
        }

        private void lblPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PDF");
        }

        int page = 0;
        private void btnNextTrang_Click(object sender, EventArgs e)
        {
            if(page < 5)
            {
                page += 1;
                txtTrang.Text = page.ToString() + "/5";
            }
            else
            {

            }

        }

        private void btnLuiTrang_Click(object sender, EventArgs e)
        {
            if(page > 1)
            {
                page -= 1;
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
    }
}
