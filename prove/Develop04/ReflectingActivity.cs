public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        _prompts.Add("--Think of a time when you stood up for someone else. ");
        _prompts.Add("--Think of a time when you did something really difficult. ");
        _prompts.Add("--Think of a time when you helped someone in need. ");
        _prompts.Add("--Think of a time when you did something truly selfless. ");

        _questions.Add("-Why was this experience meaningful to you?... ");
        _questions.Add("-Have you ever done anything like this before?... ");
        _questions.Add("-How did you get started?... ");
        _questions.Add("-How did you feel when it was complete?... ");
        _questions.Add("-What made this time different than other times when you were not as successful?... ");
        _questions.Add("-What did you learn about yourself through this experience?... ");
        _questions.Add("-How can you keep this experience in mind in the future?... ");
    }
    public ReflectingActivity(int duration) : base(duration)
    {
        _prompts.Add("--Think of a time when you stood up for someone else. ");
        _prompts.Add("--Think of a time when you did something really difficult. ");
        _prompts.Add("--Think of a time when you helped someone in need. ");
        _prompts.Add("--Think of a time when you did something truly selfless. ");

        _questions.Add("-Why was this experience meaningful to you?... ");
        _questions.Add("-Have you ever done anything like this before?... ");
        _questions.Add("-How did you get started?... ");
        _questions.Add("-How did you feel when it was complete?... ");
        _questions.Add("-What made this time different than other times when you were not as successful?... ");
        _questions.Add("-What did you learn about yourself through this experience?... ");
        _questions.Add("-How can you keep this experience in mind in the future?... ");
    }

    public void RandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _prompts.Count);
        Console.Write($"{_prompts[randomIndex]}");
    }

    public void RandomQuestions()
    {
        Random randomGen = new Random();
        int randomIn = randomGen.Next(0, _questions.Count);
        Console.Write($"{_questions[randomIn]}");        
    }
    public void StartReflectingActivity()
    {
        ReflectingActivity r = new ReflectingActivity();
        Activity a = new Activity("Reflecting");

        Console.WriteLine(a.Welcome());
        Console.WriteLine($"\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");

        r.Duration();
        Activity b = new Activity("Reflecting", r._duration);
        int duration = r._duration/10;

        Console.WriteLine();
        Console.WriteLine("Get ready to begin...");
        a.Spinner1();
        Console.WriteLine();

        r.RandomPrompt();
        a.Spinner2();
        Console.WriteLine();

        for (int i = 0; i < duration; i++)
        {
            r.RandomQuestions();
            a.Spinner2();
            Console.WriteLine();
        }
        Console.WriteLine(b.Close());
        Console.WriteLine();
    }
}