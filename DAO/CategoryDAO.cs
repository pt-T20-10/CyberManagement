using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }

        private CategoryDAO() { }

        // Kiểm tra loại có thức ăn hay không
        public bool HasFoodInCategory(int idLoai)
        {
            string query = "SELECT COUNT(*) FROM ThucAn WHERE ID_Loai = @idLoai";
            int count = (int)DataProvider.Instance.ExcuteScalar(query, new object[] { idLoai });
            return count > 0;
        }

        // Xóa loại thức ăn nếu không có thức ăn trong loại
        public bool DeleteCategory(int idLoai)
        {
            if (HasFoodInCategory(idLoai))
            {
                return false; 
            }

            string query = "DELETE FROM LoaiThucAn WHERE ID = @idLoai";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idLoai });
            return result > 0;
        }

        // Chuyển thức ăn sang loại khác
        public bool TransferFoodToCategory(int oldCategoryID, int newCategoryID)
        {
            string query = "UPDATE ThucAn SET ID_Loai = @newCategory WHERE ID_Loai = @oldCategory";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { newCategoryID, oldCategoryID });
            return result > 0;
        }
    }

}
