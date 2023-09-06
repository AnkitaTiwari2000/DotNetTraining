// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

class Program
{
    public static void Main()
    {


        string a = "hii";
        string b = "12";
        string c = "10.899534";
        string d = "0921498489575285938905";
        int result;

        Console.WriteLine("parse Example");
        result = int.Parse(a);
        result = int.Parse(b);
        result = int.Parse(c);
        result = int.Parse(d);
        Console.WriteLine("Tryparse Example");
       bool result1;
        result1 = int.TryParse(a,out result);
        result1 = int.TryParse(b ,out result);
        result1 = int.TryParse(c,out result);
        result1 = int.TryParse(d,out result);
    }
}