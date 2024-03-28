using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Order
{
        List<String> productsList1 = new List<String>();
        List<String> productsList2 = new List<String>();
        private double _shipping {get; set;}

        public Order()
        {
            _shipping = 0;
        }

        public void GetPackingLabel1()
        {
            Console.WriteLine("Packing Label:");
            Product p1 = new Product(112, "Banana", 1.50, 2);
            Product p2 = new Product(135, "Milk", 2.50, 1);
            Product p3 = new Product(127, "Oreos", 5.99, 4);
            Product p4 = new Product(254, "Ice Cream", 1.50, 3);
            p1.ListProducts();
            p2.ListProducts();
            p3.ListProducts();
            p4.ListProducts();
            foreach (string product in p1.products)
            {
                string [] parts = product.Split(",");
                int id = int.Parse(parts[0]);
                string name = parts[1];
                double price = double.Parse(parts[2]);
                int quantity = int.Parse(parts[3]);
                Console.WriteLine($"(x{quantity}) - {name} - {id}");
                _shipping += p1.Total();
            }   
            foreach (string product in p2.products)
            {
                string [] parts = product.Split(",");
                int id = int.Parse(parts[0]);
                string name = parts[1];
                double price = double.Parse(parts[2]);
                int quantity = int.Parse(parts[3]);
                Console.WriteLine($"(x{quantity}) - {id} - {name}");
                _shipping += p2.Total();
            } 
            foreach (string product in p3.products)
            {
                string [] parts = product.Split(",");
                int id = int.Parse(parts[0]);
                string name = parts[1];
                double price = double.Parse(parts[2]);
                int quantity = int.Parse(parts[3]);
                Console.WriteLine($"(x{quantity}) - {name} - {id}");
                _shipping += p3.Total();
            } 
            foreach (string product in p4.products)
            {
                string [] parts = product.Split(",");
                int id = int.Parse(parts[0]);
                string name = parts[1];
                double price = double.Parse(parts[2]);
                int quantity = int.Parse(parts[3]);
                Console.WriteLine($"(x{quantity}) - {name} - {id}");
                _shipping += p4.Total();
            } 

            Customer c = new Customer("John");
            double total = c.IsUS1() + _shipping;
            Console.WriteLine($"Total Price: ${total}");
            Console.WriteLine("");
        }

        public void GetShippingLabel1()
        {
            Console.WriteLine("Shipping Label:");
            Customer c = new Customer("John Jones");
            c.GetName();
            c.GetAddress1();
            Console.WriteLine("");
        }

        public void GetPackingLabel2()
        {
            _shipping = 0;
            Console.WriteLine("Packing Label:");
            Product p1 = new Product(121, "Chocolate", 5.50, 6);
            Product p2 = new Product(174, "Gas-X", 2.50, 1);
            Product p3 = new Product(199, "Cups", 1.99, 1);
            Product p4 = new Product(515, "Pop Tarts", 3.99, 2);
            p1.ListProducts();
            p2.ListProducts();
            p3.ListProducts();
            p4.ListProducts();
            foreach (string product in p1.products)
            {
                string [] parts = product.Split(",");
                int id = int.Parse(parts[0]);
                string name = parts[1];
                double price = double.Parse(parts[2]);
                int quantity = int.Parse(parts[3]);
                Console.WriteLine($"(x{quantity}) - {name} - {id}");
                _shipping += p1.Total();
            }   
            foreach (string product in p2.products)
            {
                string [] parts = product.Split(",");
                int id = int.Parse(parts[0]);
                string name = parts[1];
                double price = double.Parse(parts[2]);
                int quantity = int.Parse(parts[3]);
                Console.WriteLine($"(x{quantity}) - {id} - {name}");
                _shipping += p2.Total();
            } 
            foreach (string product in p3.products)
            {
                string [] parts = product.Split(",");
                int id = int.Parse(parts[0]);
                string name = parts[1];
                double price = double.Parse(parts[2]);
                int quantity = int.Parse(parts[3]);
                Console.WriteLine($"(x{quantity}) - {name} - {id}");
                _shipping += p3.Total();
            } 
            foreach (string product in p4.products)
            {
                string [] parts = product.Split(",");
                int id = int.Parse(parts[0]);
                string name = parts[1];
                double price = double.Parse(parts[2]);
                int quantity = int.Parse(parts[3]);
                Console.WriteLine($"(x{quantity}) - {name} - {id}");
                _shipping += p4.Total();
            } 

            Customer c = new Customer("Jill");
            double total = c.IsUS2() + _shipping;
            Console.WriteLine($"Total Price: ${total}");
            Console.WriteLine("");
        }
        public void GetShippingLabel2()
        {
            Console.WriteLine("Shipping Label:");
            Customer c = new Customer("Jill Pickle");
            c.GetName();
            c.GetAddress2();
            Console.WriteLine("");
        }

}