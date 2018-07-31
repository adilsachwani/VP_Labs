using System;

class Program
{
    static void Main(string[] args)
    {
        Person cr = new Person();

        cr.Name = "Adil Aslam";

        Console.WriteLine(cr.Name + " - " + cr.Age + " years");

        Console.ReadKey();
    }
}

class Person
{ 
    string name;
    int age = 22;

    public string Name
    {
        set { name = value; }
        get { return name; }
    }

    public int Age
    {
        get { return age; }
    }

}