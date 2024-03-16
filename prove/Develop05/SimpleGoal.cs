using System.ComponentModel;

public class SimpleGoal : Goal
{

    public string _saved = "";


    public SimpleGoal()
    {
        
    }
    public SimpleGoal(string name, string description, int points, bool isComplete, string saved) : base(name, description, points, isComplete)
    {
        _saved = saved;
    }

    public void StartSimpleGoal()
    {
        Goal gs = new Goal();
        string name = gs.GetName();
        string description = gs.GetDescription();
        int points = gs.GetPoints();
        _saved = $"{name}, {description}, {points}";
    }

    public override int TotalPoints()
    {
        return _totalPoints + _points;
    }
}