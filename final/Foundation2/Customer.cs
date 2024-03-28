public class Customer
{
    private string _name {get; set;}




    public Customer(string name)
    {
        _name = name;
    }

    public void GetName()
    {
        Console.WriteLine(_name);
    }

    public void GetAddress1()
    {
        Address a1 = new Address("123 Main Street", "Anytown", "NY", "United States");
        a1.GetFullAddress();
    }

    public void GetAddress2()
    {
        Address a2 = new Address("123 Main Street", "Anytown", "Siberia", "Canada");
        a2.GetFullAddress();
    }
    public double IsUS1()
    {
        Address a1 = new Address("123 Main St.", "Anytown", "NY", "United States");

        if (a1.IsUS() == "True")
        {
            return 5.00;
        }
        else
        {
            return 35.00;
        }
        
    }
    public double IsUS2()
    {
        Address a2 = new Address("123 Main St.", "Anytown", "Siberia", "Canada");

        if (a2.IsUS() == "True")
        {
            return 5.00;
        }
        else
        {
            return 35.00;
        }
        
    }
    
}