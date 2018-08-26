using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
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

        //creating a stream writer object
        StreamWriter sw = new StreamWriter(fs);
        
        //writing to file
        sw.WriteLine("Adil Aslam Sachwani");
        sw.WriteLine("Hello World");
        sw.Close();
        fs.Close();

        try{
            //creating a stream reader object
            StreamReader sr = new StreamReader("D:\\MyDirectory\\vp.txt");

            //reading from file
            string str;

            while ((str = sr.ReadLine()) != null)
                Console.WriteLine(str);

            sr.Close();
        }
        catch(FileNotFoundException e){
            Console.WriteLine(e.Message);
        }
        
        Console.ReadKey();
    }
}