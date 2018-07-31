using System;

class Program
{
    static void Main(string[] args)
    {
        Demo obj = new Demo();
        obj.color();
        obj.wheels();
   
        Console.ReadLine();
    }
}

abstract class Features
{
    public abstract void wheels();
    public abstract void color();
}

abstract class Bicycle : Features
{
    public override void wheels() {
        Console.WriteLine("Two Wheels");
    }
    public override abstract void color();
}

class Demo : Bicycle
{
    public override void wheels()
    {
        Console.WriteLine("Three Wheels");
    }
    public override void color() {
        Console.WriteLine("Black Color");
    }
}