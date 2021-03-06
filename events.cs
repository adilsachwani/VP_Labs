using System;

delegate void MyEventHandler();

class EventDemo
{
    static void Main(string[] args)
    {
        MyEvent evt = new MyEvent();

        evt.SomeEvent += Handler;

        evt.onSomeEvent();

        Console.ReadKey();
    }

    static void Handler(){
        Console.WriteLine("Event occured!");
    }
}

class MyEvent
{
    public event MyEventHandler SomeEvent;

    public void onSomeEvent(){
        if (SomeEvent != null)
            SomeEvent();
    }
}