

namespace class_5;

public class Ractangle
{
    private double width;
    private double height;
    public void setWidth(double width)
    {
        this.width = width;
    }
    public void setHeight(double height)
    {
        this.height = height;
    }
    public double racArea() {

        return this.width * this.height;
    }
    public void printData()
    {
        Console.WriteLine("Width = " + this.width);
        Console.WriteLine("Height = " + this.height);
        double area=this.racArea();
        Console.WriteLine("Area=" + area);
    }


    }



