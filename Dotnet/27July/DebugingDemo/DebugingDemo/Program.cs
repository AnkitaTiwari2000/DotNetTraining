// See https://aka.ms/new-console-template for more information
using System.Text;
class Debug
{
    public static string GetMultiplicationTable(int number)
    {
        var result = new StringBuilder();

        for (int i = 1; i <= 10; i++)
        {
            result.AppendLine($"{number} X {i} = {number * i}");
        }

        return result.ToString();
    }
    static void Main()
    {
        GetMultiplicationTable(5);
    }
    
}