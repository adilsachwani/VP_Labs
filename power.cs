using System;

class Program
{
    static void Main(string[] args)
    {
        Demo obj = new Demo();

        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter power: ");
        int pow = int.Parse(Console.ReadLine());

        Console.WriteLine("Answer is " + obj.pow(num,pow));

        Console.ReadKey();
    }
}

class Demo{

    public int pow(int a, int b){

        int ans = 1;

        for(int i=0; i<b; i++)
        {
            ans = ans * a;
        }

        return ans;
    }

}