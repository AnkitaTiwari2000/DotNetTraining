// See https://aka.ms/new-console-template for more information
using System;
class RefVal
{
    static void Add(int a) {
        a=10; 
       
        Console.WriteLine("add method"+a);
    }
    static void Main(string[] args)
    {
        int a = 25;
      
        Console.WriteLine("mainmethod"+a);
        Add(a);
        Console.WriteLine("recll add method"+a);


    }
}
