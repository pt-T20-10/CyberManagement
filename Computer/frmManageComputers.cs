using CyberManagementProject.DAO;
using CyberManagementProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberManagementProject.Computer
{
    public partial class frmManageComputers : Form
    {
        private MayTinh mayTinh;
        public MayTinh MayTinh { get => mayTinh; set => mayTinh = value; }
        public frmManageComputers(MayTinh? com)
        {
            InitializeComponent();
            if (com != null)
            {
                this.mayTinh = com;
            }
            LoadInfoComputer(com);


        }
        public frmManageComputers() : this(null) { }

        void LoadInfoComputer(MayTinh? com)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            tbxIDComputer.Text = com != null ? com.IDMayTinh.ToString() : string.Empty;
            tbxNameComputer.Text = com != null ? com.TenMay.ToString() : string.Empty;
            tbxPriceComputer.Text = com != null ? com.BangGia.ToString("c", culture) : string.Empty;
            tbxNoteComputer.Text = com != null ? com.GhiChuMay.ToString() : string.Empty;
            btnDeleteComputer.Enabled = com != null ? true : false;
            btnUpdateComputer.Enabled = com != null ? true : false;
        }
        private void btnDeleteComputer_Click(object sender, EventArgs e)
        {
            if (MayTinhDAO.Instance.isInUseComputer())
            {
                MessageBox.Show("Còn máy đang hoạt động không thể thực hiện xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int iDMay = int.Parse(tbxIDComputer.Text);
                if (MayTinhDAO.Instance.DeleteComputer(iDMay))
                {
                    MessageBox.Show("Xóa máy thành công");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }    
                

        }

        private void btnAddComputer_Click(object sender, EventArgs e)
        {
            
            string tenMay = tbxNameComputer.Text;
            double totalPrice = string.IsNullOrWhiteSpace(tbxPriceComputer.Text)
                    ? 0
                    : Convert.ToDouble(tbxPriceComputer.Text);

            string note = tbxNoteComputer.Text;
            if (MayTinhDAO.Instance.ísTenMayTonTai(tenMay))
            {
                MessageBox.Show("Tên máy đã tồn tại vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
             if (MayTinhDAO.Instance.InsertComputer(tenMay, (float)totalPrice, note))
                 {
                    MessageBox.Show("Thêm máy thành công");
                    LoadInfoComputer(mayTinh);

                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

           
        }

        private void btnUpdateComputer_Click(object sender, EventArgs e)
        {
            int iDMay = int.Parse(tbxIDComputer.Text);
            string tenMay = tbxNameComputer.Text;
            double totalPrice = Convert.ToDouble(tbxPriceComputer.Text.Split(' ')[0].Replace(".", ""));
            string note = tbxNoteComputer.Text;
            if (MayTinhDAO.Instance.UpdateComputer(iDMay, tenMay , (float)totalPrice , note))
            {
                MessageBox.Show("Cập nhật máy thành công");
                LoadInfoComputer(mayTinh);

            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnCancelfrm_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện đóng form và truyền tham số hủy mặc định
            this.Close();
        }

        private void frmManageComputers_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu sự kiện được gọi từ việc nhấn nút đóng (X) hoặc từ btnCancelfrm
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn thoát không?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Nếu người dùng chọn "No", hủy việc đóng form
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
    


