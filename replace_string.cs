using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        string s = "Its a cat in the house.";

        Console.WriteLine(s);

        char[] ch = s.ToCharArray();

        int i = s.IndexOf("cat");

        if(i != -1){
            ch[i++] = 'f';
            ch[i++] = 'o';
            ch[i] = 'x';
        }

        s = new string(ch);

        Console.WriteLine(s);

        Console.ReadLine();
    }
}