namespace ELements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 7, 10, 21,2, 30, 45, 50, 87 };
            List<string> stringList = new List<string>() { "cs", "it", "ece", "me", "EE" };
            List<string> stringList2 = new List<string>() { "cs", "it", "ece", "me", "EE" };
            Console.WriteLine(" Element  At: {0}", intList.ElementAt(1));
            Console.WriteLine("Element Default"+" "+stringList.ElementAtOrDefault(11));
            Console.WriteLine("first ELement "+intList.First());
            Console.WriteLine("first of default "+intList.First(i=>i%2==0));
            Console.WriteLine("Last "+intList.Last());
            // Console.WriteLine("Single "+intList.Single());
            var res = stringList2.Concat(stringList);
            foreach(var i in res)
            Console.WriteLine(i);


        }
    }
}