namespace InterFaceExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();
            products.Add(new Product("Teltta", 124.99, 450));
            products.Add(new Product("Aurinkotuoli", 19.99, 300));
            products.Add(new Product("Uimapatja", 39.00, 200));

            foreach (Product p in products)
            {
               // Console.WriteLine(p);
                if (p.MatchesName("Aurinkotuoli"))
                {
                    Console.WriteLine("Aurinkotuoli löytyi");
                    Console.WriteLine(p.ToString());

                    Console.WriteLine($"Varaston arvo: {p.CalculateTotal():F2}");
                }
            }
            Store KMarket = new Store("K-kauppa", 1000000);
            KMarket.AddProduct(new Product("Maito", 1, 150));
            KMarket.AddProduct(new Product("RedBull", 2.30, 200)); 
            KMarket.PrintProducts();
        }
    }
}
