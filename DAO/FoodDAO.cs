using CyberManagementProject.DTO;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;



namespace CyberManagementProject.DAO
{
    public class FoodDAO
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



        //-----------------------------------------
        // ✅ Lấy danh sách món ăn từ CSDL
        public List<DoAnDTO> GetFoodList()
        {
            List<DoAnDTO> foodList = new List<DoAnDTO>();

            string query = "SELECT IDDoAn, TenDoAn, Gia, IDLoai, HinhAnh FROM DoAn";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                DoAnDTO food = new DoAnDTO(
                    Convert.ToInt32(row["IDDoAn"]),
                    row["TenDoAn"].ToString(),
                    Convert.ToDecimal(row["Gia"]),
                    Convert.ToInt32(row["IDLoai"]),
                    row["HinhAnh"].ToString()
                );
                foodList.Add(food);
            }

            return foodList;
        }

        //Sửa món ăn
        public bool UpdateFood(DoAnDTO food)
        {
            string query = "UPDATE DoAn SET TenDoAn = @tenDoAn , Gia = @gia , IDLoai = @idLoai , HinhAnh = @hinhAnh WHERE IDDoAn = @idDoAn ";

            try
            {
                if (food == null)
                {
                    throw new ArgumentNullException(nameof(food), "Thông tin món ăn không được để trống.");
                }

                object[] parameters = new object[]
                {
                 food.TenDoAn,
                 food.Gia,
                 food.IDLoai,
                 food.HinhAnh,
                 food.IDDoAn
                  };


                int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);
                return result > 0; // Trả về true nếu cập nhật thành công
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật đồ ăn: " + ex.Message);
            }
        }


        //lấy dữ liệu từ bảng LoaiDoAn
        public DataTable GetCategories()
        {
            string query = "SELECT IDLoai, TenLoai FROM LoaiDoAn";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        //Chức năng tìm kiếm món ăn
        public List<DoAnDTO> SearchFood(string name, int categoryID)
        {
            string query = "SELECT * FROM DoAn WHERE TenDoAn LIKE @name";
            List<object> parameters = new List<object> { "%" + name + "%" };

            if (categoryID != -1)
            {
                query += " AND IDLoai = @categoryID";
                parameters.Add(categoryID);
            }

            DataTable data = DataProvider.Instance.ExcuteQuery(query, parameters.ToArray());
            return data.AsEnumerable().Select(row => new DoAnDTO(
                row.Field<int>("IDDoAn"),
                row.Field<string>("TenDoAn"),
                row.Field<decimal>("Gia"),
                row.Field<int>("IDLoai"),
                row.Field<string>("HinhAnh")
            )).ToList();
        }

        public List<DoAnDTO> GetListFoodByCategoryId(int id)
        {
            List<DoAnDTO> listFood = new List<DoAnDTO>();

            string query = "SELECT * FROM DoAn WHERE IDLoai=" + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DoAnDTO food = new DoAnDTO(row);
                listFood.Add(food);
            }
            return listFood;
        }

    }
}