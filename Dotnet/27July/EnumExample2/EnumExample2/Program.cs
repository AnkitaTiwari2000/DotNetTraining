using System;
class EnumExample2
{
    static void Main()
    {
        int[] Values = (int[])Enum.GetValues(typeof(Gender));
        foreach( int name in Values)
        {            Console.WriteLine(name);
        }

    }
}
public enum Gender
{
    unknown,
    male,
    female
}