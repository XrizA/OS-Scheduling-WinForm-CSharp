using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling
{
    class EventManagement
    {
        #region 字型
        public static Font font = new Font("Consolas", 12, FontStyle.Bold);
        #endregion
        #region 只能輸入數字事件
        protected static void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt32(e.KeyChar);
            if (key == 8) return;
            if (key < 48 || key > 57) e.Handled = true;
        }
        #endregion
    }
}
