public class EternalGoal : Goal
{
    public string _saved = "";

    public EternalGoal()
    {
        
    }
    public EternalGoal(string name, string description, int points, bool isComplete, string saved) : base(name, description, points, isComplete)
    {
        _saved = saved;
    }

    public void StartEternalGoal()
    {
        Goal ge = new Goal();
        string name = ge.GetName();
        string description = ge.GetDescription();
        int points = ge.GetPoints();
        _saved = $"{name}, {description}, {points}";
    }

    public override int TotalPoints()
    {
        return base.TotalPoints();
    }
}