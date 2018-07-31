using System;

class Program
{

    static void Main(string[] args)
    {
        Control obj = new Control();

        obj.converyor(Control.Action.start);
        obj.converyor(Control.Action.reverse);

        Console.ReadLine();
    }
}

class Control
{
    public enum Action {start, stop, forward, reverse };

    public void converyor(Action a){

        switch (a){
            case Action.start:
                Console.WriteLine("Starting");
                break;
            case Action.stop:
                Console.WriteLine("Stopping");
                break;
            case Action.forward:
                Console.WriteLine("Moving forward");
                break;
            case Action.reverse:
                Console.WriteLine("Moving backward");
                break;
        }
    }
}