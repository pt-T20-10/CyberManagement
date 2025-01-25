using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DTO
{
    public class AddNewNhanVienDTO
    {
        public AddNewNhanVienDTO(string TKNhanVien, string MKNhanVien)
        {
            this.TKNhanVien = TKNhanVien;
            this.MKNhanVien = MKNhanVien;
        }

        public AddNewNhanVienDTO() { }

        public AddNewNhanVienDTO(DataRow row)
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
