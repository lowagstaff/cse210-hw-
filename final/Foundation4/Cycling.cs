class Cycling : Activity
{
    int _speed {get; set;}

    public Cycling(string name, string date, int minutes, int speed) : base(name, date, minutes)
    {
        _speed = speed;
    }

    public override double GetPace(int minutes)
    {
        double pace = 60 / _speed;
        return pace;
    }

    public override double GetSpeed(int minutes)
    {
        return _speed;
    }


    public override double GetDistance()
    {
        double minutes = 30;
        double time = minutes / 60.0;
        double distance = _speed / time;
        return distance;
    }


}