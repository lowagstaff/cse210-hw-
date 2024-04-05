using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture l = new Lecture("Calculus", "Come learn about calculus", "01/01/2023", "10:00", "123 Main St", "Lecture", "John Doe", "50");
        l.GetAddress();
        Console.WriteLine("Standard Details: ");
        Console.WriteLine(l.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine("Full Details: ");
        Console.WriteLine(l.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine("Basic Description: ");
        Console.WriteLine(l.GetDescription());
        Console.WriteLine("");

        Reception r = new Reception("K&L Wedding", "We are getting married", "01/31/2023", "12:00", "123 State St", "Reception", "Email@example.com");
        r.GetAddress();
        Console.WriteLine("Standard Details: ");
        Console.WriteLine(r.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine("Full Details: ");
        Console.WriteLine(r.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine("Basic Description: ");
        Console.WriteLine(r.GetDescription());
        Console.WriteLine("");

        Outdoor o = new Outdoor("Hunters Education", "Get Your Hunting License", "03/19/2023", "1:00", "123 Copperhead St", "Outdoor", "Sunny");
        o.GetAddress();
        Console.WriteLine("Standard Details: ");
        Console.WriteLine(o.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine("Full Details: ");
        Console.WriteLine(o.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine("Basic Description: ");
        Console.WriteLine(o.GetDescription());
        Console.WriteLine("");
    }
}