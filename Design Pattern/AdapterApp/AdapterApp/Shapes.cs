namespace AdapterApp;

public class Line {
    public void DrawLine(double x1, double y1, double x2, double y2) {
        Console.WriteLine("Line");
    }
}

public class Rectangle {
    public void Draw(double x, double y, double width, double height) {
        Console.WriteLine("Rectangle");
    }
}

public class Circle {
    public void VeryBadMethodName(double x, double y, double radius) {
        Console.WriteLine("Circle");
    }
}