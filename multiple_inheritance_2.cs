
using System;

class Program
{
    static void Main(string[] args)
    {
        MultipleInherit obj = new MultipleInherit();
        obj.changeVolume();
        obj.changeVolume();
        obj.changeStatus();
        obj.range();
        obj.insBattery();
   
        Console.ReadLine();
    }
}

interface IFeatures
{
    void changeVolume();
    void changeChannel();
    void changeStatus();
}

abstract class Base
{
    public abstract void range();
    public void insBattery() {
        Console.WriteLine("Battery inserted!");
    }
}

class MultipleInherit : Base, IFeatures
{
    public override void range(){
        Console.WriteLine("Range!");
    }

    public void changeVolume(){
        Console.WriteLine("Volume changed!");
    }

    public void changeChannel(){
        Console.WriteLine("Channel changed!");
    }

    public void changeStatus(){
        Console.WriteLine("Status changed!");
    }
}