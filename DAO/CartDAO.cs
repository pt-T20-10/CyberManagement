using CyberManagementProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DAO
{
    public class CartDAO
    {
        private static CartDAO instance;

        public static CartDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CartDAO();
                return instance;
            }
        }

        private CartDAO() { }

        // Lấy danh sách giỏ hàng
        public List<CartDTO> GetCart()
        {
            List<CartDTO> list = new List<CartDTO>();
            string query = "SELECT IDCart, IDDoAn AS FoodID, SoLuong AS Quantity, ThanhTien AS TotalPrice FROM Cart";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                CartDTO cartItem = new CartDTO(
                    Convert.ToInt32(row["IDCart"]),
                    Convert.ToInt32(row["FoodID"]),
                    Convert.ToInt32(row["Quantity"]),
                    Convert.ToDecimal(row["TotalPrice"]),
                    Convert.ToInt32(row["IDHoaDon"])
                );
                list.Add(cartItem);
            }
            return list;
        }



        // Thêm món vào giỏ
        public bool AddToCart(int foodID, int quantity)
        {
            string query = "INSERT INTO Cart (FoodID, Quantity) VALUES (@foodID, @quantity)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { foodID, quantity });
            return result > 0;
        }

        // Cập nhật số lượng món trong giỏ
        public bool UpdateCart(int cartID, int quantity)
        {
            string query = "UPDATE Cart SET Quantity = @quantity WHERE IDCart = @cartID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { quantity, cartID });
            return result > 0;
        }

        // Xóa món khỏi giỏ
        public bool RemoveFromCart(int cartID)
        {
            string query = "DELETE FROM Cart WHERE IDCart = @cartID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { cartID });
            return result > 0;
        }

        // Xóa toàn bộ giỏ hàng sau khi thanh toán
        public bool ClearCart()
        {
            string query = "DELETE FROM Cart";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool SaveCartToOrderDetails(int idHoaDon)
        {
            string query = @"
        INSERT INTO ChiTietHoaDon (IDHoaDon, IDDoAn, SoLuong, ThanhTien)
        SELECT @idHoaDon , FoodID, Quantity, TotalPrice
        FROM Cart";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idHoaDon });
            return result > 0;
        }



    }

}
