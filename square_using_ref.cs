using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 4;
        Demo obj = new Demo();

        Console.WriteLine("Before Call: " + a);

        obj.square(ref a);

        Console.WriteLine("After Call: " + a);

        Console.ReadLine();
    }
}

class Demo
{
    public void square(ref int n){
        n = n * n;
    }
}