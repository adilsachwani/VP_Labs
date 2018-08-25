using System;
using System.Collections.Generic;

class EventDemo
{
    static void Main(string[] args)
    {
        List<int> ls = new List<int>();

        ls.Add(23);
        ls.Add(26);
        ls.Add(31);
        ls.Add(33);
        ls.Add(35);

        foreach(var n in ls)
            Console.WriteLine(n);

        Console.ReadKey();
    }

}