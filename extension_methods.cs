using System;

class Demo
{
    static void Main(string[] args)
    {
        string[] texts = { "adil_aslam_sachwani", "naveed_raza", "rija_asif_butt"};

        foreach(string text in texts)
            Console.WriteLine(text.CamelCase());

        Console.ReadKey();
    }
}

static class Extension
{
    public static string CamelCase(this string str)
    {
        string newstr = "";
        bool sawUnderScore = false;

        foreach(char ch in str)
        {
            if (newstr.Length == 0 && char.IsLetter(ch))
                newstr += char.ToUpper(ch);
            else if (ch == '_')
                sawUnderScore = true;
            else if (sawUnderScore){
                newstr += char.ToUpper(ch);
                sawUnderScore = false;
            }
            else
                newstr += ch;
        }

        return newstr;
    }
}