using System.CodeDom.Compiler;

public class Address
{
    private string _streetAddress {get; set;}
    private string _city {get; set;}
    private string _sorp {get; set;}
    private string _country {get; set;}

    public Address(string streetAddress, string city, string sorp, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _sorp = sorp;
        _country = country;
    }

    public void GetFullAddress()
    {
        Console.WriteLine($"{_streetAddress}, {_city}\n{_sorp}, {_country}");
    }

    public string IsUS()
    {
        if (_country == "United States")
        {
            return "True";
        }
        else 
        {
            return "False";
        }
    }
}