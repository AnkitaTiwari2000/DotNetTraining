using System;
using System.Collections;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        ArrayList array = new ArrayList();
        array.Add("BMW");
        array.Add("Farari");
        array.Add("Thar");
       
        array.Add("hello3");
        array.Add(5);
        
       // array[4] = array[4].ToString();
        foreach (var item in array)
            Console.WriteLine(item);



        Console.WriteLine("insert at 1st position.....");
        array.Insert(1, "hii");

        foreach(var value in array)
        {
            Console.WriteLine(value);
        }
        //count
       // Console.WriteLine(" After {0}", array.Count);
        Console.WriteLine(" remove...........");
        array.Remove("hello3");
        foreach(var item in array)
            Console.WriteLine(item);

        Console.WriteLine(" Remove At Position.................");
        array.RemoveAt(0);
        foreach(var item in array)
            Console.WriteLine(item);

        Console.WriteLine("remove range--------------------");
        array.RemoveRange(0, 1);
        foreach(var item in array)

                Console.WriteLine(item);
        Console.WriteLine(" Clean All------------");
        //  array.Clear();

        Console.WriteLine("Contains ---------------------");
        Console.WriteLine(array.Contains(5));

        Console.WriteLine("Get Range----------------------");
        ArrayList names = new ArrayList(0);
        names = array.GetRange(0, 1);
        foreach (var item in names)
            Console.WriteLine(item);




    }
}
