using System;
using System.Collections;

class EventDemo
{
    static void Main(string[] args)
    {
        Queue q = new Queue();
        showEnqueue(q, 5);
        showEnqueue(q, 10);
        showEnqueue(q, 23);
        showEnqueue(q, 26);
        showEnqueue(q, 31);
        showEnqueue(q, 33);
        showEnqueue(q, 35);

        showDequeue(q);
        showDequeue(q);
        showDequeue(q);
        showDequeue(q);
        showDequeue(q);
        showDequeue(q);
        showDequeue(q);

        try
        {
            showDequeue(q);
        }
        catch(InvalidOperationException){
            Console.WriteLine("Empty Queue");
        }

        Console.ReadKey();
    }

    static void showEnqueue(Queue q, int i){
        q.Enqueue(i);
        Console.WriteLine("Enqueue(" + i + ")");

        Console.Write("Queue: ");
        foreach(int n in q)
            Console.Write( n + ", ");

        Console.WriteLine();
    }

    static void showDequeue(Queue q){
        Console.Write("Dequeue->");
        Console.WriteLine((int) q.Dequeue());

        Console.Write("Queue: ");
        foreach (int n in q)
            Console.Write(n + ", ");

        Console.WriteLine();
    }

}