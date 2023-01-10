using lab1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace dimas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Электронный учебник предназнаечен для студентов 2 курса СПО направления 09.02.03 Программирование в Компьютерных системах ");
        }
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент 3 курса СПО УрТИСИ Ждановских Дмитрий Андреевич ");
        }


  

        private void теоритическаяЧастьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teoria te = new teoria();

            te.Show();
           
            progressBar1.Value = 20;
        }

        private void практическаяЧастьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == 20)
            {
                progressBar1.Value += 20;
            }
            praktika pr = new praktika();

            pr.Show();
           
        }

        private void тестоваяЧастьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void проверкаТЗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proverka_tz tz = new proverka_tz();
            tz.Show();
        }

        private void проверкаСетевогоГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test_form set_graf = new test_form();
            set_graf.Show();
        }

        private void динамическоеПрограммированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            din_prog d = new din_prog();
            d.Show();
        }

        private void добавлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdf_est pdf = new pdf_est();
            pdf.Show();
            pdf.textBox2.Text = this.textBox1.Text;
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Для этого выполнения действия требуется ввести логин и пароль, хотите продолжить?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                teacher_check te = new teacher_check();
                te.textBox3.Text = "2";
                te.Show();
            }
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void математическаяМодельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mat_model te = new mat_model();
            te.Show();
        }

        private void прохождениеТестаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == 40)
            {
                progressBar1.Value += 20;
            }
            Form2 f2 = new Form2();

            f2.Show();
        }

        private void созданиеТестаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Для этого выполнения действия требуется ввести логин и пароль, хотите продолжить?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {

                teacher_check te = new teacher_check();
                te.textBox3.Text = "1";
                te.Show();
            }
        }
    }
}

