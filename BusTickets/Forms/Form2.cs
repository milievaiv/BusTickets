using BusTickets.Forms;
using BusTickets.UserControls;
using DesktopCalendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;

namespace BusTickets
{
    public partial class Form2 : Form
    {
        List<Control[]> lbl_button;
        private int last_state = 0;
        private int last_state2 = 0;
        private bool example = true;
        private bool one_way = false;
        List<string> s_point = new List<string>();
        List<string> e_point = new List<string>();
        private DayBlank SPselectedDayblank;
        SQLConnection sql = new SQLConnection();
        private DayBlank EPselectedDayblank;
        private string clicked_item;
        private int SubPanelHeight = 1056;
        private VScrollBar mainScrollBar;
        private Panel scrollPanel;
        private Panel p;
        public Form2()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           panel3, new object[] { true });

            mainScrollBar = new VScrollBar()
            {
                //Left = -200,
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

            p = new Panel()
            {
                Parent = scrollPanel,
                Left = 0,
                Top = 0 * SubPanelHeight,
                Width = scrollPanel.Width,
                Height = SubPanelHeight,
                Text = "Sub Panel",
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Transparent,
                Tag = 0,
            };

            int _x = 39;
            customComboBox1.Location = new Point(_x, 67);
            panel1.Location = new Point(_x, 160);
            pictureBox1.Location = new Point(_x, 266);
            customComboBox2.Location = new Point(_x, 361);
            panel2.Location = new Point(_x, 454);
            button3.Location = new Point(149, 582);
            customComboBox1.Parent = p;
            panel1.Parent = p;
            customComboBox2.Parent = p;
            panel2.Parent = p;
            pictureBox1.Parent = p;
            //button1.Parent = p;
            //button2.Parent = p;
            button3.Parent = p;
            //button.Click += Button_Click;
            Resize += Form3_Resize;
            mainScrollBar.Scroll += mainScrollBar_Scroll;
            ResetScrollbar();
            mainScrollBar.Hide();
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            ResetScrollbar();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            SubPanelHeight = 1000;
            //this.Height = 200;
            ResetScrollbar();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            button1.Text = "";
            //this.MaximizeBox = false;
            customComboBox2.Enabled = true;
            sql.Search_SP(s_point);
            customComboBox1.Fill(s_point);
            button2.Enabled = false;
            customComboBox1.TabStop = false;
            foreach (Button bt in customComboBox1.Panel1.Controls)
            {
                bt.Click += button_Click;
            }
            foreach (Button bt in customComboBox2.Panel1.Controls)
            {
                bt.Click += button2_Click;
            }
            button2.Text = "";
            userControl11.Hide();
            userControl12.Hide();
            DoubleBuffered = true;
            this.ActiveControl = null;
            for(int i = 41; i >= 0; i--)
            {
                if (userControl11.Calendar_C.Controls[i] is DayBlank && userControl12.Calendar_C.Controls[i] is DayBlank)
                {
                    userControl11.Calendar_C.Controls[i].Click += SPDayBlankControl_MouseClick;
                    userControl12.Calendar_C.Controls[i].Click += EPDayBlankControl_MouseClick;

                }
            }
            userControl12.previousYearButton.Click += PreviousYear_MouseClick;
            userControl12.nextYearButton.Click += NextYear_MouseClick;
            userControl12.previousMonthButton.Click += PreviousMonth_MouseClick;
            userControl12.nextMonthButton.Click += NextMonth_MouseClick;
            customComboBox1.MyTextBox1._TextChanged += MTB_TextChanged;
            userControl11.PreviousDays();
            List<Label[]> arr = new List<Label[]>();
            //sql.SearchRPC(arr, "Sofia", "Silistra", true, "14.06.2022");
            button1.Enabled = false;
            customComboBox1.MyTextBox1.Texts = "Изберете град";
            customComboBox2.MyTextBox1.Texts = "Изберете град";
            customComboBox1.MyTextBox1.Enter += RemoveText;
            customComboBox1.MyTextBox1.Leave += AddText;
            button3.Location = new Point(button3.Location.X, customComboBox2.Location.Y + customComboBox2.Height * 3);
        }
        public void RemoveText(object sender, EventArgs e)
        {
            if (customComboBox1.MyTextBox1.Texts == "Изберете град")
            {
                customComboBox1.MyTextBox1.Texts = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customComboBox1.MyTextBox1.Texts) && clicked_item == "")
                customComboBox1.MyTextBox1.Texts = "Изберете град";
        }

        private void MTB_TextChanged(object sender, EventArgs e)
        {
            foreach (Button bt in customComboBox1.Controls[0].Controls)
            {
                bt.Text = "";
            }
            int but_num = 0;
            foreach (string item in customComboBox1.points)
            {
                if (item.Contains(customComboBox1.MyTextBox1.Texts) && customComboBox1.MyTextBox1.Texts != "" && but_num < customComboBox1.Controls[0].Controls.Count)
                {
                    customComboBox1.Controls[0].Controls[but_num].Text = item;
                    but_num++;
                }
                else if (customComboBox1.MyTextBox1.Texts == "" && but_num < customComboBox1.Controls[0].Controls.Count)
                {
                    customComboBox1.Controls[0].Controls[but_num].Text = item;
                    but_num++;
                }
            }
            //button1.Enabled = true;
            button1.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }
        private void DayBlank_DefaultEv(CustomCalendar customCalendar, DayBlank db, Label lb, bool sp)
        {

        }

        private void EPDayBlankControl_MouseClick(object sender, EventArgs e)
        {
            DayBlank _db = sender as DayBlank;
            EPselectedDayblank = _db;
            Label _lb = sender as Label;
            string _selectedDate = _db.DB_Date.ToString("d MMMM yyyy");
            this.button2.Text = _selectedDate;
            //Use this if you want to disable every other date before the selected one
            //for (int i = this.Parent.Controls.Count-8; i >= 0; i--)
            //{
            //    if ((this.Parent.Controls[i] as DayBlank) == tdb_clicked || (dn_clicked != null && (this.Parent.Controls[i] as DayBlank) == dn_clicked.Parent))
            //    {
            //        for (int j = i + 1; j <= 42; j++)
            //        {
            //                this.Parent.Controls[j].Enabled = false;
            //        }
            //        break;
            //    }
            //}
        }

        private void PreviousYear_MouseClick(object sender, EventArgs e)
        {
        }

        private void NextYear_MouseClick(object sender, EventArgs e)
        {
        }

        private void PreviousMonth_MouseClick(object sender, EventArgs e)
        {
            for (int i = userControl12.Calendar_C.Controls.Count - 8; i >= 0; i--)
            {
                if ((userControl11.Calendar_C.Controls[i] as DayBlank).DB_Date.ToString("d MMMM yyyy") == SPselectedDayblank.DB_Date.ToString("d MMMM yyyy"))
                {
                    if (userControl11._MonthButton.Text == userControl12._MonthButton.Text)
                    {
                        for (int j = i + 1; j <= 41; j++)
                        {
                            userControl12.Calendar_C.Controls[j].Enabled = false;
                        }
                    }
                    else if (DateTime.ParseExact(userControl12._MonthButton.Text, "MMMM", new CultureInfo("bg-BG")).Month > SPselectedDayblank.DB_Date.Month)
                    {
                        for (int j = 41; j >= 0; j--)
                        {
                            userControl12.Calendar_C.Controls[j].Enabled = true;
                        }
                    }
                    else if (DateTime.ParseExact(userControl12._MonthButton.Text, "MMMM", new CultureInfo("bg-BG")).Month < SPselectedDayblank.DB_Date.Month)
                    {
                        for (int j = 41; j >= 0; j--)
                        {
                            userControl12.Calendar_C.Controls[j].Enabled = false;
                        }
                    }
                    break;
                }
            }

        }

        private void NextMonth_MouseClick(object sender, EventArgs e)
        {
            for (int i = userControl12.Calendar_C.Controls.Count - 8; i >= 0; i--)
            {
                if ((userControl11.Calendar_C.Controls[i] as DayBlank).DB_Date.ToString("d MMMM yyyy") == SPselectedDayblank.DB_Date.ToString("d MMMM yyyy"))
                {
                    if (userControl11._MonthButton.Text == userControl12._MonthButton.Text)
                    {
                        for (int j = i + 1; j <= 41; j++)
                        {
                            userControl12.Calendar_C.Controls[j].Enabled = false;
                        }
                    }
                    else if (DateTime.ParseExact(userControl12._MonthButton.Text, "MMMM", new CultureInfo("bg-BG")).Month > SPselectedDayblank.DB_Date.Month)
                    {
                        for (int j = 41; j >= 0; j--)
                        {
                            userControl12.Calendar_C.Controls[j].Enabled = true;
                        }
                    }
                    else if (DateTime.ParseExact(userControl12._MonthButton.Text, "MMMM", new CultureInfo("bg-BG")).Month < SPselectedDayblank.DB_Date.Month)
                    {
                        for (int j = 41; j >= 0; j--)
                        {
                            userControl12.Calendar_C.Controls[j].Enabled = false;
                        }
                    }
                    break;
                }
            }
        }

        private void SPDayBlankControl_MouseClick(object sender, EventArgs e)
        {
            userControl12.ClearDays();
            DayBlank _db = sender as DayBlank;
            SPselectedDayblank = _db;
            Label _lb = sender as Label;
            string _selectedDate = _db.DB_Date.ToString("d MMMM yyyy");
            button1.Text = _selectedDate;
            button2.Text = _selectedDate;
            if (one_way == false)
            {
                button2.Enabled = true;
                customComboBox2.Enabled = true;
            }
            button1.Refresh();
            for (int i = userControl12.Calendar_C.Controls.Count - 8; i >= 0; i--)
            {
                if ((userControl11.Calendar_C.Controls[i] as DayBlank).DB_Date.ToString("d MMMM yyyy") == _selectedDate)
                {
                    if (userControl11._MonthButton.Text == userControl12._MonthButton.Text)
                    {
                        for (int j = i + 1; j <= 41; j++)
                        {
                            userControl12.Calendar_C.Controls[j].Enabled = false;
                        }
                    }
                    else if (DateTime.ParseExact(userControl12._MonthButton.Text, "MMMM", new CultureInfo("bg-BG")).Month > SPselectedDayblank.DB_Date.Month)
                    {
                        for (int j = 41; j >= 0; j--)
                        {
                            userControl12.Calendar_C.Controls[j].Enabled = true;
                        }
                    }
                    else if (DateTime.ParseExact(userControl12._MonthButton.Text, "MMMM", new CultureInfo("bg-BG")).Month < SPselectedDayblank.DB_Date.Month)
                    {
                        for (int j = 41; j >= 0; j--)
                        {
                            userControl12.Calendar_C.Controls[j].Enabled = false;
                        }
                    }
                    break;
                }          
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button_ = sender as Button;       
            List<string> SE_Result = new List<string>();
            SQLConnection sql = new SQLConnection();
            sql.SearchSE(SE_Result, button_.Text);
            customComboBox2.Clear();
            for (int i = 0; i < SE_Result.Count && i < customComboBox1.Panel1.Controls.Count; i++)
            {
                customComboBox2.Panel1.Controls[i].Text = SE_Result[i];
            }   
            customComboBox1.MyTextBox1.Texts = (sender as Button).Text;
            clicked_item = (sender as Button).Text;
            customComboBox2.MyTextBox1.Texts = customComboBox2.Panel1.Controls[0].Text;
            customComboBox1.Size = new Size(customComboBox1.Width, customComboBox1.PictureBox1.Height + 2);
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Button button_ = sender as Button;
            customComboBox2.MyTextBox1.Texts = (sender as Button).Text;
            customComboBox2.Size = new Size(customComboBox2.Width, customComboBox2.PictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (last_state == 0)
            {
                panel1.Height = button1.Height + userControl11.Height + 5;
                userControl11.Show();
                last_state = 1;
            }
            else if (last_state == 1)
            {
                panel1.Height = button1.Height + 5;
                userControl11.Hide();
                last_state = 0;
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (last_state2 == 0)
            {
                panel2.Height = button2.Height + userControl12.Height + 5;
                button3.Location = new Point(button3.Location.X, userControl12.Height + customComboBox2.Location.Y + customComboBox2.Height * 3);
                userControl12.Show();
                mainScrollBar.Show();
                last_state2 = 1;
                p.Height += 200;
                scrollPanel.Height += 200;
                SubPanelHeight += 200;
                ResetScrollbar();
            }
            else if (last_state2 == 1)
            {
                panel2.Height = button2.Height + 5;
                button3.Location = new Point(button3.Location.X, customComboBox2.Location.Y + customComboBox2.MyTextBox1.Height * 3);
                userControl12.Hide();
                mainScrollBar.Hide();
                last_state2 = 0;
                p.Height -= 200;
                scrollPanel.Height -= 200;
                SubPanelHeight -= 200;
                ResetScrollbar();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (one_way == false)
            {
                pictureBox1.BackgroundImage = BusTickets.Properties.Resources.uncheck;
                //customComboBox2.Hide();
                button2.Hide();
                one_way = true;
                button3.Location = new Point(button3.Location.X, customComboBox2.Location.Y + customComboBox2.Height + 30);
                button3.BringToFront();
                userControl12.SendToBack();
                customComboBox2.BringToFront();
                panel1.BringToFront();
                customComboBox1.BringToFront();

            }
            else
            {
                pictureBox1.BackgroundImage = BusTickets.Properties.Resources.check;
                customComboBox2.Show();
                button2.Show();
                one_way = false;
                button3.Location = new Point(button3.Location.X, customComboBox2.Location.Y + customComboBox2.MyTextBox1.Height * 3);
                //button3.BringToFront();
            }
        }

        private void customComboBox2_EnabledChanged(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void Search(string dp)
        {
            List<Label[]> labels = new List<Label[]>();
            List<int> buses_id = new List<int>();
            sql.SearchRPC(labels, customComboBox1.MyTextBox1.Texts, customComboBox2.MyTextBox1.Texts, one_way, dp);
            int x = panel4.Location.X + 40;
            int y = 0;
            int tmpx = x;
            panel4.Controls.Clear();
            lbl_button = new List<Control[]>();
            for (int i = 0; i < labels.Count; i++)
            {
                foreach (Label label in labels[i])
                {
                    label.AutoSize = true;
                    label.Visible = true;
                    label.Font = new Font("Century Gothic", 25);
                }
                if (labels[i].Length == 5)
                {
                    //
                    y = y + 40;
                    labels[i][0].Location = new Point(x, y);
                    panel4.Controls.Add(labels[i][0]);
                    labels[i][0].Refresh();
                    //
                    x = x + 100;
                    labels[i][1].Location = new Point(x, y);
                    panel4.Controls.Add(labels[i][1]);
                    labels[i][1].Refresh();
                    //
                    x = x + 100;
                    labels[i][2].Location = new Point(x, y);
                    panel4.Controls.Add(labels[i][2]);
                    labels[i][2].Refresh();
                    //
                    Button button = new Button();
                    button.Click += Reserve;
                    button.Font = new Font("Bahnschrift SemiLight", 10);
                    button.Text = "Резервирай";
                    button.FlatStyle = FlatStyle.Flat;
                    button.Location = new Point(x + 120, y);
                    button.Enabled = true;
                    button.AutoSize = false;
                    panel4.Controls.Add(button);
                    button.Refresh();
                    //
                    y = y + 30;
                    labels[i][3].Location = new Point(x, y);
                    panel4.Controls.Add(labels[i][3]);
                    labels[i][3].Refresh();
                    Control[] comb = new Control[6];
                    comb[0] = button;
                    comb[1] = labels[i][0];
                    comb[2] = labels[i][1];
                    comb[3] = labels[i][2];
                    comb[4] = labels[i][3];
                    comb[5] = labels[i][4];
                    lbl_button.Add(comb);
                }
                else
                {
                    //
                    y = y + 40;
                    labels[i][0].Location = new Point(x, y);
                    panel4.Controls.Add(labels[i][0]);
                    //
                    x = x + labels[i][0].Width + 100;
                    labels[i][1].Location = new Point(x, y);
                    panel4.Controls.Add(labels[i][1]);
                    //
                    x = x + labels[i][1].Width + 100;
                    labels[i][2].Location = new Point(x, y);
                    panel4.Controls.Add(labels[i][2]);
                    //
                    Button button = new Button();
                    button.Click += Reserve;
                    button.Font = new Font("Bahnschrift SemiBold", 25);
                    button.Text = "Резервирай";
                    button.FlatStyle = FlatStyle.Flat;
                    button.Location = new Point(x + labels[i][2].Width + 100, y);
                    button.Enabled = true;
                    button.AutoSize = false;
                    button.Size = new Size(360, 90);
                    panel4.Controls.Add(button);
                    button.Refresh();
                    Control[] comb = new Control[5];
                    comb[0] = button;
                    comb[1] = labels[i][0];
                    comb[2] = labels[i][1];
                    comb[3] = labels[i][2];
                    comb[4] = labels[i][3];
                    lbl_button.Add(comb);
                    labels[i][0].Location = new Point(labels[i][0].Location.X, button.Location.Y * 2);
                    labels[i][1].Location = new Point(labels[i][1].Location.X, button.Location.Y * 2);
                    labels[i][2].Location = new Point(labels[i][2].Location.X, button.Location.Y * 2);
                    labels[i][0].Refresh();
                    labels[i][1].Refresh();
                    labels[i][2].Refresh();
                }
                x = tmpx;
                y = y + 20;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (customComboBox1.MyTextBox1.Texts != "" && customComboBox1.MyTextBox1.Texts != "Изберете град" && customComboBox2.MyTextBox1.Texts != "" && customComboBox2.MyTextBox1.Texts != "Изберете град")
            { 
                string dp = "";
                if (one_way == true)
                {
                    if (SPselectedDayblank == null)
                    {
                        dp = DateTime.Now.ToString("dd.MM.yyyy");
                        Search(dp);

                    }
                    else
                    {
                        dp = SPselectedDayblank.DB_Date.ToString("dd.MM.yyyy");
                        Search(dp);

                    }
                }
                else 
                {
                    if (EPselectedDayblank == null && button2.Text != "")
                    {
                        dp = SPselectedDayblank.DB_Date.ToString("dd.MM.yyyy") + " - " + SPselectedDayblank.DB_Date.ToString("dd.MM.yyyy");
                        Search(dp);

                    }
                    else if (button2.Text != "")
                    {
                        dp = SPselectedDayblank.DB_Date.ToString("dd.MM.yyyy") + " - " + EPselectedDayblank.DB_Date.ToString("dd.MM.yyyy");
                        Search(dp);

                    }
                    else
                    {
                        MessageBox.Show("Моля изберете дата на връщане!");
                    }
                }
                
            }
        }

        private void Reserve(object sender, EventArgs e)
        {
            foreach (Control[] control in lbl_button)
            {
                if (control[0] == (Button)sender)
                {
                    if (control.Length == 6)
                    {
                        this.Hide();
                        List<string> bus_info = new List<string>() { customComboBox1.MyTextBox1.Texts, customComboBox2.MyTextBox1.Texts, button1.Text };
                        Form3 t_Orders = new Form3(control[1].Text, control[2].Text, control[3].Text, control[4].Text, bus_info);
                        t_Orders.Show();
                        break;
                    }
                    else
                    {
                        this.Hide();
                        List<string> bus_info = new List<string>() { customComboBox1.MyTextBox1.Texts, customComboBox2.MyTextBox1.Texts, button1.Text, button2.Text };
                        Form3 t_Orders = new Form3(control[1].Text, control[2].Text, control[3].Text, bus_info);
                        t_Orders.Show();
                        break;
                    }

                }
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            foreach (Control childControl in panel4.Controls)
            {
                childControl.Top = -e.NewValue;
            }
        }
    }
}
