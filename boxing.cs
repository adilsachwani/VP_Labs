using System;

class Program
{
    static void Main(string[] args)
    {
        int i, j;
        i = 23;

        object o = i; //boxing
         
        j = (int) o; //unboxing

        Console.WriteLine(j);

        Console.ReadKey();
    }
}