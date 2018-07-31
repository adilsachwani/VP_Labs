using System;

class Program
{
    static void Main(string[] args)
    {
        Register obj = new Register();

        Console.WriteLine(Register.pi);
        Console.WriteLine(obj.currentDateTime);

        Console.ReadLine();
    }
}

class Register
{
    public const double pi = 3.14;
    public readonly DateTime currentDateTime;

    public Register(){
        currentDateTime = DateTime.Now;
    }

}