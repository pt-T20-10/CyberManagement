using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DTO
{
    public class OrderedFood
    {
        private string foodName;
        private int count;
        private float price;
        private float totalPrice;
        public OrderedFood(string nameFood , int count , float price , float totalPrice)
        {
            this.foodName = nameFood;
            this.count = count;
            this.price = price;
            this.totalPrice = totalPrice;
        }
        public OrderedFood(DataRow row) 
        {
            this.foodName = row["TenDoAn"].ToString();
            this.count = (int)row["SoLuong"];
            this.price = (float)Convert.ToDouble((row["Gia"]).ToString());
            this.totalPrice = (float)Convert.ToDouble((row["totalPrice"]).ToString());
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
