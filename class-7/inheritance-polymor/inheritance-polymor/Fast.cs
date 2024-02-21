namespace inheritance_polymor;

public class Fast : IFast
{
    public double Div(double x, double y)
    {
        return x / y;
    }

    public double Mul(double x, double y)
    {
        return (x * y);
    }

    public double Sub(double x, double y)
    {
        return x - y;
    }

    public double Sum(double x, double y)
    {
        return x + y;
    }

}
