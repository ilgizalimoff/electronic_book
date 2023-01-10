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
    public partial class pdf_est : Form
    {
        public pdf_est()
        {
            InitializeComponent();
        }
        string path_global = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"server=localhost; port=3307; username=root; password=root; database=itproger");
            con.Open();
            

            MySqlCommand command1 = new MySqlCommand("select Фамилия, Группа from students WHERE `ID` = @id;", con);
            command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox2.Text;
            MySqlDataReader thisReader = command1.ExecuteReader();
          
            string path = textBox1.Text;
            string tip = ".pdf"; 
            string fam = string.Empty;
            string group = string.Empty;
            while (thisReader.Read())
            {
      
                fam += thisReader["Фамилия"];
                group += thisReader["Группа"];
            }
            FileInfo fileInf = new FileInfo(path);

            string namefiles = fam + " " + group;
            string newPath = @path_global + "pdf_files\\" + namefiles + tip;
            if (fileInf.Exists)
            {
                fileInf.MoveTo(newPath);
                // альтернатива с помощью класса File
                //File.Move(path, newPath);
            }
            thisReader.Close();
            MySqlCommand command = new MySqlCommand("UPDATE `students` SET Пдф = @pdf WHERE `ID` = @id;", con);
            command.Parameters.Add("@pdf", MySqlDbType.VarChar).Value = newPath;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox2.Text;


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пдф файл добавлен!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
            con.Close();
        }

        private void pdf_est_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            // всё. имя файла теперь хранится в openFileDialog1.FileName
            textBox1.Text = openFileDialog1.FileName;

            button1.Enabled = true;
            button2.Enabled = true;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string put = Convert.ToString(textBox1.Text);
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = @put;
                axAcroPDF1.src = put;

            }
            catch
            {
                MessageBox.Show("Такого файла нет");
            }
            //using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF|*.pdf" })
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        axAcroPDF1.src = ofd.FileName;
            //    }
            //}
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
