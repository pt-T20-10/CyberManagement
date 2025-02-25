using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DTO
{
    public class PhienSuDung
    {
        private int iDPhien;
        private string tKKhachHang;
        private int iDMayTinh;
        private DateTime? timeBatDau;
        private DateTime? timeKetThuc;
        private TimeSpan? thoiGianDaSuDung; // Sẽ được tính toán trong code nếu phiên đang chạy
        private int thoiGianConLai; // Giữ nguyên kiểu int cho thời gian còn lại (phút)
        private double? tongTienNap;
        private double? tongTienDoAn;

        public PhienSuDung(int idPhien, string tkKhacHang, int idMayTinh, DateTime? timeBatDau, DateTime? timeKetThuc)
        {
            this.IDPhien = idPhien;
            this.TKKhachHang = tkKhacHang;
            this.IDMayTinh = idMayTinh;
            this.TimeBatDau = timeBatDau;
            this.TimeKetThuc = timeKetThuc;
        }

        public PhienSuDung(DataRow row)
        {
            this.IDPhien = (int)row["IDPhien"];
            this.TKKhachHang = row["TKKhachHang"].ToString();
            this.IDMayTinh = (int)row["IDMayTinh"];
            this.TimeBatDau = (DateTime?)row["ThoiGianBatDau"];
            var dateCheckOutTemp = row["ThoiGianKetThuc"];
            if (dateCheckOutTemp.ToString() != "")
            {
                this.TimeKetThuc = (DateTime?)dateCheckOutTemp;
            }
            this.TongTienNap = Convert.ToDouble(row["TongTienNap"]);
            this.TongTienDoAn = Convert.ToDouble(row["TongTienDoAn"]);

            // Tính ThoiGianDaSuDung nếu phiên đã kết thúc (ThoiGianKetThuc có giá trị)
            if (this.TimeKetThuc.HasValue && this.TimeBatDau.HasValue)
            {
                this.ThoiGianDaSuDung = this.TimeKetThuc.Value - this.TimeBatDau.Value;
            }
            else if (this.TimeBatDau.HasValue) // Phiên đang chạy, ThoiGianDaSuDung sẽ được tính trong code
            {
                this.ThoiGianDaSuDung = null; // Hoặc TimeSpan.Zero nếu cần giá trị mặc định
            }

            // Tính ThoiGianConLai (nếu cần) dựa trên logic ứng dụng, nhưng không tính trong DTO để tránh chậm
            this.ThoiGianConLai = 0; // Mặc định 0, sẽ được tính trong CyberManager hoặc UI
        }

        public int IDPhien { get => iDPhien; set => iDPhien = value; }
        public string TKKhachHang { get => tKKhachHang; set => tKKhachHang = value; }
        public int IDMayTinh { get => iDMayTinh; set => iDMayTinh = value; }
        public DateTime? TimeBatDau { get => timeBatDau; set => timeBatDau = value; }
        public DateTime? TimeKetThuc { get => timeKetThuc; set => timeKetThuc = value; }
        public TimeSpan? ThoiGianDaSuDung { get => thoiGianDaSuDung; set => thoiGianDaSuDung = value; }
        public int ThoiGianConLai { get => thoiGianConLai; set => thoiGianConLai = value; }
        public double? TongTienNap { get => tongTienNap; set => tongTienNap = value; }
        public double? TongTienDoAn { get => tongTienDoAn; set => tongTienDoAn = value; }

        // Thêm phương thức tính ThoiGianDaSuDung cho phiên đang chạy
        public TimeSpan? CalculateCurrentThoiGianDaSuDung()
        {
            if (TimeBatDau.HasValue && !TimeKetThuc.HasValue)
            {
                return DateTime.Now - TimeBatDau.Value;
            }
            return ThoiGianDaSuDung; // Trả về giá trị đã tính nếu phiên đã kết thúc
        }
    }
}