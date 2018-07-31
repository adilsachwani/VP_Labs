using System;

class Program
{
    static void Main(string[] args)
    {
        Demo obj = new Demo();

        Console.WriteLine(obj.add(1,2));
        Console.WriteLine(obj.add(1,2,3));
        Console.WriteLine(obj.add(1,2,3,4));

        Console.ReadLine();
    }
}

class Demo
{
    public int add(params int[] nums){
        int sum = 0;

        foreach (int num in nums)
            sum = sum + num;

        return sum;
    }
}