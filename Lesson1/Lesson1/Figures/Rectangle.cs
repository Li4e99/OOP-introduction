public class Rectangle : Point, ISquare
{
    private double _A;
    private double _B;

    public double A
    {
        get => _A;
        set => _A = value;
    }
    public double B
    {
        get => _B;
        set => _B = value;
    }

    public Rectangle (double x, double y, double a, double b) : base(x, y)

    {
        _A = a;
        _B = b;
    }

    public double GetSquare()
    {
        double square = _A * _B;
        return square;

    }
}

