using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList al = new ArrayList();
        al.Add('A');
        al.Add('B');
        al.Add('C');

        Console.WriteLine("Number of elements: " + al.Count);

        foreach(char c in al)
            Console.WriteLine(c);

        al.Remove('C');

        Console.WriteLine("Capacity: " + al.Capacity);

        al[0] = 'X';

        foreach (char c in al)
            Console.WriteLine(c);

        Console.ReadLine();
    }
}