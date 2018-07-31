using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 4;
        int b = 5;

        Demo obj = new Demo();

        Console.WriteLine("a before call: " + a + ", b before call: " + b);

        obj.swap(ref a, ref b);

        Console.WriteLine("a before call: " + a + ", b before call: " + b);

        Console.ReadLine();
    }
}

class Demo
{
    public void swap(ref int a, ref int b){
        int temp = a;
        a = b;
        b = temp;
    }
}