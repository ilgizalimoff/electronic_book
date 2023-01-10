using lab1;
using MySql.Data.MySqlClient;
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
    public partial class avtorization : Form
    {
        public avtorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"server=localhost; port=3307; username=root; password=root; database=itproger");
            con.Open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT ID FROM `students` WHERE Фамилия=@fam and Группа=@group", con);
            command.Parameters.Add("@fam", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@group", MySqlDbType.VarChar).Value = textBox2.Text;
          
            adapter.SelectCommand = command;
            adapter.Fill(table);
            /*
             если такой есть
             */
            if (table.Rows.Count > 0)
            {   
                /*
                успешно авторизовались 
                */
                
                MySqlDataReader thisReader = command.ExecuteReader();
                string res = string.Empty;
                while (thisReader.Read())
                {
                    res += thisReader["ID"];
                }
                MessageBox.Show("Вы успешно авторизовались", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 f1 = new Form1();
                f1.textBox1.Text = res;
                this.Hide();
                f1.Show();

                thisReader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Таких студентов нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            regist reg = new regist();
            this.Hide();
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            test_form tf = new test_form();
            tf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainForm ma = new mainForm();
            ma.Show();
        }
    }
}
