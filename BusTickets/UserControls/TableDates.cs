using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopCalendar
{
    public partial class TableDates : UserControl
    {
        private readonly Color HOLIDAY_COLOR = Color.FromArgb(85, 238, 82, 83);
        private readonly Color DAY_COLOR = Color.FromArgb(85, 246, 242, 242);
        private readonly Color PREVIOUS_MONTH_DAY_COLOR = Color.FromArgb(35, 34, 47, 62);
        private readonly Color PREVIOUS_DAY= Color.FromArgb(35, 34, 47, 62);
        private Color TODAY = Color.FromArgb(222, 255, 159, 67);
        
        public TableDates()
        {
            InitializeComponent();

        }

        //public string SelectedDate
        //{
        //    get { return selectedDate; }
        //    set
        //    {
        //        Day
        //    }
        //}

        public void DisplayDays(DateTime date)
        {
            var now = date;
            var previousMonth = date.AddMonths(-1);

            var startOfTheMonth = new DateTime(now.Year, now.Month, 1);

            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int previousMonthDays = DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);


            //Checks if the first day of the week is Sunday (Sunday is considered the 7th day in many calendars)
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) == 0
                ? 7
                : Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            //Check if the last day of the week is Sunday
            dayOfTheWeek = dayOfTheWeek == 1 ? 8 : dayOfTheWeek;
            //Remember the days from previous month
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                (tableLayoutPanel1.Controls[42 - i] as DayBlank).Refresh(PREVIOUS_MONTH_DAY_COLOR,
                    (previousMonthDays - dayOfTheWeek + i + 1),
                    new DateTime(previousMonth.Year, previousMonth.Month, (previousMonthDays - dayOfTheWeek + i + 1)),
                    Color.LightGray);
                //(tableLayoutPanel1.Controls[42 - i] as DayBlank).Enabled = false;
                //dbs[i].Add(new List<object>() { PREVIOUS_MONTH_DAY_COLOR, (tableLayoutPanel1.Controls[42 - i] as DayBlank)});
            }
            //Remember the days from current month
            for (int i = 0; i < days; i++)
            {
                //if (42 - i - dayOfTheWeek < DateTime.Now.Day)
                //{
                //    (tableLayoutPanel1.Controls[42 - i - dayOfTheWeek] as DayBlank).Refresh(PREVIOUS_DAY,
                //        i + 1,
                //       new DateTime(now.Year, now.Month, 42 - i - dayOfTheWeek),
                //        Color.LightGray);
                //    (tableLayoutPanel1.Controls[42 - i - dayOfTheWeek] as DayBlank).Enabled = false;
                //}
                if ((42 - i - dayOfTheWeek) % 7 == 0 || (42 - i - dayOfTheWeek - 1) % 7 == 0)
                {
                    (tableLayoutPanel1.Controls[42 - i - dayOfTheWeek] as DayBlank).Refresh(HOLIDAY_COLOR,
                        i + 1,
                        new DateTime(now.Year, now.Month, i + 1),
                        Color.Azure);

                }
                else
                {
                    (tableLayoutPanel1.Controls[42 - i - dayOfTheWeek] as DayBlank).Refresh(DAY_COLOR,
                        i + 1,
                        new DateTime(now.Year, now.Month, i + 1),
                        Color.Azure);

                }
            }

            //Remember the days from the next month
            int otherDays = 42 - days - dayOfTheWeek;
            for (int i = otherDays; i >= 0; i--)
            {
                (tableLayoutPanel1.Controls[i] as DayBlank).Refresh(PREVIOUS_MONTH_DAY_COLOR,
                    otherDays - i + 1,
                    new DateTime(now.AddMonths(1).Year, now.AddMonths(1).Month, otherDays - i + 1),
                    Color.LightGray);
            }
            //for (int i = this.Controls.Count - 8; i >= 0; i--)
            //{   
            //    for (int j = i + 1; j <= 42; j++)
            //    {
            //        this.Controls[j].Enabled = false;
            //    }
            //    break;
            //}
        }

        private void CustomCalendar_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;

        }

    }
}
