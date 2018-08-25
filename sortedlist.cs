using System;
using System.Collections;

class EventDemo
{
    static void Main(string[] args)
    {
        SortedList sl = new SortedList();

        sl.Add("name", "adil aslam");
        sl.Add("num", "23");
        sl.Add("age", "21");

        sl["height"] = "6";

        ICollection c = sl.Keys;

        //accessing values by key
        foreach(string str in c)
            Console.WriteLine(str + " : " + sl[str]);

        //accessing values by index
        for(int i=0; i<sl.Count; i++)
            Console.WriteLine(sl.GetByIndex(i));

        //accessing index by key
        foreach(string str in c)
            Console.WriteLine(sl.IndexOfKey(str));

        Console.ReadKey();
    }
}