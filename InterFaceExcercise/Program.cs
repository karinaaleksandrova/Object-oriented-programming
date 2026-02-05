namespace InterFaceExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Product> products = new List<Product>();
            products.Add(new Product("Teltta", 124.99, 450));
            products.Add(new Product("Aurinkotuoli", 19.99, 300));
            products.Add(new Product("Uimapatja", 39.00, 200));

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Miska Suhonen", 1908.89));
            customers.Add(new Customer("Elina Huttunen", 3453.00));
            customers.Add(new Customer("Moona Mannari", 9999.99));

            foreach (Product d in products)
            {
                Console.WriteLine(d.ToString());
            }
            Console.WriteLine();

            foreach (Product p in products)
            {
                if (p.MatchesName("Aurinkotuoli"))
                {
                    Console.WriteLine("Aurinkotuoli löytyi");
                    Console.WriteLine(p.ToString());

                    Console.WriteLine($"Varaston arvo: {p.CalculateTotal():F2}");
                }
            }

            double sum = 0;
            foreach (Product p in products)
            {
                sum += p.CalculateTotals();
            }

            Store KMarket = new Store("K-kauppa", 1000000);
            KMarket.AddProduct(new Product("Maito", 1, 150));
            KMarket.AddProduct(new Product("RedBull", 2.30, 200));
            KMarket.AddProduct(new Product("Jauheliha", 6.99, 450));
            KMarket.PrintProducts();
            Console.WriteLine();

           

            bool found = false;
            foreach (Customer c in customers)
                if (c.MatchesName("Elina Huttunen"))
                {
                    Console.WriteLine("Elina Huttunen löytyi");
                    Console.WriteLine(c.ToString());

                    Console.WriteLine($"Bonukset: {c.GetBonus():F2}");
                    found = true;
                    break;
                }
                if (!found)
                {
                    Console.WriteLine("Asiakkaan nimi ei tiedossa");
                }

                foreach (Customer c in customers)
            {
                KMarket.AddCustomers(c);
            }
                Console.WriteLine(KMarket.ToString());
            Console.ReadLine();
        }
    }
}
