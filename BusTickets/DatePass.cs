using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTickets
{
    public class DatePass
    {
        private static string selectedDate = "";
        public static string SelectedString
        {
            get 
            {
                return selectedDate; 
            }
            set
            {
                selectedDate = value;
            }
        }
        public void GetSelectedDate(string _selectedDate)
        {
            selectedDate = _selectedDate;
        }

        public string ReturnSelectedDate()
        {
            return SelectedString;
        }
    }
}
