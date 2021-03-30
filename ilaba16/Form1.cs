using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilaba16
{
    public partial class Form1 : Form
    {
        string b;
        public Form1()
        {
            InitializeComponent();
        }

        private void сервисToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void правкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText() == true)
            {
                //Извлекаем (точнее копируем) его и сохраняем в переменную
                string someText = Clipboard.GetText();

                //Выводим показываем сообщение с текстом, скопированным из буфера обмена
                MessageBox.Show(this, someText, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //Выводим сообщение о том, что в буфере обмена нет текста
                MessageBox.Show(this, "В буфере обмена нет текста", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = Clipboard.GetText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                b = textBox1.Text;
                Clipboard.SetText(b);
            }
            catch { }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
 
                Clipboard.SetImage(pictureBox1.Image);
            }
            catch { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Clipboard.GetImage();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                if (Clipboard.ContainsImage() == true)
                {
                    //Извлекаем (точнее копируем) его и сохраняем в переменную
                    string someText ="Изображение в буфере обмена";

                    //Выводим показываем сообщение с текстом, скопированным из буфера обмена
                    MessageBox.Show(this, someText, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    //Выводим сообщение о том, что в буфере обмена нет текста
                    MessageBox.Show(this, "В буфере обмена нет изображения", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
