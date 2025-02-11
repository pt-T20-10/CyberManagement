using CyberManagementProject.DTO;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;


namespace CyberManagementProject.DAO
{
    internal class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }

        private FoodDAO() { }

        public bool InSertFood(DoAnDTO food)
        {
            string query = "INSERT INTO DoAn (TenDoAn, Gia, IDLoai, HinhAnh) VALUES ( @tenDoAn , @gia , @idLoai , @hinhAnh )";
            try
            {
                // Sử dụng đối tượng DTO để truyền tham số
                object[] parameters = new object[]
                {
            food.TenDoAn,
            food.Gia,
            food.IDLoai,
            food.HinhAnh
                };

                int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm đồ ăn: " + ex.Message);
            }
        }


    }
}


