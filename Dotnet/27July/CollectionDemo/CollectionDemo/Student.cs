// See https://aka.ms/new-console-template for more information
using CollectionDemo;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CollectionDemo
{
    class Student
    {
        public string _name;
        public int _id;

        public Student()
        {
        }
        public int Getid()
        {
            return this._id;
        }
        public string Getname()
        {
            return this._name;
        }
    }
}


class Program2
{
    static int num = 0;

    static List<Student> st = new List<Student>();
    public static void Main(string[] args)
    {
        bool f = true;

        while (f)
        {
            Console.Write("1 to Add \n2 To Delete \n3 To disp \nOther to exit \nEnter choice ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: f = Add(); break;
                case 3: f = disp(); break;
                case 2: f = delete(); break;

                default: f = false; Console.WriteLine("Thanks for visit"); break;
            }


        }
    }
       public   static bool Add()
        {
        return true;
        }

    public static bool delete()
    {
        return true;
    }
    public static bool disp()
    {
        return true;
    }
}
