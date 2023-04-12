using System.Drawing;
using System.Windows.Forms;

namespace DesktopCalendar
{
    partial class CustomCalendar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public System.Windows.Forms.TableLayoutPanel Calendar_C
        {
            get { return (TableLayoutPanel)_calendar.Controls[0]; }
        }

        public Button previousYearButton
        {
            get { return PreviousYearButton; }
        }

        public Button nextYearButton
        {
            get { return NextYearButton; }
        }

        public Button previousMonthButton
        {
            get { return PreviousMonthButton; }
        }

        public Button nextMonthButton
        {
            get { return NextMonthButton; }
        }
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.NextYearButton = new System.Windows.Forms.Button();
            this.PreviousYearButton = new System.Windows.Forms.Button();
            this.YearButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MonthButton = new System.Windows.Forms.Button();
            this.PreviousMonthButton = new System.Windows.Forms.Button();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 334);
            this.panel2.TabIndex = 1;
            // 
            // NextYearButton
            // 
            this.NextYearButton.BackColor = System.Drawing.Color.RosyBrown;
            this.NextYearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextYearButton.FlatAppearance.BorderSize = 0;
            this.NextYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextYearButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextYearButton.Location = new System.Drawing.Point(516, 0);
            this.NextYearButton.Name = "NextYearButton";
            this.NextYearButton.Size = new System.Drawing.Size(75, 76);
            this.NextYearButton.TabIndex = 6;
            this.NextYearButton.Text = ">>";
            this.NextYearButton.UseVisualStyleBackColor = false;
            this.NextYearButton.Click += new System.EventHandler(this.NextYearButton_Click);
            // 
            // PreviousYearButton
            // 
            this.PreviousYearButton.BackColor = System.Drawing.Color.RosyBrown;
            this.PreviousYearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviousYearButton.FlatAppearance.BorderSize = 0;
            this.PreviousYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousYearButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousYearButton.Location = new System.Drawing.Point(0, 0);
            this.PreviousYearButton.Name = "PreviousYearButton";
            this.PreviousYearButton.Size = new System.Drawing.Size(75, 76);
            this.PreviousYearButton.TabIndex = 7;
            this.PreviousYearButton.Text = "<<";
            this.PreviousYearButton.UseVisualStyleBackColor = false;
            this.PreviousYearButton.EnabledChanged += new System.EventHandler(this.PreviousYearButton_EnabledChanged);
            this.PreviousYearButton.Click += new System.EventHandler(this.PreviousYearButton_Click);
            // 
            // YearButton
            // 
            this.YearButton.BackColor = System.Drawing.Color.RosyBrown;
            this.YearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearButton.FlatAppearance.BorderSize = 0;
            this.YearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearButton.Location = new System.Drawing.Point(75, 0);
            this.YearButton.Name = "YearButton";
            this.YearButton.Size = new System.Drawing.Size(441, 76);
            this.YearButton.TabIndex = 8;
            this.YearButton.Text = "ГОДИНА";
            this.YearButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.YearButton);
            this.panel1.Controls.Add(this.PreviousYearButton);
            this.panel1.Controls.Add(this.NextYearButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 76);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MonthButton);
            this.panel3.Controls.Add(this.PreviousMonthButton);
            this.panel3.Controls.Add(this.NextMonthButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 76);
            this.panel3.TabIndex = 3;
            // 
            // MonthButton
            // 
            this.MonthButton.BackColor = System.Drawing.Color.RosyBrown;
            this.MonthButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthButton.FlatAppearance.BorderSize = 0;
            this.MonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthButton.Location = new System.Drawing.Point(75, 0);
            this.MonthButton.Name = "MonthButton";
            this.MonthButton.Size = new System.Drawing.Size(441, 76);
            this.MonthButton.TabIndex = 11;
            this.MonthButton.Text = "МЕСЕЦ";
            this.MonthButton.UseVisualStyleBackColor = false;
            // 
            // PreviousMonthButton
            // 
            this.PreviousMonthButton.BackColor = System.Drawing.Color.RosyBrown;
            this.PreviousMonthButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviousMonthButton.FlatAppearance.BorderSize = 0;
            this.PreviousMonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousMonthButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousMonthButton.Location = new System.Drawing.Point(0, 0);
            this.PreviousMonthButton.Name = "PreviousMonthButton";
            this.PreviousMonthButton.Size = new System.Drawing.Size(75, 76);
            this.PreviousMonthButton.TabIndex = 10;
            this.PreviousMonthButton.Text = "<<";
            this.PreviousMonthButton.UseVisualStyleBackColor = false;
            this.PreviousMonthButton.EnabledChanged += new System.EventHandler(this.PreviousMonthButton_EnabledChanged);
            this.PreviousMonthButton.Click += new System.EventHandler(this.PreviousMonthButton_Click);
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.BackColor = System.Drawing.Color.RosyBrown;
            this.NextMonthButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextMonthButton.FlatAppearance.BorderSize = 0;
            this.NextMonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextMonthButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextMonthButton.Location = new System.Drawing.Point(516, 0);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(75, 76);
            this.NextMonthButton.TabIndex = 9;
            this.NextMonthButton.Text = ">>";
            this.NextMonthButton.UseVisualStyleBackColor = false;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // CustomCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomCalendar";
            this.Size = new System.Drawing.Size(591, 486);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NextYearButton;
        private System.Windows.Forms.Button PreviousYearButton;
        private System.Windows.Forms.Button YearButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button PreviousMonthButton;
        private System.Windows.Forms.Button NextMonthButton;
        private System.Windows.Forms.Button MonthButton;
        public System.Windows.Forms.Button _MonthButton
        {
            get 
            { 
                return MonthButton; 
            }
            set
            {
                MonthButton = value;
            }
        }
    }
}
