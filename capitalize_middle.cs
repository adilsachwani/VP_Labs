using System;

class Program
{
    static void Main(string[] args)
    {
        string text;
        Console.Write("Enter text: ");

        text = Console.ReadLine();
        char[] ch = text.ToCharArray();

        int l = (text.Length / 2) - 1;

        if(text.Length%2 == 0){
            ch[l] = (char) (ch[l] - 32);
        }
        
        ch[++l] = (char)(ch[l] - 32);

        text = new string(ch);

        Console.WriteLine(text);

        Console.ReadKey();
    }
}