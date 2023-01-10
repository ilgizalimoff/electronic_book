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
    public partial class proverka_tz : Form
    {
        public proverka_tz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked)&&(textBox1.Text=="245"))
            {
                MessageBox.Show("Вы решили данную задачу верно");
            }
            else if ((radioButton2.Checked) && (textBox1.Text == "2270"))
            {
                MessageBox.Show("Вы решили данную задачу верно");
            }
            else
            {
                MessageBox.Show("Неверно!!!");
            }

        }
    }
}
