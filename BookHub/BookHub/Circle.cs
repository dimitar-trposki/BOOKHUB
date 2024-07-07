using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub
{
    [Serializable]
    public class Circle : Shape
    {
        public Circle(Color color, Point location, int size, int thickness) : base(color, location, size, thickness)
        {
        }

        //исцртување на круг
        public override void Draw(Graphics g)
        {
            //исцртување на обиколка
            Pen p = new Pen(Color.Black, Thickness);
            g.DrawEllipse(p, this.Location.X - this.Size, this.Location.Y - this.Size, 2 * this.Size, 2 * this.Size);
            p.Dispose();

            //боење на кругот
            Brush brush = new SolidBrush(this.Color);
            g.FillEllipse(brush, this.Location.X - this.Size, this.Location.Y - this.Size, 2 * this.Size, 2 * this.Size);
            brush.Dispose();
        }
    }
}
