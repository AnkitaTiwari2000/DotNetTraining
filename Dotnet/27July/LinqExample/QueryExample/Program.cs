using System;
using System.Linq;
public class Qexample
{
    public static void Main()
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

      foreach (var s in result)
        {
Console.WriteLine(s);
        }

    }
}


