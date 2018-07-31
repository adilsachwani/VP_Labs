using System;

class Program
{
    enum Apple { Jonathan, GoldenDel, RedDel, Winesap, Cortland, Mcintosh};

    static void Main(string[] args)
    {
        string[] color = { "Red", "Yellow", "Red", "Red", "Red", "Reddish Green" };

        Apple i;

        for(i=Apple.Jonathan; i<=Apple.Mcintosh; i++)
            Console.WriteLine(i + " has value of " + (int)i);

        Console.WriteLine();

        for(i=Apple.Jonathan; i<=Apple.Mcintosh; i++)
            Console.WriteLine("Color of " + i + " is " + color[(int)i] );

        Console.ReadLine();
    }
}