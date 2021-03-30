using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;


namespace DanLaba
{
    public partial class Form1 : Form
    {

        Color color = Color.Black;
        bool isPressed = false; 
        Point CurrentPoint; 
        Point PrevPoint;
        ColorDialog colorDialog = new ColorDialog();
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(label3, "Выбирите цвет заливки");
            toolTip1.IsBalloon = true;
            label3.BackColor = Color.Black;
            toolTip1.SetToolTip(button2, "Вы можите выбрать цвет контура нажава в начале на выбор цвета заливки, а потом на эту кнопку");
            toolTip1.IsBalloon = true;
            label3.BackColor = Color.Black;

        }

        int i;
        int x1;
        int y1;
        int x2;
        int y2;

        Graphics g;
        Graphics G; // Объект графики
        PointF[] Arr = new PointF[] // Исходный массив точек
        {
            new PointF(200,300),
            new PointF(5,50),
            new PointF(150,50),
            new PointF(140,140),
            new PointF(150,50),
            new PointF(150,50),
            new PointF(150,50),

        };
        PointF[] Abr = new PointF[] // Исходный массив точек
        {
            new PointF(300,300),
            new PointF(495,50),
            new PointF(350,50),
            new PointF(360,140),
            new PointF(350,50),
            new PointF(350,50),
            new PointF(350,50),

        };


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK) 
            {
                color = colorDialog.Color;
                label3.BackColor = colorDialog.Color; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 2;
            G = Graphics.FromHwnd(pictureBox1.Handle);
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Draw1();
            Draw2();
            g = Graphics.FromHwnd(pictureBox1.Handle);
            Pen p = new Pen(color, 2);
            g.DrawLine(p, 200, 300, 300, 300);
            g.DrawLine(p, 150, 50, 350, 50);
            Pen pen = new Pen(Brushes.Red);
            g.DrawEllipse(pen, 150, 100, 200, 120);


        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
         }


        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 2)
            {
                SolidBrush Fill = new SolidBrush(color);
                g.FillEllipse(Fill, 150, 100, 200, 120);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            pictureBox1.Invalidate();
            pictureBox1.Refresh();
            i = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int Fuctorial(int n) // Функция вычисления факториала
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
                res *= i;
            return res;
        }
        float polinom(int i, int n, float t)// Функция вычисления полинома Бернштейна
        {
            return (Fuctorial(n) / (Fuctorial(i) * Fuctorial(n - i))) * (float)Math.Pow(t, i) * (float)Math.Pow(1 - t, n - i);
        }
        void Draw1()// Функция рисования кривой
        {
            int j = 0;
            float step = 0.01f;// Возьмем шаг 0.01 для большей точности

            PointF[] result = new PointF[101];//Конечный массив точек кривой
            for (float t = 0; t < 1; t += step)
            {
                float ytmp = 0;
                float xtmp = 0;
                for (int i = 0; i < Arr.Length; i++)
                { // проходим по каждой точке
                    float b = polinom(i, Arr.Length - 1, t); // вычисляем наш полином Бернштейна
                    xtmp += Arr[i].X * b; // записываем и прибавляем результат
                    ytmp += Arr[i].Y * b;
                }
                result[j] = new PointF(xtmp, ytmp);
                j++;

            }

            G.DrawLines(new Pen(color), result);// Рисуем полученную кривую Безье

        }

        void Draw2()// Функция рисования кривой
        {
            int j = 0;
            float step = 0.01f;// Возьмем шаг 0.01 для большей точности

            PointF[] result = new PointF[101];//Конечный массив точек кривой
            for (float t = 0; t < 1; t += step)
            {
                float ytmp = 0;
                float xtmp = 0;
                for (int i = 0; i < Abr.Length; i++)
                { // проходим по каждой точке
                    float b = polinom(i, Abr.Length - 1, t); // вычисляем наш полином Бернштейна
                    xtmp += Abr[i].X * b; // записываем и прибавляем результат
                    ytmp += Abr[i].Y * b;
                }
                result[j] = new PointF(xtmp, ytmp);
                j++;

            }

            G.DrawLines(new Pen(color), result);// Рисуем полученную кривую Безье

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
