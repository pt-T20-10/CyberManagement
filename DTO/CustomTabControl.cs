using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CyberManagementProject.DTO
{
  

    public class CustomTabControl : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            // Ẩn phần tabs bằng cách chặn vẽ
            if (m.Msg == 0x1328) // TCN_FIRST + 20: Xử lý vẽ tab
            {
                m.Result = (IntPtr)1;
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
