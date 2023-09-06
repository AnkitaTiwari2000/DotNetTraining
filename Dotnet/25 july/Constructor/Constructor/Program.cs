// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

class InheritanceProgram
{
    String s;
   public InheritanceProgram()
    {
        Console.WriteLine("hii i am COnstructor");
    } 
   public void parent()
    {
        Console.WriteLine("hii i am parent class");
    }

}
class InheritanceProgram1 : InheritanceProgram
{
    public void show()
    {
        Console.WriteLine("hii i am child class");
    }
}

   class main
{
    static void Main()
    {
        InheritanceProgram1 I = new InheritanceProgram1();
       I.parent();
        I.show();
    }
}
