public class Rational
{
    private int _Numerator; //числитель 

    private int _Denominator; //знаменатель

    public double RationalNumber => (double)_Numerator) / _Denominator;

    public override string ToString() => $"{Numerator}/{Denominator}";

    public Rational ()
    {
        _Numerator = 0;
        _Denominator = 1;
    }

    public Rational (int numerator, int denominator)
    {
        if (denominator == 0)
            throw new Exception("На ноль делить нельзя!");
        int nod= 1;
        if (numerator == 0)
        {
            numerator = 0;
            denominator = 1;
            return;
        }

        if (numerator > 0)
            nod= NOD(numerator, denominator);
        else
            nod = NOD(numerator, denominator);
        _Numerator = numerator / nod;
        _Denominator = denominator / nod;
    }

    public int Numerator
    {
        get => _Numerator; 
        set => _Numerator = value; 
    }

    public int Denominator
    {
        get => _Denominator;
        set => _Denominator = value;
    }

    /// <summary>Статический метод возвращающий наибольший общий делитель двух положительных чисел</summary>
    /// <param name="a">Первое число</param>
    /// <param name="b">Второе число</param>
    /// <returns>Возвращает ноль - если оба чисела равно нулю, в остальных случаях НОД</returns>
    public static int NOD (int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static implicit operator float(Rational r1) => r1.RationalNumber;

    public static implicit operator Rational(int r1) => new Rational(r1, 1);

  
    public static Rational operator +(Rational r1, Rational r2)
    {
        return new Rational
            (
                (int)(r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator),
                r1.Denominator * r2.Denominator
            );
    }

    public static Rational operator ++(Rational a)
    {
        return a + 1;
    }

    public static Rational operator -(Rational r1, Rational r2)
    {
        return r1 + (-1 * r2);
    }
    public static Rational operator --(Rational a)
    {
        return a - 1;
    }

    public static Rational operator *(Rational r1, Rational r2)
    {
        return new Rational
            (
                (int)(r1.Numerator * r2.Numerator),
                 (int)(r1.Denominator * r2.Denominator)
            );
    }
 
    public static Rational operator /(Rational r1, Rational r2)
    {
        return new Rational
            (
                (int)(r1.Numerator * r2.Denominator),
                (int)(r1.Denominator * r2.Numerator)
            );
    }
    public static Rational operator %(Rational r1, Rational r2)
    {
        return new Rational
            (
                (int)(r1.Numerator * r2.Denominator),
                (int)(r1.Denominator * r2.Numerator)
            );
    }

    public static bool operator >(Rational r1, Rational r2)
    {
        return (r1 - r2).Numerator > 0;
    }

    public static bool operator <(Rational r1, Rational r2)
    {
        return (r1 - r2).Numerator < 0;
    }

    public static bool operator == (Rational r1, Rational r2)
    {
        return (r1 - r2).Numerator == 0;
    }

    public static bool operator <=(Rational r1, Rational r2)
    {
        return !(r1 > r2);
    }

    public static bool operator >=(Rational r1, Rational r2)
    {
        return !(r1 < r2);
    }

    public static bool operator !=(Rational r1, Rational r2)
    {
        return Equals(r1, r2);
    }

    public override bool Equals(object obj)
    {
        if (!(obj is Rational))
        {
            return false;
        }

        var number = (Rational)obj;
        return Numerator == number.Numerator &&
               Denominator == number.Denominator;
    }

    public override int GetHashCode()
    {
        var hashCode = -1534900553;
        hashCode = hashCode * -1521134295 + Numerator.GetHashCode();
        hashCode = hashCode * -1521134295 + Denominator.GetHashCode();
        return hashCode;
    }
}
