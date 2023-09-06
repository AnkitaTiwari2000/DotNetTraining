using System;
namespace Demo
{
   public static class ExtensionHelper
    {
        public static void PrintElements(this List<int> ints)
        {
            foreach (int i in ints) { Console.WriteLine(i); }
        }
        public static void DoSomething(this ifoo foo)
        {

        }

    }
    public interface ifoo
    {

    }
    public class foo : ifoo { }
    public class foo : ifoo { }
}


