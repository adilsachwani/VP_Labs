using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string t;
        StringBuilder orgText;
        StringBuilder revText = new StringBuilder();

        Console.Write("Enter text: ");

        t = Console.ReadLine();
        orgText = new StringBuilder(t);

        for(int i=orgText.Length-1; i>=0; i--)
            revText.Append(orgText[i]);

        Console.WriteLine(revText);

        if(orgText.Equals(revText))
            Console.WriteLine("Palindrome!");
        else
            Console.WriteLine("No Palindrome!");

        Console.ReadKey();
    }
}