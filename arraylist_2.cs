using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList al = new ArrayList();
        al.Add(-1);
        al.Add(5);
        al.Add(2);
        al.Add(1);
        al.Add(3);

        Console.Write("Orignal List: ");
        foreach(int n in al)
            Console.Write(n + ", ");

        Console.WriteLine();

        al.Sort();

        Console.Write("After Sort: ");
        foreach (int n in al)
            Console.Write(n + ", ");

        Console.WriteLine();

        al.Reverse();

        Console.Write("After Reverse: ");
        foreach (int n in al)
            Console.Write(n + ", ");

        Console.ReadLine();
    }
}