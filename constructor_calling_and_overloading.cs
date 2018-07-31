using System;

class Program
{

    static void Main(string[] args)
    {
        Demo obj1 = new Demo();
        Console.WriteLine("(x,y) = (" + obj1.x + "," + obj1.y + ")\n");
        Demo obj2 = new Demo(2,3);
        Console.WriteLine("(x,y) = (" + obj2.x + "," + obj2.y + ")\n");
        Demo obj3 = new Demo(obj2);
        Console.WriteLine("(x,y) = (" + obj2.x + "," + obj2.y + ")\n");

        Console.ReadLine();
    }

}

class Demo
{
    public int x, y;

    public Demo(int x, int y){
        Console.WriteLine("Calling Demo(int, int) Constructor");
        this.x = x;
        this.y = y;
    }

    public Demo():this(0,0){
        Console.WriteLine("Calling Demo() Constructor");
    }

    public Demo(Demo obj):this(obj.x, obj.y){
        Console.WriteLine("Calling Demo(Demo) Constructor");
    }
}