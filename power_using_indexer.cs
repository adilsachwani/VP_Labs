using System;

class Program
{
    static void Main(string[] args)
    {
        Power obj = new Power();

        Console.WriteLine(obj[0]);
        Console.WriteLine(obj[3]);
        Console.WriteLine(obj[-3]);

        Console.ReadLine();
    }
}

class Power
{
    private int pow(int num){

        int ans = 1;

        for (int i = 0; i < num; i++)
            ans = ans * 2;
        return ans;
    }

    public int this[int a]{

        get
        {
            if (a > 0)
                return pow(a);
            else
                return 0;
        }
    }

}