

using System.Security.Principal;

namespace class_5;

public class Account
{
    public int id;
    public string name;
    public static float rateOfInterest;
    public Account(int id,string name)
    {
        this.id = id;
        this.name = name;
    }
    public Account()
    {
        rateOfInterest = 55.9f;
    }
    public void display()
    {
        Console.WriteLine($"Your Id is {id} your name is {name} your rate of rant {rateOfInterest}");
    }

}
