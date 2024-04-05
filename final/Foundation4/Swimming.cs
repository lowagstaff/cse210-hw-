class Swimming : Activity
{
    private int _laps {get; set;}

    public Swimming(string name, string date, int minutes, int laps) : base(name, date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = (_laps * 50) / (1000 * 0.62);
        return distance;
    }


    public override double GetPace(int minutes)
    {
        double pace = minutes / GetDistance();
        return pace;
    }

        public override double GetSpeed(int minutes)
    {
        double speed = 60 / GetPace(minutes);
        return speed;
    }

    







}