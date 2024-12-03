namespace BarbaraMarte.Schule.Library;

class User
{

    private string FirstName { get; set; }
    private string LastName { get; set; }
    public string IdNumber { get; private set; }
    public List<Book> UserBorrowedBooks { get; private set; } = []; // is the exact same as this: " new List<string>() " just in short

    public User(string firstName, string lastName, string idNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        IdNumber = idNumber;
    }
    public override string ToString()
    {
        string borrowedBooks;
        if (UserBorrowedBooks.Count > 0)
        {
            borrowedBooks = string.Join("\n", UserBorrowedBooks);
        }
        else
        {
            borrowedBooks = "No borrowed books";
        }

        return string.Format(
            @$"Family name: {LastName}, First name: {FirstName}, User ID: {IdNumber}, 
            Borrowed Books:
            {borrowedBooks} ");
    }
}
/*
	Benutzer Eingabe über die Konsole
	Klasse mit Objekten
    o	Klasse Buch mit Eigenschaften: Titel, Autor, ISBN, Verfügbarkeit
	Erstelle ein oder zwei Objekte der Klasse Buch und schreib die Details vom Buch aus
	Klass Bibliothek die eine Sammlung von Büchern verwaltet
    o	Methode: Buch Hinzufügen
    o	Alle Bücher Anzeigen
	Buch ausleihen und zurückgeben
    o	Buch ausleihen, mit ISBN  prüfen ob da Buch da ist und setze die Verfügbarkeit auf false
    o	Buch zurückgeben, ISBN auf true setzen
	Erstelle eine Klasse Benutzer
    o	Name, BenutzerID Ausgeliehene Bücher
    o	Benutzer hinzufügen und Regestrieren
    o	Verknüpfe das Ausleihen eines Buches mit einem Benutzer
Benutzer soll die Information 

*/