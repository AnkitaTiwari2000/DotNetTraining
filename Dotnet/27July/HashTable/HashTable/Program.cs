// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
class Progra
{
    static void Main()
    {
        Hashtable h = new Hashtable();
        h.Add("ora", "oracle");
        h.Add("vb", "vb.net");
        h.Add("cs", "cs.net");
        h.Add("asp", "asp.net");

        foreach (DictionaryEntry d in h)
        {
            Console.Write(d.Key + " " + d.Value);
           
           
        }
    }
}