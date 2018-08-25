using System;

delegate int Op1(int a);
delegate bool Op2(int a);

class Demo
{
    static void Main(string[] args)
    {
        int[] a = { 10, 20, 30, -40, 50 ,60};
        int[] b = { 2, 5, 0, 5, 0 };

        for (int i = 0; i < a.Length; i++){
            try
            {
                Console.WriteLine("a" + "/" + "b" + " = " + a[i] / b[i]);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.ReadKey();
    }
}