using System;

class Program
{
    static void Main(string[] args)
    {
        double frac;
        int whole;

        Demo obj = new Demo();

        whole = obj.decompose(3.14323, out frac);

        Console.WriteLine("Whole Part: " + whole);
        Console.WriteLine("Fractional Part: " + frac);

        Console.ReadLine();
    }
}

class Demo
{
    public int decompose(double n, out double f){
        int w = (int) n;
        f = n - w;
        return w;
    }
}