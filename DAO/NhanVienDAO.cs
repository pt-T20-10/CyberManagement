﻿using CyberManagementProject.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }

        public static int NhanVienWidth = 100;
        public static int NhanVienHeight = 100;

        private NhanVienDAO() { }


        //load TKNhanVien  ,   ChucVu vào button trong flowlayoutPanel
        public List<NhanVienDTO> LoadNhanVienList()
        {
            List<NhanVienDTO> nhanvienList = new List<NhanVienDTO>();

            DataTable data = DataProvider.Instance.ExcuteQuery(@" EXEC USP_DanhSachNha  nVien ");

            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO NhanVienDTO = new NhanVienDTO(item);
                nhanvienList.Add(NhanVienDTO);
            }

            return nhanvienList;
        }

        // Thêm nhân viên mới
        public bool AddNhanVien(string tkNhanVien  ,   string mkNhanVien)
        {

            //// Chuyển đổi mật khẩu (mkNhanVien) từ chuỗi thành mảng byte (varbinary)
            //byte[] mkNhanVienBinary = Encoding.UTF8.GetBytes(mkNhanVien);  // Đổi mật khẩu thành mảng byte
            //// Câu lệnh INSERT vào bảng TKNhanVien
            //string query = " EXEC USP_ThemTKNhanVien @TKNhanVien  ,  @MKNhanVien ";
            //int result = DataProvider.Instance.ExcuteNonQuery(query  ,   new object[] { tkNhanVien  ,   mkNhanVienBinary });

            //if (result > 0)
            //{
            //    // Sau khi thêm TKNhanVien vào bảng TKNhanVien   ,    thêm vào bảng NhanVien
            //    // Cung cấp các tham số mặc định cho các trường còn lại trong bảng NhanVien
            //    string queryNhanVien = " EXEC USP_ThemNhanVien @TKNhanVien ,  @TenChucVu , @TenBoPhan , @KieuLam , @GioiTinh , @TonGiao ";
            //    string TenChucVu = "Phục vụ";
            //    string TenBoPhan = "Nhân sự";
            //    string KieuLam = "Parttime";
            //    string GioiTinh = "Nam";
            //    string TonGiao = "Không";

            //    // Thực hiện thêm dữ liệu vào bảng NhanVien
            //    DataProvider.Instance.ExcuteNonQuery(queryNhanVien ,  new object[] { tkNhanVien  ,  TenChucVu  ,  TenBoPhan  ,  KieuLam  ,  GioiTinh  ,  TonGiao }); //  ,   hoTenLot  ,   ten  ,   soDT  ,   email  ,   idChucVu  ,   idBoPhan  ,   cCCD });
            //    return true;
            //}
            //return false;

            // Thêm tài khoản nhân viên trước
            bool addTaiKhoan = TKNhanVienDAO.Instance.AddTaiKhoanNhanVien(tkNhanVien, mkNhanVien); //gọi phương thức AddTaiKhoanNhanVien trong TKNhanVienDAO, bởi vì
                                                                                                    //tạo nhân viên mới trong TKNhanVienDAO sẽ hợp lý hơn, nhưng mà cũng cần vài trường trong table NhanVien nên phải rườm rà như vậy
            if (!addTaiKhoan) return false;

            // Sau khi thêm tài khoản thành công, thêm thông tin vào bảng NhanVien
            string queryNhanVien = "EXEC USP_ThemNhanVien @TKNhanVien , @TenChucVu , @TenBoPhan , @KieuLam , @GioiTinh , @TonGiao ";

            string TenChucVu = "Phục vụ";
            string TenBoPhan = "Nhân sự";
            string KieuLam = "Parttime";
            string GioiTinh = "Nam";
            string TonGiao = "Không";

            int result = DataProvider.Instance.ExcuteNonQuery(queryNhanVien, new object[] { tkNhanVien, TenChucVu, TenBoPhan, KieuLam, GioiTinh, TonGiao });

            return result > 0;

        }

        //thực hiện thao tác hiển thị thông tin Khách hàng khi click vào button
        public NhanVienDTO GetNhanVienDetailsByUser(string TKNhanVien)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery(@" EXEC USP_GetNhanVienByTKNhanVien @TKNhanVien " ,   new object[] { TKNhanVien });

            // Kiểm tra nếu có dữ liệu trả về
            if (data.Rows.Count > 0)
            {
                return new NhanVienDTO(data.Rows[0]);
            }
            return null;

        }


        //Update thông tin nhân viên
        public bool UpdateNhanVien(string ten ,  string soDT ,  string email ,  string tenchucvu ,  string tenbophan ,  string kieulam ,  string diaChi ,  string cccd ,  string gioiTinh ,  string tonGiao ,  string ngaySinh ,  string ngayVao ,  string ngayRa  ,  string tknv )
        {
            string query = "UPDATE NhanVien " +
                "SET Ten = @Ten , SoDT = @SoDT , Email = @Email , DiaChi = @DiaChi , TenChucVu = @TenChucVu , TenBoPhan = @TenBoPhan , KieuLam = @KieuLam ," +
                "  CCCD = @CCCD , GioiTinh = @GioiTinh , TonGiao = @TonGiao ,  NgaySinh = @NgaySinh , NgayVao = @NgayVao , NgayRa = @NgayRa " +
                "WHERE TKNhanVien = @TKNhanVien  ";

            int result = DataProvider.Instance.ExcuteNonQuery(query , 
                new object[] { ten ,  soDT ,  email ,  diaChi ,  tenchucvu ,  tenbophan ,  kieulam ,  cccd ,  gioiTinh ,  tonGiao ,  ngaySinh ,  ngayVao ,  ngayRa  ,  tknv });

            return result > 0;
        }


        //Xóa thông tin nhân viên (Xóa nhân viên)
        public bool DeleteNhanVienByTKNhanVien(string tkNhanVien)
        {
            // Câu lệnh xóa trong bảng NhanVien
            string query_NV = @" EXEC USP_XoaNhanVien @TKNhanVien ";

            // Câu lệnh xóa trong bảng TKNhanVien
            string query_TKNV = @" EXEC USP_DeleteTKNhanVien @TKNhanVien ";

            try
            {
                // Thực thi câu lệnh DELETE cho bảng NhanVien
                int result1 = DataProvider.Instance.ExcuteNonQuery(query_NV ,  new object[] { tkNhanVien });

                // Thực thi câu lệnh DELETE cho bảng TKNhanVien
                int result2 = DataProvider.Instance.ExcuteNonQuery(query_TKNV ,  new object[] { tkNhanVien });

                return ((result1 > 0) && (result2 > 0));
            }
            catch (Exception ex)
            {
                // Nếu có lỗi ,  rollback giao dịch
                MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}");
                return false;
            }
        }


        ////Tìm kiếm nhân viên theo TKNhanVien
        //public List<string> TimKiemNhanVien(string tkNhanVien)
        //{
        //    List<string> danhSachTKNhanVien = new List<string>();
        //    string query = "SELECT TKNhanVien FROM NhanVien WHERE TKNhanVien LIKE @TKNhanVien";

        //    DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { $"%{tkNhanVien}%" });
        //    foreach (DataRow row in data.Rows)
        //    {
        //        danhSachTKNhanVien.Add(row["TKNhanVien"].ToString());
        //    }
        //    return danhSachTKNhanVien;
        //}

        //

        public List<string> GetDanhSachChucVu()
        {
            string query = "SELECT DISTINCT TenChucVu FROM NhanVien WHERE TenChucVu IS NOT NULL";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            List<string> danhSachChucVu = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                danhSachChucVu.Add(row["TenChucVu"].ToString());
            }
            return danhSachChucVu;
        } //Lấy danh sách chức vụ từ SQL
    }
}
