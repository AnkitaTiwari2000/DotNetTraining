// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
namespace CollectionDemo{

class Program2
{
    static int num = 0;

    static List<Student> st = new List<Student>();
      public  static void Main(string[] args)
        {
            bool f = true;

            while (f)
            {
                Console.Write("1 to Add\n2 to Display \n3 To Delete \n4 To Find \nOther to exit \nEnter choice ");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1: f = Add(); break;
                    case 2: f = disp(); break;
                    case 3: f = delete(); break;
                    case 4: f = findV(); break;
                    default: f = false; Console.WriteLine("Thanks for visit"); break;
                }


            }



        }
    }
}