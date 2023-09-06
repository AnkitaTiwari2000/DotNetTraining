using System;
class Program
{
  /*  pass by value example
   *  static void Main()//main method
    {
        int i = 0;
        m1(i);
        Console.WriteLine(i);
    }
    static void m1(int j)
    {
        j = 10;
    }*/


    //pass by reference

    static void Main()
    {
        int i = 0;

        m2(ref i);
        Console.WriteLine( i);
    }
    static void m2(ref int j)
    {
        j = 10;
    }
}