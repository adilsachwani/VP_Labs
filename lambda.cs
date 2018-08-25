using System;

delegate int Op1(int a);
delegate bool Op2(int a);

class Demo
{
    static void Main(string[] args)
    {
        //lambda statement
        Op1 fact = n => {
            int ans = 1;
            for (int i = 1; i <= n; i++)
                ans = ans * i;
            return ans;
        };

        //lambda expression
        Op2 even = n => n % 2 == 0;

        Console.WriteLine(fact(4));

        if (even(6))
            Console.WriteLine("Number is even");

        Console.ReadKey();
    }
}