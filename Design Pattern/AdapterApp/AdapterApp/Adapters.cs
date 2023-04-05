namespace AdapterApp;

public interface IShapeAdapter {
    void Draw(double x1, double y1, double x2, double y2);
}

public class LineAdapter : IShapeAdapter {
	private readonly Line line;

	public LineAdapter(Line line) {
		this.line = line;
	}

    public void Draw(double x1, double y1, double x2, double y2) {
        line.DrawLine(x1, y1, x2, y2);
    }
}

public class CircleAdapter : IShapeAdapter {
    private readonly Circle circle;

    public CircleAdapter(Circle circle) {
        this.circle = circle;
    }

    public void Draw(double x1, double y1, double x2, double y2) {
        this.circle.VeryBadMethodName(x1, y1, radius: (x2 - x1) / 2);
    }
}

public class RectangleAdapter : IShapeAdapter {
    private readonly Rectangle rectangle;

    public RectangleAdapter(Rectangle rectangle) {
        this.rectangle = rectangle;
    }

    public void Draw(double x1, double y1, double x2, double y2) {
        this.rectangle.Draw(x1, y1, width: x2 - x1, height: y2 - y1);
    }
}