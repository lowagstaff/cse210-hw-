using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

class Reception : Event
{
    private string _email {get; set;}

    public Reception(string title, string description, string date, string time, string address, string type, string email) : base(title, description, date, time, address, type)
    {
        _email = email;
    }

    public string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nRSVP Email: {_email}";
    }
}