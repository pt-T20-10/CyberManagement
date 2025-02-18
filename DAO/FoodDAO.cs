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

        // Thêm món ăn vào giỏ hàng  
        public bool AddToCart(int foodID, int quantity)
        {
            string checkQuery = "SELECT Quantity FROM Cart WHERE FoodID = @foodID";
            object existingQuantity = DataProvider.Instance.ExcuteScalar(checkQuery, new object[] { foodID });

            if (existingQuantity != null)
            {
                // Nếu món ăn đã có trong giỏ hàng, cập nhật số lượng
                int newQuantity = Convert.ToInt32(existingQuantity) + quantity;
                return UpdateCart(foodID, newQuantity);
            }
            else
            {
                // Nếu chưa có, thêm mới vào giỏ hàng
                string insertQuery = "INSERT INTO Cart (FoodID, Quantity) VALUES (@foodID, @quantity)";
                int result = DataProvider.Instance.ExcuteNonQuery(insertQuery, new object[] { foodID, quantity });
                return result > 0;
            }
        }

        //Xóa món ăn
        public bool DeleteFood(int id)
        {
            string query = $"DELETE FROM DoAn WHERE IDDoAn = {id}";
            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }



        //-----------------------------------------  
        //  Cập nhật số lượng món ăn trong giỏ hàng  
        public bool UpdateCart(int foodID, int quantity)
        {
            string query = "UPDATE Cart SET Quantity = @quantity WHERE FoodID = @foodID";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { quantity, foodID });
            return result > 0;
        }


        //-----------------------------------------  
        // ✅ Xóa món ăn khỏi giỏ hàng  
        public bool RemoveFromCart(int cartID)
        {
            string query = "DELETE FROM Cart WHERE IDCart = @cartID";
            try
            {
                int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { cartID });
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa món ăn khỏi giỏ hàng: " + ex.Message);
            }
        }

        //-----------------------------------------  
        // ✅ Lấy danh sách món ăn trong giỏ hàng  
        public List<DoAnDTO> GetCartList()
        {
            List<DoAnDTO> cartList = new List<DoAnDTO>();

            string query = @"
                SELECT d.IDDoAn, d.TenDoAn, d.Gia, d.IDLoai, d.HinhAnh, c.Quantity 
                FROM Cart c 
                INNER JOIN DoAn d ON c.FoodID = d.IDDoAn";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                DoAnDTO food = new DoAnDTO(
                    Convert.ToInt32(row["IDDoAn"]),
                    row["TenDoAn"].ToString(),
                    Convert.ToDecimal(row["Gia"]),
                    Convert.ToInt32(row["IDLoai"]),
                    row["HinhAnh"].ToString(),
                    Convert.ToInt32(row["Quantity"])  // Số lượng từ giỏ hàng
                );
                cartList.Add(food);
            }
            return cartList;
        }

        //-----------------------------------------  
        // ✅ Tính tổng tiền giỏ hàng  
        public decimal GetTotalPrice()
        {
            string query = @"
        SELECT SUM(d.Gia * c.Quantity) AS TotalPrice
        FROM Cart c 
        INNER JOIN DoAn d ON c.FoodID = d.IDDoAn";

            object result = DataProvider.Instance.ExcuteScalar(query);
            return (result != DBNull.Value && result != null) ? Convert.ToDecimal(result) : 0;
        }


        public DoAnDTO GetFoodByID(int foodID)
        {
            string query = "SELECT IDDoAn, TenDoAn, Gia, IDLoai, HinhAnh FROM DoAn WHERE IDDoAn = @foodID";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { foodID });

            if (data.Rows.Count > 0)
            {
                return new DoAnDTO(
                    Convert.ToInt32(data.Rows[0]["IDDoAn"]),
                    data.Rows[0]["TenDoAn"].ToString(),
                    Convert.ToDecimal(data.Rows[0]["Gia"]),
                    Convert.ToInt32(data.Rows[0]["IDLoai"]),
                    data.Rows[0]["HinhAnh"].ToString()
                );
            }

            return null;
        }

        public class HoaDonDAO
        {
            private static HoaDonDAO instance;

            public static HoaDonDAO Instance
            {
                get { if (instance == null) instance = new HoaDonDAO(); return instance; }
                private set { instance = value; }
            }

            private HoaDonDAO() { }

            // Thêm hóa đơn mới và lấy ID của hóa đơn vừa tạo
            public int TaoHoaDon()
            {
                string query = "INSERT INTO HoaDon (TongTien) OUTPUT INSERTED.IDHoaDon VALUES (0)";
                object result = DataProvider.Instance.ExcuteScalar(query);
                return (result != null) ? Convert.ToInt32(result) : -1;
            }

            // Cập nhật tổng tiền cho hóa đơn
            public void CapNhatTongTien(int idHoaDon)
            {
                string query = @"
                UPDATE HoaDon 
                SET TongTien = (SELECT SUM(ThanhTien) FROM ChiTietHoaDon WHERE IDHoaDon = @IDHoaDon )
                WHERE IDHoaDon = @IDHoaDon ";

                DataProvider.Instance.ExcuteNonQuery(query, new object[] { idHoaDon });
            }
            public bool UpdateTotalPrice(int idHoaDon, decimal tongTien)
            {
                string query = "UPDATE HoaDon SET TongTien = @TongTien WHERE IDHoaDon = @IDHoaDon ";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tongTien, idHoaDon });
                return result > 0;
            }

        }



        //ChiTietHoaDonDAO do ChiTietHoaDon liên kết nhiều quá nên t không xóa được huhu :((
        public class ChiTietHoaDonDAO
        {
            private static ChiTietHoaDonDAO instance;

            public static ChiTietHoaDonDAO Instance
            {
                get { if (instance == null) instance = new ChiTietHoaDonDAO(); return instance; }
                private set { instance = value; }
            }

            private ChiTietHoaDonDAO() { }

            // Lưu giỏ hàng vào bảng ChiTietHoaDon
            public void LuuGioHangVaoChiTietHoaDon(int idHoaDon)
            {
                string query = @"
                INSERT INTO ChiTietHoaDon (IDHoaDon, IDDoAn, SoLuong, ThanhTien)
                SELECT @IDHoaDon , IDDoAn, SoLuong, ThanhTien FROM GioHang ";

                DataProvider.Instance.ExcuteNonQuery(query, new object[] { idHoaDon });
            }

            public bool SaveCartToChiTietHoaDon(int idHoaDon)
            {
                string query = @"
                INSERT INTO ChiTietHoaDon (IDHoaDon)
                SELECT IDHoaDon
                FROM HoaDon 
                WHERE IDHoaDon = @IDHoaDon ";

                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idHoaDon });
                return result > 0;
            }
            
            public bool UpdateTotalPrice1(int idHoaDon, decimal tongTien, List<string> tenMonAnList, List<int> SoLuongMonAnList)
            {

                try
                {
                    string query = "UPDATE HoaDon SET TongTien = @TongTien WHERE IDHoaDon = @IDHoaDon ";
                    int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tongTien, idHoaDon });

                    // Kiểm tra nếu update thành công
                    if (result <= 0)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn với IDHoaDon = " + idHoaDon);
                        MessageBox.Show("Không tìm thấy hóa đơn với TongTien = " + tongTien);
                    }

                    List<string> updatedTenMonAnList = new List<string>();
                    List<int> updatedSoLuongMonAnList = new List<int>();

                    for (int i = 0; i < tenMonAnList.Count; i++)
                    {
                        string tenMonAn = tenMonAnList[i];
                        int soLuong = SoLuongMonAnList[i]; // Lấy số lượng món ăn tương ứng

                        // Thêm món ăn và số lượng vào bảng HoaDonChiTiet (nếu có)
                        string query1 = "INSERT INTO ChiTietHoaDon (TenDoAn, SoLuong) VALUES ( @TenDoAn , @SoLuong )";
                        int result1 = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { tenMonAn, soLuong });

                        // Kiểm tra nếu insert thành công
                        if (result1 <= 0)
                        {
                            MessageBox.Show("Không thể thêm món ăn vào hóa đơn.");
                            return false; // Trả về false nếu không insert được
                        }

                        updatedTenMonAnList.Add(tenMonAn);
                        updatedSoLuongMonAnList.Add(soLuong); // Lưu số lượng vào danh sách đã cập nhật
                    }

                    // Cập nhật lại thông tin của hóa đơn sau khi thêm tất cả các món ăn

                    //foreach (string tenMonAn in updatedTenMonAnList)
                    //{
                    //    string detailQuery = "UPDATE HoaDon SET TenMonAn = @TenMonAn WHERE IDHoaDon = @IDHoaDon ";
                    //    int result2 = DataProvider.Instance.ExecuteNonQuery(detailQuery, new object[] { tenMonAn, idHoaDon });

                    //    // Kiểm tra nếu update thành công
                    //    if (result2 <= 0)
                    //    {
                    //        MessageBox.Show("Không tìm thấy hóa đơn với TenMonAn = " + tenMonAn);
                    //        return false; // Trả về false nếu không cập nhật được tên món ăn
                    //    }
                    //}
                    //string query3 = "DELETE FROM HoaDon WHERE IDHoaDon = @IDHoaDon ";
                    //int result3 = DataProvider.Instance.ExecuteNonQuery(query3, new object[] { idHoaDon + tenMonAnList.Count });
                    return true;


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi khi cập nhật hóa đơn: " + ex.Message);
                    return false;
                }

            }
        }


        //GioHangDAO
        public class GioHangDAO
        {
            private static GioHangDAO instance;

            public static GioHangDAO Instance
            {
                get { if (instance == null) instance = new GioHangDAO(); return instance; }
                private set { instance = value; }
            }

            private GioHangDAO() { }

            // Xóa giỏ hàng sau khi thanh toán
            public void XoaGioHang()
            {
                string query = "DELETE FROM GioHang";
                DataProvider.Instance.ExcuteNonQuery(query);
            }

        }


    }

 }