using System;
using System.Threading.Channels;

namespace ClassLibrary1
{
    public class Class1
    {
        public int add(int a,int b)
        {
            return a + b;
        }
       static void Main() {
            Class1 c1 = new Class1();
            Console.WriteLine(c1.add(1,2));

        }

    }
}