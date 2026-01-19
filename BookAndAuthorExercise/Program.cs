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
            Console.WriteLine(b1);
        }
    }
}
