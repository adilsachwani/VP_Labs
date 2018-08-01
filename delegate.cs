using System;
delegate string strMode(string str);

class Program
{
    static void Main(string[] args)
    {
        string s = "Adil Aslam";
        strMode replace = new strMode(replaceSpaces);
        strMode remove = new strMode(removeSpaces);
        strMode reverse = new strMode(reverseString);

        Console.WriteLine(s);
        Console.WriteLine(replace(s));
        Console.WriteLine(remove(s));
        Console.WriteLine(reverse(s));

        Console.ReadLine();
    }

    static string replaceSpaces(string s){
        return s.Replace(' ', '-');
    }

    static string reverseString(string s){

        string temp = "";

        for (int i = s.Length - 1; i >= 0; i--)
            temp += s[i];

        return temp;
    }

    static string removeSpaces(string s){

        string temp = "";

        for (int i = 0; i < s.Length; i++)
            if (s[i] != ' ')
                temp += s[i];
        return temp;
    }
}