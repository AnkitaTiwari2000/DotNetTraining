using System;
using static Calculater;

class Calculater
{
    public delegate void CalculaterDelegate(int a,int b);
    public delegate void CalculaterDelegate2(int a, int b,int c);

    public void Sum(int a,int b)
    {
        Console.WriteLine("{4+3}= "+(a+b));
    }
    public void Sub(int a, int b)
    {
        Console.WriteLine("{4-3}= " + (a - b));
    }
    public void Mul(int a, int b,int c)
    {
        Console.WriteLine("{4*3*2}= " + (a*b*c));
    }
    public void Div(int a, int b)
    {
        Console.WriteLine("{4/3}= " + (a / b));
    }
}
class Controller
{
    static void Main()
    {
        //object of Calculator class
        Calculater cal= new Calculater();
        // object of delegate
        CalculaterDelegate cd = new(cal.Sum);
        CalculaterDelegate2 cd2=new(cal.Mul);
        CalculaterDelegate cd3 = new(cal.Sub);
        CalculaterDelegate cd4 = new(cal.Div);
        cd(4, 3);
        cd2(4, 3,2);
        cd3(4, 3);
        cd4(4, 3);
    }
}