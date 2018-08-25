using System;

class Program
{
    static void Main(string[] args)
    {
        Boiler boiler = new Boiler(400);
        boiler.Increase();
        boiler.Decrease();

        try{
            boiler.check();
        }
        catch (BoilerException e){
            Console.WriteLine(e.Message);
        }
        Console.ReadKey();
    }
}

public class BoilerException : Exception
{
    public BoilerException(string message):base(message) {}
}

public class Boiler
{
    public double pressure;

    public Boiler(int pressure){
        this.pressure = pressure;
    }

    public void Increase(){
        pressure += 100;
    }

    public void Decrease(){
        pressure -= 100;
    }

    public void check(){
        if (pressure >= 2000 || pressure <= 500)
            throw new BoilerException("Boiler is out of range now");
        else
            Console.WriteLine(pressure);
    }
}