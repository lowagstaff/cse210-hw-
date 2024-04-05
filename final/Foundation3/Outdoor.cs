class Outdoor : Event
{
    private string _weather {get; set;}
    public Outdoor(string title, string description, string date, string time, string address, string type, string weather) : base(title, description, date, time, address, type)
    {
        _weather = weather;
    }

    public string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nWeather: {_weather}";
    }
}