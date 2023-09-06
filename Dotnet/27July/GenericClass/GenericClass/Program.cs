using System;
class GenericClass<I>
{

  public  static void Main()
    {
        GenericClass<string> store = new GenericClass<string>();
        store.dis("Hello World");

    }
    public static void dis(I data)
    {
        Console.WriteLine("the data is : "+data);
    }
     
}