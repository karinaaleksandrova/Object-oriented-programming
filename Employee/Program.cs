namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            employee[] employee = new employee[3];
            employee[0] = new employee("Martti Pekkanen", 777, "Sihteeri", 3000);
            employee[1] = new employee("Tiina Matikainen", 888, "Päälikkö", 55000);
            employee[2] = new employee("Kalevi Puro", 333, "Koodaaja", 5000);

            Console.WriteLine("--Työntekijän tiedot:\n");

            foreach (employee currentemployee in employee)
            {
                currentemployee.PrintEmployeeInfo();
            }
            Console.WriteLine("\n\n-- Verrataan palkkoja:\n");

            for (int i = 0; i < employee.Length; i++)
            {
                employee[i].CompareSalary(employee[(i + 1) % employee.Length]);
            }
        }
    }
}
