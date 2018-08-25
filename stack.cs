using System;
using System.Collections;

class EventDemo
{
    static void Main(string[] args)
    {
        Stack s = new Stack();
        showPush(s, 5);
        showPush(s, 10);
        showPush(s, 23);
        showPush(s, 26);
        showPush(s, 31);
        showPush(s, 33);
        showPush(s, 35);

        showPop(s);
        showPop(s);
        showPop(s);
        showPop(s);
        showPop(s);
        showPop(s);
        showPop(s);

        try{
            showPop(s);
        }
        catch(InvalidOperationException){
            Console.WriteLine("Empty Stack");
        }

        Console.ReadKey();
    }

    static void showPush(Stack s, int i){
        s.Push(i);
        Console.WriteLine("Push(" + i + ")");

        Console.Write("Stack: ");
        foreach(int n in s)
            Console.Write( n + ", ");

        Console.WriteLine();
    }

    static void showPop(Stack s){
        Console.Write("Pop->");
        Console.WriteLine((int) s.Pop());

        Console.Write("Stack: ");
        foreach (int n in s)
            Console.Write(n + ", ");

        Console.WriteLine();
    }

}