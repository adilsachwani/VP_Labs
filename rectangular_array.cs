using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] nums = new int[2, 2];

        nums[0, 0] = 1;
        nums[0, 1] = 2;
        nums[1, 0] = 3;
        nums[1, 1] = 4;

        for (int i = 0; i < nums.GetLength(0); i++){
            for (int j = 0; j < nums.GetLength(1); j++)
                Console.Write(nums[i, j]);

            Console.WriteLine();
        }
            
        Console.ReadKey();
    }
}