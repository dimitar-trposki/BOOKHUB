using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHub
{
    [Serializable]
    public class Scene
    {
        public List<Shape> Shapes { get; set; }
        public List<Polygon> Polygons { get; set; }
        public List<Line> Lines { get; set; }

        public Stack<Shape> ShapesUndoRedo { get; set; }
        public Stack<Polygon> PolygonsUndoRedo { get; set; }
        public Stack<Line> LineUndoRedo { get; set; }
        public Stack<string> ShapeTypes { get; set; }
        public Stack<string> ShapeTypesRedo { get; set; }

        public Polygon CurrentPolygon { get; set; }
        public Point LastPoint { get; set; }
        public Point Cursor { get; set; }

        public Color Color { get; set; }
        public int Size { get; set; }
        public int Thickness { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public int CounterOfShapes { get; set; }

        public Scene()
        {
            Shapes = new List<Shape>();
            Polygons = new List<Polygon>();
            Lines = new List<Line>();
            ShapesUndoRedo = new Stack<Shape>();
            PolygonsUndoRedo = new Stack<Polygon>();
            LineUndoRedo = new Stack<Line>();
            ShapeTypes = new Stack<string>();
            ShapeTypesRedo = new Stack<string>();
            CurrentPolygon = new Polygon(Thickness);
            LastPoint = Point.Empty;
            Color = Color.White;
            Size = 30;
            Thickness = 3;
            this.Width = Width;
            this.Height = Height;
        }

        //додавање на форма/Shape
        public void AddShape(Shape s)
        {
            Shapes.Add(s);
            CounterOfShapes++;
        }

        //додавање на точки за формирање на полигон
        public void AddPointToPolygon(Point p, Color color)
        {
            CurrentPolygon.AddPointToPolygon(p, color);
            if (CurrentPolygon.IsClosed)
            {
                Polygons.Add(CurrentPolygon);
                CurrentPolygon = new Polygon(this.Thickness);
                CounterOfShapes++;
            }
        }

        //додавање на точки за формирање на линија
        public void AddPointToLine(Point point)
        {
            if (!LastPoint.IsEmpty)
            {
                Lines.Add(new Line(LastPoint, point, Color, this.Thickness));
                LastPoint = new Point();
                CounterOfShapes++;
            }
            else
            {
                LastPoint = point;
            }
        }

        //земање на тековната позиција на курсорот 
        public void UpdateCursor(Point p)
        {
            CurrentPolygon.UpdateCursor(p);
        }

        //метод кој се користи за цртање на формите со помош на инстанца од Graphics
        public void Draw(Graphics g)
        {
            foreach (var shape in Shapes)
            {
                shape.Draw(g);
            }

            CurrentPolygon.Draw(g);
            foreach (Polygon polygon in Polygons)
            {
                polygon.Draw(g);
            }

            foreach (Line line in Lines)
            {
                line.Draw(g);
            }
        }

        //метод кој се користи за ставање линии на Stack кои подоцна можеме да ги вратиме на панелот за цртање 
        public void LineUndo()
        {
            if (Lines.Count > 0)
            {
                Line l = Lines[Lines.Count - 1];
                LineUndoRedo.Push(l);
                Lines.RemoveAt(Lines.Count - 1);
                if (Lines.Count == 0)
                {
                    LastPoint = Point.Empty;
                }
                else
                {
                    LastPoint = Lines[Lines.Count - 1].Right;
                }
            }
        }

        //метод кој се користи за вадење линии од Stack кои претходно сме ги ставиле со помош на методот LineUndo()
        public void LineRedo()
        {
            if (LineUndoRedo.Count > 0)
            {
                Line l = LineUndoRedo.Pop();
                Lines.Add(l);
                LastPoint = l.Right;
            }
        }

        //метод кој се користи за ставање форми на Stack кои подоцна можеме да ги вратиме на панелот за цртање 
        public void ShapeUndo()
        {
            if (Shapes.Count > 0)
            {
                Shape s = Shapes[Shapes.Count - 1];
                ShapesUndoRedo.Push(s);
                Shapes.RemoveAt(Shapes.Count - 1);
            }
        }

        //метод кој се користи за вадење форми од Stack кои претходно сме ги ставиле со помош на методот ShapeUndo()
        public void ShapeRedo()
        {
            if (ShapesUndoRedo.Count > 0)
            {
                Shape s = ShapesUndoRedo.Pop();
                Shapes.Add(s);
            }
        }

        //метод кој се користи за ставање полигони на Stack кои подоцна можеме да ги вратиме на панелот за цртање 
        public void PolygonUndo()
        {
            if (Polygons.Count > 0)
            {
                Polygon m = Polygons[Polygons.Count - 1];
                PolygonsUndoRedo.Push(m);
                Polygons.RemoveAt(Polygons.Count - 1);
            }
        }

        //метод кој се користи за вадење полигони од Stack кои претходно сме ги ставиле со помош на методот PolygonUndo()
        public void PolygonRedo()
        {
            if (PolygonsUndoRedo.Count > 0)
            {
                Polygon m = PolygonsUndoRedo.Pop();
                Polygons.Add(m);
            }
        }
    }
}
