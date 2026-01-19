namespace CompanyExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- CompanyExample");
            Company c1 = new Company("X Oy", "Koulukatu 12", "0442994248", 10000000, 999000);
            Company c3 = new Company("Z Oy", "Rantakuja 45", "04543839485", 6500000, 834879483);
            Company c2 = new Company(c1);
            c1.CalculateProfit();
            

            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3);

            Company[] companies = new Company[2];
            companies[0] = new Company("X Oy", "Koulukatu 12", "0442994248", 10000000, 999000);
            companies[1] = new Company("Z Oy", "Rantakuja 45", "04543839485", 6500000, 834879483);

            Console.WriteLine("Testing foreach");
            foreach (Company currentCompany in companies)
            {
                Console.WriteLine(currentCompany.ToString());
                currentCompany.CalculateProfit();
            }
            Console.WriteLine("Testing for");
            for (int i=0; i<companies.Length; i++)
            {
                Console.WriteLine(companies[i].ToString());
                companies[i]?.CalculateProfit();
            }
            
        }
    }
}
