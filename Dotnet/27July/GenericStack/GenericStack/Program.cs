using System;
using System.ComponentModel;

class Program
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Push(6);
        foreach (var i in stack)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-----------peek --------");
        Console.WriteLine(stack.Peek());

        Console.WriteLine("-----------Contains --------");
        Console.WriteLine("contains item "+stack.Contains(6));

        Console.WriteLine("-----------pop--------");

        Console.WriteLine("value that is pop " + stack.Pop());

        Console.WriteLine("value that is pop " + stack.Pop());
        Console.WriteLine(-----------Clear----);


    }
}
