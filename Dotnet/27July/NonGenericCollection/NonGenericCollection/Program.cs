// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList arr = new ArrayList();
        Program1 p = new Program1();
        arr.Add(1);
        arr.Add("hii");
        arr.Add(2);
      
        foreach(object i in arr)
        {
            Console.WriteLine(i);
        }
    }
}

internal class Program1
{
}