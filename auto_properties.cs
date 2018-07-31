using System;

class Program
{
    static void Main(string[] args)
    {
        Person cr = new Person();

        cr.Name = "Adil Aslam";
        cr.Age = 22;

        Console.WriteLine(cr.Name + " - " + cr.Age + " years");

        Console.ReadKey();
    }
}

class Person
{ 
    public string Name
    {
        get; set;
    }

    public int Age
    {
        get; set;
    }
}