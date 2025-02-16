using CyberManagementProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace CyberManagementProject.DAO
{
    public class PhienSuDungDAO
    {
        private static PhienSuDungDAO instance;
        public static PhienSuDungDAO Instance
        {
            get { if (instance == null) instance = new PhienSuDungDAO(); return instance; }
            private set => instance = value;
        }
        private PhienSuDungDAO() { }

        // ✅ 1️⃣ Cập nhật tiền nạp vào phiên
        public void CapNhatTienNap(int idPhien, float soTien)
        {
            string query = "EXEC CapNhatTienNap @IDPhien , @SoTien";
            DataProvider.Instance.ExcuteNonQuery(query, new object[] { idPhien, soTien });
        }

        // ✅ 2️⃣ Lấy danh sách các phiên đang chạy (ThoiGianKetThuc IS NULL)
        public List<PhienSuDung> LayPhienDangChay()
        {
            List<PhienSuDung> danhSach = new List<PhienSuDung>();
            string query = "EXEC LayPhienDangChay";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                PhienSuDung secsion = new PhienSuDung(row);
                danhSach.Add(secsion);
            }

            return danhSach;
        }
    }
}
