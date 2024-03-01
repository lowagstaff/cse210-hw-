using System.Globalization;
using System.Reflection.Metadata;
using Microsoft.Win32.SafeHandles;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _input = new List<string>();

    public ListingActivity()
    {
        _prompts.Add("--Who are people that you appreciate? ");
        _prompts.Add("--What are personal strengths of yours? ");
        _prompts.Add("--Who are people that you have helped this week? ");
        _prompts.Add("--When have you felt the Holy Ghost this month? ");
        _prompts.Add("--Who are some of your personal heroes? ");

    }
    

    public void RandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _prompts.Count);
        Console.Write($"{_prompts[randomIndex]}");        
    }

    public void StartListingActivity()
    {
        ListingActivity l = new ListingActivity();
        Activity a = new Activity("Listing");

        Console.WriteLine(a.Welcome());
        Console.WriteLine("\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");

        l.Duration();
        Activity b = new Activity("Listing", l._duration);
        int duration = l._duration;

        Console.WriteLine();
        Console.WriteLine("Get ready to begin... List as many responses as you can to the following prompt!");
        a.Spinner1();
        Console.WriteLine();
        l.RandomPrompt();
        Console.WriteLine();
        
        DateTime startTime = DateTime.Now;
        DateTime end = DateTime.Now.AddSeconds(duration);

        
        while (DateTime.Now - startTime < end - DateTime.Now)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            _input.Add(input);
        }
                
        Console.WriteLine($"You listed {_input.Count} items!");


        Console.WriteLine(b.Close());
        Console.WriteLine();
    }

}