using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace StudentDetailsProgram
{


    public class Cotroller
    {
        static int num = 0;
        static List<Student> sd = new List<Student>();
        public static void Main()
        {
            bool f = true;
            while (f)
            {

                Console.WriteLine("enter 1 for Add \nenter 2 for Display\nenter 3 for Delete\n enter 4 for find  ");
                Console.WriteLine("***Please Enter Your Choise***");
                
                    int ch = int.Parse(Console.ReadLine());
               

                switch (ch) {
                    case 1: f = Add();
                        break;
                    case 2:
                        f = Disp();
                        break;
                    case 3:
                        f = Del();
                        break;
                    case 4:
                        f = Find();
                        break;
                    default: f = false; Console.WriteLine("Thanks For Visit"); break;
                }

            }
        }
        public static bool Add()
        {
            Console.WriteLine("enter id");
            // int id = int.Parse(Console.ReadLine());
            int id=0;
            string id1 = Console.ReadLine();
            try
            {

             
                if (!(Int32.TryParse(id1, out id)))
                {
                    throw new("enter only number!####");
                }
            }
            catch (InvalidFormatExep e)
            {

                Console.WriteLine(e.Message);
            }
           
                Console.WriteLine("enter Name");
               string  name = Console.ReadLine();

            
            
            Console.WriteLine("----------------------");
            sd.Add(new Student());
            sd[num].Id = id;
            sd[num++].Name = name;
            return true;
        }
        public static bool Disp()
        {
            Console.WriteLine("***Your Result Is***");
            foreach (Student s in sd)
            {
                Console.WriteLine("ID = " + s.Id + "\nName = " + s.Name);
            }
            Console.WriteLine("--------------------------");
            return true;
        }
        public static bool Del()
        {
            Console.WriteLine("***Enter 1 for id ***\n ***enter 2 for Name***");
            int press = int.Parse(Console.ReadLine());
            int i = 0, k = -1;
            switch (press)
            {

                case 1:
                    Console.Write("Enter Id  to Delete : ");
                    int res = int.Parse(Console.ReadLine());

                    foreach (Student obj in sd)
                    {
                        if (res == obj.getId())
                        {
                            k = i;
                        }
                        i++;
                    }
                    Console.WriteLine("---------Result-------------");
                    if (k != -1)
                    {
                        sd.RemoveAt(k);
                        Console.WriteLine("Deleted Succcessfull");
                    }
                    

                    break;
                case 2:
                    Console.Write("Enter Name to find: ");
                    string ress = Console.ReadLine();
                    foreach (Student obj in sd)
                    {
                        if (obj.getName() == ress)
                        {
                            k = i;
                        }
                        i++;
                    }
                    Console.WriteLine("---------Result-------------");
                    if (k != -1)
                    {
                        sd.RemoveAt(k);
                        Console.WriteLine("Deleted Succcessfull");
                    }
                    Console.WriteLine("Name not found");
                    Console.WriteLine("------------------------");
                    break;
                case 3: return true;break;

            }
        
        return true;
    }
            public static bool Find()
            {
                return true;
            }
        }
    }
