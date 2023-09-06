using System;

public class Customer
{
    private int _id;
    public String name;
    public int ID

    {
        get
        {
            return _id;
        }
        set
        {
            _id = 10;
        }
    }


}



public class MainClass
{
    public  static void Main()
    {
        Customer c1 = new Customer();
        Console.WriteLine(c1.ID);
    }
}

