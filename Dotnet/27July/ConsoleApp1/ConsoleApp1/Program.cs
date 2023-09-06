using System;
class LambdaExample
{
    public static void Main()
    {
        List<int> number = new List<int>() { 1, 3, 9,4, 8, 943, 45,12, 67 };
        Console.WriteLine("---------the list is-------");
        foreach (int i in number)
            Console.WriteLine(i);
        // Using lambda expression
        // to calculate square of
        // each value in the list
        Console.WriteLine("---------print Square---------");
        var square =number.Select(i => i*i);
        //print 
        foreach (int i in square)
        Console.WriteLine(i);
        Console.WriteLine("-----which number is devided by 0------");
        var divBythree = number.Select(i => (i % 3 == 0));
       foreach (int num in divBythree) 
        Console.WriteLine(num); 


    }
}
