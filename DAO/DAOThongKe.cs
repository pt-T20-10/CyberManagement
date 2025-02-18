using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DAO
{
    internal class DAOThongKe
    {
        private static DAOThongKe instance;


        public static DAOThongKe Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAOThongKe();
                return instance;
            }
        }

        private DAOThongKe() { }

        //----------------------DOANH THU----------------------------//
        // Phương thức lấy tất cả tên khách hàng
        public DataTable GetAllTenKhachHang()
        {
            string query = "SELECT DISTINCT TenKhachHang FROM LuuTruThongKe"; // Truy vấn lấy tất cả tên khách hàng
            return DataProvider.Instance.ExcuteQuery(query);
        }

        // Thống kê doanh thu theo ngày
        public DataTable GetThongKeDoanhThuTheoNgay(DateTime ngay)
        {
            string query = "EXEC sp_DoanhThu_TheoNgay @Ngay ";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { ngay });
        }

        // Thống kê doanh thu theo tháng
        public DataTable GetThongKeDoanhThuTheoThang(int thang, int nam)
        {
            string query = "EXEC sp_DoanhThu_TheoThang @Thang , @Nam ";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { thang, nam });
        }

        // Thống kê doanh thu theo năm
        public DataTable GetThongKeDoanhThuTheoNam(int nam)
        {
            string query = "EXEC sp_DoanhThu_TheoNam @Nam ";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { nam });
        }

        // Thống kê doanh thu theo ngày
        public DataTable GetTongDoanhThuTheoNgay(DateTime ngay)
        {
            string query = "EXEC sp_TongDoanhThu_TheoNgay @Ngay ";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { ngay });
        }

        // Thống kê doanh thu theo tháng
        public DataTable GetTongDoanhThuTheoThang(int thang, int nam)
        {
            string query = "EXEC sp_TongDoanhThu_TheoThang @Thang , @Nam ";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { thang, nam });
        }

        // Thống kê doanh thu theo năm
        public DataTable GetTongDoanhThuTheoNam(int nam)
        {
            string query = "EXEC sp_TongDoanhThu_TheoNam @Nam ";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { nam });
        }

        //----------------------MAY TRAM----------------------------//
        // Số giờ hoạt động của từng máy trong ngày/tháng
        public DataTable GetSoGioHoatDongMayTinh(int thang, int nam)
        {
            string query = "EXEC sp_SoGioHoatDong_MayTinh @Thang , @Nam ";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { thang, nam });
        }

        // Máy có số giờ sử dụng nhiều nhất trong tháng/năm
        public string GetMayTinhSuDungNhieuNhat(int thang, int nam)
        {
            string query = "EXEC sp_MayTinh_SuDungNhieuNhat @Thang , @Nam ";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { thang, nam });
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["TenMayTinh"].ToString();
            }
            return string.Empty;
        }

        // Máy có số giờ sử dụng ít nhất trong tháng/năm
        public string GetMayTinhSuDungItNhat(int thang, int nam)
        {
            string query = "EXEC sp_MayTinh_SuDungItNhat @Thang , @Nam ";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { thang, nam });
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["TenMayTinh"].ToString();
            }
            return string.Empty;
        }

        // Doanh thu theo từng máy trạm
        public DataTable GetDoanhThuMayTinh(int thang, int nam)
        {
            string query = "EXEC sp_DoanhThu_MayTinh @Thang , @Nam ";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { thang, nam });
        }

        //----------------------KHACH HANG----------------------------//
        //Khách hàng thường xuyên sử dụng dịch vụ nhất
        public DataTable GetKhachHangThuongXuyen()
        {
            string query = "EXEC sp_KhachHang_ThuongXuyenSuDung";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        //Tổng số tiền khách hàng đã chi tiêu tại quán
        public DataTable GetTongTienChiTieuKhachHang(string tenKhachHang)
        {
            string query = "EXEC sp_TongTienChiTieu_KhachHang @KhachHang ";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { tenKhachHang });
        }

        //Số lượng khách mới trong tháng/năm
        public int GetSoLuongKhachMoi(int thang, int nam)
        {
            string query = "EXEC sp_KhachHang_Moi @Thang , @Nam";
            object result = DataProvider.Instance.ExcuteScalar(query, new object[] { thang, nam });

            return result != null ? Convert.ToInt32(result) : 0;
        }

        //Lấy danh sách tên khách hàng mới
        public DataTable GetDanhSachKhachHangMoi(int thang, int nam)
        {
            string query = "EXEC sp_DanhSachKhachHangMoi @Thang , @Nam";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { thang, nam });
        }

        public DataTable GetThongKeDoanhThuKhachHang(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT TenKhachHang, SoDTKhachHang, EmailKhachHang, DiaChiKhachHang, NhomKhach, " +
                           "SUM(ISNULL(TongTienNap, 0) + ISNULL(TongTienDoAn, 0)) AS TongTien " +
                           "FROM LuuTruThongKe " +
                           "WHERE ThoiGianLuuTru BETWEEN @StartDate AND @EndDate " +
                           "GROUP BY TenKhachHang, SoDTKhachHang, EmailKhachHang, DiaChiKhachHang, NhomKhach " +
                           "ORDER BY TongTien DESC";

            var parameters = new object[] { startDate, endDate };
            return DataProvider.Instance.ExcuteQuery(query, parameters);
        }



        //------------------------ Tong ket --------------------//
        public DataTable GetTongDoanhThu()
        {
            string query = "EXEC sp_TongDoanhThu1";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable GetTongGioSuDungMay()
        {
            string query = "EXEC sp_TongGioSuDungMay1";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable GetTongTienDoAn()
        {
            string query = "EXEC sp_TongTienDoAn1";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable GetTongTienMay()
        {
            string query = "EXEC sp_TongTienMay1";
            return DataProvider.Instance.ExcuteQuery(query);
        }


        public DataTable GetTongKetThongKe()
        {
            string query = "EXEC sp_TongKetThongKe";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        //--------------------DO AN----------------//
        public DataTable GetThongKeTongSoLuongDoAn(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT SUM(ISNULL(SoLuong, 0)) AS TongSoLuongMonAnBanRa, " +
                           "SUM(ISNULL(TongTienDoAn, 0)) AS TongDoanhThu " +
                           "FROM LuuTruThongKe WHERE ThoiGianLuuTru BETWEEN @StartDate AND @EndDate";

            var parameters = new object[] { startDate, endDate };

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable thongKeData = DataProvider.Instance.ExcuteQuery(query, parameters);

            // Trả về DataTable chứa dữ liệu thống kê
            return thongKeData;
        }
    }
}
