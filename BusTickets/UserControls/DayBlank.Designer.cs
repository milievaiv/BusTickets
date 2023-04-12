
namespace DesktopCalendar
{
    partial class DayBlank
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayNumber
            // 
            this.dayNumber.BackColor = System.Drawing.Color.Transparent;
            this.dayNumber.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayNumber.Location = new System.Drawing.Point(0, 0);
            this.dayNumber.Name = "dayNumber";
            this.dayNumber.Size = new System.Drawing.Size(52, 44);
            this.dayNumber.TabIndex = 0;
            this.dayNumber.Text = "01";
            this.dayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dayNumber.Click += new System.EventHandler(this.dayNumber_Click);
            // 
            // DayBlank
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dayNumber);
            this.Name = "DayBlank";
            this.Size = new System.Drawing.Size(170, 84);
            this.Load += new System.EventHandler(this.DayBlank_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label dayNumber;
    }
}
