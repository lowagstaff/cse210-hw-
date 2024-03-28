public class Product
{
    private int _id {get; set;}
    private string _name {get; set;}
    private double _price {get; set;}
    private int _quantity {get; set;}

    public List<string> products = new List<string>();

    public Product(int id, string name, double price, int quantity)
    {
        _id = id;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public void ListProducts()
    {
        string product = $"{_id},{_name},{_price},{_quantity}";
        products.Add(product);
    }

    public double Total()
    {
        return _price * _quantity;
    }
}