

namespace constructor;

//public class Triangle
//{
//    public double Tri()
//    {
//        Console.Write("Enter your height: ");
//        double height=Convert.ToDouble(Console.ReadLine());
//        Console.Write("Enter your width: ");
//        double width = Convert.ToDouble(Console.ReadLine());
//        return (.5 * height * width);
//    }
//}




internal class Traiangle
{
    double Height;
    double Width;
    public Traiangle(double Height, double Width)
    {
        this.Height = Height;
        this.Width = Width;
    }

    public static double Tri(double Height, double Width)
    {

        return (.5 * Height * Width);
    }

    //public static void FullName()
    //{
    //    Console.WriteLine("Cute ar dibba ");
    //}
}
