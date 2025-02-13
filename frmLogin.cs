using CyberManagementProject.DAO;

namespace CyberManagementProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tkNhanVien = txbUserName.Text;
            string matKhau = txbPassWord.Text;

            if (string.IsNullOrEmpty(tkNhanVien) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TKNhanVienDAO.Instance.Login(tkNhanVien, matKhau))
            {
                this.Hide();
                frmMain mainForm = new frmMain();
                mainForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            // Hiển thị MessageBox hỏi người dùng có muốn thoát hay không
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu người dùng chọn "No", hủy việc đóng form
            if (result == DialogResult.No || result == DialogResult.Cancel || result == DialogResult.None)
            {
                e.Cancel = true; // Hủy sự kiện đóng form
            }
        }

      
    }
}
  

