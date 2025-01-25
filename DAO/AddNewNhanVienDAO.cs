using CyberManagementProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DAO
{
    public class AddNewNhanVienDAO
    {
        private static AddNewNhanVienDAO instance;

        public static AddNewNhanVienDAO Instance
        {
            get { if (instance == null) instance = new AddNewNhanVienDAO(); return instance; }
            private set { instance = value; }
        }

        public static int NhanVienWidth = 80;
        public static int NhanVienHeight = 80;

        private AddNewNhanVienDAO() { }

        // Phương thức Load danh sách nhân viên từ cơ sở dữ liệu
        public List<NhanVienDTO> LoadNhanVienList()
        {
            List<NhanVienDTO> nhanVienList = new List<NhanVienDTO>();

            // Câu lệnh SQL để lấy danh sách TKNhanVien
            string query = "SELECT TKNhanVien FROM TKNhanVien";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO nhanVien = new NhanVienDTO
                {
                    TKNhanVien = row["TKNhanVien"].ToString() // Lấy TKNhanVien từ cơ sở dữ liệu
                };

                nhanVienList.Add(nhanVien);
            }

            return nhanVienList;
        }

        // Thêm nhân viên mới
        public bool AddNhanVien(string tkNhanVien ,  string mkNhanVien)
        {
           
            // Chuyển đổi mật khẩu (mkNhanVien) từ chuỗi thành mảng byte (varbinary)
            byte[] mkNhanVienBinary = Encoding.UTF8.GetBytes(mkNhanVien);  // Đổi mật khẩu thành mảng byte
            // Câu lệnh INSERT vào bảng TKNhanVien
            string query = "INSERT INTO TKNhanVien (TKNhanVien ,  MKNhanVien) VALUES ( @TKNhanVien  ,  @MKNhanVien )";
            int result = DataProvider.Instance.ExcuteNonQuery(query ,  new object[] { tkNhanVien , mkNhanVienBinary });

            if (result > 0)
            {
                // Sau khi thêm TKNhanVien vào bảng TKNhanVien ,  thêm vào bảng NhanVien
                // Cung cấp các tham số mặc định cho các trường còn lại trong bảng NhanVien
                string queryNhanVien = "INSERT INTO NhanVien (TKNhanVien ,  HoTenLot ,  Ten  ,   SoDT ,  Email ,  IDChucVu ,  IDBoPhan, CCCD ) " +
                                       "VALUES ( @TKNhanVien  ,  @HoTenLot  ,  @Ten  ,  @SoDT  ,  @Email ,  @IDChucVu ,  @IDBoPhan , @CCCD )";

                // Các giá trị mặc định cho nhân viên mới (bạn có thể thay đổi giá trị mặc định này theo yêu cầu)
                string hoTenLot = "Nguyen Hoang"; // Giá trị mặc định cho họ
                string ten = "Nghia"; // Giá trị mặc định cho tên
                string soDT = "0397419555"; // Giá trị mặc định cho số điện thoại
                string email = "nhoangnghia2104@gmail.com"; // Giá trị mặc định cho email
                int idChucVu = 2; // Giả sử mặc định là Chức vụ 1 (có thể thay đổi)
                int idBoPhan = 1;
                string cCCD = "123654789"; // Giả sử mặc định là Bộ phận 1 (có thể thay đổi)

                // Thực hiện thêm dữ liệu vào bảng NhanVien
                DataProvider.Instance.ExcuteNonQuery(queryNhanVien ,  new object[] { tkNhanVien ,  hoTenLot ,  ten ,  soDT ,  email ,  idChucVu ,  idBoPhan , cCCD });
                return true;
            }
            return false;
        }

        //// Lấy thông tin nhân viên bằng TKNhanVien
        //public NhanVienDTO GetNhanVienByUser(string tkNhanVien)
        //{
        //    string query = "SELECT TKNhanVien ,  MKNhanVien FROM TKNhanVien WHERE TKNhanVien = @TKNhanVien ";
        //    DataTable data = DataProvider.Instance.ExcuteQuery(query ,  new object[] { tkNhanVien });

        //    if (data.Rows.Count > 0)
        //    {
        //        return new NhanVienDTO(data.Rows[0]);
        //    }

        //    return null;
        //}

    }
}
