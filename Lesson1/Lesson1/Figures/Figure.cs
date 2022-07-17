public class Figure : IVisibility, IColorized, IMoveable
{
    public enum Color { black, white, red, orange, yellow, green, blue, purple }

    private Color _Color;

    public enum Visibility { visible, invisible }

    private Visibility _Visibility;

    public override string ToString() => $"Color - {_Color}, Visibility - {_Visibility}";

    public Color FigureColor
    {
        get => _Color;
        set => _Color = value;
    }

    public Visibility FigureVisibility
    {
        get => _Visibility;
        set => _Visibility = value;
    }

    public Visibility GetVisibility()
    {
        return _Visibility;
    }


    public Color GetColor()
    {
        return _Color;
    }

    public double MoveForX(double x, double distance)
    {
        return x + distance;
    }
    public double MoveForY(double y, double distance)
    {
        return y + distance;
    }

    
}

