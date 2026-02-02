namespace VehicleExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("--Autojen tiedot--\n");
            Car car1 = new Car("Mercedes", "C", "2021", "Musta", 1.5, "sedan", 4, 220000);
            Car car2 = new Car("Toyota", "RAV 4", "2025", "Sähkön sininen", 2.5, "Katumaasturi", 4, 770000);
            Car car3 = new Car("Audi", "A6", "2004", "Harmaa", 2.6, "Farmari", 4, 5000);

            car1.PrintInformation();
            car2.printInformation();
            car3.printInformation();

            Console.WriteLine("\n --Autojen tiedot To.String- metodilla--\n");
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());


            Console.WriteLine("--equals--");
          Car car4 = car1 as Car;
            if (car4.Equals(car1))
            {
                Console.WriteLine($"\nHuom!: Tieto toistuu, auto {car4.Brand} ja auto {car1.Brand} ovat samat {car4.Equals(car1)}\n");
            }
            else
            {
                Console.WriteLine(car1.ToString());
            }


            Console.WriteLine("\nKuorma-autojen tiedot\n");
            Truck truck1 = new Truck("Sisu", "Kuorma-auto", "2017", "Sininen", 55000000, 7.2, "CM16M", 2, 5500000, 55);
            Truck truck2 = new Truck("Volvo", "Kuorma-auto", "2022", "Valkoinen", 4500000, 17.3, "FH16", 2, 6700000, 23.5);
            Truck truck3 = new Truck("Mercedes-Benz", "Kuorma-auto", "2018", "Musta", 77000000, 15.6, "Actros", 2, 7500000, 26);

            truck1.PrintInformation();
            truck2.PrintInformation();
            truck3.PrintInformation();

            Truck truck4 = new Truck("Renault", "Kuorma-auto", "2006", "Keltainen", 4400000, 12.8, "T", 2, 6340000, 57);

            Console.WriteLine("\n--Suoritetaan tyyppimuunnokset auto- ja kuorma-auto olioiden välillä\n");
            Car car5 = truck4 as Car;
            car5.printInformation();

            Console.WriteLine("Suoritetun tyyppimuunnoksen tulos:");

            if (car5 == truck4)
            {
                Console.WriteLine("Tyyppimuunnos onnistui");
            }
            else
            {
                Console.WriteLine("Tyyppimuunnos epäonnistui");
            }

            Console.WriteLine("---");




        }
    }
}
