using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTickets.UserControls
{
    public class DoubleBufferedLabel : Label
    {
        public DoubleBufferedLabel()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Redraw the panel contents
            base.OnPaint(e);
        }
    }
}
