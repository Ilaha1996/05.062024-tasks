namespace _05._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book("Master ve Marqarita") { Name = "Master ve Marqarita", PageCount = 657, AuthorName = "Mixail Bulqakov" });
            books.Add(new Book("Da Vinchi shifresi") { Name = "Da Vinchi shifresi", PageCount = 600, AuthorName = "Dan Brown" });
            books.Add(new Book("Nutuk") { Name = "Nutuk", PageCount = 325, AuthorName = "Ataturk" });
            books.ForEach(book => Console.WriteLine(book.Name));

            // Butun tasklari yoxlamadim tapsiriqda qeyd etmemisdiz deye, Yuxaridaki hissenin ise taskla o qeder de elaqesi yoxdu:)
        }
    }
}
