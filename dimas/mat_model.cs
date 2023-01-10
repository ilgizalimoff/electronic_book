using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dimas
{
    public partial class mat_model : Form
    {
        public mat_model()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((textBox3.Text == "2") && (checkBox18.Checked == true))&&((textBox7.Text == "0") && (checkBox23.Checked == true)))
            {
                MessageBox.Show("Ограничения для х2 верно");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "3x1+4x2")
            {
                MessageBox.Show("Целевая функци верна");
                textBox1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (((textBox4.Text == "2x1+3x2") && (checkBox9.Checked == true)&&(textBox8.Text=="10")) &&
                ((textBox5.Text == "3x1+2x2") && (checkBox13.Checked == true)&& (textBox9.Text == "15")) &&
                ((textBox6.Text == "x1+x2") && (checkBox17.Checked == true) && (textBox10.Text == "1")))
            {
                MessageBox.Show("Общие ограничения верны");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "0")&& (checkBox12.Checked == true)){
                MessageBox.Show("Ограничения для х1 верно");
            }
        }
    }
}
