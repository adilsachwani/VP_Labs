using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Byte[] b = { 72, 101, 108, 108, 111, 32 };

        //creating directory
        DirectoryInfo di = new DirectoryInfo("D:\\MyDirectory");
        di.Create();

        //creating file and file stream
        FileInfo fi = new FileInfo("D:\\MyDirectory\\vp.txt");
        FileStream fs = fi.Create();

        //checking if the file is created or not
        if (File.Exists("D:\\MyDirectory\\vp.txt"))
            Console.WriteLine("File created");
        else
            Console.WriteLine("File not created");

        //writing to file
        fs.Write(b, 0, 6);
        fs.Close();
        Console.WriteLine("Data Written");

        Console.ReadKey();
    }
}