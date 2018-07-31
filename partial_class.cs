using System;

class Program
{
    static void Main(string[] args)
    {
        Demo obj = new Demo(2,3);
        Console.WriteLine(obj.X);
        Console.WriteLine(obj.Y);
   
        Console.ReadLine();
    }
}

partial class Demo{
    public Demo(int x, int y){
        this.x = x;
        this.y = y;
    }
}

partial class Demo
{
    int x;
    public int X {
        get { return x; }
    }
}

partial class Demo
{
    int y;
    public int Y{
        get { return y; }
    }
}