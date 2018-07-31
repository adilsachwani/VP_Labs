using System;

class Program
{

    static void Main(string[] args)
    {
        Base bRef = new Base();
        Derive1 d1 = new Derive1();
        Derive2 d2 = new Derive2();

        bRef.who();
        d1.who();
        d1.whos();
        d2.who();
        d2.whos();

        Console.WriteLine();

        bRef = d1;
        bRef.who();

        bRef = d2;
        bRef.who();

        Console.ReadLine();
    }

}

class Base
{
    public virtual void who(){
        Console.WriteLine("Who() in Base");
    }
}

class Derive1 : Base
{
    public override void who(){
        Console.WriteLine("Who() in Derive1");
    }
    public void whos(){
        Console.WriteLine("Whos() in Derive1");
    }

}

class Derive2 : Base
{
    public override void who(){
        Console.WriteLine("Who() in Derive2");
    }

    public void whos(){
        Console.WriteLine("Whos() in Derive2");
    }
}