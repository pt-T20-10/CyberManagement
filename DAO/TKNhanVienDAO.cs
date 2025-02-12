using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CyberManagementProject.DAO
{
    public class TKNhanVienDAO
    {
        private static TKNhanVienDAO instance;

        public static TKNhanVienDAO Instance
        {
            get { if (instance == null) instance = new TKNhanVienDAO(); return TKNhanVienDAO.instance; }
            private set { TKNhanVienDAO.instance = value; }
        }

        public TKNhanVienDAO() { }

        // Hàm băm mật khẩu
        private byte[] HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public bool AddTaiKhoanNhanVien(string tkNhanVien, string mkNhanVien)
        {
            // Băm mật khẩu trước khi lưu vào SQL
            byte[] hashedPassword = HashPassword(mkNhanVien);

            string query = "EXEC USP_ThemTKNhanVien @TKNhanVien , @MKNhanVien ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { tkNhanVien, hashedPassword });

            return result > 0;
        }

        // Lấy mật khẩu từ database theo tài khoản nhân viên
        public byte[] GetPasswordHash(string tkNhanVien)
        {
            string query = "SELECT MKNhanVien FROM TKNhanVien WHERE TKNhanVien = @TKNhanVien ";

            object result = DataProvider.Instance.ExcuteScalar(query, new object[] { tkNhanVien });

            return result as byte[];
        }


        // So sánh hai mảng byte
        private bool CompareByteArrays(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }

        // Kiểm tra đăng nhập
        public bool Login(string tkNhanVien, string mkNhanVien)
        {
            byte[] hashedPasswordFromDB = GetPasswordHash(tkNhanVien);
            if (hashedPasswordFromDB == null) return false;  // Không tồn tại tài khoản

            byte[] hashedInputPassword = HashPassword(mkNhanVien);

            return CompareByteArrays(hashedPasswordFromDB, hashedInputPassword);
        }

    }
}
