using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> Activities = new List<Activity>();
        Running r = new ("Running", "4 April 2024", 65, 5);
        Activities.Add(r);
        //Console.WriteLine(r.GetDistance());
        //Console.WriteLine(r.GetSpeed(30));
        //Console.WriteLine(r.GetPace(30));
        //Console.WriteLine(r.GetSummary());

        Swimming s = new ("Swimming", "4 April 2024", 50, 10);
        Activities.Add(s);
        //Console.WriteLine(s.GetDistance());
        //Console.WriteLine(s.GetSpeed(30));
        //Console.WriteLine(s.GetPace(30));
        //Console.WriteLine(s.GetSummary());

        Cycling c = new ("Cycling", "4 April 2024", 30, 20);
        Activities.Add(c);
        //Console.WriteLine(c.GetDistance());
        //Console.WriteLine(c.GetSpeed(30));
        //Console.WriteLine(c.GetPace(30));
        //Console.WriteLine(c.GetSummary());

        foreach(Activity i in Activities)
        {
            Console.WriteLine(i.GetSummary());
            Console.WriteLine();
        }

    }
}