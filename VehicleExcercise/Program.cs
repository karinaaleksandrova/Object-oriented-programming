namespace VehicleExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("Audi", "A6", 2004, "20,000");
            v1.PrintInformation();
            Console.WriteLine();
            Vehicle v2 = new Vehicle("Audi", "A5", 2015, "50,000");
            v2.PrintInformation();
            Console.WriteLine();    
           // Console.WriteLine("Vehicle 1 Information: ");
            //Console.WriteLine("Vehicle 2 Information: ");
            //v1.PrintInformation();
            //v2.PrintInformation();

           
        }
    }
}
