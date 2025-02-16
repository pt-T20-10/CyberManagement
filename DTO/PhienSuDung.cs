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
        private double? tongTienNap;
        private double? tongTienDoAn;

        public PhienSuDung(int idPhien, string tkKhacHang, int idMayTinh , DateTime? timeBatDau , DateTime? timeKetThuc)
        {
            this.iDPhien = idPhien;
            this.TKKhachHang = tkKhacHang;
            this.iDMayTinh = idMayTinh; 
            this.TimeBatDau = timeBatDau;
        }
        public PhienSuDung(DataRow row)
        {
            this.iDPhien = (int)row["IDPhien"];
            this.TKKhachHang = row["TKKhachHang"].ToString();
            this.iDMayTinh = (int)row["IDMayTinh"];
            this.timeBatDau = (DateTime?)row["ThoiGianBatDau"];
            var dateCheckOutTemp = row["ThoiGianKetThuc"];
            if (dateCheckOutTemp.ToString() != "")
            {
                this.timeKetThuc = (DateTime?)dateCheckOutTemp;
            }
            this.TongTienNap = Convert.ToDouble(row["TongTienNap"]);
            this.TongTienDoAn = Convert.ToDouble(row["TongTienDoAn"]);
        }

        public int IDPhien { get => iDPhien; set => iDPhien = value; }
       
        public int IDMayTinh { get => iDMayTinh; set => iDMayTinh = value; }
        public DateTime? TimeBatDau { get => timeBatDau; set => timeBatDau = value; }
        public DateTime? TimeKetThuc { get => timeKetThuc; set => timeKetThuc = value; }
        public double? TongTienNap { get => tongTienNap; set => tongTienNap = value; }
        public double? TongTienDoAn { get => tongTienDoAn; set => tongTienDoAn = value; }
        public string TKKhachHang { get => tKKhachHang; set => tKKhachHang = value; }
    }
}
