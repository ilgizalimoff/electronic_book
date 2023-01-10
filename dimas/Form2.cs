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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Программа тестирует студента по какому-либо предмету обучения
        int СчетВопросов; // Счет вопросов
        int ПравилОтветов; // Количество правильных ответов
        int НеПравилОтветов; // Количество не правильных ответов
        int a, m, s;
        // Массив вопросов, на которые данынеправильные ответы :
        String[] НеПравилОтветы;
        StreamReader Читатель;

        int НомерПравОтвета; // Номер правильного ответа
        int ВыбранОтвет; // Номер ответа, выбранный студентом
        string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));
        string path_global = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));
        string testNAme;
        void НачалоТеста()
        {
            System.Text.Encoding Кодировка = System.Text.Encoding.GetEncoding(1251);
            try
            {
                string pathOfTest = Convert.ToString(textBox3.Text);
                Читатель = new StreamReader(@pathOfTest, Кодировка);

                testNAme = this.Text = Читатель.ReadLine(); // Название предмета
                                                 // Обнуление всех счетчиков :
                СчетВопросов = 0;
                ПравилОтветов = 0;
                НеПравилОтветов = 0;
                НеПравилОтветы = new String[100];
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                ЧитатьСледВопрос();

            }
            catch (Exception Ситуация)
            { // Отчет о всех ошибках
                MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        void ЧитатьСледВопрос()
        {
            label16.Text = Читатель.ReadLine();
            // Считывание вариантов ответа:
            radioButton1.Text = Читатель.ReadLine();
            radioButton2.Text = Читатель.ReadLine();
            radioButton3.Text = Читатель.ReadLine();
            radioButton4.Text = Читатель.ReadLine();

            // Выясняем, какой ответ - правильный:
            НомерПравОтвета = int.Parse(Читатель.ReadLine());
            // Переводим все переключатели в состояние "выключено":
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            // Первую кнопку задаем не активной, пока студент не выберет
            // вариант ответа:
            button10.Enabled = false;
            СчетВопросов = СчетВопросов + 1;
            // Проверка, конец ли файла:
            if (Читатель.EndOfStream == true) button10.Text = "Завершить";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Щелчок на кнопке
            // "Следующий вопрос/Завершить/Начать тестирование снач"
            // Счет правильных ответов:
            if (ВыбранОтвет == НомерПравОтвета)
                ПравилОтветов = ПравилОтветов + 1;
            if (ВыбранОтвет != НомерПравОтвета)
            { // Счет неправильных ответов:
                НеПравилОтветов = НеПравилОтветов + 1;
                // Запоминаем вопросы с неправильными ответами:
                НеПравилОтветы[НеПравилОтветов] = label16.Text;
            }
            if (button10.Text == "Cначала")
            {

                button10.Text = "Следующий вопрос";
                // Переключатели становятся видимыми, доступными для выбора:
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;

                // Переход к началу файла:
                НачалоТеста(); return;
            }
            if (button10.Text == "Завершить")
            { // Закрываем текстовый файл:
                Читатель.Close();
                // Переключатели делаем невидимыми:
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;

                // Формируем оценку за тест:
                string a;
                a= String.Format("Правильных ответов: {0} из {1}.\n" +
                    "Оценка в пятибальной системе: {2:F2}.", ПравилОтветов,
                    СчетВопросов, (ПравилОтветов * 5.0F) / СчетВопросов);

                label16.Text = String.Format("Тестирование завершено.\n" +
                    "Правильных ответов: {0} из {1}.\n" +
                    "Оценка в пятибальной системе: {2:F2}.", ПравилОтветов,
                    СчетВопросов, (ПравилОтветов * 5.0F) / СчетВопросов);
                // 5F - это максимальная оценка
                button10.Text = "Cначала";
                // Вывод вопросов, на которые вы дали неправильный ответ
                String Str = "СПИСОК ВОПРОСОВ, НА КОТОРЫЕ ВЫ ДАЛИ " +
                    "НЕПРАВИЛЬНЫЙ ОТВЕТ:\n\n";
                for (int i = 1; i <= НеПравилОтветов; i++)
                    Str = Str + НеПравилОтветы[i] + "\n";
                // Если есть неправильные ответы, то вывести через
                // MessageBox список соответствующих вопросов:
                if (НеПравилОтветов != 0)
                    MessageBox.Show(Str, "Тестирование завершено");
                StreamWriter sw = new StreamWriter(path+"\\TestsResults.txt", true, System.Text.Encoding.Default);
                //Write a line of text
                sw.WriteLine(testNAme + "\n" + "Фамилия: " + textBox1.Text + "\n" + "Группа: " + textBox2.Text + "\n" + a + "\n" + "Дата и время прохождения теста: " + DateTime.Now + "\n\n");
                sw.Close();

               
            }
            if (button10.Text == "Следующий вопрос") ЧитатьСледВопрос();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Введено пустое значение!!! Повторите ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Выберите тест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {
                label2.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                listBox1.Visible = false;
                button11.Visible = true;

                button10.Visible = true;
                button9.Visible = false;
                label16.Visible = true;
                label17.Visible = false;
                label19.Visible = false;

                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;

                textBox1.Visible = false;
                textBox2.Visible = false;

                button10.Text = "Следующий вопрос";


                // Подписка на событие "изменение состояния
                // переключателей RadioButton:"
                radioButton1.CheckedChanged += new EventHandler(ИзмСостПерекл);
                radioButton2.CheckedChanged += new EventHandler(ИзмСостПерекл);
                radioButton3.CheckedChanged += new EventHandler(ИзмСостПерекл);
                radioButton4.CheckedChanged += new EventHandler(ИзмСостПерекл);

                НачалоТеста();
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(@path_global + "\\tests");
            FileInfo[] files = dir.GetFiles("*.txt");
            foreach (FileInfo fi in files)
            {
                listBox1.Items.Add(fi.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dir1 = Convert.ToString(listBox1.SelectedItem);
            string nach_put = @path_global + "\\tests\\";
            string put = Convert.ToString(nach_put + dir1);
            textBox3.Text = put;
        }

        void ИзмСостПерекл(System.Object sender, System.EventArgs e)
        { // Кнопка "Следующий вопрос" становится активной и ей передаем фокус:
            button10.Enabled = true; button10.Focus();
            RadioButton Переключатель = (RadioButton)sender;
            String tmp = Переключатель.Name;
            // Выясняем номер ответа, выбранный студентом:
            ВыбранОтвет = int.Parse(tmp.Substring(11));

        }

        private void button11_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            //label18.Visible = false;
            label19.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
        }
        
    }
}
