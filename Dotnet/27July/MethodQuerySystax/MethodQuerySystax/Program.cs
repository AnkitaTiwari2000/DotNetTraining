namespace MethodQuerySystax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> slist = new List<String> {
            "Sudha",
            "Radha",
            "Seema",
            "Harsh"
            
            };

            var res = slist.Where(S => S.Contains("a"));
            foreach( var q in res)
            {
                Console.WriteLine(q);
            }
        }
    }
}