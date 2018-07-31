using System;

class Program
{
    static void Main(string[] args)
    {
        Demo obj = new Demo();
        obj.Invoke();
   
        Console.ReadLine();
    }
}

partial class Demo{
    partial void Method1();
    partial void Method2();

    public void Invoke(){
        Method1();
        Method2();
    }
}

partial class Demo
{
    partial void Method1(){
        Console.WriteLine("Method 1");
    }
}

partial class Demo
{
    partial void Method2(){
        Console.WriteLine("Method 2");
    }
}