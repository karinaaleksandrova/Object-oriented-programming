using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookexcercise
{
    internal class Book
    {
            public string title;
            public string author;
            public double price;
            public string id;

            public Book()
            {
                this.title = string.Empty;
                this.author = string.Empty;
                this.price = 0;
                this.id = string.Empty;

            }

            public Book(string title, string author, double price, string id)
            {
                this.title = title;
                this.author = author;
                this.price = price;
                SetId(id); // this.id = id;
            }

            public void PrintBookInfo()
            {
                Console.WriteLine($"{this.author} : {this.title} : {this.price} : {this.id}");
            }
        public void SetId(string Idvalue)
        {
            if (Idvalue.Length == 5)
            {
                this.id = Idvalue;
            }
            else
            {
                this.id = "";
            }

             }
        }
    }


