using System;
using System.Threading.Channels;

namespace Assembly1
{
    public class ASClass
    {
        internal int ID { get; set; }
       
    }public class ASClass2
    {
     public   static void Main()
        {
            ASClass A1 = new ASClass();
            Console.WriteLine(A1.ID);

        }
}