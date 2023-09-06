using System;
class CustumExceptionEx
{
    public static void Main()
    {
     
        String num;
        try
        {
            Console.WriteLine("enter any alphabet");
            num = Console.ReadLine();
            if (int.TryParse(num, out int number))
            {
                throw new EnterValidNumber("NUmber Not Allow : exception");
            }
            else
            {
                throw new EnterValidNumber("string not allow : exception");
            }
            
        }
        catch (EnterValidNumber e)
        {
            Console.WriteLine(e.Message);
        }

    }

}
class EnterValidNumber : Exception
{
    public EnterValidNumber(string message):base(message) {
    
    }
}







