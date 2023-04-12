﻿namespace BusTickets.UserControls
{
    partial class CustomComboBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// 
        
        public System.Windows.Forms.Panel Panel1
        {
            get { return panel1; }
        }

        public BusTickets.MyTextBox MyTextBox1
        {
            get { return myTextBox1; }
        }

        public System.Windows.Forms.PictureBox PictureBox1
        {
            get { return pictureBox1; }
        }
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.myTextBox1 = new BusTickets.MyTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.myTextBox1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 77);
            this.panel2.TabIndex = 1;
            // 
            // myTextBox1
            // 
            this.myTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.myTextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.myTextBox1.BorderFocusColor = System.Drawing.Color.Black;
            this.myTextBox1.BorderSize = 2;
            this.myTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTextBox1.Font = new System.Drawing.Font("Roboto Lt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.myTextBox1.Location = new System.Drawing.Point(0, 0);
            this.myTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.myTextBox1.Multiline = false;
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.myTextBox1.PasswordChar = false;
            this.myTextBox1.Size = new System.Drawing.Size(412, 59);
            this.myTextBox1.TabIndex = 2;
            this.myTextBox1.Texts = "";
            this.myTextBox1.UnderlinedStyle = false;
            this.myTextBox1.Click += new System.EventHandler(this.myTextBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BusTickets.Properties.Resources.free_arrow_down_icon_3101_thumb;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(412, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 395);
            this.panel1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, -3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(501, 79);
            this.button5.TabIndex = 4;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(501, 79);
            this.button4.TabIndex = 3;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(501, 80);
            this.button3.TabIndex = 2;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(501, 80);
            this.button2.TabIndex = 1;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(501, 80);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CustomComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "CustomComboBox";
            this.Size = new System.Drawing.Size(501, 472);
            this.Load += new System.EventHandler(this.CustomComboBox_Load);
            this.EnabledChanged += new System.EventHandler(this.CustomComboBox_EnabledChanged);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private MyTextBox myTextBox1;
        private System.Windows.Forms.Button button5;
    }
}
