using System;

public class Customer
{
    public String name { get; set; }
    public int age { get; set; }

    public Customer()
    {

    }
    public Customer(String name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
public class MainClass
{
    private static void Main()
    {
        Customer c = new Customer();
        c.name = "hii";
        c.age = 10;
       
    }
}
