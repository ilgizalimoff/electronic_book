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
    public partial class teoria : Form
    {
        public teoria()
        {
            InitializeComponent();
        }
        string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void практическиеЗанятия2РешениеЗадачЛинейногоПрограммированияГрафическимМетодомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@path + "uchebnik_html/pz/pz2/pz2.html");
        }

        private void практическиеЗанятия5РешениеЗадачНелинейногоПрограммированияГрафическимМетодомИМетодомМножителейЛагранжаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@path + "uchebnik_html/pz/pz5/pz5.html");

        }

        private void практическиеЗанятия6РешениеПростейшихЗадачМетодомДинамическогоПрограммированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@path + "uchebnik_html/pz/pz6/pz6.html");

        }

        private void практическиеЗанятия7ВычислениеОсновныхПараметровСетевогоГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@path + "uchebnik_html/pz/pz7/pz7.html");

        }

        private void задачаЛинейногоПрограммированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@path + "uchebnik_html/html1/1.html");

        }

        private void графическийМетодРешенияЗадачЛинейногоПрограммированияСимплексметодТранспортнаяЗадачаМетодПотенциаловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@path + "uchebnik_html/html2/2.html");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            this.Close();
        }
    }
}
