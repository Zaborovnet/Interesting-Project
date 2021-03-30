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



namespace WinFormsApp_Paint
{
    public partial class Form1 : Form
    {
        bool mouseDown;
        Bitmap snapshot;
        Bitmap tempDraw;
        Color color = Color.Black; //Создаем переменную типа Color присваиваем ей черный цвет.
        bool isPressed = false; //логическая переменная понадобиться для опеределения когда можно рисовать на panel
        Point CurrentPoint; //Текущая точка ресунка.
        Point PrevPoint; //Это начальная точка рисунка.
        ColorDialog colorDialog = new ColorDialog(); //диалоговое окно для выбора цвета.
        readonly BezierCurve bezier;
        readonly Marker[] markers = new Marker[4];
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(label2, "Выбирите цвет");
            toolTip1.IsBalloon = true;
            toolTip2.SetToolTip(numericUpDown1, "Выбирите толщину пера");
            toolTip2.IsBalloon = true;
            toolTip3.SetToolTip(button6, "Кисть");
            toolTip3.IsBalloon = true;
            toolTip4.SetToolTip(button1, "Заливка");
            toolTip4.IsBalloon = true;
            toolTip5.SetToolTip(button4, "Прямые");
            toolTip5.IsBalloon = true;
            toolTip6.SetToolTip(button5, "Посмореть кривую Безье");
            toolTip6.IsBalloon = true;
            toolTip7.SetToolTip(button2, "Очистить холст");
            toolTip7.IsBalloon = true;

            label2.BackColor = Color.Black; //По умолчанию для пера задан черный цвет, поэтому мы зададим такой же фон для label2
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            snapshot = new Bitmap(pictureBox1.ClientRectangle.Width, this.ClientRectangle.Height);
            markers[0] = new Marker(100, 200);
            markers[1] = new Marker(150, 250);
            markers[2] = new Marker(200, 150);
            markers[3] = new Marker(250, 200);
            for (int index = 0; index < markers.Length; index++)
            {
                Marker marker = markers[index];
                int i = index;
                marker.OnDrag += f =>
                {
                    bezier[i] = f;
                    pictureBox1.Invalidate();
                };
                marker.OnMouseDown += f => { Cursor = Cursors.Hand; };
            }

            bezier = new BezierCurve(markers.Select(m => m.Location).ToArray());
        }

        int i = 0;
        int x1;
        int y1;
        int x2;
        int y2;


        private void label2_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK) //Если окно закрылось с OK, то меняем цвет для пера и фона label2
            {
                color = colorDialog.Color; //меняем цвет для пера
                label2.BackColor = colorDialog.Color; //меняем цвет для Фона label2
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Graphics.FromImage(tempDraw).Clear(Color.Black);

            pictureBox1.Invalidate();
            pictureBox1.Refresh();
            snapshot = new Bitmap(pictureBox1.ClientRectangle.Width, this.ClientRectangle.Height);

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            isPressed = false;
            snapshot = (Bitmap)tempDraw.Clone();
            foreach (Marker marker in markers)
            {
                marker.MouseUp();
            }
            Cursor = Cursors.Arrow;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                x2 = e.X;
                y2 = e.Y;
                PrevPoint = CurrentPoint;
                CurrentPoint = e.Location;
                pictureBox1.Invalidate();
            }
            if (e.Button == MouseButtons.Left)
            {
                foreach (Marker marker in markers)
                {
                    marker.MouseMove(e);
                    Thread.Sleep(0);
                }
            }

        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            x1 = e.X;
            y1 = e.Y;
            tempDraw = (Bitmap)snapshot.Clone();
            isPressed = true;
            CurrentPoint = e.Location;
            foreach (Marker marker in markers)
            {
                marker.MouseDown(e);
            }
        }





        private void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            targetColor = bmp.GetPixel(pt.X, pt.Y);
            if (targetColor.ToArgb().Equals(replacementColor.ToArgb()))
            {
                return;
            }

            Stack<Point> pixels = new Stack<Point>();

            pixels.Push(pt);
            while (pixels.Count != 0)
            {
                Point temp = pixels.Pop();
                int y1 = temp.Y;
                while (y1 >= 0 && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    y1--;
                }
                y1++;
                bool spanLeft = false;
                bool spanRight = false;
                while (y1 < bmp.Height && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    bmp.SetPixel(temp.X, y1, replacementColor);

                    if (!spanLeft && temp.X > 0 && bmp.GetPixel(temp.X - 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X - 1, y1));
                        spanLeft = true;
                    }
                    else if (spanLeft && temp.X - 1 == 0 && bmp.GetPixel(temp.X - 1, y1) != targetColor)
                    {
                        spanLeft = false;
                    }
                    if (!spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X + 1, y1));
                        spanRight = true;
                    }
                    else if (spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) != targetColor)
                    {
                        spanRight = false;
                    }
                    y1++;
                }

            }
            pictureBox1.Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            i = 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {





                switch (i)
                {
                    case 1:
                        {
                            if (tempDraw != null)
                            {

                                Graphics g = Graphics.FromImage(tempDraw);
                                Pen pen = new Pen(color, (float)numericUpDown1.Value);
                                g.DrawLine(pen, x1, y1, x2, y2);
                                pen.Dispose();
                                e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
                                g.Dispose();
                                x1 = x2;
                                y1 = y2;

                        }
                        }
                        break;
                    case 2:
                        {
                            if (tempDraw != null)
                            {
                            tempDraw = (Bitmap)snapshot.Clone();
                            FloodFill(tempDraw, CurrentPoint, Color.White, label2.BackColor);
                            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);

                        }

                        }
                        break;

                    case 3:
                        {
                            if (tempDraw != null)
                            {
                                tempDraw = (Bitmap)snapshot.Clone();
                                Graphics g = Graphics.FromImage(tempDraw);
                                Pen pen = new Pen(color, (float)numericUpDown1.Value); //Создаем перо, задаем ему цвет и толщину.
                                g.DrawLine(pen, x1, y1, x2, y2);
                                e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);





                        }
                        }
                        break;

                case 5:
                    {
                        if (tempDraw != null)
                        {
                            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                            Pen pen = new Pen(Color.Gray, 1f);
                            e.Graphics.DrawLines(pen, markers.Select(m => m.Location).ToArray());
                            foreach (Marker marker in markers)
                            {
                                marker.Draw(e.Graphics);
                            }
                            bezier.Draw(e.Graphics);
                        }
                    }
                    break;


            }  }




            private void button3_Click(object sender, EventArgs e)
            {
                i = 4;
            }

            private void button5_Click(object sender, EventArgs e)
            {
                i = 5;
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void numericUpDown1_ValueChanged(object sender, EventArgs e)
            {

            }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }

    }


