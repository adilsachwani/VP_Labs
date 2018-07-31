using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 11, 22, 33, 44, 55 };

        var values = from a
                     in nums
                     where a > 25
                     select a;

        foreach(int value in values)
            Console.WriteLine(value);

        Console.ReadKey();
    }
}