using System;

class Program
{
    static void Main(string[] args)
    {
        Factorial obj = new Factorial();

        Console.WriteLine("Factorial of 0: " + obj.fact(0));
        Console.WriteLine("Factorial of 4: " + obj.fact(4));

        Console.ReadLine();
    }
}

class Factorial
{
    public int fact(int num){

        int ans = 1;

        for (int i = 1; i <= num; i++)
            ans = ans * i;

        return ans;
    }
}