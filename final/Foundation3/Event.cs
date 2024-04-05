class Event
{
    private string _type {get; set;}
    private string _title {get; set;}
    private string _description {get; set;}
    private string _date {get; set;}
    private string _time {get; set;}
    private string _address {get; set;}

    public Event(string title, string description, string date, string time, string address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public string GetAddress()
    {
        return _address;
    }

    public string GetStandardDetails()
    {
        return $"{_title}, {_description}, {_date}\n{_time}, {GetAddress()}";
    }


    public string GetDescription()
    {
        return $"{_type}\n{_title} - {_description}";
    }
}