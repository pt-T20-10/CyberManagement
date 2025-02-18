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
        private double tienNap;
        private int timeLeft;

        public TKKhachHangDTO(string userName , float tienNap , int timeleft) 
        {
            this.userName = userName;
            this.tienNap = tienNap;
            this.timeLeft = timeleft;
        }
        public TKKhachHangDTO(DataRow row)
        {
            this.userName = row["TKKhachHang"].ToString();
            this.TienNap = (float)Convert.ToDouble(row["TienNap"]);
            this.timeLeft = (int)row["ThoiGianSuDung"];
        }

        public string UserName { get => userName; set => userName = value; }
        public double TienNap { get => tienNap; set => tienNap = value; }
        public int TimeLeft { get => timeLeft; set => timeLeft = value; }
    }
}
