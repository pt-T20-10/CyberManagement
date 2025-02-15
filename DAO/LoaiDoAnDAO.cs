using CyberManagementProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DAO
{
    public class LoaiDoAnDAO
    {
        private static LoaiDoAnDAO instance;
        public static LoaiDoAnDAO Instance
        {
            get { if (instance == null) { instance = new LoaiDoAnDAO(); } return instance; }
            private set { instance = value; }
        }

        private LoaiDoAnDAO() { }

        public List<LoaiDoAn> GetListCategory()
        {
            List<LoaiDoAn> listCategory = new List<LoaiDoAn>();

            string query = "SELECT * FROM LoaiDoAn";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                LoaiDoAn category = new LoaiDoAn(row);
                listCategory.Add(category);
            }
            return listCategory;
        }
        public LoaiDoAn GetCategoryByID(int id)
        {
            LoaiDoAn category = null;
            string query = "SELECT * FROM LoaiDoAn WHERE IDLoai = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                category = new LoaiDoAn(row);
                return category;
            }
            return category;
        }
    }
}
