using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DTO
{
    public class CartDTO
    {
        public int IDCart { get; set; }
        public int FoodID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int IDHoaDon { get; set; }

        public CartDTO(int idCart, int foodID, int quantity, decimal totalPrice, int iDHoaDon)
        {
            IDCart = idCart;
            FoodID = foodID;
            Quantity = quantity;
            TotalPrice = totalPrice;
            IDHoaDon = iDHoaDon;

        }

        public CartDTO(DataRow row)
        {
            this.IDCart = (int)row["IDCart"];
            this.FoodID = (int)row["FoodID"];
            this.Quantity = (int)row["Quantity"];
            this.TotalPrice = (decimal)Convert.ToDouble((row["TotalPrice"]).ToString());
            this.IDHoaDon = (int)row["IDHoaDon"];
            //this.Quantity = row.Table.Columns.Contains("Quantity") ? Convert.ToInt32(row["Quantity"]) : 0;
            // (decimal)Convert.ToDouble((row["Quantity"]).ToString())//
        }
    }

}
