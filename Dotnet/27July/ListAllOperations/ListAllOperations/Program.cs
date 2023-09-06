using System;
class DictonaryItem
{
    public static void Main()
    {
        Dictionary<int ,String> dict = new Dictionary<int ,String>();
        dict.Add(1, "id");
        dict.Add(2, "name");
        dict.Add(3, "mob");
        dict.Add(4, "rollNo");
        dict.Add(5, "Address");
        dict.Add(6, "add Something");
        foreach(var i in dict)
        {
            Console.WriteLine(i.Key+" "+i.Value);
        }

        Console.WriteLine("------------Second dict-----------------");
        Dictionary<int, string> dict1 = new Dictionary<int, string>()
            {
                {6,"USa" },{8,"Egypt"}
            };
        dict1.Add(1, "delhi");
        dict1.Add(2, "moscow");
        dict1.Add(3, "rome");
        dict1.Add(4, "london");
        dict1.Add(5, "berlin");

        foreach (var i in dict1)
        {
            Console.WriteLine(i.Key + " " + i.Value);
        }
        Console.WriteLine("change value---------------");
        dict1[2] = "Lucknow";
        foreach(var i in dict1)
            Console.WriteLine(i);

        Console.WriteLine("try get value------------------");
     
        dict.TryGetValue(2, out String Result);
        Console.WriteLine(Result);
        Console.WriteLine("Remove ---------------------");
        dict.Remove(2);
        foreach(var i in dict)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("count -----------------------");
        Console.WriteLine(" Count "+ dict.Count());
        Console.WriteLine("COntain------------------");
        Console.WriteLine(dict.ContainsValue("id"));
    }
}