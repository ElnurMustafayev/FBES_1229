namespace AdapterApp;

class ShapeDrawer {
    public IShapeAdapter? shapeAdapter { protected get; set; }

    public void Draw(double x1, double y1, double x2, double y2) {
        shapeAdapter?.Draw(x1, y1, x2, y2);
    }
}

public class Program {
    static void Main() {
        var line = new Line();
        var rectangle = new Rectangle();
        var circle = new Circle();

        //List<Line> shapes = new List<Line>() {
        //    line, rectangle, circle
        //};

        //List<IShapeAdapter> shapeAdapters = new List<IShapeAdapter>() {
        //    new LineAdapter(line),
        //    new RectangleAdapter(rectangle),
        //    new CircleAdapter(circle),
        //};

        //foreach (var adapter in shapeAdapters) {
        //    adapter.Draw(1, 5, 3, 12);
        //}

        ShapeDrawer drawer = new ShapeDrawer();

        drawer.shapeAdapter = new CircleAdapter(circle);

        drawer.Draw(1, 5, 3, 12);
    }
}