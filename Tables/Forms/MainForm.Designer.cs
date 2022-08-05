
namespace Goods2
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Таблицы = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.Запросы = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Таблицы.SuspendLayout();
            this.Запросы.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных транспортной компании";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "О программе";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(67, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = "Гистограмма";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(385, 227);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 50);
            this.button6.TabIndex = 7;
            this.button6.Text = "Выход";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Таблицы);
            this.tabControl1.Controls.Add(this.Запросы);
            this.tabControl1.Location = new System.Drawing.Point(57, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 150);
            this.tabControl1.TabIndex = 8;
            // 
            // Таблицы
            // 
            this.Таблицы.Controls.Add(this.button8);
            this.Таблицы.Controls.Add(this.button7);
            this.Таблицы.Controls.Add(this.button1);
            this.Таблицы.Controls.Add(this.button2);
            this.Таблицы.Controls.Add(this.button9);
            this.Таблицы.Controls.Add(this.button10);
            this.Таблицы.Controls.Add(this.button11);
            this.Таблицы.Controls.Add(this.button12);
            this.Таблицы.Location = new System.Drawing.Point(4, 22);
            this.Таблицы.Name = "Таблицы";
            this.Таблицы.Padding = new System.Windows.Forms.Padding(3);
            this.Таблицы.Size = new System.Drawing.Size(438, 124);
            this.Таблицы.TabIndex = 0;
            this.Таблицы.Text = "Таблицы";
            this.Таблицы.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(324, 62);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 50);
            this.button8.TabIndex = 17;
            this.button8.Text = "Сотрудники";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(218, 62);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 50);
            this.button7.TabIndex = 16;
            this.button7.Text = "Рейсы";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "Марки автомобилей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 14;
            this.button2.Text = "Должности";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(324, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 50);
            this.button9.TabIndex = 13;
            this.button9.Text = "Грузы";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(218, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 50);
            this.button10.TabIndex = 12;
            this.button10.Text = "Виды грузов";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(112, 6);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 50);
            this.button11.TabIndex = 11;
            this.button11.Text = "Виды автомобилей";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 6);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 50);
            this.button12.TabIndex = 10;
            this.button12.Text = "Автомобили";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Запросы
            // 
            this.Запросы.Controls.Add(this.button13);
            this.Запросы.Controls.Add(this.button14);
            this.Запросы.Controls.Add(this.button15);
            this.Запросы.Controls.Add(this.button16);
            this.Запросы.Controls.Add(this.button17);
            this.Запросы.Location = new System.Drawing.Point(4, 22);
            this.Запросы.Name = "Запросы";
            this.Запросы.Padding = new System.Windows.Forms.Padding(3);
            this.Запросы.Size = new System.Drawing.Size(438, 124);
            this.Запросы.TabIndex = 1;
            this.Запросы.Text = "Запросы";
            this.Запросы.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(6, 62);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 50);
            this.button13.TabIndex = 15;
            this.button13.Text = "Транспортировка";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(324, 6);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 50);
            this.button14.TabIndex = 14;
            this.button14.Text = "Перевозимые грузы";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(218, 6);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 50);
            this.button15.TabIndex = 13;
            this.button15.Text = "Отдел кадров";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(112, 6);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 50);
            this.button16.TabIndex = 12;
            this.button16.Text = "Заказы";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(6, 6);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 50);
            this.button17.TabIndex = 11;
            this.button17.Text = "Автопарк";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 356);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "База данных транспортной компании";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Таблицы.ResumeLayout(false);
            this.Запросы.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Таблицы;
        private System.Windows.Forms.TabPage Запросы;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
    }
}

