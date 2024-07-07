using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub
{
    [Serializable]
    public class Polygon
    {
        public List<Point> Points { get; set; }
        public int Thickness { get; set; }
        public Color Color { get; set; }
        public bool IsClosed { get; set; } = false;
        public bool IsCloseToStart { get; set; } = false;
        public Point Cursor { get; set; } = new Point();

        public Polygon(int thickness)
        {
            Points = new List<Point>();
            Thickness = thickness;
        }

        //додавање на точка на полигонот
        public void AddPointToPolygon(Point p, Color color)
        {
            IsCloseToStart = NearStart();
            if (IsCloseToStart)
            {
                Points.Add(Points[0]);
                IsClosed = true;
                IsCloseToStart = false;
            }
            else
            {
                Points.Add(p);
            }
            this.Color = color;
        }

        //ажурирање на курсорот
        public void UpdateCursor(Point p)
        {
            Cursor = p;
            IsCloseToStart = NearStart();
        }

        //проверка дали курсорот се наоѓа во близина на почетната точка
        public bool NearStart()
        {
            if (Points.Count < 3)
            {
                return false;
            }
            Point FirstPoint = Points[0];
            double Distance = Math.Sqrt(Math.Pow(FirstPoint.X - Cursor.X, 2) + Math.Pow(FirstPoint.Y - Cursor.Y, 2));
            return Distance <= 5;
        }

        //исцртување на полигонот
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, Thickness);
            Brush brush = new SolidBrush(Color);
            Pen dashedPen = new Pen(Color.Black, 1);
            dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            if (Points.Count >= 2)
            {
                g.DrawLines(pen, Points.ToArray());
                //исцртување на мал круг околу почетната точка при hover со маусот
                if (IsCloseToStart)
                {
                    Point firstPoint = Points[0];
                    g.DrawEllipse(dashedPen, firstPoint.X - 5, firstPoint.Y - 5, 10, 10);
                }
                //боење на полигонот
                if (IsClosed)
                {
                    g.FillPolygon(brush, Points.ToArray());
                }
            }

            //исцртување на привремена испрекината линија со движење на курсорот
            if (Points.Count > 0)
            {
                Point lastPoint = Points[Points.Count - 1];
                g.DrawLine(dashedPen, lastPoint, Cursor);
            }

            pen.Dispose();
            dashedPen.Dispose();
            brush.Dispose();
        }

    }
}
