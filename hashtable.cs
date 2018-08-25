using System;
using System.Collections;

class EventDemo
{
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();

        ht.Add("name", "adil aslam");
        ht.Add("num", "23");
        ht.Add("age", "21");

        ht["height"] = "6";

        ICollection c = ht.Keys;

        foreach(string str in c)
            Console.WriteLine(str + " : " + ht[str]);

        Console.ReadKey();
    }
}