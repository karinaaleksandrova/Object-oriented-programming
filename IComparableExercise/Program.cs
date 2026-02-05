using Literature;

namespace IComparableExercise;

internal class Program : Books
{
    static void Main(string[] args)
    {
        List<Books> Books = new List<Books>();
        Books.Add(new Books("J.K. Rowling", "WSOY", "Harry Potter", 45.00, "978-123-12385"));
        Books.Add(new Books("Jane Austen", "Otava", "Ylpeys ja Ennakkoluulo", 24.99, "978-452-46574"));
        Books.Add(new Books("George Orwell", "Otava", "Vuonna 1984", 12.94, "978-346-53267"));

        Books.Sort();

        foreach (Books book in Books)
        {
            Console.WriteLine(book);
        }
    }
}
