using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CollectionPractice
{
    class DateAndTime
    {

      public  static void Main()
        {
            MainContent();
            Menu();
        }
        public static void MainContent() { 
        //User Input

        start:
            {
               Console.WriteLine("Enter Any Number You Want To Show Date");
                int day;
                try
                {

                    day = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception ex)
                {

                    goto start;
                }


                int today = DateTime.Today.Day;
                int month = DateTime.Today.Month;
                int year = DateTime.Today.Year;
                //Days in a Month
                int daysinmonth = System.DateTime.DaysInMonth(year, month);
                String Date1 = day + "/" + (month + 1) + "/" + year;
                if (day <= 31 && day >= 1)

                {
                    if (day < today)
                    {
                        Console.WriteLine(Date1);
                    }
                    else if (day > today && day <= daysinmonth)
                    {
                        Console.WriteLine(day + "/" + month + "/" + year);

                    }
                    else if (day > today && day > daysinmonth)
                    {
                        Console.WriteLine(Date1);
                    }
                    else
                    {
                        Console.WriteLine(today + "/" + (month + 1) + "/" + year);
                    }

                }
                else
                {
                    Console.WriteLine("Please Enter The Valid Number");
                }
                }
             }
        public static void Menu()
        {
            while (true) { 
                Console.WriteLine("If U Want To Start Press 1");
            Console.WriteLine("If U Want To Exit Press 0");
            int choise = Convert.ToInt32(Console.ReadLine());
            if (choise == 1)
            {
                MainContent();
            }
            else
            {
                Console.WriteLine(" Thank You.........!");
                System.Environment.Exit(1);

            }
        }
        }
    }
}
    
    

