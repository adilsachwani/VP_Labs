using System;

class Program
{
    enum TimeOfDay {Morning = 10,
        Afternoon = 20,
        Evening = 30};

    static void Main(string[] args)
    {
        getGreetings(20);
        getGreetings(10);

        Console.ReadLine();
    }

    static void getGreetings(int t){

        switch (t){

            case (int) TimeOfDay.Morning:
                Console.WriteLine("Good Morning!");
                break;

            case (int) TimeOfDay.Afternoon:
                Console.WriteLine("Good Afternoon!");
                break;

            case (int) TimeOfDay.Evening:
                Console.WriteLine("Good Evening!");
                break;
        }
    }
}