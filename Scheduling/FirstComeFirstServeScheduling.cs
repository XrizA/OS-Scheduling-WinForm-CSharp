using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Scheduling
{
    /// <summary>
    /// 先到先做排程(First-Come First-Serve, FCFS)
    /// </summary>
    class FirstComeFirstServeScheduling : EventManagement
    {
        #region 物件
        private static Panel main;
        private static Label SchedulingLabel;
        private static Label CPUBurstTimeLabel;
        private static Label ArrivalTimeLabel;
        private static Label[] SchedulingName;
        private static TextBox[] CPUBurstTime;
        private static TextBox[] ArrivalTime;
        #endregion

        #region FCFS初始化
        /// <summary>
        /// FCFS初始化
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
                    Width = 400,
                    Height = 190,
                    Location = new Point(15, 120),
                    BorderStyle = BorderStyle.Fixed3D,
                    AutoScroll = true
                };
                controls.Add(main);
                SchedulingLabel = new Label()
                {
                    Text = "行程",
                    Font = font,
                    Location = new Point(0, 0),
                    AutoSize = true
                };
                CPUBurstTimeLabel = new Label()
                {
                    Text = "CPU暴衝時間(毫秒)",
                    Font = font,
                    Location = new Point(60, 0),
                    AutoSize = true
                };
                ArrivalTimeLabel = new Label()
                {
                    Text = "到達時間",
                    Font = font,
                    Location = new Point(270, 0),
                    AutoSize = true
                };
            }

            main.Controls.Clear();

            SchedulingName = new Label[count];
            CPUBurstTime = new TextBox[count];
            ArrivalTime = new TextBox[count];
            for (int i = 0; i < count; i++)
            {
                SchedulingName[i] = new Label
                {
                    Width = 60,
                    Text = $"P{i + 1}",
                    Font = font,
                    Location = new Point(0, 25 + i * 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                CPUBurstTime[i] = new TextBox
                {
                    Width = 190,
                    Text = (i + 1).ToString(),
                    Font = font,
                    Location = new Point(65, 25 + i * 30),
                    TextAlign = HorizontalAlignment.Center
                };
                CPUBurstTime[i].KeyPress += new KeyPressEventHandler(Input_KeyPress);
                ArrivalTime[i] = new TextBox
                {
                    Width = 90,
                    Location = new Point(275, 25 + i * 30),
                    Text = (i + 2).ToString(),
                    Font = font,
                    TextAlign = HorizontalAlignment.Center
                };
                ArrivalTime[i].KeyPress += new KeyPressEventHandler(Input_KeyPress);
            }
            main.Controls.Add(SchedulingLabel);
            main.Controls.Add(CPUBurstTimeLabel);
            main.Controls.Add(ArrivalTimeLabel);
            main.Controls.AddRange(SchedulingName);
            main.Controls.AddRange(CPUBurstTime);
            main.Controls.AddRange(ArrivalTime);
        }
        #endregion

        #region 移除FirstComeFirstServerScheduling的Panel
        /// <summary>
        /// 移除FirstComeFirstServerScheduling的Panel
        /// </summary>
        /// <param name="controls">在哪個視窗移除Panel</param>
        public static void Remove(ControlCollection controls)
        {
            if (SchedulingLabel == null) return;
            SchedulingLabel.Dispose();
            CPUBurstTimeLabel.Dispose();
            ArrivalTimeLabel.Dispose();
            foreach (var Label in SchedulingName) Label.Dispose();
            foreach (var TextBox in CPUBurstTime) TextBox.Dispose();
            foreach (var TextBox in ArrivalTime) TextBox.Dispose();
            main?.Dispose(); main = null;
            controls.RemoveByKey("main");
        }
        #endregion

        #region 亂數產生值後計算FCFS
        public static Image RandomCalcFCFS(TextBox turnaroundtime, TextBox waittime)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < CPUBurstTime.Count(); i++)
            {
                CPUBurstTime[i].Text = random.Next(1, 100).ToString();
                ArrivalTime[i].Text = random.Next(0, 100).ToString();
            }
            return CalcFCFS(turnaroundtime, waittime);
        }
        #endregion

        #region 計算完後繪圖
        public static Image CalcFCFS(TextBox turnaroundtime, TextBox waittime)
        {
            var SchedulingNameList = new List<string>();
            var CPUList = new List<double> { 0.0 };

            var arrivalList = ArrivalTime.Select(s => double.Parse(s.Text)).ToList();
            var at = arrivalList.OrderBy(sort => sort).ToList();

            var CPUBurstTimeList = CPUBurstTime.Select(textbox => 
            double.Parse(textbox.Text)).ToList();

            var TurnaroundTime = 0.0;
            var WaitTime = 0.0;
            var TotalTime = 0.0;
            turnaroundtime.Text = "( ";
            waittime.Text = "( ";

            var index = 0;

            for (int i = 0; i < arrivalList.Count; i++)
            {
                index = arrivalList.FindIndex(value => value == at[i]);
                if (index == -1) continue;
                while (CPUBurstTimeList[index] == 0)
                    index = arrivalList.FindIndex(index + 1, value => value == at[i]);
                    

                if (TotalTime < arrivalList[index])
                {
                    SchedulingNameList.Add("空");
                    TotalTime = arrivalList[index];
                    CPUList.Add(TotalTime);
                }

                SchedulingNameList.Add(SchedulingName[index].Text);
                TotalTime += CPUBurstTimeList[index];
                var tt = TotalTime - arrivalList[index];
                TurnaroundTime += tt;
                turnaroundtime.AppendText($"{tt} + ");
                var wt = TotalTime - arrivalList[index] - CPUBurstTimeList[index];
                WaitTime += wt;
                waittime.AppendText($"{wt} + ");
                CPUList.Add(TotalTime);
                CPUBurstTimeList[index] = 0;
            }
            turnaroundtime.Text = turnaroundtime.Text.TrimEnd(new char[] { ' ', '+' });
            waittime.Text = waittime.Text.TrimEnd(new char[] { ' ', '+' });
            turnaroundtime.AppendText($" ) / {SchedulingName.Length} = {TurnaroundTime / SchedulingName.Length}");
            waittime.AppendText($" ) / {SchedulingName.Length} = {WaitTime / SchedulingName.Length}");

            return DrawingSort.DrawStart(CPUList, SchedulingNameList);
        }
        #endregion
    }
}
