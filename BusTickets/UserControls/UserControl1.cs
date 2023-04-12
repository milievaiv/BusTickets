using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTickets.UserControls
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        VScrollBar vScrollBar1 = new VScrollBar();
        private void UserControl1_Load(object sender, EventArgs e)
        {
            doubleBufferedPanel1.Dock = DockStyle.Fill;
            doubleBufferedPanel1.AutoScroll = false;
            this.Controls.Add(doubleBufferedPanel1);

            // Create a VScrollBar control and add it to the panel
            VScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.LargeChange = 30;
            vScrollBar1.Width = 30;
            doubleBufferedPanel1.Controls.Add(vScrollBar1);

            // Create some labels and add them to the panel
            for (int i = 0; i < 50; i++)
            {
                DoubleBufferedLabel label = new DoubleBufferedLabel();
                label.AutoSize = false;
                //label.TextAlign = ContentAlignment.MiddleLeft;
                label.Size = new Size(200, 50);
                label.Text = "Label " + i;
                label.Top = i * label.Height;
                doubleBufferedPanel1.Controls.Add(label);
            }

            // Add a SizeChanged event handler to the panel
            doubleBufferedPanel1.SizeChanged += new EventHandler(doubleBufferedPanel1_SizeChanged);

            // Add a Scroll event handler to the VScrollBar control
            vScrollBar1.Scroll += new ScrollEventHandler(vScrollBar1_Scroll);

        }

        private void doubleBufferedPanel1_SizeChanged(object sender, EventArgs e)
        {
            // Calculate the total height of all the controls inside the panel
            int totalHeight = doubleBufferedPanel1.Controls.Cast<Control>().Sum(c => c.Height) + vScrollBar1.Height;

            // Set the maximum value of the VScrollBar control
            vScrollBar1.Maximum = totalHeight - doubleBufferedPanel1.Height;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Adjust the Top property of each control inside the panel based on the value of the scrollbar
            foreach (Control control in doubleBufferedPanel1.Controls)
            {
                control.Top = control.Top + e.OldValue - e.NewValue;
            }
        }
    }
}
