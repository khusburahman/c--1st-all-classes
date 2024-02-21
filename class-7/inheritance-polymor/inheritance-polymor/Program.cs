
//Console.Write("Enter the Prime number:");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    int result = 0;
//    for (int j = i; j <= i; j++)
//    {
//        if (i % j == 0)
//        {
//            result++;
//        }
//    }
//    if (result == 2)
//    {
//        Console.Write(i);
//    }

//}
//Console.ReadKey(true);


//Console.Write("Enter the number: ");
//int E=Convert.ToInt32(Console.ReadLine());
//for (int i = 2; i < E; i++)
//{
//    bool n = true;
//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//        {
//            n = false;
//            break;
//        }
//    }
//    if (n)
//    {
//        Console.Write(i + " ");
//    }
//}
//Console.ReadKey(true);



using inheritance_polymor;
using System.Diagnostics.CodeAnalysis;

Fast fast = new Fast();
Console.WriteLine("\n Divide result is: " + fast.Div(10, 2));
Console.WriteLine("\n Multiplex result is: " + fast.Mul(5, 4));
Console.WriteLine("\n Sub result is: " + fast.Sub(5, 4));
Console.WriteLine("\n Sum result is: " + fast.Sum(7, 3));

