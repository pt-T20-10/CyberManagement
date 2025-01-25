using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DTO
{
    public class NhanVienDTO
    {
        public NhanVienDTO(int ID, string TKNhanVien, string TenChucVu, string Ten, string TenBoPhan, string KieuLam,
                            string DiaChi, string SoDT, string Email, string CCCD, string GioiTinh, string TonGiao, 
                            string NgaySinh, string NgayVao, string NgayRa)
        {
            this.ID = ID;
            this.TKNhanVien = TKNhanVien;
            this.TenChucVu = TenChucVu;
            this.Ten = Ten; 
            this.TenBoPhan = TenBoPhan;
            this.KieuLam = KieuLam;
            this.DiaChi = DiaChi;
            this.SoDT = SoDT;
            this.Email = Email;
            this.CCCD = CCCD;
            this.GioiTinh = GioiTinh;
            this.TonGiao = TonGiao;
            this.NgaySinh = NgaySinh;
            this.NgayVao = NgayVao;
            this.NgayRa = NgayRa;
        }

        public NhanVienDTO() { }


        public NhanVienDTO(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TKNhanVien = row["TKNhanVien"].ToString();
            this.TenChucVu = row["TenChucVu"].ToString();
            this.TenBoPhan = row["TenBoPhan"].ToString();
            this.Ten = row["Ten"].ToString();
            this.KieuLam = row["KieuLam"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SoDT = row["SoDT"].ToString();
            this.Email = row["Email"].ToString();
            this.CCCD = row["CCCD"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.TonGiao = row["TonGiao"].ToString();
            this.NgaySinh = row["NgaySinh"].ToString();
            this.NgayVao = row["NgayVao"].ToString();
            this.NgayRa = row["NgayRa"].ToString();
        }



        private string tKNhanVien;

        public string TKNhanVien
        {
            get { return tKNhanVien; }
            set { tKNhanVien = value; }
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string tenChucVu;
        public string TenChucVu
        {
            get { return tenChucVu; }
            set { tenChucVu = value; }
        }

        private string ten;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        private string tenBoPhan;
        public string TenBoPhan
        {
            get { return tenBoPhan; }
            set { tenBoPhan = value; }
        }

        public static object Instance { get; internal set; }

        private string kieuLam;
        public string KieuLam
        {
            get { return kieuLam; }
            set { kieuLam = value; }
        }

        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string soDT;
        public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string cCCD;
        public string CCCD
        {
            get { return cCCD; }
            set { cCCD = value; }
        }
        private string gioiTinh;
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private string tonGiao;
        public string TonGiao
        {
            get { return tonGiao; }
            set { tonGiao = value; }
        }

        private string ngaySinh;
        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string ngayVao;
        public string NgayVao
        {
            get { return ngayVao; }
            set { ngayVao = value; }
        }
        private string ngayRa;
        public string NgayRa
        {
            get { return ngayRa; }
            set { ngayRa = value; }
        }
    }
}
