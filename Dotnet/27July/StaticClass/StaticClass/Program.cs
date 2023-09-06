// See https://aka.ms/new-console-template for more information
using System;
public static class StaticC{

    private static int _id;
    public static int id=1;
   public  static int Sum(int a,int b)
    {
        Console.WriteLine(a+b);
        return 0;
    }
    

}
class MAin
{
    public static void Main()
    {
        var i = StaticC.Sum(12, 34);
        // StaticC.Sum(12,34);
        var a = StaticC.id;
        Console.WriteLine(a);
    }
}