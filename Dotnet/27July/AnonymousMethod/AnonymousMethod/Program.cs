using System;
using System.Security.Cryptography.X509Certificates;

class Anonymous
{
    public delegate void petName(string pet);
    public static void Main()
    {
        petName p = delegate (String myPet)
        {
            Console.WriteLine("My favorite pet is: {0}", myPet);

        };
        p("dog");
    }
}
