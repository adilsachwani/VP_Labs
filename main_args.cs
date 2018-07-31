using System;

    class Program
    {
        static void Main(string[] args)
        {

            int ans = 1;
            int[] values = new int[2];

            for(int i=0; i<=1; i++)
            {
                values[i] = int.Parse(args[i]);
            }

            for(int j=0; j<values[1]; j++)
            {
                ans = ans * values[0];
            }

            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }