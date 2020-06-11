using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region FCFS, SRT, PS, RR
enum SortMethod
{
    FirstComeFirstServeSchedulingSort,
    ShortestRemainingTimeSchedulingSort,
    PrioritySchedulingSort,
    RoundRobinSchedulingSort
}
#endregion

namespace Scheduling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int PrevTemporary = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = numericUpDown1.Visible = true;
            numericUpDown1.Value = 0;
            button1.Visible = button2.Visible = TurnaroundTimeLabel.Visible = WaitTimeLabel.Visible = TurnaroundTimeTextBox.Visible = WaitTimeTextBox.Visible = false;
            TurnaroundTimeTextBox.ResetText(); WaitTimeTextBox.ResetText();
            DrawBox.Image = null;

            switch (Enum.Parse(typeof(SortMethod), PrevTemporary.ToString()))
            {
                case SortMethod.FirstComeFirstServeSchedulingSort:
                    FirstComeFirstServeScheduling.Remove(Controls);
                    break;
                case SortMethod.ShortestRemainingTimeSchedulingSort:
                    ShortestRemainingTimeScheduling.Remove(Controls);
                    break;
                case SortMethod.PrioritySchedulingSort:
                    PriorityScheduling.Remove(Controls);
                    break;
                case SortMethod.RoundRobinSchedulingSort:

                    break;
            }

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int count = (int)numericUpDown1.Value;
            int select = comboBox1.SelectedIndex;
            TurnaroundTimeTextBox.ResetText(); WaitTimeTextBox.ResetText();
            DrawBox.Image = null;
            if (PrevTemporary != select)
            {
                switch (Enum.Parse(typeof(SortMethod), PrevTemporary.ToString()))
                {
                    case SortMethod.FirstComeFirstServeSchedulingSort:
                        FirstComeFirstServeScheduling.Remove(Controls);
                        break;
                    case SortMethod.ShortestRemainingTimeSchedulingSort:
                        ShortestRemainingTimeScheduling.Remove(Controls);
                        break;
                    case SortMethod.PrioritySchedulingSort:
                        PriorityScheduling.Remove(Controls);
                        break;
                    case SortMethod.RoundRobinSchedulingSort:

                        break;
                }
            }

            if (count != 0) button1.Visible = button2.Visible = TurnaroundTimeLabel.Visible = WaitTimeLabel.Visible = TurnaroundTimeTextBox.Visible = WaitTimeTextBox.Visible = true;
            else button1.Visible = button2.Visible = TurnaroundTimeLabel.Visible = WaitTimeLabel.Visible = TurnaroundTimeTextBox.Visible = WaitTimeTextBox.Visible = false;

            switch (Enum.Parse(typeof(SortMethod), select.ToString()))
            {
                case SortMethod.FirstComeFirstServeSchedulingSort:
                    FirstComeFirstServeScheduling.Initialize(Controls, count);
                    break;
                case SortMethod.ShortestRemainingTimeSchedulingSort:
                    ShortestRemainingTimeScheduling.Initialize(Controls, count);
                    break;
                case SortMethod.PrioritySchedulingSort:
                    PriorityScheduling.Initialize(Controls, count);
                    break;
                case SortMethod.RoundRobinSchedulingSort:

                    break;
            }

            PrevTemporary = select;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Enum.Parse(typeof(SortMethod), comboBox1.SelectedIndex.ToString()))
            {
                case SortMethod.FirstComeFirstServeSchedulingSort:
                    DrawBox.Image = FirstComeFirstServeScheduling.CalcFCFS(
                        TurnaroundTimeTextBox, WaitTimeTextBox);
                    break;
                case SortMethod.ShortestRemainingTimeSchedulingSort:
                    DrawBox.Image = ShortestRemainingTimeScheduling.CalcSRT(
                        TurnaroundTimeTextBox, WaitTimeTextBox);
                    break;
                case SortMethod.PrioritySchedulingSort:

                    break;
                case SortMethod.RoundRobinSchedulingSort:
                    
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (Enum.Parse(typeof(SortMethod), comboBox1.SelectedIndex.ToString()))
            {
                case SortMethod.FirstComeFirstServeSchedulingSort:
                    DrawBox.Image = FirstComeFirstServeScheduling.RandomCalcFCFS
                        (TurnaroundTimeTextBox, WaitTimeTextBox);
                    break;
                case SortMethod.ShortestRemainingTimeSchedulingSort:
                    ShortestRemainingTimeScheduling.CalcSRT
                        (TurnaroundTimeTextBox, WaitTimeTextBox);
                    break;
                case SortMethod.PrioritySchedulingSort:

                    break;
                case SortMethod.RoundRobinSchedulingSort:

                    break;
            }
        }
    }
}
