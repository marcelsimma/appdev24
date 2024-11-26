namespace BarbaraMarte.Week08.Test;

class BasisClassMedium
{
    private string Title { get; set; }
    private string Author { get; set; }
    private string PublishingYear { get; set; }
    private string ISBN { get; set; }

    public BasisClassMedium(string title, string author, string publishingYear, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublishingYear = publishingYear;
    }
    public override string ToString()
    {
        return string.Format($"Title: {Title} Author {Author} Publishing Year: {PublishingYear} ISBN {ISBN}");
    }
}

class Hardcover
{
    private string HardCover { get; set; }
    private string SoftCover { get; set; }
    public Hardcover(string hardCover, string softCover)
    {
        HardCover = hardCover;
        SoftCover = softCover;
    }
    public override string ToString()
    {
        return string.Format($"Hard covered Book: {HardCover} Soft covered Book: {SoftCover}");
    }
}
class EBook
{
    private string PDF { get; set; }
    private string EPub { get; set; }
    public EBook(string pdf, string ePub)
    {
        PDF = pdf;
        EPub = ePub;
    }
    public override string ToString()
    {
        return string.Format("");
    }
}