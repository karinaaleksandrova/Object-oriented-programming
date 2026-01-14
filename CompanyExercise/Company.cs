using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExercise
{
    internal class Company
    {
        public string title;
        public string address;
        public string phone;
        public double income;
        public double expense;


        //Copy constructor
        public Company(Company otherCompany)
        {
            this.title = otherCompany.title;
            this.address = otherCompany.address;
            this.phone = otherCompany.phone;
            this.income = otherCompany.income;
            this.expense = otherCompany.expense;

        }



        public Company()
        {
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.income = 0;
            this.expense = 0;

        }

        public Company(string title, string address, string phone, double income, double expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.income = income;
            this.expense = expense;
        }

        public override string? ToString()
        {
            return $"{this.title}, {this.address}, {this.phone}, {this.income}, {this.expense} "; //base.ToString();

        }
        public void CalculateProfit()
        {
            double profitProcent = (this.income - this.expense) / this.income * 100;


            if (profitProcent < 5) 
            {
                Console.WriteLine("Yrityksellä menee huonosti.");
            }

            else if (profitProcent >= 5 && profitProcent <= 10)
                {
                    Console.WriteLine("Yrityksellä menee välttävästi");
                }
                else if (profitProcent >= 10 && profitProcent <= 20)
                {
                    Console.WriteLine("Yrityksellä menee tyydyttävästi");
                }
                else
                {
                    Console.WriteLine("Yrityksellä menee hyvin");
                }

            }
        }
    }



