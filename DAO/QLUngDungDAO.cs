using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberManagementProject.DTO;

namespace CyberManagementProject.DAO
{
    internal class QLUngDungDAO
    {
        private static QLUngDungDAO instance;

        public static QLUngDungDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLUngDungDAO();
                return instance;
            }
        }

        private QLUngDungDAO() { }

        // Thêm ứng dụng mới bằng Stored Procedure
        /// <summary>
        /// Lấy danh sách tất cả ứng dụng
        /// </summary>
        public List<UngDungDTO> LayDanhSachUngDung()
        {
            List<UngDungDTO> danhSach = new List<UngDungDTO>();
            string query = "SELECT * FROM UngDung";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                danhSach.Add(new UngDungDTO(row));
            }
            return danhSach;
        }

        /// <summary>
        /// Thêm một ứng dụng mới vào CSDL
        /// </summary>
        public bool ThemUngDung(string tenUngDung, int loaiUngDungID, string moTa, string duongDan)
        {
            string query = "INSERT INTO UngDung (TenUngDung, LoaiUngDungID, MoTa, DuongDan) " +
                           "VALUES ( @TenUngDung , @LoaiUngDungID , @MoTa , @DuongDan )";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { tenUngDung, loaiUngDungID, moTa, duongDan });

            return result > 0;
        }

        /// <summary>
        /// Cập nhật thông tin ứng dụng
        /// </summary>
        public bool CapNhatUngDung(int id, string tenUngDung, int loaiUngDungID, string moTa, string duongDan)
        {
            string query = "UPDATE UngDung SET TenUngDung = @TenUngDung , LoaiUngDungID = @LoaiUngDungID , " +
                           "MoTa = @MoTa , DuongDan = @DuongDan WHERE ID = @ID ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { tenUngDung, loaiUngDungID, moTa, duongDan, id });

            return result > 0;
        }

        /// <summary>
        /// Xóa ứng dụng theo ID
        /// </summary>
        public bool XoaUngDung(int id)
        {
            string query = "DELETE FROM UngDung WHERE ID = @ID ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { id });

            return result > 0;
        }

    }
}
