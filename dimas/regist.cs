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
    public partial class regist : Form
    {
        public regist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"server=localhost; port=3307; username=root; password=root; database=itproger");
            con.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO `students` (`ID`, `Фамилия`, `Группа`, `Пдф`) Values (NULL, @fam, @group,NULL)", con);
            command.Parameters.Add("@fam", MySqlDbType.VarChar).Value =textBox1.Text;
            command.Parameters.Add("@group", MySqlDbType.VarChar).Value = textBox2.Text;
            Form1 f1 = new Form1();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успех");
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Нет успеха");
            }
            MySqlCommand command1 = new MySqlCommand("Select ID from students where Фамилия=@fam and Группа=@group", con);
            command1.Parameters.Add("@fam", MySqlDbType.VarChar).Value = textBox1.Text;
            command1.Parameters.Add("@group", MySqlDbType.VarChar).Value = textBox2.Text;
            MySqlDataReader thisReader = command1.ExecuteReader();
            string res = string.Empty;
            while (thisReader.Read())
            {
                res += thisReader["ID"];
            }
            f1.textBox1.Text = res;
            thisReader.Close();
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            avtorization avt = new avtorization();
            this.Hide();
            avt.Show();
        }
    }
}
