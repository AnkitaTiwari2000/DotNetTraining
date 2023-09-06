using System;
class A
{
    public int value { get; set; }
    public A(int passbyRef)
    {
        this.value = passbyRef;
    }
}
    class p
    {
        static void Main()
        {
            A a = new A(20);
            A b = new A(2);
            b = a;
            Console.WriteLine(a.value);
            Console.WriteLine(b.value);
        }
    }

