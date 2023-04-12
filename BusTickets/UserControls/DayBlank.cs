using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using BusTickets;

namespace DesktopCalendar
{
    public partial class DayBlank : UserControl
    {
        private DateTime _currentDate;
        private Color _backColor;
        bool button2_enabled = false;

        public DateTime DB_Date
        {
            get { return _currentDate; }
        }

        public Color BackColor_C
        {
            get { return _backColor; }
        }
        public DayBlank()
        {
            InitializeComponent();
            DoubleBuffered = true;

        }

        public void Refresh(Color backColor, int day, DateTime date, Color foreColor)
        {
            DoubleBuffered = true;
            BackColor = _backColor = backColor;
            dayNumber.Text = day.ToString();
            _currentDate = date;
            if (_currentDate.ToShortDateString() == DateTime.Now.ToShortDateString())
            {
                BackColor = Color.FromArgb(222, 255, 159, 67);
            }

            dayNumber.ForeColor = Color.Black;
            _backColor = BackColor;        
        }

        private void DayBlank_Load(object sender, EventArgs e)
        {
            new List<Control> { dayNumber , this}.ForEach(x =>
            {
                x.MouseEnter += DayBlank_MouseEnter;
                x.MouseLeave += DayBlank_MouseLeave;
            });
        }

        private void DayBlank_MouseLeave(object sender, EventArgs e)
        {
            if (!ClientRectangle.Contains(PointToClient(MousePosition)) && this.BackColor != Color.Red)
            {
                BackColor = _backColor;                             
            }
        }

        private void DayBlank_MouseEnter(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Red)
            {
                BackColor = Color.FromArgb(123, _backColor);
            }
        }

        private void dayNumber_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
