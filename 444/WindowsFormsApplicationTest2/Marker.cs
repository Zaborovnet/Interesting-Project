using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplicationTest2
{
    /// <summary>
    /// Управляющий маркер
    /// </summary>
    public class Marker
    {
        /// <summary>
        /// Радиус маркера
        /// </summary>
        private const int Radius = 10;

        /// <summary>
        /// Флаг, определяющий начало перетаскивания
        /// </summary>
        private bool drag;

        /// <summary>
        /// Ограничивающий прямоугольник
        /// </summary>
        private RectangleF rectangle;

        /// <summary>
        /// Создание нового маркера
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        public Marker(int x, int y)
        {
            rectangle = new RectangleF(x - Radius / 2f, y - Radius / 2f, Radius, Radius);
        }

        /// <summary>
        /// Событие, возникающее при перетаскивании
        /// </summary>
        public Action<PointF> OnDrag { get; set; }

        /// <summary>
        /// Собитие, возникающее при нажании на маркер
        /// </summary>
        public Action<PointF> OnMouseDown { get; set; }

        /// <summary>
        /// Положение маркера
        /// </summary>
        public PointF Location
        {
            get { return new PointF(rectangle.X + Radius / 2f, rectangle.Y + Radius / 2f); }
        }

        /// <summary>
        /// Отрисовка маркера
        /// </summary>
        /// <param name="g">График для отрисовки</param>
        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Black, rectangle);
        }

        /// <summary>
        /// Необходимо вызывать при нажатии мыши
        /// </summary>
        public void MouseDown(MouseEventArgs e)
        {
            if (rectangle.Contains(e.Location))
            {
                drag = true;
                if (OnMouseDown != null)
                {
                    OnMouseDown(e.Location);
                }
            }
        }

        /// <summary>
        /// Необходмио вызывать при отпускании мыши
        /// </summary>
        public void MouseUp()
        {
            drag = false;
        }

        /// <summary>
        /// Необходмо вызывать при передвижении мыши
        /// </summary>
        public void MouseMove(MouseEventArgs e)
        {
            if (drag)
            {
                rectangle.X = e.X - Radius / 2f;
                rectangle.Y = e.Y - Radius / 2f;
                if (OnDrag != null)
                {
                    OnDrag(e.Location);
                }
            }
        }
    }
}