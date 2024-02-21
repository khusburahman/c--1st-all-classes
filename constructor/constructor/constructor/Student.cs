

namespace constructor;


public class Student { 
     public int id;
     public string name;
     public float roll;
    public Student(int id, string name,float roll)
    {
        this.id= id;
        this.name= name;
        this.roll=roll;
    }
    public void display()
    {
        Console.WriteLine($"Your id is: {id} your name is: {name} your roll is: {roll}");
    }

}
