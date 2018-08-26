using System;

class Program
{
    static void Main(string[] args)
    {
        int cost, ratio, person, days, hours;

        Console.Write("Enter Cost (in $): ");
        cost = int.Parse(Console.ReadLine());

        ratio = cost / 480;

        person = days = 2*ratio;
        hours = ratio;

        Console.WriteLine(person + " person");
        Console.WriteLine(days + " days");
        Console.WriteLine(hours + " hrs");

        Console.ReadLine();
    }