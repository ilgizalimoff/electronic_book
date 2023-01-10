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
    public partial class test_form : Form
    {
        public test_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;      // Общее количество работ по проекту          
            // (количество ребер ориентированного графа).
            int[] i = new int[20];  // Вектор-пара, представляющая k-ю работу,    
            int[] j = new int[20];  // которая понимается как стрелка, связыва-   
            // ющая событие i[k] с событием j[k]          
            // Граф задан массивом ребер:                 
            // (i[0],j[0]),(i[1],j[1]),...,(i[n-1],j[n-1])    
            // Должно быть выполнено:  
            // i[0]=1, i[k]<i[k+1], i[k]<j[k].
            int[] dij = new int[20];// dij[k] - продолжительность k-й операции.
            int[] s1 = new int[20]; // s1[k] - самый ранний срок начала k-й операции.
            int[] s2 = new int[20]; // s2[k] - самый поздний срок начала k-й.
            int[] f1 = new int[20]; // f1[k] - самый ранний срок завершения k-й.
            int[] f2 = new int[20]; // f2[k] - самый поздний срок завершения k-й операции.
            int[] tf = new int[20]; // tf[k] - полный резерв времени k-й операции.
            int[] ff = new int[20]; // ff[k] - свободный резерв времени k-й операции.
            int k;      // Параметр цикла.

            Console.Write("Введите общее количество работ по проекту: ");
            n = int.Parse(Console.ReadLine());
            for (k = 0; k < n; k++)
            {
                Console.Write("Вводите начало, конец дуги и продолжительность: \n");
                i[k] = int.Parse(Console.ReadLine());
                j[k] = int.Parse(Console.ReadLine());
                dij[k] = int.Parse(Console.ReadLine());
            }
            Critical_Path(n, i, j, dij, s1, s2, f1, f2, tf, ff);
            //Вывод результатов.
            Console.Write("Самый ранний срок начала     : ");
            for (k = 0; k < n; k++) Console.Write("{0} \n", s1[k]);
            Console.Write("Самый поздний срок начала    : ");
            for (k = 0; k < n; k++) Console.Write("{0} \n", s2[k]);
            Console.Write("Самый ранний срок завершения : ");
            for (k = 0; k < n; k++) Console.Write("{0} \n", f1[k]);
            Console.Write("Самый поздний срок завершения : ");
            for (k = 0; k < n; k++) Console.Write("{0} \n", f2[k]);
            Console.Write("Свободный резерв времени     : ");
            for (k = 0; k < n; k++) Console.Write("{0} \n", ff[k]);
            Console.Write("Полный резерв времени        : ");
            for (k = 0; k < n; k++) Console.Write("{0} \n", tf[k]);
            // Определение  критического  пути. Критический путь задается 
            // стрелками, соединяющими события, для которых полный резерв
            // времени равен нулю.
            Console.Write("Критический путь: 1 ");
            for (k = 0; k < n; k++)
                if (tf[k] == 0) Console.Write("{0} ", j[k]);

            Console.ReadKey();

        }
        public static void Critical_Path(int n, int[] i, int[] j, int[] dij,
                        int[] s1, int[] s2, int[] f1, int[] f2, int[] tf, int[] ff)
        {
            int k, index, max, min;
            int[] ti = new int[20];
            int[] te = new int[20];

            index = 0;
            for (k = 0; k < n; k++)
            {
                if (i[k] == index + 1) index = i[k];
                ti[k] = 0; te[k] = 9999;
            }

            for (k = 0; k < n; k++)
            {
                max = ti[i[k]] + dij[k];
                if (ti[j[k]] < max) ti[j[k]] = max;
            }

            te[j[n - 1]] = ti[j[n - 1]];
            for (k = n - 1; k >= 0; k--)
            {
                min = te[j[k]] - dij[k];
                if (te[i[k]] > min) te[i[k]] = min;
            }

            for (k = 0; k < n; k++)
            {
                s1[k] = ti[i[k]]; f1[k] = s1[k] + dij[k];
                f2[k] = te[j[k]]; s2[k] = f2[k] - dij[k];
                tf[k] = f2[k] - f1[k]; ff[k] = ti[j[k]] - f1[k];
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ran_srok_nach = "0 0 3 3 4 8 8 14";
            string pozd_srok_nach = "0 2 3 7 6 8 18 14";
            string ran_srok_zav = "3 4 8 10 6 14 12 22";
            string pozd_srok_zav = "3 6 8 14 8 14 22 22";
            string svob_rezerv = "0 0 0 4 2 0 10 0";
            string poln_rezerv = "0 2 0 4 2 0 10 0";
            string krit_put = "1 2 4 5 6";
            try
            {
                if (textBox1.Text != ran_srok_nach)
                {
                    this.textBox1.BackColor = System.Drawing.Color.Coral;
                }
                else
                {
                    this.textBox1.BackColor = System.Drawing.Color.White;
                }
                if (textBox2.Text != pozd_srok_nach)
                {
                    this.textBox2.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox2.BackColor = System.Drawing.Color.White;

                if (textBox3.Text != ran_srok_zav)
                {
                    this.textBox3.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox3.BackColor = System.Drawing.Color.White;

                if (textBox4.Text != pozd_srok_zav)
                {
                    this.textBox4.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox4.BackColor = System.Drawing.Color.White;

                if (textBox5.Text != svob_rezerv)
                {
                    this.textBox5.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox5.BackColor = System.Drawing.Color.White;

                if (textBox6.Text != poln_rezerv)
                {
                    this.textBox6.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox6.BackColor = System.Drawing.Color.White;

                if (textBox7.Text != krit_put)
                {
                    this.textBox7.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox7.BackColor = System.Drawing.Color.White;


                if((this.textBox1.BackColor == System.Drawing.Color.Coral)
                || (this.textBox2.BackColor == System.Drawing.Color.Coral)
                ||(this.textBox3.BackColor == System.Drawing.Color.Coral)
                ||(this.textBox4.BackColor == System.Drawing.Color.Coral)
                ||(this.textBox5.BackColor == System.Drawing.Color.Coral)
                ||(this.textBox6.BackColor == System.Drawing.Color.Coral)
                ||(this.textBox7.BackColor == System.Drawing.Color.Coral))
                {
                    MessageBox.Show("У вас есть ошибка, попробуйте снова");
                }
                else MessageBox.Show("Вы все сделали правильно!!!");

            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ran_srok_nach = "0 0 0 3 3 7 7 12 10";
            string pozd_srok_nach = "0 0 8 3 7 8 7 13 10";
            string ran_srok_zav = "3 7 2 7 9 12 10 17 18";
            string pozd_srok_zav = "3 7 10 7 13 13 10 18 18";
            string svob_rezerv = "0 0 8 0 3 0 0 1 0";
            string poln_rezerv = "0 0 8 0 4 1 0 1 0";
            string krit_put = "1 2 3 3 5 6";
            try
            {
                if (textBox8.Text != ran_srok_nach)
                {
                    this.textBox8.BackColor = System.Drawing.Color.Coral;
                }
                else
                {
                    this.textBox8.BackColor = System.Drawing.Color.White;
                }
                if (textBox9.Text != pozd_srok_nach)
                {
                    this.textBox9.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox9.BackColor = System.Drawing.Color.White;

                if (textBox10.Text != ran_srok_zav)
                {
                    this.textBox10.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox10.BackColor = System.Drawing.Color.White;

                if (textBox11.Text != pozd_srok_zav)
                {
                    this.textBox11.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox11.BackColor = System.Drawing.Color.White;

                if (textBox12.Text != svob_rezerv)
                {
                    this.textBox12.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox12.BackColor = System.Drawing.Color.White;

                if (textBox13.Text != poln_rezerv)
                {
                    this.textBox13.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox13.BackColor = System.Drawing.Color.White;

                if (textBox14.Text != krit_put)
                {
                    this.textBox14.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox14.BackColor = System.Drawing.Color.White;


                if ((this.textBox8.BackColor == System.Drawing.Color.Coral)
                || (this.textBox9.BackColor == System.Drawing.Color.Coral)
                || (this.textBox10.BackColor == System.Drawing.Color.Coral)
                || (this.textBox11.BackColor == System.Drawing.Color.Coral)
                || (this.textBox12.BackColor == System.Drawing.Color.Coral)
                || (this.textBox13.BackColor == System.Drawing.Color.Coral)
                || (this.textBox14.BackColor == System.Drawing.Color.Coral))
                {
                    MessageBox.Show("У вас есть ошибка, попробуйте снова");
                }
                else MessageBox.Show("Вы все сделали правильно!!!");

            }
            catch
            {

            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ran_srok_nach = "0 0 4 4 5 5 8 15";
            string pozd_srok_nach = "0 2 4 12 7 19 8 15";
            string ran_srok_zav = "4 5 8 7 6 8 15 22";
            string pozd_srok_zav = "4 7 8 15 8 22 15 22";
            string svob_rezerv = "0 0 0 8 2 14 0 0";
            string poln_rezerv = "0 2 0 8 2 14 0 0";
            string krit_put = "1 2 4 5 6";
            try
            {
                if (textBox15.Text != ran_srok_nach)
                {
                    this.textBox15.BackColor = System.Drawing.Color.Coral;
                }
                else
                {
                    this.textBox15.BackColor = System.Drawing.Color.White;
                }
                if (textBox16.Text != pozd_srok_nach)
                {
                    this.textBox16.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox16.BackColor = System.Drawing.Color.White;

                if (textBox17.Text != ran_srok_zav)
                {
                    this.textBox17.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox17.BackColor = System.Drawing.Color.White;

                if (textBox18.Text != pozd_srok_zav)
                {
                    this.textBox18.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox18.BackColor = System.Drawing.Color.White;

                if (textBox19.Text != svob_rezerv)
                {
                    this.textBox19.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox19.BackColor = System.Drawing.Color.White;

                if (textBox20.Text != poln_rezerv)
                {
                    this.textBox20.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox20.BackColor = System.Drawing.Color.White;

                if (textBox21.Text != krit_put)
                {
                    this.textBox21.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox21.BackColor = System.Drawing.Color.White;


                if ((this.textBox15.BackColor == System.Drawing.Color.Coral)
                || (this.textBox16.BackColor == System.Drawing.Color.Coral)
                || (this.textBox17.BackColor == System.Drawing.Color.Coral)
                || (this.textBox18.BackColor == System.Drawing.Color.Coral)
                || (this.textBox19.BackColor == System.Drawing.Color.Coral)
                || (this.textBox20.BackColor == System.Drawing.Color.Coral)
                || (this.textBox21.BackColor == System.Drawing.Color.Coral))
                {
                    MessageBox.Show("У вас есть ошибка, попробуйте снова");
                }
                else MessageBox.Show("Вы все сделали правильно!!!");

            }
            catch
            {

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string ran_srok_nach = "0 0 0 4 4 1 9 9 12";
            string pozd_srok_nach = "0 5 10 4 14 6 9 15 12";
            string ran_srok_zav = "4 1 2 9 8 4 12 12 18";
            string pozd_srok_zav = "4 6 12 9 18 9 12 18 18";
            string svob_rezerv = "0 0 10 0 10 5 0 6 0";
            string poln_rezerv = "0 5 10 0 10 5 0 6 0";
            string krit_put = "1 2 4 5 6";
            try
            {
                if (textBox64.Text != ran_srok_nach)
                {
                    this.textBox64.BackColor = System.Drawing.Color.Coral;
                }
                else
                {
                    this.textBox64.BackColor = System.Drawing.Color.White;
                }
                if (textBox65.Text != pozd_srok_nach)
                {
                    this.textBox65.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox65.BackColor = System.Drawing.Color.White;

                if (textBox66.Text != ran_srok_zav)
                {
                    this.textBox66.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox66.BackColor = System.Drawing.Color.White;

                if (textBox67.Text != pozd_srok_zav)
                {
                    this.textBox67.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox67.BackColor = System.Drawing.Color.White;

                if (textBox68.Text != svob_rezerv)
                {
                    this.textBox68.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox68.BackColor = System.Drawing.Color.White;

                if (textBox69.Text != poln_rezerv)
                {
                    this.textBox69.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox69.BackColor = System.Drawing.Color.White;

                if (textBox70.Text != krit_put)
                {
                    this.textBox70.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox70.BackColor = System.Drawing.Color.White;


                if ((this.textBox64.BackColor == System.Drawing.Color.Coral)
                || (this.textBox65.BackColor == System.Drawing.Color.Coral)
                || (this.textBox66.BackColor == System.Drawing.Color.Coral)
                || (this.textBox67.BackColor == System.Drawing.Color.Coral)
                || (this.textBox68.BackColor == System.Drawing.Color.Coral)
                || (this.textBox69.BackColor == System.Drawing.Color.Coral)
                || (this.textBox70.BackColor == System.Drawing.Color.Coral))
                {
                    MessageBox.Show("У вас есть ошибка, попробуйте снова");
                }
                else MessageBox.Show("Вы все сделали правильно!!!");

            }
            catch
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string ran_srok_nach = "0 0 4 4 3 3 9 16";
            string pozd_srok_nach = "3 0 7 11 3 8 9 16";
            string ran_srok_zav = "4 3 6 9 9 15 16 20";
            string pozd_srok_zav = "7 3 9 16 9 20 16 20";
            string svob_rezerv = "0 0 3 7 0 5 0 0";
            string poln_rezerv = "3 0 3 7 0 5 0 0";
            string krit_put = "1 3 4 5 6";
            try
            {
                if (textBox57.Text != ran_srok_nach)
                {
                    this.textBox57.BackColor = System.Drawing.Color.Coral;
                }
                else
                {
                    this.textBox57.BackColor = System.Drawing.Color.White;
                }
                if (textBox58.Text != pozd_srok_nach)
                {
                    this.textBox58.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox58.BackColor = System.Drawing.Color.White;

                if (textBox59.Text != ran_srok_zav)
                {
                    this.textBox59.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox59.BackColor = System.Drawing.Color.White;

                if (textBox60.Text != pozd_srok_zav)
                {
                    this.textBox60.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox60.BackColor = System.Drawing.Color.White;

                if (textBox61.Text != svob_rezerv)
                {
                    this.textBox61.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox61.BackColor = System.Drawing.Color.White;

                if (textBox62.Text != poln_rezerv)
                {
                    this.textBox62.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox62.BackColor = System.Drawing.Color.White;

                if (textBox63.Text != krit_put)
                {
                    this.textBox63.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox63.BackColor = System.Drawing.Color.White;


                if ((this.textBox57.BackColor == System.Drawing.Color.Coral)
                || (this.textBox58.BackColor == System.Drawing.Color.Coral)
                || (this.textBox59.BackColor == System.Drawing.Color.Coral)
                || (this.textBox60.BackColor == System.Drawing.Color.Coral)
                || (this.textBox61.BackColor == System.Drawing.Color.Coral)
                || (this.textBox62.BackColor == System.Drawing.Color.Coral)
                || (this.textBox63.BackColor == System.Drawing.Color.Coral))
                {
                    MessageBox.Show("У вас есть ошибка, попробуйте снова");
                }
                else MessageBox.Show("Вы все сделали правильно!!!");

            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ran_srok_nach = "0 0 0 3 3 2 6 6 13";
            string pozd_srok_nach = "2 0 10 5 16 2 6 15 13";
            string ran_srok_zav = "3 2 3 4 8 6 13 12 21";
            string pozd_srok_zav = "5 2 13 6 21 6 13 21 21";
            string svob_rezerv = "0 0 10 2 13 0 0 9 0";
            string poln_rezerv = "2 0 10 2 13 0 0 9 0";
            string krit_put = "1 3 4 5 6";
            try
            {
                if (textBox22.Text != ran_srok_nach)
                {
                    this.textBox22.BackColor = System.Drawing.Color.Coral;
                }
                else
                {
                    this.textBox22.BackColor = System.Drawing.Color.White;
                }
                if (textBox23.Text != pozd_srok_nach)
                {
                    this.textBox23.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox23.BackColor = System.Drawing.Color.White;

                if (textBox24.Text != ran_srok_zav)
                {
                    this.textBox24.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox24.BackColor = System.Drawing.Color.White;

                if (textBox25.Text != pozd_srok_zav)
                {
                    this.textBox25.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox25.BackColor = System.Drawing.Color.White;

                if (textBox26.Text != svob_rezerv)
                {
                    this.textBox26.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox26.BackColor = System.Drawing.Color.White;

                if (textBox27.Text != poln_rezerv)
                {
                    this.textBox27.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox27.BackColor = System.Drawing.Color.White;

                if (textBox28.Text != krit_put)
                {
                    this.textBox28.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox28.BackColor = System.Drawing.Color.White;


                if ((this.textBox22.BackColor == System.Drawing.Color.Coral)
                || (this.textBox23.BackColor == System.Drawing.Color.Coral)
                || (this.textBox24.BackColor == System.Drawing.Color.Coral)
                || (this.textBox25.BackColor == System.Drawing.Color.Coral)
                || (this.textBox26.BackColor == System.Drawing.Color.Coral)
                || (this.textBox27.BackColor == System.Drawing.Color.Coral)
                || (this.textBox28.BackColor == System.Drawing.Color.Coral))
                {
                    MessageBox.Show("У вас есть ошибка, попробуйте снова");
                }
                else MessageBox.Show("Вы все сделали правильно!!!");

            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ran_srok_nach = "0 0 2 2 2 6 11 5";
            string pozd_srok_nach = "0 3 2 9 10 6 11 13";
            string ran_srok_zav = "2 3 6 4 5 11 17 9";
            string pozd_srok_zav = "2 6 6 11 13 11 17 17";
            string svob_rezerv = "0 3 0 7 0 0 0 8";
            string poln_rezerv = "0 3 0 7 8 0 0 8";
            string krit_put = "1 2 3 4 6";
            try
            {
                if (textBox29.Text != ran_srok_nach)
                {
                    this.textBox29.BackColor = System.Drawing.Color.Coral;
                }
                else
                {
                    this.textBox29.BackColor = System.Drawing.Color.White;
                }
                if (textBox30.Text != pozd_srok_nach)
                {
                    this.textBox30.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox30.BackColor = System.Drawing.Color.White;

                if (textBox31.Text != ran_srok_zav)
                {
                    this.textBox31.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox31.BackColor = System.Drawing.Color.White;

                if (textBox32.Text != pozd_srok_zav)
                {
                    this.textBox32.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox32.BackColor = System.Drawing.Color.White;

                if (textBox33.Text != svob_rezerv)
                {
                    this.textBox33.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox33.BackColor = System.Drawing.Color.White;

                if (textBox34.Text != poln_rezerv)
                {
                    this.textBox34.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox34.BackColor = System.Drawing.Color.White;

                if (textBox35.Text != krit_put)
                {
                    this.textBox35.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox35.BackColor = System.Drawing.Color.White;


                if ((this.textBox29.BackColor == System.Drawing.Color.Coral)
                || (this.textBox30.BackColor == System.Drawing.Color.Coral)
                || (this.textBox31.BackColor == System.Drawing.Color.Coral)
                || (this.textBox32.BackColor == System.Drawing.Color.Coral)
                || (this.textBox33.BackColor == System.Drawing.Color.Coral)
                || (this.textBox34.BackColor == System.Drawing.Color.Coral)
                || (this.textBox35.BackColor == System.Drawing.Color.Coral))
                {
                    MessageBox.Show("У вас есть ошибка, попробуйте снова");
                }
                else MessageBox.Show("Вы все сделали правильно!!!");

            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ran_srok_nach = "0 0 0 5 5 11 4 4 14";
            string pozd_srok_nach = "0 9 6 5 8 11 10 10 14";
            string ran_srok_zav = "5 2 4 11 11 14 8 11 17";
            string pozd_srok_zav = "5 11 10 11 14 14 14 17 17";
            string svob_rezerv = "0 9 0 0 3 0 6 6 0";
            string poln_rezerv = "0 9 6 0 3 0 6 6 0";
            string krit_put = "1 2 3 5 6";
            try
            {
                if (textBox36.Text != ran_srok_nach)
                {
                    this.textBox36.BackColor = System.Drawing.Color.Coral;
                }
                else
                {
                    this.textBox36.BackColor = System.Drawing.Color.White;
                }
                if (textBox37.Text != pozd_srok_nach)
                {
                    this.textBox37.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox37.BackColor = System.Drawing.Color.White;

                if (textBox38.Text != ran_srok_zav)
                {
                    this.textBox38.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox38.BackColor = System.Drawing.Color.White;

                if (textBox39.Text != pozd_srok_zav)
                {
                    this.textBox39.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox39.BackColor = System.Drawing.Color.White;

                if (textBox40.Text != svob_rezerv)
                {
                    this.textBox40.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox40.BackColor = System.Drawing.Color.White;

                if (textBox41.Text != poln_rezerv)
                {
                    this.textBox41.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox41.BackColor = System.Drawing.Color.White;

                if (textBox42.Text != krit_put)
                {
                    this.textBox42.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox42.BackColor = System.Drawing.Color.White;


                if ((this.textBox36.BackColor == System.Drawing.Color.Coral)
                || (this.textBox37.BackColor == System.Drawing.Color.Coral)
                || (this.textBox38.BackColor == System.Drawing.Color.Coral)
                || (this.textBox39.BackColor == System.Drawing.Color.Coral)
                || (this.textBox40.BackColor == System.Drawing.Color.Coral)
                || (this.textBox41.BackColor == System.Drawing.Color.Coral)
                || (this.textBox42.BackColor == System.Drawing.Color.Coral))
                {
                    MessageBox.Show("У вас есть ошибка, попробуйте снова");
                }
                else MessageBox.Show("Вы все сделали правильно!!!");

            }
            catch
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ran_srok_nach = "0 0 0 4 4 10 10 16 13";
            string pozd_srok_nach = "0 8 3 4 11 10 10 16 13";
            string ran_srok_zav = "4 2 10 10 9 16 13 17 17";
            string pozd_srok_zav = "4 10 13 10 16 16 13 17 17";
            string svob_rezerv = "0 8 3 0 7 0 0 0 0";
            string poln_rezerv = "0 8 3 0 7 0 0 0 0";
            string krit_put = "1 2 3 4 5 6 6";
            try
            {
                if (textBox43.Text != ran_srok_nach)
                {
                    this.textBox43.BackColor = System.Drawing.Color.Coral;
                }
                else
                {
                    this.textBox43.BackColor = System.Drawing.Color.White;
                }
                if (textBox44.Text != pozd_srok_nach)
                {
                    this.textBox44.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox44.BackColor = System.Drawing.Color.White;

                if (textBox45.Text != ran_srok_zav)
                {
                    this.textBox45.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox45.BackColor = System.Drawing.Color.White;

                if (textBox46.Text != pozd_srok_zav)
                {
                    this.textBox46.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox46.BackColor = System.Drawing.Color.White;

                if (textBox47.Text != svob_rezerv)
                {
                    this.textBox47.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox47.BackColor = System.Drawing.Color.White;

                if (textBox48.Text != poln_rezerv)
                {
                    this.textBox48.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox48.BackColor = System.Drawing.Color.White;

                if (textBox49.Text != krit_put)
                {
                    this.textBox49.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox49.BackColor = System.Drawing.Color.White;


                if ((this.textBox43.BackColor == System.Drawing.Color.Coral)
                || (this.textBox44.BackColor == System.Drawing.Color.Coral)
                || (this.textBox45.BackColor == System.Drawing.Color.Coral)
                || (this.textBox46.BackColor == System.Drawing.Color.Coral)
                || (this.textBox47.BackColor == System.Drawing.Color.Coral)
                || (this.textBox48.BackColor == System.Drawing.Color.Coral)
                || (this.textBox49.BackColor == System.Drawing.Color.Coral))
                {
                    MessageBox.Show("У вас есть ошибка, попробуйте снова");
                }
                else MessageBox.Show("Вы все сделали правильно!!!");

            }
            catch
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string ran_srok_nach = "0 0 4 4 3 9 9 16";
            string pozd_srok_nach = "1 0 5 11 3 9 15 16";
            string ran_srok_zav = "4 3 8 9 9 16 14 20";
            string pozd_srok_zav = "5 3 9 16 9 16 20 20";
            string svob_rezerv = "0 0 1 7 0 0 6 0";
            string poln_rezerv = "1 0 1 7 0 0 6 0";
            string krit_put = "1 3 4 5 6";
            try
            {
                if (textBox50.Text != ran_srok_nach)
                {
                    this.textBox50.BackColor = System.Drawing.Color.Coral;
                }
                else
                {
                    this.textBox50.BackColor = System.Drawing.Color.White;
                }
                if (textBox51.Text != pozd_srok_nach)
                {
                    this.textBox51.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox51.BackColor = System.Drawing.Color.White;

                if (textBox52.Text != ran_srok_zav)
                {
                    this.textBox52.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox52.BackColor = System.Drawing.Color.White;

                if (textBox53.Text != pozd_srok_zav)
                {
                    this.textBox53.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox53.BackColor = System.Drawing.Color.White;

                if (textBox54.Text != svob_rezerv)
                {
                    this.textBox54.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox54.BackColor = System.Drawing.Color.White;

                if (textBox55.Text != poln_rezerv)
                {
                    this.textBox55.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox55.BackColor = System.Drawing.Color.White;

                if (textBox56.Text != krit_put)
                {
                    this.textBox56.BackColor = System.Drawing.Color.Coral;
                }
                else this.textBox56.BackColor = System.Drawing.Color.White;


                if ((this.textBox50.BackColor == System.Drawing.Color.Coral)
                || (this.textBox51.BackColor == System.Drawing.Color.Coral)
                || (this.textBox52.BackColor == System.Drawing.Color.Coral)
                || (this.textBox53.BackColor == System.Drawing.Color.Coral)
                || (this.textBox54.BackColor == System.Drawing.Color.Coral)
                || (this.textBox55.BackColor == System.Drawing.Color.Coral)
                || (this.textBox56.BackColor == System.Drawing.Color.Coral))
                {
                    MessageBox.Show("У вас есть ошибка, попробуйте снова");
                }
                else MessageBox.Show("Вы все сделали правильно!!!");

            }
            catch
            {

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для правильного ввода необходимо решать задачу последовательно исхлдя из графа. Сначала вводятся ранние и поздние сроки начала, конца и другие для первого пути, в данном случае 1->2 с длиной пути 3. Пишется этот ответ, затем через пробел пишутся все остальные характеристики через пробел, то есть если получен ответ 5, то надо написать 0 5, и аналогично для остальных направлений");
        }
    }
}
