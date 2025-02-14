using CyberManagementProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DAO
{
    public class OrderedFoodDAO
    {
        private static OrderedFoodDAO instance;

        public static OrderedFoodDAO Instance
        {
            get { if (instance == null) instance = new OrderedFoodDAO(); return OrderedFoodDAO.instance; }
            private set => instance = value;
        }
        private OrderedFoodDAO() { }

        public List<OrderedFood> GetListOrderedFoodByComputer(int id)
        {
            List<OrderedFood> listOrderedFood = new List<OrderedFood>();

            string query = "EXEC USP_OrderedFoodByComputer @idCom ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                OrderedFood info = new OrderedFood(item);
                listOrderedFood.Add(info);
            }
            return listOrderedFood;
        }
    }
}
