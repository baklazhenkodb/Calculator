using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Задаем переменные для вычисляемых полей
        float a, b;
        //Переменная хранения операции
        int count;
        //Тоггл для знака
        bool znak = true;

        //Обработка нажатия кнопки 0
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        //Обработка нажатия кнопки ,
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(","))  //На каждое число допускается только один разделитель!
            { }
            else textBox1.Text = textBox1.Text + ",";

        }

        //Обработка нажатия кнопки 1
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        //Обработка нажатия кнопки 2

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        //Обработка нажатия кнопки 3

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        //Обработка нажатия кнопки 4
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        //Обработка нажатия кнопки 5
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        //Обработка нажатия кнопки 6
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        //Обработка нажатия кнопки 7
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        //Обработка нажатия кнопки 8
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        //Обработка нажатия кнопки 9
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        //Обработка нажатия кнопки +\- - добавляет/убирает знак у текущего числа
        private void button1_Click(object sender, EventArgs e)
        {
            if(znak==true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak==false)
            {
                textBox1.Text=textBox1.Text.Replace("-", "");
                znak = true;
            }
            
        }

        // Вычисление результата с учетом операции и знака при нажатии кнопки =
        private void calculate()
        {

            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }

        //Обработчик нажатия кнопки +
        private void button4_Click(object sender, EventArgs e)
        {
            // Заносим значение тексбокса в переменную и очищаем результат
            a = float.Parse(textBox1.Text);
            textBox1.Clear();

            //Устанавливаем знак + в переменной
            count = 1;

            //Заносим промежуточные значения в буфер
            label1.Text = a.ToString() + "+";
            znak = true;

        }

        //Обработчик нажатия кнопки -
        private void button8_Click(object sender, EventArgs e)
        {
            // Заносим значение тексбокса в переменную и очищаем результат
            a = float.Parse(textBox1.Text);
            textBox1.Clear();

            //Устанавливаем знак - в переменной
            count = 2;

            //Заносим промежуточные значения в буфер
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        //Обработчик нажатия кнопки *
        private void button12_Click(object sender, EventArgs e)
        {
            // Заносим значение тексбокса в переменную и очищаем результат
            a = float.Parse(textBox1.Text);
            textBox1.Clear();

            //Устанавливаем знак * в переменной
            count = 3;

            //Заносим промежуточные значения в буфер
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        //Обработчик нажатия кнопки /
        private void button16_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }


        //Обработчик нажатия кнопки = - вызвваем процедуру вычисления
        private void button19_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        //Обработчик нажатия кнопки С - стираем все данные
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Обработчик нажатия кнопки <-
        private void button2_Click(object sender, EventArgs e)
        {
            //Уменьшаем длину строки
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();

            //Перезаписываем строку
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        
    }
}
