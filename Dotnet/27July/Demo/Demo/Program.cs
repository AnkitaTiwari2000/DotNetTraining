
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    class P
    {
        static void Main()
        {


            //User Input
            Console.WriteLine("Enter Any Number You Want To Show Date");
            int a = Convert.ToInt32(Console.ReadLine());

            int today = DateTime.Today.Day;
            int month = DateTime.Today.Month;
            int year = DateTime.Today.Year;
            //Days in a Month
            int daysinmonth = System.DateTime.DaysInMonth(year, month);

            if (a > 31)
            {
                Console.WriteLine("Please Enter The Valid Number");
            }
            else
            {
                if (a < today)
                {

                    Console.WriteLine(a + "/" + (month + 1) + "/" + year);
                }
                else if (a > today && a < daysinmonth)
                {
                    Console.WriteLine(a + "/" + month + "/" + year);

                }
                else if (a > today && a > daysinmonth)
                {
                    Console.WriteLine(a + "/" + (month + 1) + "/" + year);
                }
                else
                {
                    Console.WriteLine(today + "/" + month + "/ " + year);
                }

            }

        }
    }
}