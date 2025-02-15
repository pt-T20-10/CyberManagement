using CyberManagementProject.DAO;
using CyberManagementProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;

namespace CyberManagementProject.DAO
{
    public class TKKhachHangDAO
    {
        private static TKKhachHangDAO instance;

        public static TKKhachHangDAO Instance
        {
            get { if (instance == null) instance = new TKKhachHangDAO(); return TKKhachHangDAO.instance; }
            private set { TKKhachHangDAO.instance = value; }
        }
       private TKKhachHangDAO() { }


        public List<TKKhachHang> GetListCategory()
        {
            List<TKKhachHang> listAccount = new List<TKKhachHang>();

            string query = "SELECT * FROM TKKhachHang";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                TKKhachHang account = new TKKhachHang(row);
                listAccount.Add(account);
            }
            return listAccount;
        }
        public bool NapTien(float tiennap , string userName)
        {
            string query = string.Format("EXEC USP_NapTien @TienNap  , @tkKhachHang  ");
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {tiennap, userName});
            return result > 0;

            
        }

        //đổi mật khẩu khách hàng

        // Hàm băm mật khẩu
        private byte[] HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public bool AddTaiKhoanKhachHang(string tkKhachHang, string mkKhachHang)
        {
            // Băm mật khẩu trước khi lưu vào SQL
            byte[] hashedPassword = HashPassword(mkKhachHang);

            string query = "EXEC USP_ThemTKKhachHang @TKKhachHang , @MKKhachHang ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { tkKhachHang, hashedPassword });

            return result > 0;
        }
        public bool DoiMatKhauKhachHang(string tkKhachHang, string matKhauMoi)
        {
            try
            {
                // Băm mật khẩu mới trước khi lưu vào database
                byte[] hashedPassword = HashPassword(matKhauMoi);

                // Gọi Stored Procedure để đổi mật khẩu
                string query = "EXEC USP_DoiMatKhauKhachHang @TKKhachHang , @MKMoi ";

                int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { tkKhachHang, hashedPassword });

                return result > 0; // Nếu có hơn 0 dòng bị ảnh hưởng thì thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
