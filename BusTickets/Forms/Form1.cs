using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTickets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Controls.Add(pictureBox2);
            //pictureBox2.Location = new Point(560, 350);
            WindowState = FormWindowState.Maximized;
            panel1.Location = new Point((this.ClientSize.Width - panel1.Width) / 2, (this.ClientSize.Height - panel1.Height) / 2);
            pictureBox1.Parent = panel1;
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
