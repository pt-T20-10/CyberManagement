using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DTO
{
    public class UngDungDTO
    {
        public int ID { get; set; }
        public string TenUngDung { get; set; }
        public int LoaiUngDungID { get; set; }
        public string MoTa { get; set; }
        public string DuongDan { get; set; }

        public UngDungDTO(int id, string tenUngDung, int loaiUngDungID, string moTa, string duongDan)
        {
            this.ID = id;
            this.TenUngDung = tenUngDung;
            this.LoaiUngDungID = loaiUngDungID;
            this.MoTa = moTa;
            this.DuongDan = duongDan;
        }

        public UngDungDTO(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"]);
            this.TenUngDung = row["TenUngDung"].ToString();
            this.LoaiUngDungID = Convert.ToInt32(row["LoaiUngDungID"]);
            this.MoTa = row["MoTa"] != DBNull.Value ? row["MoTa"].ToString() : null;
            this.DuongDan = row["DuongDan"] != DBNull.Value ? row["DuongDan"].ToString() : null;
        }
    }
}
