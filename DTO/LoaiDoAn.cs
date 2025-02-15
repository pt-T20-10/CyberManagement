using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DTO
{
    public class LoaiDoAn
    {
        private int idLoai;
        private string tenLoai;

        public LoaiDoAn(int idloai , string tenLoai) 
        {
            this.idLoai = idloai;
            this.tenLoai = tenLoai;
        }
        public LoaiDoAn(DataRow row)
        {
            this.idLoai = (int)row["IDLoai"];
            this.tenLoai = row["TenLoai"].ToString();
        }
        public int IdLoai { get => idLoai; set => idLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
    }
}
