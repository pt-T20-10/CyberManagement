using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DTO
{
    public class TKKhachHangDTO
    {
        private string userName;
        private decimal? tienNap;         // Tổng tiền đã nạp (TienNap)
        private decimal? tienConLai;      // Số tiền còn lại (TienConLai)
       

        public TKKhachHangDTO(string userName, decimal? tienNap,  decimal? tienConLai)
        {
            this.UserName = userName;
            this.TienNap = tienNap;
           
            this.TienConLai = tienConLai;
        }

        public TKKhachHangDTO(DataRow row)
        {
            // Kiểm tra và gán giá trị cho UserName
            this.UserName = row["TKKhachHang"].ToString();

            // Kiểm tra DBNull cho TienNap, nếu NULL thì gán 0.0
            this.TienNap = row["TienNap"] == DBNull.Value ? 0.0M : Convert.ToDecimal(row["TienNap"]);

            // Kiểm tra DBNull cho TienConLai, nếu NULL thì gán 0.0
            this.TienConLai = row["TienConLai"] == DBNull.Value ? 0.0M : Convert.ToDecimal(row["TienConLai"]);

      
        }

        public string UserName
        {
            get => userName;
            set => userName = value;
        }

        public decimal? TienNap
        {
            get => tienNap;
            set => tienNap = value;
        }

        public decimal? TienConLai
        {
            get => tienConLai;
            set => tienConLai = value;
        }

    }
}