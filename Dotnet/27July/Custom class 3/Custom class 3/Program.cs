using System;
class LessThan3NotAllow:Exception
{
    public  LessThan3NotAllow(string message) : base(message)
    {

    }
}

class Controller
{
    public static void Main()
    {
        string name;
        try
        {
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            if (name.Length < 3)
            {
                throw new LessThan3NotAllow("length Not Match:Exception");
            }
            else
            {
                Console.WriteLine("your name is: " + name);
            }
        }
        catch (LessThan3NotAllow e) {
            Console.WriteLine(e.Message);
        }
    }
}
