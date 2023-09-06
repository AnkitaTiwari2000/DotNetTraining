using System;
using System.Linq;
namespace GroupBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> Slist = new List<Student>()
            {
             new Student() {Id=1, Name="raha",Age=12 },
             new Student() {Id=2, Name="raha",Age=22},
             new Student() {Id=3, Name="raha",Age=22},
             new Student() {Id=4, Name="raha",Age=12},
             new Student (){Id=5, Name="raha",Age=12},
             new Student (){Id=6, Name="raha",Age=11}
            };
            var res=Slist.GroupBy(x => x.Age);
            foreach(var ageGroup in res)
            {
                Console.WriteLine("Age Group:{0} "+ageGroup.Key);
            }

        }
    }


    public class Student {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

             }
}