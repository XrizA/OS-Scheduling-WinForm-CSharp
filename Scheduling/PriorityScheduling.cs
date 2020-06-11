using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Scheduling
{
    /// <summary>
    /// 優先權排程(Priority Scheduling, PS)
    /// </summary>
    class PriorityScheduling
    {
        #region 物件
        private static Panel main;
        private static Label SchedulingLabel;
        private static Label CPUStormTimeLabel;
        private static Label PriorityLabel;
        private static Label ArrivalTimeLabel;
        private static Label[] SchedulingName;
        private static TextBox[] CPUStormTime;
        private static TextBox[] Priority;
        private static TextBox[] ArrivalTime;
        #endregion

        #region PS初始化
        /// <summary>
        /// PS初始化
        /// </summary>
        /// <param name="controls">在哪個視窗加入物件</param>
        /// <param name="count">要加入多少物件</param>
        public static void Initialize(ControlCollection controls,
            int count)
        {
            if (main == null)
            {
                main = new Panel()
                {
                    Name = "main",
                    Width = 480,
                    Height = 190,
                    Location = new Point(15, 120),
                    BorderStyle = BorderStyle.Fixed3D,
                };
                controls.Add(main);
                SchedulingLabel = new Label()
                {
                    Text = "行程",
                    Font = new Font("Consolas", 12, FontStyle.Bold),
                    Location = new Point(0, 0),
                    AutoSize = true
                };
                CPUStormTimeLabel = new Label()
                {
                    Text = "CPU暴衝時間(毫秒)",
                    Font = new Font("Consolas", 12, FontStyle.Bold),
                    Location = new Point(60, 0),
                    AutoSize = true,
                };
                ArrivalTimeLabel = new Label()
                {
                    Text = "抵達時間",
                    Font = new Font("Consolas", 12, FontStyle.Bold),
                    Location = new Point(270, 0),
                    AutoSize = true,
                };
                PriorityLabel = new Label()
                {
                    Text = "優先權",
                    Font = new Font("Consolas", 12, FontStyle.Bold),
                    Location = new Point(380, 0),
                    AutoSize = true
                };
            }

            main.Controls.Clear();

            SchedulingName = new Label[count];
            CPUStormTime = new TextBox[count];
            Priority = new TextBox[count];
            ArrivalTime = new TextBox[count];
            for (int i = 0; i < count; i++)
            {
                SchedulingName[i] = new Label
                {
                    Width = 60,
                    Text = Convert.ToChar(('A' + i)).ToString(),
                    Font = new Font("Consolas", 12, FontStyle.Bold),
                    Location = new Point(0, 25 + i * 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                CPUStormTime[i] = new TextBox
                {
                    Width = 190,
                    Location = new Point(65, 25 + i * 30),
                    Text = "0",
                    Font = new Font("Consolas", 12, FontStyle.Bold),
                    TextAlign = HorizontalAlignment.Center
                };
                ArrivalTime[i] = new TextBox
                {
                    Width = 90,
                    Location = new Point(275, 25 + i * 30),
                    Text = "0",
                    Font = new Font("Consolas", 12, FontStyle.Bold),
                    TextAlign = HorizontalAlignment.Center
                };
                Priority[i] = new TextBox
                {
                    Width = 70,
                    Location = new Point(385, 25 + i * 30),
                    Text = "0",
                    Font = new Font("Consolas", 12, FontStyle.Bold),
                    TextAlign = HorizontalAlignment.Center
                };
                main.Controls.Add(SchedulingLabel);
                main.Controls.Add(CPUStormTimeLabel);
                main.Controls.Add(ArrivalTimeLabel);
                main.Controls.Add(PriorityLabel);                
                main.Controls.AddRange(SchedulingName);
                main.Controls.AddRange(CPUStormTime);
                main.Controls.AddRange(ArrivalTime);
                main.Controls.AddRange(Priority);
            }
        }
        #endregion

        #region 移除PriorityScheduling的Panel
        /// <summary>
        /// 移除PriorityScheduling的Panel
        /// </summary>
        /// <param name="controls">在哪個視窗移除Panel</param>
        public static void Remove(ControlCollection controls)
        {
            if (SchedulingLabel == null) return;
            SchedulingLabel.Dispose();
            CPUStormTimeLabel.Dispose();
            PriorityLabel.Dispose();
            foreach (var Label in SchedulingName) Label.Dispose();
            foreach (var TextBox in CPUStormTime) TextBox.Dispose();
            foreach (var TextBox in Priority) TextBox.Dispose();
            main?.Dispose(); main = null;
            controls.RemoveByKey("main");
        }
        #endregion
    }
}
