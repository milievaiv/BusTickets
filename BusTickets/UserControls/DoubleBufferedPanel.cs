using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTickets.UserControls
{
    public class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Don't paint the background (avoids flickering)
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Redraw the panel contents
            base.OnPaint(e);
        }
    }
}
