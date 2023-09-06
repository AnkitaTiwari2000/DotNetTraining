
using System;
using System.Collections;
class Program1
{
    static void Main()
    {
        Hashtable ht = new Hashtable();
        ht.Add("ora", "oracle");
        ht.Add("vb", "vb.net");
        ht.Add("cs", "cs.net");
        ht.Add("asp", "asp.net");

        foreach (DictionaryEntry d in ht)
        {
            Console.Write(d.Key + " " + d.Value);
            Console.Write("<br>");
        }
    }
}

