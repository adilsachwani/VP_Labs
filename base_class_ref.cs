using System;

class Program
{
    static void Main(string[] args)
    {
        X xOb1 = new X(10);
        Console.WriteLine("a: " + xOb1.a);

        Y yOb1 = new Y(12);
        Console.WriteLine("a: " + yOb1.a + ", b: " + yOb1.b);

        X xOb2;
        xOb2 = xOb1;
        Console.WriteLine("a: " + xOb2.a);

        xOb2 = yOb1;
        Console.WriteLine("a: " + xOb2.a);

        Console.ReadLine();
    }
}

class X
{
    public int a;
    public X(int i){
        a = i;
    }
}

class Y : X
{
    public int b;

    public Y(int i):base(i){
        b = i;
    }
}