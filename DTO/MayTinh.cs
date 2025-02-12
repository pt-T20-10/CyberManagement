using System;
using System.Collections.Generic;
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
        private string trangThaiMay;
        private string ghiChuMay = " ";

        public MayTinh(int id,string tenmay, double banggia, string status, string note) 
        {
            this.iDMayTinh = id;
            this.tenMay = tenmay;
            this.bangGia = banggia;
            this.trangThaiMay = status;
            this.ghiChuMay = note;  
        }


        public int IDMayTinh { get => iDMayTinh; set => iDMayTinh = value; }
        public string TenMay { get => tenMay; set => tenMay = value; }
        public double BangGia { get => bangGia; set => bangGia = value; }
        public string TrangThaiMay { get => trangThaiMay; set => trangThaiMay = value; }
        public string GhiChuMay { get => ghiChuMay; set => ghiChuMay = value; }

    }
}
