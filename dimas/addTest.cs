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
    public partial class addTest : Form
    {
        public addTest()
        {
            InitializeComponent();
        }
        string path_global = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));

        private void button1_Click(object sender, EventArgs e)
        {
            string globalFileaName = Convert.ToString(textBox10.Text);
            int selectQuestionNumber = Convert.ToInt32(textBox8.Text);
            int size = Convert.ToInt32(textBox2.Text);
            string question, quesOne, quesTwo, quesThree, quesFour, rightOtvet;

            if (selectQuestionNumber <= size)
            {
                question = Convert.ToString(textBox3.Text);
                quesOne = Convert.ToString(textBox4.Text);
                quesTwo = Convert.ToString(textBox5.Text);
                quesThree = Convert.ToString(textBox6.Text);
                quesFour = Convert.ToString(textBox7.Text);
                rightOtvet = Convert.ToString(textBox9.Text);

                StreamWriter sw = new StreamWriter(@globalFileaName, true, System.Text.Encoding.UTF8);
                sw.WriteLine(question + "\n" + quesOne + "\n" + quesTwo + "\n" + quesThree + "\n" + quesFour + "\n" + rightOtvet);
                sw.Close();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox9.Text = "";
                selectQuestionNumber++;
                textBox8.Text = Convert.ToString(selectQuestionNumber);
            }
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nameTest = Convert.ToString(textBox1.Text);
            int size = Convert.ToInt32(textBox2.Text);
            string globalFileaName = @path_global + "\\tests\\" + nameTest + ".txt";
            StreamWriter sw = new StreamWriter(@globalFileaName, true, System.Text.Encoding.UTF8);
            sw.WriteLine(nameTest);
            textBox10.Text += globalFileaName;
            textBox8.Text = "1";
            sw.Close();

            button2.Visible = false;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;


            this.ClientSize = new System.Drawing.Size(800, 411);

            //visible
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label10.Visible = true;

            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            button1.Visible = true;
        }

        private void addTest_Load(object sender, EventArgs e)
        {

           // this.ClientSize = new System.Drawing.Size(800, 154);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dir1 = Convert.ToString(listBox1.SelectedItem);
            string nach_put = @path_global + "\\tests\\";
            string put = Convert.ToString(nach_put + dir1);
            textBox11.Text = put;

        }

        private void добавлениеТестаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.ReadOnly = false;
                textBox1.ReadOnly = false;
            }
       

                //this.ClientSize = new System.Drawing.Size(800, 154);
        

            label1.Visible = true;
            label2.Visible = true;
            button2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;

            button3.Visible = false;
            button4.Visible = false;
            listBox1.Visible = false;
        }

        private void удалениеТестаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            button3.Visible = true;


            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label10.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;

            button1.Visible = false;
            button2.Visible = false;

            button4.Visible = false;

            this.ClientSize = new System.Drawing.Size(800, 300);

            this.listBox1.Location = new System.Drawing.Point(182, 36);
            this.listBox1.Size = new System.Drawing.Size(456, 186);
            this.button3.Location = new System.Drawing.Point(346, 241);

            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(@path_global + "\\tests");
            FileInfo[] files = dir.GetFiles("*.txt");
            foreach (FileInfo fi in files)
            {
                listBox1.Items.Add(fi.ToString());
            }


        }

        private void именениеТестаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            button4.Visible = true;


            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label10.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;

            button1.Visible = false;
            button2.Visible = false;

            button3.Visible = false;


            this.ClientSize = new System.Drawing.Size(800, 300);

            this.listBox1.Location = new System.Drawing.Point(182, 36);
            this.listBox1.Size = new System.Drawing.Size(456, 186);
            this.button4.Location = new System.Drawing.Point(346, 241);
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(@path_global + "\\tests");
            FileInfo[] files = dir.GetFiles("*.txt");
            foreach (FileInfo fi in files)
            {
                listBox1.Items.Add(fi.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string put = Convert.ToString(textBox11.Text);
            System.IO.File.Delete(@put);

            listBox1.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo(@path_global + "\\tests");
            FileInfo[] files = dir.GetFiles("*.txt");
            foreach (FileInfo fi in files)
            {
                listBox1.Items.Add(fi.ToString());

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string put = Convert.ToString(textBox11.Text);
            System.Diagnostics.Process.Start(@put);

        }
    }
}
