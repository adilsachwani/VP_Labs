using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        char[] splitter = { ' ', ':', '/' };
        string s = "Adil:Aslam Sachwani TCIT/023";

        Console.WriteLine(s);

        string[] texts = s.Split(splitter);

        foreach(string text in texts)
            Console.WriteLine(text);

        Console.ReadLine();
    }
}