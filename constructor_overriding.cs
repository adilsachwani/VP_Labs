using System;

class Program
{

    static void Main(string[] args)
    {
        C obj = new C();

        Console.ReadLine();
    }

}

class A
{
    public A(){
        Console.WriteLine("A");
    }
}

class B : A
{
    public B(){
        Console.WriteLine("B");
    }
}

class C : B
{
    public C(){
        Console.WriteLine("C");
    }
}