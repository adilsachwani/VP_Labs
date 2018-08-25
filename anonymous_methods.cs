using System;
delegate void Printer(string a);

class Demo
{
    static void Main(string[] args)
    {

        //using anonymous method
        Printer p = delegate (string a){
            Console.WriteLine(a);
        };
        p("Delegate using Anonymous Method is called!");

        //using named method
        p = new Printer(DoWork);
        p("Delegate using Named Method is called!");

        //using lamba expressions
        p = x => Console.WriteLine(x);
        p("Delegate using Lambda Expression is called!");

        Console.ReadKey();
    }

    static void DoWork(string a){
        Console.WriteLine(a);
    }
}