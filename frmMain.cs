using CyberManagementProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberManagementProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void timerToggle_Tick(object sender, EventArgs e)
        {
            if (Utilize.isCollapsed)
            {
                pnlLeft.Width += 10; // Mở rộng
                if (pnlLeft.Width >= Utilize.sidebarExpandedWidth)
                {
                    pnlLeft.Width = Utilize.sidebarExpandedWidth; // Đặt giá trị tối đa
                    timerToggle.Stop(); // Dừng Timer
                    Utilize.isCollapsed = false; // Cập nhật trạng thái
                }
            }
            else
            {
                pnlLeft.Width -= 10; // Thu hẹp
                if (pnlLeft.Width <= Utilize.sidebarCollapsedWidth)
                {
                    pnlLeft.Width = Utilize.sidebarCollapsedWidth; // Đặt giá trị tối thiểu
                    timerToggle.Stop(); // Dừng Timer
                    Utilize.isCollapsed = true; // Cập nhật trạng thái
                }
            }
        }

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            timerToggle.Start();
        }
    }
}