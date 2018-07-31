using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 0;
        int[][] nums = new int[3][];

        nums[0] = new int[5];
        nums[1] = new int[2];
        nums[2] = new int[3];

        for (int i = 0; i<nums.Length; i++){
            for (int j = 0; j<nums[i].Length; j++){
                nums[i][j] = a;
                Console.Write(nums[i][j] + " ");
                a += 5;
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}