using CyberManagementProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DAO
{
    public class AddNewKhachHangDAO
    {
        private static AddNewKhachHangDAO instance;

        public static AddNewKhachHangDAO Instance
        {
            get { if (instance == null) instance = new AddNewKhachHangDAO(); return instance; }
            private set { instance = value; }
        }

        public static int KhachHangWidth = 80;
        public static int KhachHangHeight = 80;

        private AddNewKhachHangDAO() { }

        // Phương thức Load danh sách nhân viên từ cơ sở dữ liệu
        public List<KhachHangDTO> LoadKhachHangList()
        {
            List<KhachHangDTO> nhanVienList = new List<KhachHangDTO>();

            // Câu lệnh SQL để lấy danh sách TKKhachHang
            string query = "SELECT TKKhachHang FROM TKKhachHang";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO nhanVien = new KhachHangDTO
                {
                    TKKhachHang = row["TKKhachHang"].ToString() // Lấy TKKhachHang từ cơ sở dữ liệu
                };

                nhanVienList.Add(nhanVien);
            }

            return nhanVienList;
        }

        // Thêm nhân viên mới
        public bool AddKhachHang(string TKKhachHang, string mkKhachHang)
        {

            // Chuyển đổi mật khẩu (mkKhachHang) từ chuỗi thành mảng byte (varbinary)
            byte[] mkKhachHangBinary = Encoding.UTF8.GetBytes(mkKhachHang);  // Đổi mật khẩu thành mảng byte
            // Câu lệnh INSERT vào bảng TKKhachHang
            string query = "INSERT INTO TKKhachHang (TKKhachHang ,  MKKhachHang) VALUES ( @TKKhachHang  ,  @MKKhachHang )";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { TKKhachHang, mkKhachHangBinary });

            if (result > 0)
            {
                // Sau khi thêm TKKhachHang vào bảng TKKhachHang ,  thêm vào bảng NhanVien
                // Cung cấp các tham số mặc định cho các trường còn lại trong bảng NhanVien
                string queryKhachHang = "INSERT INTO KhachHang ( ID , TKKhachHang ,  HoTenLot ,  Ten  ,   SoDT ,  Email , DiaChi , NhomKhach ) " +
                                       "VALUES ( @ID , @TKKhachHang  ,  @HoTenLot  ,  @Ten  ,  @SoDT  , @Email , @DiaChi , @NhomKhach )";

                // Các giá trị mặc định cho nhân viên mới (bạn có thể thay đổi giá trị mặc định này theo yêu cầu)
                //string hoTenLot = "Nguyen Hoang"; // Giá trị mặc định cho họ
                //string ten = "Nghia"; // Giá trị mặc định cho tên
                //string soDT = "0397419555"; // Giá trị mặc định cho số điện thoại
                //string email = "nhoangnghia2104@gmail.com"; // Giá trị mặc định cho email
                //int idChucVu = 2; // Giả sử mặc định là Chức vụ 1 (có thể thay đổi)
                //int idBoPhan = 1; // Giả sử mặc định là Bộ phận 1 (có thể thay đổi)
                //string cCCD = "123654789"; 

                // Thực hiện thêm dữ liệu vào bảng NhanVien
                DataProvider.Instance.ExcuteNonQuery(queryKhachHang, new object[] { TKKhachHang });// hoTenLot, ten, soDT, email, idChucVu, idBoPhan, cCCD });
                return true;
            }
            return false;
        }
    }
}
