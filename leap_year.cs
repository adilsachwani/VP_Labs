using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int year;
        Console.Write("Enter year: ");
        year = int.Parse(Console.ReadLine());

        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            Console.WriteLine("Leap Year");
        else
            Console.WriteLine("Not a leap year.");

        Console.ReadKey();
    }
}