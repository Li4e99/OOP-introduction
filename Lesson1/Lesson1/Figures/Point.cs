public class Point : Figure
{
    private double _X;
    private double _Y;

    public double X
    {
        get => _X;
        set => _X = value;
    }
    public double Y
    {
        get => _Y;
        set => _Y = value;
    }
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public new void MoveForX(double x, double distance)
    {
        _X = x + distance;
    }
    public new void MoveForY(double y, double distance)
    {
        _X = y + distance;
    }




}

