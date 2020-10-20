using System;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateTime();
        }

        private void UpdateTime()
        {
            DateTime now = DateTime.Now;
            int presentHour = now.Hour;
            string hourLabel = "AM";
            if (now.Hour > 12)
            {
                presentHour = now.Hour % 12;
                hourLabel = "PM";
            }
            timeLabel.Text = $"{presentHour:D2} : {now.Minute:D2} : {now.Second:d2} {hourLabel}";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }
    }
}
