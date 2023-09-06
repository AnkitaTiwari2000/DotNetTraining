// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
class Program
{
    static void Main()
    {
        SortedList<int,string> sl = new SortedList<int ,string>();
        sl.Add(1 , "oracle");
        sl.Add(3, "vb.net");
        sl.Add(2, "cs.net");
        sl.Add(4, "asp.net");

        foreach (var d in sl)
        {
            Console.Write(d.Key + " " + d.Value );
            



        }
        Console.WriteLine("count...............................");
        Console.WriteLine("Count"+" " +sl.Count);
        Console.WriteLine("----------Contains by key and value-------------");
        Console.WriteLine("Contain by key  "+sl.ContainsKey(2));
        Console.WriteLine("Contain by value "+sl.ContainsValue("hii"));
        Console.WriteLine("----------Remove-------------");
        sl.Remove(2);
        sl.RemoveAt(2);
        foreach(var d in sl)
            Console.WriteLine(d);
        Console.WriteLine("----------Try get  value-------------");
        sl.TryGetValue(3, out string value);
        Console.WriteLine("having the value "+value);
        Console.WriteLine("---------- replace-------------");
        sl[3] = "Kolkata";
        Console.WriteLine("After replaced ");
        foreach (var i in sl)
        {
            Console.WriteLine(i.Key + " " + i.Value);
        }



    }

}
