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
    public partial class pdf_check : Form
    {
        public pdf_check()
        {
            InitializeComponent();
        }

        private void pdf_check_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DefaultCellStyle.Font = new Font("Comic Sans MS", 10.25F);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 10.25F);
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                MySqlConnection con = new MySqlConnection(@"server=localhost; port=3307; username=root; password=root; database=itproger");
                con.Open();

                MySqlCommand com = new MySqlCommand(@"SELECT * FROM students;", con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "students");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();

        }
    }
}
