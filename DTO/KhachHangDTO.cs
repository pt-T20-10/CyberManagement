    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DTO
{
    public class KhachHangDTO
    {
        public KhachHangDTO(int ID, string TKKhachHang, string NhomKhach, string Ten, string DiaChi, string SoDT, string Email)
        {
            this.ID = ID;
            this.TKKhachHang = TKKhachHang;
            this.NhomKhach = NhomKhach;
            this.Ten = Ten;
            this.DiaChi = DiaChi;
            this.SoDT = SoDT;
            this.Email = Email;
        }

        public KhachHangDTO() { }


        public KhachHangDTO(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TKKhachHang = row["TKKhachHang"].ToString();
            this.NhomKhach = row["NhomKhach"].ToString();
            this.Ten = row["Ten"].ToString(); 
            this.DiaChi = row["DiaChi"].ToString(); 
            this.SoDT = row["SoDT"].ToString(); 
            this.Email = row["Email"].ToString(); 
        }


        private string tKKhachHang;

        public string TKKhachHang
        {
            get { return tKKhachHang; }
            set { tKKhachHang = value; }
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string nhomKhach;
        public string NhomKhach
        {
            get { return nhomKhach; }
            set { nhomKhach = value; }
        }

        public string ten;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string soDT;
        public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }

        public string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
