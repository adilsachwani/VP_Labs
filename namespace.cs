using System;

namespace one
{
    class A
    {
        public void func(){
            Console.WriteLine("One");
        }
    }
}

namespace two
{
    class A
    {
        public void func()
        {
            Console.WriteLine("Two");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        one.A objOne = new one.A();
        two.A objTwo = new two.A();

        objOne.func();
        objTwo.func();

        Console.ReadKey();
    }
}