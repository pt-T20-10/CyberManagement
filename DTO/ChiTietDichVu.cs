using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DTO
{
    public class ChiTietDichVu
    {
        private int iDChiTiet;
        private int iDPhien;
        private int iDDoAn;
        private int soLuong;
        private float tongTien;

        public ChiTietDichVu(int IdChiTiet , int IdPhien , int IdDoAn , int soluong , int tongtien)
        {
            this.iDChiTiet = IdChiTiet;
            this.iDPhien = IdPhien;
            this.iDDoAn = IdDoAn;
            this.soLuong = soluong;
            this.tongTien = tongtien;
        }
        public ChiTietDichVu(DataRow row)
        {
            this. iDChiTiet = (int)row["IDChiTiet"];
            this.iDPhien = (int)row["IDPhien"];
            this.iDDoAn = (int)row["IDDoAn"];
            this.soLuong = (int)row["SoLuong"];
            this.tongTien = (float)row["TongTien"];

        }


        public int IDChiTiet { get => IDChiTiet; set => IDChiTiet = value; }
        public int IDDoAn { get => iDDoAn; set => iDDoAn = value; }
        public int IDPhien { get => iDPhien; set => iDPhien = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
