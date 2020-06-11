using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Scheduling
{
    static class DrawingSort
    {
        static Graphics graphics;
        static Bitmap bitmap = new Bitmap(770, 70);
        const int SIZE = 40;
        public static Image DrawStart(List<double> CPU, List<string>
            schedulingname)
        {
            graphics = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Red, 5);
            Font font = new Font("consols", 9, FontStyle.Bold);
            graphics.Clear(Color.White);
            int hair = bitmap.Width / 2;
            if (CPU.Count > 7) hair -= 18 * (CPU.Count + 1);
            else hair -= 20 * (CPU.Count % 8 + 1);

            Rectangle[] rects = new Rectangle[CPU.Count];
            int i; Point xy;
            for (i = 0; i < CPU.Count - 1; i++)
            {
                var x = Convert.ToInt32(CPU[i]);
                xy = new Point(hair + SIZE * i, 10);
                var Size = new Size(SIZE, SIZE);
                rects[i] = new Rectangle(xy, Size);
                if (x < 10) xy.Offset(-5, 40);
                else xy.Offset(-9, 40);
                graphics.DrawString(x.ToString(), font , pen.Brush, xy);
                if (x < 10) xy.Offset(15, -30);
                else xy.Offset(19, -30);
                if (schedulingname[i] != "空")
                {
                    var sch = int.Parse(schedulingname[i].Replace("P", " "));
                    if (sch >= 10) xy.X -= 5;
                }
                graphics.DrawString(schedulingname[i], font, pen.Brush, xy);
            }
            xy = new Point(hair + SIZE * i, 30);
            xy.Offset(-7, 20);
            graphics.DrawString(CPU[i].ToString(), font , pen.Brush, xy);
            graphics.DrawRectangles(pen, rects);

            return bitmap;
        }
    }
}
