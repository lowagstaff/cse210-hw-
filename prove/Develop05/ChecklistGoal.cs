using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

public class ChecklistGoal : Goal
{
    private int _bonus = 0;

    private int _count = 0;

    protected int _done = 0;

    public string _saved = "";

    public ChecklistGoal()
    {

    }

    public ChecklistGoal(string name, string description, int points, int bonus, bool isComplete, int count, string saved) : base(name, description, points, isComplete)
    {
        _bonus = bonus;
        _count = count;
        _saved = saved;
    }

    public int GetBonus()
    {
        Console.Write("What is the bonus for completing this goal? ");
        _bonus = int.Parse(Console.ReadLine()); 
        return _bonus;
    }

    public int GetCount()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _count = int.Parse(Console.ReadLine());
        return _count;
    }

    public void StartChecklist()
    {
        Goal gc = new Goal();
        string name = gc.GetName();
        string description = gc.GetDescription();
        int points = gc.GetPoints();
        _saved = $"{name}, {description}, {points}";
    }

    public override int TotalPoints()
    {
        return base.TotalPoints();
    }
}