using System;

public class Employee
{
   
    public virtual void m1()
    {
        Console.WriteLine("hii i am employee m1");
    }
    public virtual void m2()
    {
        Console.WriteLine("hii i am emp m2");
    }
}



public class FullTimeEmployee : Employee
{
    public override void m1()
    {
        Console.WriteLine("hii i am ft m1");
    }
    public   void m2()
    {
        Console.WriteLine("hii iam ft m2");
    }
}

public class Program
{
    public static void Main()
    {
        Employee e = new Employee();
        e.m1();
        e.m2();

        FullTimeEmployee fte = new FullTimeEmployee();
        fte.m1();
        fte.m2();
        

        Employee e2 = new FullTimeEmployee();
        e2.m1();
        e2.m2();
        FullTimeEmployee e3 = (FullTimeEmployee)e2;
        e3.m1();
        e3.m2();
    }

}
