using System;

public delegate void MethodDelegates(string Message);
class Deleg
{
    public static void Main()
    {
        MethodDelegates m = new MethodDelegates(Hello);
        MethodDelegates m1 = new MethodDelegates(Hello1);
        Console.WriteLine("hello from delegate");

    }
    public static void Hello(string message)
    {
        Console.WriteLine(message);
    }
    public static void Hello1(string message)
    {
        Console.WriteLine(message);
    }
}
