using System;

class Program
{

    static void Main(string[] args)
    {
        B obj = new B();
        obj.show();

        Console.ReadLine();
    }

}

class A
{
    public int i = 5;
}

class B : A
{
    public new int i = 6;

    public void show(){
        Console.WriteLine(i);
        Console.WriteLine(base.i);
    }
}