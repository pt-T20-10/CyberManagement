using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DTO
{
    public class TKNhanVienDTO
    {
        public TKNhanVienDTO(string TKNhanVien, string MKNhanVien)
        {
            this.TKNhanVien = TKNhanVien;
            this.MKNhanVien = MKNhanVien;
        }
        public TKNhanVienDTO() { }

        public TKNhanVienDTO(DataRow row)
        {
            this.TKNhanVien = row["TKNhanVien"].ToString();
            this.MKNhanVien = row["MKNhanVien"].ToString();
        }

        private string tKNhanVien;
        public string TKNhanVien
        {
            get { return tKNhanVien; }
            set { tKNhanVien = value; }
        }

        private string mKNhanVien;
        public string MKNhanVien
        {
            get { return mKNhanVien; }
            set { mKNhanVien = value; }
        }
    }
}
