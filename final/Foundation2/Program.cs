using System;

class Program
{
    static void Main(string[] args)
    {
        Order o1 = new Order();
        o1.GetPackingLabel1();
        o1.GetShippingLabel1();
        o1.GetPackingLabel2();
        o1.GetShippingLabel2();
    }
}