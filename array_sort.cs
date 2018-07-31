using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { -1, 5, 2, 6, 3 };

        Console.Write("Orignal Contents: ");
        foreach(int num in nums)
            Console.Write(num + " ");

        Array.Sort(nums);
        Console.Write("\nContents after Sort: ");
        foreach (int num in nums)
            Console.Write(num + " ");

        Array.Reverse(nums);
        Console.Write("\nContents after Reverse: ");
        foreach (int num in nums)
            Console.Write(num + " ");

        Console.ReadKey();
    }
}