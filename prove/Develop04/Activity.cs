using System.Transactions;

public class Activity
{
    protected string _name;
    protected int _duration;

    public Activity()
    {
        _name = "";
    }

    public Activity(string name)
    {
        _name = name;
    }

    public Activity(string name, int duration)
    {
        _name = name;
        _duration = duration;
    }

    public Activity(int duration)
    {
        _duration = duration;
    }
    
    public string Welcome()
    {
        return $"Welcome to the {_name} Activity!";
    }

    public void Duration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public string Close()
    {
        return $"\nWell done!\nYou have completed another {_duration} seconds of the {_name} Activity.";
    }

    public void Spinner1()
    {
        for(int i = 0; i < 4; i++)
        {
            Console.Write("\b|");
            Thread.Sleep(200);
            Console.Write("\b/");
            Thread.Sleep(200);
            Console.Write("\b-");
            Thread.Sleep(200);
            Console.Write("\b\\");
            Thread.Sleep(200);
            Console.Write("\b|");
            Thread.Sleep(200);
        }
    }

    public void Spinner2()
    {
        for(int i = 0; i < 4; i++)
        {
            Console.Write("\b|");
            Thread.Sleep(400);
            Console.Write("\b/");
            Thread.Sleep(400);
            Console.Write("\b-");
            Thread.Sleep(400);
            Console.Write("\b\\");
            Thread.Sleep(400);
            Console.Write("\b|");
            Thread.Sleep(400);
        }
    }

    public void Countdown()
    {
        Console.Write("\b5");
        Thread.Sleep(1000);
        Console.Write("\b4");
        Thread.Sleep(1000);
        Console.Write("\b3");
        Thread.Sleep(1000);
        Console.Write("\b2");
        Thread.Sleep(1000);
        Console.Write("\b1");
        Thread.Sleep(1000);
        Console.Write("\b0");
        Thread.Sleep(1000);
    }


}