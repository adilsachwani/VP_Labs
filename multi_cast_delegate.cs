using System;
delegate void strMode(ref string str);

class Program
{
    static void Main(string[] args)
    {
        string s = "Adil Aslam";

        strMode strOp;
        strMode replace = replaceSpaces;
        strMode remove = removeSpaces;
        strMode reverse = reverseString;

        strOp = replaceSpaces;
        strOp += removeSpaces;
        strOp += reverseString;

        strOp(ref s);
        Console.WriteLine(s);

        strOp -= replaceSpaces;

        strOp(ref s);
        Console.WriteLine(s);

        Console.ReadLine();
    }

    static void replaceSpaces(ref string s){
        s.Replace(' ', '-');
    }

    static void reverseString(ref string s){

        string temp = "";

        for (int i = s.Length - 1; i >=  0; i--)
            temp += s[i];

        s = temp;
    }

    static void removeSpaces(ref string s){

        string temp = "";

        for (int i = 0; i < s.Length; i++)
            if (s[i] != ' ')
                temp += s[i];
        s = temp;
    }
}