

namespace class_5;

public class Employe
{
    public int Id;
    public string Name;
    public float Salary;
    public Employe(int i, string n, float s)
    {
        Id = i;
        Name = n;
        Salary = s;
    }
    public void Display()
    {
        Console.WriteLine($"Your id {Id} Your name {Name} Your salary {Salary}");
    }
}



