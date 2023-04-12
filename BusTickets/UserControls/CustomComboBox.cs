using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BusTickets.UserControls
{
    public partial class CustomComboBox : UserControl
    {
        bool clicked = false;
        List<string> Points = new List<string>();
        SQLConnection connection = new SQLConnection();
        public CustomComboBox(List<string> _Points)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            myTextBox1.Size = new Size(myTextBox1.Width, 70);
            myTextBox1.Padding = new Padding(15);
            panel2.Controls.Add(myTextBox1);
            Points = _Points;
        }

        public List<string> points
        {
            get { return Points; }
        }

        public CustomComboBox()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            myTextBox1.Size = new Size(myTextBox1.Width, 70);
            myTextBox1.Padding = new Padding(15);
            panel2.Controls.Add(myTextBox1);
        }

        public void Clear()
        {
            for (int i = panel1.Controls.Count - 1; i >= 0; i--)
            {
               //panel1.Controls[i].Click += button_Click;
                panel1.Controls[i].Text = "";
            }
            //myTextBox1._TextChanged += MTB_TextChanged;
        }

        public void Fill(List<string> items)
        {
            Points = items;
            items.Sort();
            for (int i = panel1.Controls.Count - 1; i >= 0; i--)
            {
                //panel1.Controls[i].Click += button_Click;
                panel1.Controls[i].Text = Points[i];
            }
            myTextBox1._TextChanged += MTB_TextChanged;
        }
        private void CustomComboBox_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width, pictureBox1.Height + 2);
            //if (Points.Count < 0)
            //{
            //    for (int i = panel1.Controls.Count - 1; i >= 0; i--)
            //    {
            //        //panel1.Controls[i].Click += button_Click;
            //        panel1.Controls[i].Text = Points[i];
            //    }
            //    myTextBox1._TextChanged += MTB_TextChanged;
            //}
        }

        private void MyTextBox1__TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                this.Size = new Size(panel1.Width, (panel1.Controls[0].Height * panel1.Controls.Count) + pictureBox1.Height + 2);
                clicked = true;
                if (myTextBox1.Texts == "Изберете град")
                {
                    MyTextBox1.Texts = "";
                }
            }
            else if (clicked == true)
            {
                this.Size = new Size(this.Width, pictureBox1.Height + 2);
                clicked = false;
                if (myTextBox1.Texts == "")
                {
                    MyTextBox1.Texts = "Изберете град";
                }
            }
        }

        private void MTB_TextChanged(object sender, EventArgs e)
        {
            foreach (Button bt in panel1.Controls)
            {
                bt.Text = "";
            }
            int but_num = 0;
            foreach (string item in Points)
            {
                if (item.Contains(myTextBox1.Texts) && myTextBox1.Texts != "" && but_num < panel1.Controls.Count)
                {
                    panel1.Controls[but_num].Text = item;
                    but_num++;
                }
                else if (myTextBox1.Texts == "" && but_num < panel1.Controls.Count)
                {
                    panel1.Controls[but_num].Text = item;
                    but_num++;
                }
            }
        }

        private void CustomComboBox_EnabledChanged(object sender, EventArgs e)
        {
            if(this.Enabled == false)
            {
                myTextBox1.BackColor = Color.LightGray;
            }
            else
            {
                myTextBox1.BackColor = SystemColors.Window;
            }
        }

        private void myTextBox1_Click(object sender, EventArgs e)
        {
            if (myTextBox1.Texts == "Изберете град")
            {
                myTextBox1.Texts = "";
            }
        }
    }
}
