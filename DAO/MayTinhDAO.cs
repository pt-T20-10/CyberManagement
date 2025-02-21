﻿using CyberManagementProject.DTO;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        public MayTinh LoadComputerById(int idCom)
        {
            MayTinh computer = null;
            string query = "SELECT * FROM MayTinh WHERE IDMayTinh =  " + idCom;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                computer = new MayTinh(row);
                return computer;
            }
            return computer;
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

        public DataTable LoadListKhachHang()
        {
            string query = "EXEC USP_LoadListKhachHangAvilable";
            return DataProvider.Instance.ExcuteQuery(query);    
        }
        public void InsertUser_Phien(int idMayTinh , string userName)
        {
            DataProvider.Instance.ExcuteQuery("EXEC USP_InsertPhienSuDung @iDMayTinh , @UserName ", new object[] {idMayTinh, userName} ); 
        }
        public bool isKhachHangNotAvailable(string userName)
        {
            DataTable result = DataProvider.Instance.ExcuteQuery("EXEC USP_CheckTKKhachHangNotAvailable @userName ", new object[] { userName });
            return result.Rows.Count > 0;
        }
        public void AddThoiGianKetThucPhien(int idPhien , DateTime timeKetThuc , float TongTienNap , float TongTienDoAn)
        {
            DataProvider.Instance.ExcuteNonQuery("EXEC USP_AddTimeKetThuc @iDPhien  , @TimeKetThuc  ,  @TongTienNap , @TongTienDoAn ", new object[] { idPhien, timeKetThuc, TongTienNap, TongTienDoAn });
        }
        public void InsertServiceToComputer(int? idPhien, int idFood, int count)
        {
            DataProvider.Instance.ExcuteQuery("EXEC USP_InsetChiTietDichVu @iDPhien  , @iDFood  , @count ", new object[] { idPhien, idFood, count });
        }
        public bool InsertComputer(string tenmay, double banggia, string note)
        {
            string query = "EXEC USP_InsertComputer @TenMay , @BangGia , @GhiChu ";
          
            
                int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {tenmay,banggia,note});
                return result > 0;
         
        }

        public bool UpdateComputer(int idmay, string tenmay, double banggia, string note)
        {
            string query = "EXEC USP_UpdateComputer @IDMayTinh , @TenMay , @BangGia , @GhiChu ";
            
                int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { idmay, tenmay, banggia, note });
                return result > 0;
            
            
        }
         public bool DeleteComputer(int idmay)
            {
                    string query = string.Format("EXEC USP_DeleteComputer @IDMayTinh = {0} ", idmay);
                    int result = DataProvider.Instance.ExcuteNonQuery(query);
                    return result > 0;
             }
        public bool ísTenMayTonTai(string name)
        {
           int result = (int)DataProvider.Instance.ExcuteScalar("SELECT COUNT(*) FROM MayTinh WHERE TenMay = N'" + name + "'" );
            return result > 0;
        }
        public bool isInUseComputer()
        {
            DataTable result = DataProvider.Instance.ExcuteQuery("SELECT * FROM MayTinh WHERE TrangThai = N'Đang được sử dụng'");
            return result.Columns.Count > 0;
        }
    }
}
