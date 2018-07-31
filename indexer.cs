using System;

class Program
{
    static void Main(string[] args)
    {
        Rect obj = new Rect(2, 3);
        Console.WriteLine("Width: " + obj[0]);
        Console.WriteLine("Height: " + obj[1]);

        Console.ReadLine();
    }
}

class Rect
{
    int[] dim = new int[2];

    public Rect(int w, int h){
        dim[0] = w;
        dim[1] = h;
    }

    public int this[int a]{

        get
        {
            if (a == 0)
                return dim[0];
            else
                return dim[1];
        }
    }

}