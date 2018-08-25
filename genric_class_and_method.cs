using System;

class Demo
{
    static void Main(string[] args)
    {
        Gen<int> intObj = new Gen<int>(23);
        Gen<string> stringObj = new Gen<string>("Adil Aslam");
        Gen<char> charObj = new Gen<char>('c');

        Console.WriteLine(intObj.getObj());
        intObj.showType();

        Console.WriteLine();

        Console.WriteLine(stringObj.getObj());
        stringObj.showType();

        Console.WriteLine();

        Console.WriteLine(charObj.getObj());
        charObj.showType();

        Console.ReadKey();
    }
}

class Gen<T>
{
    T obj;

    public Gen(T obj){
        this.obj = obj;
    }

    public T getObj(){
        return obj;
    }

    public void showType(){
        Console.WriteLine("Type of T is " + typeof(T));
    }
}