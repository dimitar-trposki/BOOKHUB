# BOOKHUB
Документација на Windows Forms App - Онлајн библиотека со забавна игра, BookHub, изработена од Димитар Трпоски и Симеон Ристовски.

# Краток опис на апликацијата  
  Целта на апликацијата е да се имплементира онлајн библиотека со симулација за купување и враќање на книги, како и забавна и едноставна игра која овозможува цртање на корица за случајно генериран наслов. Составена е од три главни форми. Почетната форма овозможува да изберете дали сакате да ги листате книгите во библиотеката, односно дали сакате да купите/вратите книга или да ја играте играта. Доколку го притиснете копчето за влез во библиотеката, се појавува нова форма и ги добивате сите достапни книги групирани по жанрови, а доколку го кликнете копчето за играње на играта, тогаш се појавува формата со соодветната игра. Правилата за играње на играта се дадени во последната точка од овој документ.
# Опис на решението
  При креирањето на апликацијата користевме поголем број на класи со цел да си го олесниме креирањето на апликацијата. Во апликацијата достапни се класите за: Book, Shape, Circle, Square, Line, Polygon, Rectangle, Triangle, Scene и SceneLibrary. Класата Shape е апстрактна класа од која наследуваат сите соодветни форми. Во сите класи се чуваат примитивни податочни типови, како и објекти и податочни структури од типот на низи, stack и листи. Примитивните податочни типови се однесуваат на имиња, цени, количини и слично. Приказот на книги е имплементиран така што корисникот избира соодветен жанр, а потоа со помош на DataGridView се покажува соодветната листа со книги(List<Book>). Апликацијата симулира купување и враќање на книга, онака како што би се случувало во реалниот свет. Покрај оваа симулација, постои и игра која е едноставна за играње, односно љубителот на книги може да нацрта корица за книга според случајно генериран наслов при клик на копче. Тука главна улога играат класите за Scene, Shape и сите оние кои наследуваат од истата.
# Опис на класата Scene
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

  Оваа класа која во нашиот проект ја користиме како сцена за исцртување на форми може да се видат најразлични функционалности како и структури кои се користат за чување на податоците. На почетокот се прикажани листите во кои се чуваат формите од сцената. Потоа се прикажани неколку податочни структури - Stack, кои ги користиме за да овозможиме Undo и Redo функционалности. Исто така, се чуваат и моменталната висина, ширина на прозорецот, курсорот, големината на формите и дебелината. Методите кои што се содржат во оваа класа се: додавање на форма на сцената, додавање на точки кај линија и полигон, ажурирање на курсорот, исцртување на формите и Undo/Redo функционалностите.
# Screenshots од изгледот на апликацијата
  - Menu Form  
    ![MenuForm](https://github.com/dimitar-trposki/BOOKHUB/assets/174914168/9f4f89f5-036c-4ac3-8bd1-df6e4a0cbd28)
  - Library Form  
    ![LibraryForm](https://github.com/dimitar-trposki/BOOKHUB/assets/174914168/8af64132-4f44-41b5-a4b8-027756de750a)
  - Image Form  
    ![ImageForm](https://github.com/dimitar-trposki/BOOKHUB/assets/174914168/eddd8fac-e511-4be6-8b4a-22bc32f1d224)
  - Buy Form  
    ![BuyForm](https://github.com/dimitar-trposki/BOOKHUB/assets/174914168/31c32efe-17f1-435f-9b1a-ebd9081908ae)
  - Return Form  
    ![ReturnForm](https://github.com/dimitar-trposki/BOOKHUB/assets/174914168/07935c80-1c50-4a48-9665-f5a938a16baa)
  - Book Cover Drawing Form  
    ![BookCoverDrawingForm](https://github.com/dimitar-trposki/BOOKHUB/assets/174914168/e833f872-dc91-4c15-82e2-beddd0cb9473)
# Правила на играта
  - За започнување на играта притиснете на зеленото копче Start. Со започнување на играта вас ќе ви биде доделен наслов на книгата за која ќе треба да ја нацртате корицата. Со притискањето на Start ќе можете да цртате на белиот панел на кој претходно не можеше да се црта.
  - Доколку сакате да ја промените формата со која ќе цртате, тоа можете да го направите во секцијата Shapes.
  - За промена на дебелинат на линијата за цртање на формите посетете ја секцијата Thickness.
  - Исто така, можете да ја промените и бојата на формите со притискање на секцијата Color. Се отвора мени од кое можете да ја изберете бојата која сакате да ја користите за обојување на формите кои тековно ги цртате.
  - Доколку завршите порано од истекување на тајмерот можете да ја завршите играта и да добиете поголем број на поени со притискање на црвеното копче End.
  - Напомена: Доколку сакате формата да биде во некоја друга боја а не бела, пред да ја нацртате формата изберете ја посакуваната боја.
