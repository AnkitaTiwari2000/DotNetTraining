using System;
public delegate int dataDelegate(int a, int b);
class DelExam
{ 
    
    
    int sub;
    public static int m1( int a,int b)
    {
        int sum = a + b;
        return sum;

    }
  public static int m2(int a,int b)  {
     int  sub = a - b;
        return sub;

    }


public  static void Main()
    {
        dataDelegate D = new dataDelegate( m1);

        /*dataDelegate D1 = new dataDelegate(m2);
        Console.WriteLine(D(5, 5));
        Console.WriteLine(D1(1, 2));
        */
        D += m2;
        Console.WriteLine(D(10, 20));
        Console.WriteLine();




    }

}