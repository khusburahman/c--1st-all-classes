

namespace object_class;

public class Employe
{
    public int Id;
    public string Name;
    public string Email;
    public string Number;
    public double Salary;
    public Employe(int id, string name, string email, string number, double salary)
    {
        this.Id = id;
        this.Name = name;
        this.Email = email;
        this.Number = number;
        this.Salary = salary;
    }
    public void GetSalary()
    {
        double ta = Salary * 5 / 100;
        double pt=Salary* 5 / 100;
        double hr = ta * 5 / 100;
        double TotalSalary = Salary + pt + hr + ta;
        Console.WriteLine($"\n Your total salary is: {TotalSalary}");
    }
    
    public void display()
    {
        Console.WriteLine($"\n Your id is: {Id} \n Your name is:{Name}\n Your Email is: {Email} \n Your Number is: {Number}");
    }
}
