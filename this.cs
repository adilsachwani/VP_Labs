using System;

class Program
{
    static void Main(string[] args)
    {
        Person cr = new Person("Adil Aslam");
        Console.WriteLine(cr.Name);

        Console.ReadLine();
    }
}

class Person{

    string name;

    public Person(string name){
        this.name = name;
    }

    public string Name
    {
        get { return name; }
    }
}