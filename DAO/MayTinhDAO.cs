using CyberManagementProject.DTO;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DAO
{
    public class MayTinhDAO
    {
        private static MayTinhDAO instance;

        public static int TableWidth = 150;
        public static int TableHeight = 215;
        public static int PicWidth = 120;
        public static int PicHeight = 120;

        public static MayTinhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MayTinhDAO();
                return MayTinhDAO.instance;
            }
            private set => instance = value;
        }

        private MayTinhDAO() { }

        public List<MayTinh>LoadComputer()
        {
            List<MayTinh> computers = new List<MayTinh>();
            string query = "SELECT * FROM MayTinh";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                MayTinh computer = new MayTinh(row);
                computers.Add(computer);
            }    
            return computers;
        }
        public List<MayTinhView> LoadComputerStatus()
        {
            List<MayTinhView> computers = new List<MayTinhView>();
            string query = "SELECT * FROM VW_MayTinhStatus";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                MayTinhView computer = new MayTinhView(row);
                computers.Add(computer);
            }
            return computers;
        }
    }
}
