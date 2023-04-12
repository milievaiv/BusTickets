namespace BusTickets.Forms
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.myTextBox1 = new BusTickets.MyTextBox();
            this.myTextBox3 = new BusTickets.MyTextBox();
            this.myTextBox2 = new BusTickets.MyTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1017);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.myTextBox1);
            this.panel2.Controls.Add(this.myTextBox3);
            this.panel2.Controls.Add(this.myTextBox2);
            this.panel2.Location = new System.Drawing.Point(168, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 723);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto Bk", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(4, 632);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3);
            this.button2.Size = new System.Drawing.Size(448, 76);
            this.button2.TabIndex = 9;
            this.button2.Text = "КРАЙ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Lt", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Избран автобус: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Lt", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Lt", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Lt", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Име";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Bk", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(4, 533);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(448, 76);
            this.button1.TabIndex = 3;
            this.button1.Text = "ПРОДЪЛЖИ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myTextBox1
            // 
            this.myTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.myTextBox1.BorderColor = System.Drawing.Color.Black;
            this.myTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.myTextBox1.BorderSize = 2;
            this.myTextBox1.Font = new System.Drawing.Font("Roboto Lt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.myTextBox1.Location = new System.Drawing.Point(4, 126);
            this.myTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.myTextBox1.Multiline = false;
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Padding = new System.Windows.Forms.Padding(15);
            this.myTextBox1.PasswordChar = false;
            this.myTextBox1.Size = new System.Drawing.Size(448, 75);
            this.myTextBox1.TabIndex = 0;
            this.myTextBox1.Texts = "";
            this.myTextBox1.UnderlinedStyle = false;
            this.myTextBox1.Click += new System.EventHandler(this.myTextBox1_Click);
            // 
            // myTextBox3
            // 
            this.myTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.myTextBox3.BorderColor = System.Drawing.Color.Black;
            this.myTextBox3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.myTextBox3.BorderSize = 2;
            this.myTextBox3.Font = new System.Drawing.Font("Roboto Lt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.myTextBox3.Location = new System.Drawing.Point(4, 406);
            this.myTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.myTextBox3.Multiline = false;
            this.myTextBox3.Name = "myTextBox3";
            this.myTextBox3.Padding = new System.Windows.Forms.Padding(15);
            this.myTextBox3.PasswordChar = false;
            this.myTextBox3.Size = new System.Drawing.Size(448, 75);
            this.myTextBox3.TabIndex = 2;
            this.myTextBox3.Texts = "";
            this.myTextBox3.UnderlinedStyle = false;
            // 
            // myTextBox2
            // 
            this.myTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.myTextBox2.BorderColor = System.Drawing.Color.Black;
            this.myTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.myTextBox2.BorderSize = 2;
            this.myTextBox2.Font = new System.Drawing.Font("Roboto Lt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.myTextBox2.Location = new System.Drawing.Point(4, 266);
            this.myTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.myTextBox2.Multiline = false;
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Padding = new System.Windows.Forms.Padding(15);
            this.myTextBox2.PasswordChar = false;
            this.myTextBox2.Size = new System.Drawing.Size(448, 75);
            this.myTextBox2.TabIndex = 1;
            this.myTextBox2.Texts = "";
            this.myTextBox2.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(832, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1088, 1017);
            this.panel3.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1017);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MyTextBox myTextBox3;
        private MyTextBox myTextBox2;
        private MyTextBox myTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
    }
}