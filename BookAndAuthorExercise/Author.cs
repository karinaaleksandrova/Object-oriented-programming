using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Literature;

namespace BookAndAuthorExercise
{
    internal class Author
    {
        public string name;
        public string birthday;
        private Book book;

        public Author()
        {
            this.name = string.Empty;
            this.birthday = string.Empty;
            this.Book = null;
        }

        public Author(string name, string birthday, Book book)
        {
            this.name = name;
            this.birthday = birthday;
            this.Book = book;
        }
        public Author(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
            this.Book = null;
        }

        internal Book Book
        {
            get
            {
                return book;
            }

            set
            {
                if (value == null || value.Author == name)
                {
                    book = value;
                }
                else
                {
                    Console.WriteLine("Error: ");
                }
                
            }
        }
        public void PrintInformation()
        {
            Console.WriteLine($"Kirjailija: {name}");
            Console.WriteLine($"Syntymäpäivä: {birthday}");

            if (Book != null)
            {
                Console.WriteLine($"Kirja: {Book.Name}");
                Console.WriteLine($"Kirjailija: {Book.Author}");
            }
            else
            {
                Console.WriteLine("Ei kirjaa");
            }
            Console.WriteLine();
        }
        public override string? ToString()
        {
            //TODO: lisää kirjan tiedot
            return $"{this.name}, {this.birthday}, {this.Book.ToString()}";
        }
    }
}
