using CyberManagementProject.DAO;
using QuanLyQuanNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CyberManagementProject
{
    public partial class fViewFood : Form
    {
        private object provider;

        public fViewFood()
        {
            InitializeComponent();
            LoadFoodList(); // Gọi hàm LoadFoodList() khi form được khởi tạo
        }

        public void LoadFoodList()
        {
            string query = "SELECT * FROM DoAn";

            dtgvFood.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }


        private void btnAddFood_Click(object sender, EventArgs e)
        {
            fAddFood f = new fAddFood();
            f.ShowDialog();
        }
    }

}
