using CyberManagementProject.DAO;
using CyberManagementProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
