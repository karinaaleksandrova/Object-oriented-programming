using Bookexcercise;

namespace BookExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BookExercise");

            Book abcBook = new Book("Aapinen", "M. Agricola", 10, "12312312312");
            abcBook.PrintBookInfo();

            Book mathBook = new Book();
            mathBook.title = "Matikka 1 lk";
            mathBook.author = "Matti Meikäläinen";
            mathBook.price = 15;
            mathBook.PrintBookInfo();
            abcBook.CompareBooks(mathBook);
            mathBook.CompareBooks(abcBook);
        }

    }
}
