using System;
using System.ComponentModel;

public class MainCLass
{
    private static void Main()
    {

        Console.WriteLine(Calculator.Add(new List<int>() { 10, 2, 0 }));
        Console.WriteLine("hii");
    }
}
public class Calculator
{
    [Obsolete]//THIS CODE IS OUTDATED
    public static int Add(int FirestNumeber,int SecondNumber)
    {
        return FirestNumeber + SecondNumber;
    }

    public static int Add(List<int> Number)
    {
        int sum = 0;
        foreach(int i in Number)
        {
            sum += i;
        }
        return sum;
    }
}
