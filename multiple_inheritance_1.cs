using System;

class Program
{
    static void Main(string[] args)
    {
        MultipleInherit obj = new MultipleInherit();
        obj.print();
        obj.showAbs();
        obj.showNonAbs();
   
        Console.ReadLine();
    }
}

interface IPrint
{
    void print();
}

abstract class Base
{
    public abstract void showAbs();
    public void showNonAbs() {
        Console.WriteLine("Non Abstract Method");
    }
}

class MultipleInherit : Base, IPrint
{
    public void print(){
        Console.WriteLine("Print Method");
    }

    public override void showAbs(){
        Console.WriteLine("Abstract Method");
    }
}