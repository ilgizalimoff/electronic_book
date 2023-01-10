using System.Drawing;

namespace dimas
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.теоритическаяЧастьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.практическаяЧастьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестоваяЧастьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаПЗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаТЗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаСетевогоГрафикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.динамическоеПрограммированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.математическаяМодельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСОтчетамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.прохождениеТестаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеТестаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Indigo;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(163, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(672, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Детерминированные задачи";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(441, 279);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(140, 29);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(311, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ваш прогесс";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.теоритическаяЧастьToolStripMenuItem,
            this.практическаяЧастьToolStripMenuItem,
            this.тестоваяЧастьToolStripMenuItem,
            this.проверкаПЗToolStripMenuItem,
            this.работаСОтчетамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 29);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // теоритическаяЧастьToolStripMenuItem
            // 
            this.теоритическаяЧастьToolStripMenuItem.Name = "теоритическаяЧастьToolStripMenuItem";
            this.теоритическаяЧастьToolStripMenuItem.Size = new System.Drawing.Size(172, 25);
            this.теоритическаяЧастьToolStripMenuItem.Text = "Теоритическая часть";
            this.теоритическаяЧастьToolStripMenuItem.Click += new System.EventHandler(this.теоритическаяЧастьToolStripMenuItem_Click);
            // 
            // практическаяЧастьToolStripMenuItem
            // 
            this.практическаяЧастьToolStripMenuItem.Name = "практическаяЧастьToolStripMenuItem";
            this.практическаяЧастьToolStripMenuItem.Size = new System.Drawing.Size(165, 25);
            this.практическаяЧастьToolStripMenuItem.Text = "Практическая часть";
            this.практическаяЧастьToolStripMenuItem.Click += new System.EventHandler(this.практическаяЧастьToolStripMenuItem_Click);
            // 
            // тестоваяЧастьToolStripMenuItem
            // 
            this.тестоваяЧастьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прохождениеТестаToolStripMenuItem,
            this.созданиеТестаToolStripMenuItem});
            this.тестоваяЧастьToolStripMenuItem.Name = "тестоваяЧастьToolStripMenuItem";
            this.тестоваяЧастьToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.тестоваяЧастьToolStripMenuItem.Text = "Тестовая часть";
            this.тестоваяЧастьToolStripMenuItem.Click += new System.EventHandler(this.тестоваяЧастьToolStripMenuItem_Click);
            // 
            // проверкаПЗToolStripMenuItem
            // 
            this.проверкаПЗToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверкаТЗToolStripMenuItem,
            this.проверкаСетевогоГрафикаToolStripMenuItem,
            this.динамическоеПрограммированиеToolStripMenuItem,
            this.математическаяМодельToolStripMenuItem});
            this.проверкаПЗToolStripMenuItem.Name = "проверкаПЗToolStripMenuItem";
            this.проверкаПЗToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.проверкаПЗToolStripMenuItem.Text = "Проверка ПЗ";
            // 
            // проверкаТЗToolStripMenuItem
            // 
            this.проверкаТЗToolStripMenuItem.Name = "проверкаТЗToolStripMenuItem";
            this.проверкаТЗToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.проверкаТЗToolStripMenuItem.Text = "Проверка транспортной задачи";
            this.проверкаТЗToolStripMenuItem.Click += new System.EventHandler(this.проверкаТЗToolStripMenuItem_Click);
            // 
            // проверкаСетевогоГрафикаToolStripMenuItem
            // 
            this.проверкаСетевогоГрафикаToolStripMenuItem.Name = "проверкаСетевогоГрафикаToolStripMenuItem";
            this.проверкаСетевогоГрафикаToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.проверкаСетевогоГрафикаToolStripMenuItem.Text = "Проверка сетевого графика";
            this.проверкаСетевогоГрафикаToolStripMenuItem.Click += new System.EventHandler(this.проверкаСетевогоГрафикаToolStripMenuItem_Click);
            // 
            // динамическоеПрограммированиеToolStripMenuItem
            // 
            this.динамическоеПрограммированиеToolStripMenuItem.Name = "динамическоеПрограммированиеToolStripMenuItem";
            this.динамическоеПрограммированиеToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.динамическоеПрограммированиеToolStripMenuItem.Text = "Динамическое программирование";
            this.динамическоеПрограммированиеToolStripMenuItem.Click += new System.EventHandler(this.динамическоеПрограммированиеToolStripMenuItem_Click);
            // 
            // математическаяМодельToolStripMenuItem
            // 
            this.математическаяМодельToolStripMenuItem.Name = "математическаяМодельToolStripMenuItem";
            this.математическаяМодельToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.математическаяМодельToolStripMenuItem.Text = "Математическая модель";
            this.математическаяМодельToolStripMenuItem.Click += new System.EventHandler(this.математическаяМодельToolStripMenuItem_Click);
            // 
            // работаСОтчетамиToolStripMenuItem
            // 
            this.работаСОтчетамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.работаСОтчетамиToolStripMenuItem.Name = "работаСОтчетамиToolStripMenuItem";
            this.работаСОтчетамиToolStripMenuItem.Size = new System.Drawing.Size(155, 25);
            this.работаСОтчетамиToolStripMenuItem.Text = "Работа с отчетами";
            // 
            // добавлениеToolStripMenuItem
            // 
            this.добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
            this.добавлениеToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.добавлениеToolStripMenuItem.Text = "Добавление";
            this.добавлениеToolStripMenuItem.Click += new System.EventHandler(this.добавлениеToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(899, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Х";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // прохождениеТестаToolStripMenuItem
            // 
            this.прохождениеТестаToolStripMenuItem.Name = "прохождениеТестаToolStripMenuItem";
            this.прохождениеТестаToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.прохождениеТестаToolStripMenuItem.Text = "Прохождение теста";
            this.прохождениеТестаToolStripMenuItem.Click += new System.EventHandler(this.прохождениеТестаToolStripMenuItem_Click);
            // 
            // созданиеТестаToolStripMenuItem
            // 
            this.созданиеТестаToolStripMenuItem.Name = "созданиеТестаToolStripMenuItem";
            this.созданиеТестаToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.созданиеТестаToolStripMenuItem.Text = "Создание теста";
            this.созданиеТестаToolStripMenuItem.Click += new System.EventHandler(this.созданиеТестаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem теоритическаяЧастьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem практическаяЧастьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестоваяЧастьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаПЗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаТЗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаСетевогоГрафикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem динамическоеПрограммированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСОтчетамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem математическаяМодельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прохождениеТестаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созданиеТестаToolStripMenuItem;
    }
}

