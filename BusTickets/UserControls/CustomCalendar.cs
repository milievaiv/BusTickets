using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace DesktopCalendar
{
    public partial class CustomCalendar : UserControl
    {
        private List<String> months = new List<String> { "Януари", "Февруари", "Март", "Април", "Май", "Юни", "Юли", "Август", "Септември", "Октомври", "Ноември", "Декември" };
        private TableDates _calendar;
        private int _selectedMonth;
        public List<List<object>> dbs = new List<List<object>>();

        public int SelectedMonth
        {
            get { return _selectedMonth; }
        }

        public int SelectedYear
        {
            get { return int.Parse(YearButton.Text); }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        public CustomCalendar()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //Math.A
            PreviousMonthButton.Enabled = false;
            PreviousYearButton.Enabled = false;
            _calendar = new TableDates();
            _calendar.Dock = DockStyle.Fill;
            //_calendar.DisplayDays(DateTime.Now);
            YearButton.Text = DateTime.Now.Year.ToString();
            _selectedMonth = DateTime.Now.Month;
            RefreshCalendar(int.Parse(YearButton.Text), _selectedMonth);
            MonthButton.Text = months[_selectedMonth - 1].ToString();
            _calendar.Name = "calendar";
            panel2.Controls.Add(_calendar);
            string v = _calendar.Controls[0].Name;
            foreach (DayBlank day in _calendar.Controls[0].Controls.OfType<DayBlank>())
            {
                List<object> list = new List<object>();
                list.Add(day.Name);
                list.Add(day.BackColor);
                dbs.Add(list);
            }
        }

        public void ClearDays()
        {
            for (int i = 41; i >= 0; i--)
            {
                _calendar.Controls[0].Controls[i].Enabled = true;
            }
        }
        public void PreviousDays()
        {
            for (int i = _calendar.Controls[0].Controls.Count - 8; i >= 0; i--)
            {
                if ((_calendar.Controls[0].Controls[i] as DayBlank).DB_Date.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy"))
                {
                    for (int j = i + 1; j <= 41; j++)
                    {
                        _calendar.Controls[0].Controls[j].Enabled = false;
                    }
                    break;
                }
            }
        }

        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            if (_selectedMonth != 12)
            {
                MonthButton.Text = months[_selectedMonth];
                _selectedMonth++;
                PreviousMonthButton.Enabled = true;
                //PreviousYearButton.Enabled = true;
            }
            else
            {
                _selectedMonth = 1;
                MonthButton.Text = months[_selectedMonth - 1];
            }
            RefreshCalendar(int.Parse(YearButton.Text), _selectedMonth);
            ClearDays();
            PreviousDays();
        }

        private void PreviousMonthButton_Click(object sender, EventArgs e)
        {
            if (_selectedMonth != 1)
            {
                _selectedMonth--;
                MonthButton.Text = months[_selectedMonth - 1];
            }
            else
            {
                _selectedMonth = 12;
                MonthButton.Text = months[_selectedMonth - 1];
            }
            if (_selectedMonth == DateTime.Now.Month && YearButton.Text == DateTime.Now.Year.ToString())
            {
                PreviousMonthButton.Enabled = false;
            }
            RefreshCalendar(int.Parse(YearButton.Text), _selectedMonth);
            ClearDays();
            PreviousDays();
        }

        public void RefreshCalendar(int year, int month)
        {
            var date = new DateTime(year, month, 1);
            _calendar.DisplayDays(date);
        }

        private void PreviousYearButton_Click(object sender, EventArgs e)
        {
            if ((int.Parse(YearButton.Text) - 1) > DateTime.Now.Year)
            {
                YearButton.Text = (int.Parse(YearButton.Text) - 1).ToString();
                PreviousMonthButton.Enabled = true;
                RefreshCalendar(int.Parse(YearButton.Text), _selectedMonth);
            }
            else if ((int.Parse(YearButton.Text) - 1) == DateTime.Now.Year && _selectedMonth > DateTime.Now.Month)
            {
                YearButton.Text = (int.Parse(YearButton.Text) - 1).ToString();
                PreviousYearButton.Enabled = false;
                PreviousMonthButton.Enabled = true;
                RefreshCalendar(int.Parse(YearButton.Text), _selectedMonth);
            }
            else if ((int.Parse(YearButton.Text) - 1) == DateTime.Now.Year && _selectedMonth == DateTime.Now.Month)
            {
                YearButton.Text = (int.Parse(YearButton.Text) - 1).ToString();
                PreviousYearButton.Enabled = false;
                PreviousMonthButton.Enabled = false;
                RefreshCalendar(int.Parse(YearButton.Text), _selectedMonth);
            }
            else if ((int.Parse(YearButton.Text) - 1) == DateTime.Now.Year && _selectedMonth < DateTime.Now.Month)
            {
                YearButton.Text = (int.Parse(YearButton.Text) - 1).ToString();
                MonthButton.Text = months[DateTime.Now.Month - 1].ToString();
                PreviousMonthButton.Enabled = false;
                PreviousYearButton.Enabled = false;
                RefreshCalendar(int.Parse(YearButton.Text), DateTime.Now.Month);
            }
        }

        private void NextYearButton_Click(object sender, EventArgs e)
        {
            YearButton.Text = (int.Parse(YearButton.Text) + 1).ToString();
            RefreshCalendar(int.Parse(YearButton.Text), _selectedMonth);
            PreviousYearButton.Enabled = true;
            PreviousMonthButton.Enabled = true;
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            //DoubleBuffered = true;
        }

        private void PreviousMonthButton_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void PreviousYearButton_EnabledChanged(object sender, EventArgs e)
        {

        }
    }
}