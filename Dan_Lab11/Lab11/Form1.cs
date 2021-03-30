using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.cat;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        Color color1 = Color.Black;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                // Создание немодального окна и родительских отношений
                // между главным окном и дочерним немодальным окном
                Form2 dialog = new Form2();
                dialog.Owner = this;

                // Копирование текста из полей ввода главного окна 
                // в свойства немодального диалогового окна 

                dialog.SMTP = color1;

                // Добавление обработчика события, 
                // создаваемого дочерним немодальным окном, в список события
                dialog.ApplyHandler += new EventHandler(PropertyForm_Apply);

                // отображение немодального окна
                dialog.Show();
            }
            // Обработчик события, созданного при нажатии кнопки Изменить 
            // в дочернем немодальном окне

        }
        private void PropertyForm_Apply(object sender, System.EventArgs e)
        {
            Form2 dialog = (Form2)sender;

            color1 = dialog.SMTP;
            Bitmap b;

            b = new Bitmap(pictureBox1.Image);
            string colorcontrol = b.GetPixel(0, 0).ToString();
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    if (b.GetPixel(i, j).ToString() != colorcontrol)
                        b.SetPixel(i, j, color1);


                }
            }
            pictureBox1.Image = b;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap b;

            b = new Bitmap(pictureBox1.Image);
            string colorcontrol = b.GetPixel(0, 0).ToString();
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    if (b.GetPixel(i, j).ToString() != colorcontrol)
                        b.SetPixel(i, j, color1);


                }
            }
            pictureBox1.Image = b;
        }
    }
}
