// See https://aka.ms/new-console-template for more information
using System;

class NotAValidId : Exception
{
    public NotAValidId(String i) : base(i) { 
    }
}

class CustomException
{
    static void checkId(int id)
    {
        if (id < 1)
        {
            throw new NotAValidId("You enter not valid Id");
        }
    }
    public static void Main(string[] args)
    {
        try
        {
            checkId(0);
        }
        catch(NotAValidId e)
        {
            Console.WriteLine(e);
        }
    }
}