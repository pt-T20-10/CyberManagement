using CyberManagementProject.DTO;
using System.Data;
using System.Drawing;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CyberManagementProject.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return KhachHangDAO.instance; }
            private set { KhachHangDAO.instance = value; }
        }

        public static int KhachHangWidth = 100;
        public static int KhachHangHeight = 100;

        private KhachHangDAO() { }

        //load TKKhachHang, NhomKhach vào button trong flowlayoutPanel
        public List<KhachHangDTO> LoadKhachHangList()
        {
            List<KhachHangDTO> khachhangList = new List<KhachHangDTO>();

            DataTable data = DataProvider.Instance.ExcuteQuery(@" EXEC USP_DanhSachKhachHang ");

            foreach (DataRow item in data.Rows)
            {
                KhachHangDTO khachHangDTO = new KhachHangDTO(item);
                khachhangList.Add(khachHangDTO);
            }

            return khachhangList;
        }


        // Thêm khách hàng mới
        public bool AddKhachHang(string TKKhachHang, string mkKhachHang)
        {

            // Chuyển đổi mật khẩu (mkKhachHang) từ chuỗi thành mảng byte (varbinary)
            byte[] mkKhachHangBinary = Encoding.UTF8.GetBytes(mkKhachHang);  // Đổi mật khẩu thành mảng byte
            // Câu lệnh INSERT vào bảng TKKhachHang
            string query = " EXEC USP_ThemTKKhachHang @TKKhachHang , @MKKhachHang ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { TKKhachHang, mkKhachHangBinary });

            if (result > 0)
            {
                // Sau khi thêm TKKhachHang vào bảng TKKhachHang ,  thêm vào bảng KhachHang
                // Cung cấp các tham số mặc định cho các trường còn lại trong bảng KhachHang
                string queryKhachHang = " EXEC USP_ThemKhachHang @TKKhachHang , @NhomKhach ";
                string NhomKhach = "Thường"; 

                // Thực hiện thêm dữ liệu vào bảng KhachHang
                DataProvider.Instance.ExcuteNonQuery(queryKhachHang, new object[] { TKKhachHang , NhomKhach});
                return true;
            }
            return false;
        }

        //thực hiện thao tác hiển thị thông tin Khách hàng khi click vào button
        public KhachHangDTO GetKhachHangDetailsByUser(string TKKhachHang)
        { 
            DataTable data = DataProvider.Instance.ExcuteQuery(@" EXEC USP_LayThongTinByTKKhachHang @TKKhachHang ", new object[] { TKKhachHang });

            

            // Kiểm tra nếu có dữ liệu trả về
            if (data.Rows.Count > 0)
            {
                return new KhachHangDTO(data.Rows[0]);
            }
            return null;
        }


        //Update thông tin khách hàng
        public bool UpdateKhachHang(string tkkh , string ten, string soDT, string email, string diachi , string nhomkhach)
        { 
            string query = " EXEC USP_UpdateKhachHang @TKKhachHang , @Ten , @SoDT , @Email , @DiaChi , @NhomKhach ";
        int result = DataProvider.Instance.ExcuteNonQuery(query,
                new object[] { tkkh , ten, soDT, email, diachi, nhomkhach });

            return result > 0;
        }



        //Xóa thông tin khách hàng (Xóa khách hàng)
        public bool DeleteKhachHangByTKKhachHang(string tkKhachHang)
        {
            // Câu lệnh xóa trong bảng KhachHang
            string query_NV = @" EXEC USP_XoaKhachHang @TKKhachHang ";

            // Câu lệnh xóa trong bảng TKKhachHang
            string query_TKNV = @" EXEC USP_DeleteTKKhachHang @TKKhachHang ";

            try
            {
                // Thực thi câu lệnh DELETE cho bảng KhachHang
                int result1 = DataProvider.Instance.ExcuteNonQuery(query_NV, new object[] { tkKhachHang });

                // Thực thi câu lệnh DELETE cho bảng TKKhachHang
                int result2 = DataProvider.Instance.ExcuteNonQuery(query_TKNV, new object[] { tkKhachHang });

                return ((result1 > 0) && (result2 > 0));
            }
            catch (Exception ex)
            {
                // Nếu có lỗi, rollback giao dịch
                MessageBox.Show($"Lỗi khi xóa khách hàng: {ex.Message}");
                return false;
            }
        }

        //phương thức load Nhóm khách từ SQL
        public List<string> GetDanhSachNhomKhach()
        {
            string query = "SELECT DISTINCT NhomKhach FROM KhachHang WHERE NhomKhach IS NOT NULL";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            List<string> danhSachNhomKhach = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                danhSachNhomKhach.Add(row["NhomKhach"].ToString());
            }
            return danhSachNhomKhach;
        }

        //kiểm tra khách hàng đã có trong SQL chưa
        public bool IsKhachHangExists(string tkKhachHang)
        {
            string query = "SELECT COUNT(*) FROM KhachHang WHERE TKKhachHang = @TKKhachHang ";
            object result = DataProvider.Instance.ExcuteScalar(query, new object[] { tkKhachHang });

            return Convert.ToInt32(result) > 0; // Trả về true nếu tài khoản đã tồn tại
        }

    }
}
