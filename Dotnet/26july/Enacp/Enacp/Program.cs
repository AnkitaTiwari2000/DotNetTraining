using System;
using System.Security.Principal;
/*
class Student
{
   /* private int id;
    public int getId()
    {
       return this.id; ;

    }
    public void setId(int id)
    {
        this.id = id;
    }


    public int Id { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        // Console.WriteLine(s.getId());
        s.Id = 1;
        Console.WriteLine(s.Id);


    }
}
*/


public class Student
{
    private int id;
    private String name;
    private int passMarks=35;
    public int PassMarks
    {
        get
        {
            return this.passMarks;
        }
      
    }
    public String Name
    {
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new Exception("NAme can not be a null or Empty");
            }
            this.name = value;
               
        }
        get
        {
            return string.IsNullOrEmpty(this.name) ? "No NAme" : this.name;
        }
    }
}

public class main
{
    public static void Main()
    {
        Student s = new Student();
        s.Name = "nishu";
       
        Console.WriteLine(s.PassMarks);
        Console.WriteLine("Student NAme={0}",s.Name);


    }
}