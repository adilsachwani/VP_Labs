using System;
using System.Linq;
using System.Collections.Generic;

class Demo
{
    static void Main(string[] args)
    {
        Person p1 = new Person() {
            ID = 23,
            FName = "Adil",
            LName = "Aslam"
        };

        Person p2 = new Person(){
            ID = 26,
            FName = "Naveed",
            LName = "Raza"
        };

        List<Person> pl = new List<Person>{
            new Person(){ ID = 31, FName = "Rija", LName = "Asif"},
            new Person(){ ID = 33, FName = "Amna", LName = "Habibi"}
        };

        pl.Add(p1);
        pl.Add(p2);

        var query = from p
                    in pl
                    where p.ID == 33
                    select new { p.FName, p.LName };

        foreach(var i in query)
            Console.WriteLine(i);

        Console.ReadKey();
    }
}

class Person
{
    public int ID{
        get;
        set;
    }

    public string FName{
        get;
        set;
    }

    public string LName {
        get;
        set;
    }
}