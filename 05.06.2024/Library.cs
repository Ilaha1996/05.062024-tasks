namespace _05._06._2024;

public class Library
{
    private List<Book> books = new List<Book>();
    public Book this[int index]
    { get { return books[index]; } }

    public void AddBook(Book book)
    {
        books.Add(book);
    }
            
    public List<Book> FindAllBooksByName(string value)
    {
       return books.FindAll(x => x.Name.Contains(value));
    }

    public Book FindBookByCode(string code)
    {
       return books.Find(x => x.Code.Equals(code));
    }
    public void RemoveAllBooksByName(string value)
    {
        books.RemoveAll(x => x.Name.Contains(value));
    }
    public List<Book> SearchBooks(string value)
    {
       return books.FindAll(x => x.Name.Contains(value) || x.AuthorName.Contains(value));

    }
    public List<Book> FindAllBooksByPageCountRange(int min, int max)
    {
        return books.FindAll(x => x.PageCount>min && x.PageCount<max);
    }

    public void RemoveBookByCode(string code)
    {
        Book bookToRemove = FindBookByCode(code);
                    
        books.Remove(bookToRemove);   

    }


}
