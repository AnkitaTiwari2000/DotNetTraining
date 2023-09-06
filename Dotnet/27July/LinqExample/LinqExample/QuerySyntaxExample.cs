using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


      class QuerySyntaxExample
    {
         static void Main()
        {
            List<string> strList = new List<string>
            {
              "Microprocessor",
              "Computer Science",
              "Electronic",
              "Information Technology"


            };
            var result =
                from s in strList
                where s.Contains("e")
                select s;

            Console.WriteLine(result);
        }
    }

