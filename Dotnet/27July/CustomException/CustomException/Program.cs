// See https://aka.ms/new-console-template for more information
using System;
public class notValidAge : Exception
{
    public notValidAge(string s) : base(s)

    {

    }

    class eec1
    {
        static void checkage(int i)
        {
            if (i < 18)
            {
                throw new notValidAge("Age is not valid");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                checkage(16);
            }
            catch (notValidAge e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }

    
}
