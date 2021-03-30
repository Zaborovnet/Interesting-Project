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
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            button2.Click += button2_Click;
            // расширенное окно для выбора цвета
            colorDialog1.FullOpen = true;
            // установка начального цвета для colorDialog
            colorDialog1.Color = this.BackColor;
            ColorDialog colorDialog = new ColorDialog();
            pictureBox1.Image = Properties.Resources.cat;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public Color SMTP
        {
            get
            {
                return colorDialog1.Color;
            }
            set
            {
                colorDialog1.Color = value;
            }
        }

        // Объявление события event событийный_делегат объект
        public event EventHandler ApplyHandler;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap b;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                b = new Bitmap(pictureBox1.Image);
                string colorcontrol = b.GetPixel(0, 0).ToString();
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        if (b.GetPixel(i, j).ToString() != colorcontrol)
                            b.SetPixel(i, j, colorDialog1.Color);


                    }
                }
                pictureBox1.Image = b;

            }
            // Если определен обработчик события, то он вызывается
            // Ему передается ссылка на дочернее окно и параметры события
            if (ApplyHandler != null)
                // Генерируем событие, обработчик для которого зарегистрирован в главном окне
                ApplyHandler(this, new EventArgs());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Bitmap b;

            b = new Bitmap(pictureBox1.Image);
            string colorcontrol = b.GetPixel(0, 0).ToString();
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    if (b.GetPixel(i, j).ToString() != colorcontrol)
                        b.SetPixel(i, j, colorDialog1.Color);


                }
            }
            pictureBox1.Image = b;
        }
    }
}
