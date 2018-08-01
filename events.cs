using System;
delegate void NotificationHandler();

class Program
{
    static void Main(string[] args)
    {

        Notifications obj = new Notifications();

        obj.setNotification += User1.user1Noti;
        obj.setNotification += User2.user2Noti;

        obj.pushNotification();

        Console.ReadKey();

    }
}

class Notifications{

    public event NotificationHandler setNotification;

    public void pushNotification(){
        if (setNotification != null)
            setNotification();
    }
}

class User1
{
    public static void user1Noti(){
        Console.WriteLine("Notification to user 1");
    }
}

class User2
{
    public static void user2Noti(){
        Console.WriteLine("Notification to user 2");
    }
}