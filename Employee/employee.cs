using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class employee
    {
        public string name;
        public int id;
        public string position;
        public double salary;
        public double biggerSalary;
        private static int Counter = 1;

        public employee()
        {
            this.name = string.Empty;
            this.id = 1;
            this.position = string.Empty;
            this.salary = 0;
        }


        public employee(string name, int id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;

        }
        public void CompareSalary(employee employee)
        {
            if (this.salary > employee.salary)
            {
                Console.WriteLine($"{this.name} palkka {this.salary} euroa on suurempi kuin {employee.name} palkka {employee.salary} euroa");
            }
            else
            {
                if (this.salary < employee.salary)
                {
                    Console.WriteLine($"{this.name} ja {employee.name} palkat ovat samat");
                }
            }
        }
            public void PrintEmployeeInfo()
        {
            Console.WriteLine(this.ToString());
        }
        public override string? ToString()
        {
            return $"Työntekijän nimi: {this.name}\n" +
                $"Työntekijän id: {this.id}\n" +
                $"Työtehtävä: {this.position}\n" +
                $"Palkkatulot: {this.salary}\n";
        }
    }

}


