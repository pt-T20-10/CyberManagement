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
        private int iDKhachHang;
        private int iDMayTinh;
        private DateTime? timeBatDau;
        private DateTime? timeKetThuc;
        private float? tongTien;

        public PhienSuDung(int idPhien, int idKhacHang, int idMayTinh , DateTime? timeBatDau , DateTime? timeKetThuc)
        {
            this.iDPhien = idPhien;
            this.iDKhachHang = idKhacHang;
            this.iDMayTinh = idMayTinh; 
            this.TimeBatDau = timeBatDau;
        }
        public PhienSuDung(DataRow row)
        {
            this.iDPhien = (int)row["IDPhien"];
            this.iDKhachHang = (int)row["IDKhachHang"];
            this.iDMayTinh = (int)row["IDMayTinh"];
            this.timeBatDau = (DateTime?)row["ThoiGianBatDau"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
            {
                this.timeKetThuc = (DateTime?)dateCheckOutTemp;
            }
        }

        public int IDPhien { get => iDPhien; set => iDPhien = value; }
        public int IDKhachHang { get => iDKhachHang; set => iDKhachHang = value; }
        public int IDMayTinh { get => iDMayTinh; set => iDMayTinh = value; }
        public DateTime? TimeBatDau { get => timeBatDau; set => timeBatDau = value; }
        public DateTime? TimeKetThuc { get => timeKetThuc; set => timeKetThuc = value; }
        public float? TongTien { get => tongTien; set => tongTien = value; }
    }
}
