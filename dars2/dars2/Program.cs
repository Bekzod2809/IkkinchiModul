namespace dars2;

internal class Program
{
    static List<Book> Books = new List<Book>();
    static void Main(string[] args)
    {
        DataSeed();
        var book = GetMaxPageCount();
        Console.WriteLine(book.PageCount);
        var books = GetBooks();
        foreach (var b in books)
        {
            Console.WriteLine(b.PageCount);
        }
    }
    static Book GetMaxPageCount()
    {
        Book book = Books[0];
        foreach (var b in Books)
        {
            if (book.PageCount < b.PageCount)
            {
                book = b;
            }
        }
        return book;
    }

    static List<Book> GetBooks()
    {
        var firstBook = GetMaxPageCount();
        Book book = Books[0];
        foreach (var b in Books)
        {
            if (book.PageCount < b.PageCount && b.PageCount < firstBook.PageCount)
            {
                book = b;
            }
        }
        List<Book> result = new List<Book>() { firstBook, book };
        return result;
    }
    static void DataSeed()
    {
        Books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "The Great Gatsby",
            Author = "F. Scott Fitzgerald",
            Price = 10.99m,
            Description = "A novel set in the Jazz Age that tells the story of Jay Gatsby's unrequited love for Daisy Buchanan.",
            Created = DateTime.Now,
            Genre = "Classic",
            PageCount = 180
        });

        Books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "Sariq Devni Minib",
            Author = "Xudoyberdi To'xtaboyev",
            Price = 5.99m,
            Description = "Legenda",
            Created = DateTime.Now,
            Genre = "Fantasy",
            PageCount = 270
        });

        Books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "Harry Poter",
            Author = "Opa",
            Price = 15.99m,
            Description = "Legenda 2",
            Created = DateTime.Now,
            Genre = "Fantasy",
            PageCount = 870
        });
    }
}
