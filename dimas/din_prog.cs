using MySql.Data.MySqlClient;
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
    public partial class din_prog : Form
    {
        public din_prog()
        {
            InitializeComponent();
        }

        string path_global = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для проверки вам необходимо указать вершины соглсано представленному рисунке (пронумерованы с 1 до 16).\n" +
                "затем необходимо ввести минимальную стоимость и путь содержащий минимальную стоимость, который состоит из вершин графа (Смотри выше)\n" +
                "Путь необходимов вводить через пробел например <<1 2 3 4>>. ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text) == "" || (textBox2.Text==""))
            {
                MessageBox.Show("поля пустые");
            }
            else
            {
                int min_stoim = Convert.ToInt32(textBox1.Text);
                string put = Convert.ToString(textBox2.Text);
                if ( (min_stoim==29)&&((put=="1 5 10 14")))
                {
                    pictureBox1.Image = Image.FromFile(@path_global+@"\\checkPz6\\1.png");
                   
                }
                else if ((min_stoim == 29) && ((put == "2 5 10 14")))
                {
                    pictureBox1.Image = Image.FromFile(@path_global + "\\checkPz6\\2.png");
                    
                } 
                else if ((min_stoim == 29) && ((put == "3 5 10 14")))
                {
                    pictureBox1.Image = Image.FromFile(@path_global+@"\\checkPz6\\3.png");
                   
                }
                else if ((min_stoim == 29) && ((put == "4 8 10 14")))
                {
                    pictureBox1.Image = Image.FromFile(@path_global+@"\\checkPz6\\4.png");
                  
                }
                else
                {
                    MessageBox.Show("Допущена ошибка");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    pictureBox1.Image = Image.FromFile(@path_global+@"\\Безымянный.png");

                }
            }
            

        }

        private void din_prog_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@path_global+@"\\Безымянный.png");

        }
    }
}
