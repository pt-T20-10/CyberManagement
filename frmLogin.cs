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
            //frmMain _frmMain = new frmMain();
            //this.Hide();
            //_frmMain.ShowDialog();
            //this.Show();
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
  

