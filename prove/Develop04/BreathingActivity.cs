using System.Transactions;

public class BreathingActivity : Activity
{    
    public BreathingActivity()
    {
        
    }
    public BreathingActivity(int duration) : base(duration)
    {

    }
    public void StartBreathingActivity()
    {
        BreathingActivity b = new BreathingActivity();
        Activity a = new Activity("Breathing");
        Console.WriteLine(a.Welcome());
        Console.WriteLine("\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        
        b.Duration();
        Activity c = new Activity("Breathing", b._duration);
        int duration = b._duration/10;
        

        Console.WriteLine("Get ready to begin...");
        a.Spinner1();


        Console.WriteLine();
        for(int i = 0; i < duration; i++)
        {
            Console.Write("\nInhale... ");
            a.Countdown();
            Console.WriteLine();
            Console.Write("\nExhale... ");
            a.Countdown();
            Console.WriteLine();
        }

        Console.WriteLine(c.Close());
        Console.WriteLine();

    }
    

}