using System;
using System.Diagnostics;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string menu = "";
        while (menu != "4")
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    BreathingActivity b = new BreathingActivity();
                    b.StartBreathingActivity();
                    break;
                case "2":
                    ReflectingActivity r = new ReflectingActivity();
                    r.StartReflectingActivity();
                    break;
                case "3":
                    ListingActivity l = new ListingActivity();
                    l.StartListingActivity();
                    break;
                case "4":
                    break;
            }        
        }
    }
}