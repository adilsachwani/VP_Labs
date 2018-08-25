using System;

delegate int Op1(int a);
delegate bool Op2(int a);

class Demo
{
    static void Main(string[] args)
    {
        double res;
        int a = 10;
        int b = 0;

        try{
            res = a / b;
            Console.WriteLine(res);
        }
        catch(DivideByZeroException e){
            Console.WriteLine(e.Message);
            Console.WriteLine(e.Source);
            Console.WriteLine(e.StackTrace);
        }
        finally{
            Console.WriteLine("Finally");
        }

        Console.ReadKey();
    }
}