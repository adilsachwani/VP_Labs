using System;

class Program
{
    static void Main(string[] args)
    {
        Stats misbahStats = new Stats(51,2023);
        Cricketer misbah = new Cricketer("Misbah-ul-Haq", 32, misbahStats);

        Console.WriteLine("Name: " + misbah.name);
        Console.WriteLine("Age: " + misbah.age);
        Console.WriteLine("Matches: " + misbah.playerStats.matches);
        Console.WriteLine("Runs: " + misbah.playerStats.runs);
   
        Console.ReadLine();
    }

}


class Cricketer
{
    public Stats playerStats; 
    public string name;
    public int age;

    public Cricketer(string name, int age,  Stats playerStats){
        this.name = name;
        this.age = age;
        this.playerStats = playerStats;
    }
}

class Stats
{
    public int matches;
    public int runs;

    public Stats(int m, int r){
        matches = m;
        runs = r;
    }
}