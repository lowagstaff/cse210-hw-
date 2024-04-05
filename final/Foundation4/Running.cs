class Running : Activity
{
    private int _distance {get; set;}

    public Running(string name, string date, int minutes, int distance) : base(name, date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed(int minutes)
    {
        int speed = 60 * _distance / minutes ;
        return speed;
    }

    public override double GetPace(int minutes)
    {
        return minutes / _distance;
    }
}