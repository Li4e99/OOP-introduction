public class Circle : Point, ISquare
{
    private double _Radius;

    public double Radius
    {
        get => _Radius;
        set => _Radius = value;
    }

    public Circle(double x, double y, double radius) : base(x, y)

    {
        _Radius = radius;
    }

    public double GetSquare()
    {

        double square = _Radius * _Radius * Math.PI;
        return square;

    }
}
