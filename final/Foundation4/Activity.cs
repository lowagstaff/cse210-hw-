using System.Dynamic;

public class Activity
{
    private string _name {get; set;}
    private string _date {get; set;}

    private int _minutes {get; set;}

    public Activity(string name, string date, int minutes)
    {
        _name = name;
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return -1;
    }

    public virtual double GetSpeed(int minutes)
    {
        return -1;
    }

    public virtual double GetPace(int minutes)
    {
        return -1;
    }

    public string GetSummary()
    {
        return $"-> {_date} {_name} ({_minutes} min): Distance {GetDistance()} miles, {GetSpeed(_minutes)} mph, {GetPace(_minutes)} min per mile";
    }


}