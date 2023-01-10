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
    public partial class teacher_check : Form
    {
        public teacher_check()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "1")
            {
                MySqlConnection con = new MySqlConnection(@"server=localhost; port=3307; username=root; password=root; database=itproger");
                con.Open();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT ID FROM `преподаватели` WHERE Логин=@log and Пароль=@pass", con);
                command.Parameters.Add("@log", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox2.Text;

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

                    MessageBox.Show("Вы успешно авторизовались", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    addTest adtest = new addTest();
                    adtest.Show();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Таких студентов нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textBox3.Text == "2")
            {
                MySqlConnection con = new MySqlConnection(@"server=localhost; port=3307; username=root; password=root; database=itproger");
                con.Open();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT ID FROM `преподаватели` WHERE Логин=@log and Пароль=@pass", con);
                command.Parameters.Add("@log", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox2.Text;

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

                    MessageBox.Show("Вы успешно авторизовались", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    pdf_check pdfCheck = new pdf_check();
                    pdfCheck.Show();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Таких студентов нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
