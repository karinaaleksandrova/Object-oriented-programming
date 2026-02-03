namespace EläinVakuutuksetKuvaus
{
    internal class Program
    {
        public static void main(String[] args)
        {
            InsuranceManager im = new InsuranceManager();
            im.AddInsurance("koira", "Rolle", false);
            im.AddInsurance("koira", "Tessu", true);
            im.AddInsurance("kissa", "Monni", true);
            im.AddInsurance("koira", "Pluto", false);
            im.AddInsurance("lintu", "Tipi", false);
            im.PrintInsurances();
            Console.WriteLine("---");
            im.FindInsurances("koira", false);
        }
    }
}
