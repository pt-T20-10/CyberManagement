using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DTO
{
    public class MayTinh
    {
        private int iDMayTinh;
        private string tenMay;
        private double bangGia;
        private string trangThaiMay = "Trống";
        private string ghiChuMay = " ";

        public MayTinh(int id,string tenmay, double banggia, string status, string note) 
        {
            this.iDMayTinh = id;
            this.tenMay = tenmay;
            this.bangGia = banggia;
            this.trangThaiMay = status;
            this.ghiChuMay = note;  
        }
        public MayTinh(DataRow row) 
        {
            this.iDMayTinh = (int)row["IDMayTinh"];
            this.tenMay = row["TenMay"].ToString();
            this.trangThaiMay = row["TrangThai"].ToString();
            this.bangGia = (float)Convert.ToDouble(row["BangGia"]);
            this.ghiChuMay = row["GhiChu"].ToString();

        }

        public int IDMayTinh { get => iDMayTinh; set => iDMayTinh = value; }
        public string TenMay { get => tenMay; set => tenMay = value; }
        public double BangGia { get => bangGia; set => bangGia = value; }
        public string TrangThaiMay { get => trangThaiMay; set => trangThaiMay = value; }
        public string GhiChuMay { get => ghiChuMay; set => ghiChuMay = value; }

    }
    public class MayTinhView
    {
        public int IDMayTinh { get; set; }
        public string TenMay { get; set; }
        public string TrangThai { get; set; }
        public int? IDPhien { get; set; }
        public int? ThoiGianConLai { get; set; }
        public decimal? TongTien { get; set; }
        public string? TKKhachHang { get; set; }
        public decimal? TienNap { get; set; }

        public MayTinhView(DataRow row)
        {
            IDMayTinh = (int)row["IDMayTinh"];
            TenMay = row["TenMay"].ToString();
            TrangThai = row["TrangThai"].ToString();
            IDPhien = row["IDPhien"] as int?;
            ThoiGianConLai = row["ThoiGianConlai"] as int?;
            TongTien = row["TongTien"] as decimal?;
            TKKhachHang = row["TKKhachHang"]?.ToString();
            TienNap = row["TienNap"] as decimal?;
        }
    }
}
