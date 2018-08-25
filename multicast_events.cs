using System;

delegate void MyEventHandler();

class EventDemo
{
    static void Main(string[] args)
    {
        MyEvent evt = new MyEvent();
        X x = new X();
        Y y = new Y();

        evt.SomeEvent += Handler;
        evt.SomeEvent += x.XHandler;
        evt.SomeEvent += y.YHandler;

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

class X
{
    public void XHandler(){
        Console.WriteLine("Event received by X Object");
    }
}

class Y
{
    public void YHandler(){
        Console.WriteLine("Event received by Y Object");
    }
}