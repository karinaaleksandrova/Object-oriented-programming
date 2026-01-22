using Literature;
namespace BookAndAuthorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Name = "Matikka";

            //Console.WriteLine(b.Name);
            Book b1 = new Book("Paavo Pesusieni", "Otava", "Matikka", 19.96, "978-456-78910");
            Book b2 = new Book("Katti Matikainen", "Tammi", "Aapinen", 54.00, "933-134-23532");
            Book.ChangeTheme();
            b1.GetBookDetails();
            b2.GetBookDetails();
            //  Console.WriteLine(b.ToString());
            Console.WriteLine(b1.GetBookDetails("978-456-78910"));
           // Console.WriteLine(b1);

            Book b3 = new Book("A.Lindgren", "Otava", "Peppi Pitkätossu", 26.99, "978-323-23418");
            Author a1 = new Author("A.Lindgren", "01.01.1700", b3);
            Author a2 = new Author("Katti Matikainen", "09.04.2035", b2);
            Author a3 = new Author("Tove Jansson", "02.02.1999");
            a1.PrintInformation();
            a2.PrintInformation();
            a3.PrintInformation();
           
        }
    }
}
