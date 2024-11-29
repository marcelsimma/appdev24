namespace BarbaraMarte.Schule.Library;

class User
{

    private string FirstName { get; set; }
    private string LastName { get; set; }
    public string IdNumber { get; private set; }
    public List<Book> UserBorrowedBooks { get; private set; } = []; // is the exact same as this: " new List<string>() " just in short

    public User(string firstName, string lastName, string idNumber) // , bool isAvailable
    {
        FirstName = firstName;
        LastName = lastName;
        IdNumber = idNumber;
        // IsAvailable = isAvailable;
    }
    public override string ToString()
    {
        return string.Format(
            @$"Family name: {LastName} First name: {FirstName} User ID: {IdNumber} 
            Books that{FirstName} has borrowed:
            {UserBorrowedBooks} ");
        // Is the User name already used {IsAvailable}
    }
}