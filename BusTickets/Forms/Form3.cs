using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace BusTickets.Forms
{

    public partial class Form3 : Form
    {
        public int count = 0;
        private string company;
        private string price;
        private string first_trip;
        private string second_trip;
        private string routes;
        private List<string> bus_info;
        private int bus_id;
        private VScrollBar mainScrollBar;
        private Panel scrollPanel;
        private int SubPanelHeight = 1056;
        SQLConnection sql = new SQLConnection();


        public Form3(string company, string price, string first_trip, string second_trip, string bus_id)
        {
            this.bus_id = int.Parse(bus_id);
            this.company = company;
            this.price = price;
            this.first_trip = first_trip;
            this.second_trip = second_trip;
            //FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            string order = bus_id + " " + company + " " + price + " " + first_trip + " " + second_trip;
        }
        public Form3(string company, string price, string first_trip, string bus_id)
        {
            this.bus_id = int.Parse(bus_id);
            this.company = company;
            this.price = price;
            this.first_trip = first_trip;
            //FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            string order = bus_id + " " + company + "\n " + price + " " + first_trip;
            //listBox1.Items.Add(order);
        }
        public Form3(string company, string price, string first_trip, string second_trip, List<string> bus_info)
        {
            this.company = company;
            this.price = price;
            this.first_trip = first_trip;
            this.second_trip = second_trip;
            this.bus_info = bus_info;
            //FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            string order = $"{company} \n {price} \n {first_trip} - {second_trip} \n {bus_info[0]} - {bus_info[1]} \n {bus_info[2]} - {bus_info[3]}";
            //listBox1.Items.Add(order);
        }
        public Form3(string company, string price, string first_trip, List<string> bus_info)
        {
            this.company = company;
            this.price = price;
            this.first_trip = first_trip;
            this.bus_info = bus_info;
            InitializeComponent();
        }

        private void NewOrder(string company, string price, string first_trip, string second_trip, string bus_id)
        {
            this.company = company;
            this.price = price;
            this.first_trip = first_trip;
            this.second_trip = second_trip;
            this.bus_id = int.Parse(bus_id);
        }

        private void NewOrder(string company, string price, string first_trip, string bus_id)
        {
            this.company = company;
            this.price = price;
            this.first_trip = first_trip;
            this.bus_id = int.Parse(bus_id);
        }

        private void NewOrder(string company, string price, string first_trip, string second_trip, List<string> bus_info)
        {
            this.company = company;
            this.price = price;
            this.first_trip = first_trip;
            this.second_trip = second_trip;
            this.bus_info = bus_info;
        }
        private void NewOrder(string company, string price, string first_trip, List<string> bus_info)
        {
            this.company = company;
            this.price = price;
            this.first_trip = first_trip;
            this.bus_info = bus_info;
        }

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            panel3.Height = this.Height;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           panel3, new object[] { true });
            SubPanelHeight = this.Height;
            mainScrollBar = new VScrollBar()
            {
                Width = 100,
                Minimum = 0,
                Value = 0,
                SmallChange = SubPanelHeight,
                Parent = panel3,
                Dock = DockStyle.Right,
            };

            scrollPanel = new Panel()
            {
                Left = 0,
                Top = 0,
                Width = panel3.Width - SystemInformation.VerticalScrollBarWidth,
                Height = SubPanelHeight,
                Parent = panel3,
            };
            mainScrollBar.Scroll += mainScrollBar_Scroll;
            ResetScrollbar();
            label5.Text = label5.Text + " " + bus_id;
            WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            button1.Location = new Point((panel2.Width - button1.Width) / 2, button1.Location.Y);
            panel2.Location = new Point(100, (this.ClientSize.Height - panel2.Height) / 2 - 50);
            string order = $" Компания: \n {company} Цена на билет: {price} \n По маршрут: {bus}\n Час на отпътуване: \n Дата: ";
            Label lbl_order = new Label();
            lbl_order.Parent = scrollPanel;
            lbl_order.Size = new Size(panel3.Width, 300);
            lbl_order.Location = new Point(panel3.Location.X, panel3.Height - 300);
            lbl_order.Font = new Font("Roboto", 30);
            lbl_order.Text = order;
            lbl_order.Dock = DockStyle.Top;
            lbl_order.BorderStyle = BorderStyle.FixedSingle;
            lbl_order.TextAlign = ContentAlignment.MiddleLeft;
            lbl_order.Padding = new Padding(20);
            lbl_order.BackColor = System.Drawing.Color.LightGray;
        }

        private void mainScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            scrollPanel.Top = -e.NewValue;
        }
        private void ResetScrollbar()
        {
            mainScrollBar.Maximum = SubPanelHeight - 1;
            mainScrollBar.LargeChange = panel3.Height;
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

        private void myTextBox1_Click(object sender, EventArgs e)
        {
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.FileName = "osk.exe";
            //startInfo.Verb = "runas"; // Run the process with elevated privileges
            ////startInfo.UseShellExecute = false;
            //Process process = new Process();
            //process.StartInfo = startInfo;
            //process.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.InsertTO(myTextBox1.Texts, myTextBox2.Texts, myTextBox3.Texts, bus_id);
            this.Hide();

            //this.Hide();
            //Form2 form2 = new Form2();
            //form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            var lbx = sender as System.Windows.Forms.ListBox;
            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            using (var bgBrush = new SolidBrush(isItemSelected ? System.Drawing.Color.LightGray : lbx.BackColor))
            using (var itemBrush = isItemSelected ? new SolidBrush(lbx.ForeColor) : new SolidBrush(System.Drawing.Color.LightGray))
            {
                string itemText = lbx.GetItemText(lbx.Items[e.Index]);
                SizeF textSize = e.Graphics.MeasureString(itemText, e.Font);
                float x = e.Bounds.Left;
                float y = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
                e.Graphics.DrawString(itemText, e.Font, itemBrush, x, y);
            }
            e.DrawFocusRectangle();
        }
    }

}
