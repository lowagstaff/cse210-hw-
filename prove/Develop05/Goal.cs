using System.ComponentModel;

public class Goal
{
    protected string _name = "";
    protected string _description = "";
    protected int _points = 0;
    protected bool _isComplete = false;

    public int _totalPoints = 0;

    protected string completion = "";

    protected List<string> _file = new List<string>();

    public Goal()
    {
        
    }

    public Goal(string name, string destription, int points, bool isComplete)
    {
        _name = name;
        _description = destription;
        _points = points;
        _isComplete = isComplete;
    }

    public Goal(int TotalPoints)
    {
        _totalPoints = TotalPoints;
    }

    public string GetName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        return _name;
    }
    public string GetDescription()
    {
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        return _description;
    }
    public int GetPoints()
    {
        Console.Write("How many points is this goal worth? ");
        _points = int.Parse(Console.ReadLine());
        return _points;
    }

    public void trueComplete()
    {
        if(_isComplete == false)
        {
            completion = " "; 
        }
        else
        {
            completion = "X";
        }
    }

    public virtual int TotalPoints()
    {
        return _totalPoints + _points;
    }
}