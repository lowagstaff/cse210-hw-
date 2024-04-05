class Lecture : Event
{
    private string _speaker {get; set;}
    private string _capacity {get; set;}

    public Lecture(string title, string description, string date, string time, string address, string type, string speaker, string capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}