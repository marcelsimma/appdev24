namespace BarbaraMarte.Schule.Library;
class Book
{
    private string Title { get; set; }
    private string Author { get; set; }
    private string ISBN { get; set; }
    private bool IsAvailable { get; set; }

    public Book(string title, string author, string isbn, bool isAvailable)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        IsAvailable = isAvailable;
    }
    public override string ToString()
    {
        return string.Format($"Title: {Title} Author {Author} ISBN {ISBN} Is the book available? {IsAvailable}");
    }
}