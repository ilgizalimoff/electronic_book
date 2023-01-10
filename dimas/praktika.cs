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
    public partial class praktika : Form
    {
        public praktika()
        {
            InitializeComponent();
        }
        string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void asaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@path+"uchebnik_html\\pz\\pz1\\pz1.html");

        }

        private void практическоеЗанятие1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@path+"uchebnik_html/pz/pz2/pz2.html");

        }

        private void практическоеЗанятие1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@path + "uchebnik_html/pz/pz3_4/pz3_4.html");

        }

        private void практическоеЗанятие1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@path + "uchebnik_html/pz/pz5/pz5.html");
        }

        private void практическоеЗанятие1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@path + "uchebnik_html/pz/pz6/pz6.html");

        }

        private void практическоеЗанятие1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@path + "uchebnik_html/pz/pz7/pz7.html");

        }
    }
}
