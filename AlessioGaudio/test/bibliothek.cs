using System;
using System.Collections.Generic;
using System.Linq;

namespace Bibliotheksverwaltung
{
    public abstract class Medium
    {
        private string Titel;
        private string Autor;
        private int Veroeffentlichungsjahr;
        private string ISBN;

        public Medium(string titel, string autor, int jahr, string isbn)
        {
            Titel = titel;
            Autor = autor;
            Veroeffentlichungsjahr = jahr;
            ISBN = isbn;
        }

        public virtual void ZeigeInfo()
        {
            Console.WriteLine($"Titel: {Titel}, Autor: {Autor}, Jahr: {Veroeffentlichungsjahr}, ISBN: {ISBN}");
        }

        public string GetTitel() => Titel;
        public string GetAutor() => Autor;
        public string GetISBN() => ISBN;
    }

    public class Buch : Medium
    {
        private string Bindung;

        public Buch(string titel, string autor, int jahr, string isbn, string bindung)
            : base(titel, autor, jahr, isbn)
        {
            Bindung = bindung;
        }

        public override void ZeigeInfo()
        {
            base.ZeigeInfo();
            Console.WriteLine($"Bindung: {Bindung}");
        }
    }

    public class Ebook : Medium
    {
        private string Dateiformat;

        public Ebook(string titel, string autor, int jahr, string isbn, string format)
            : base(titel, autor, jahr, isbn)
        {
            Dateiformat = format;
        }

        public override void ZeigeInfo()
        {
            base.ZeigeInfo();
            Console.WriteLine($"Dateiformat: {Dateiformat}");
        }
    }

    public class Bibliothek
    {
        private List<Medium> medien;

        public Bibliothek()
        {
            medien = new List<Medium>();
        }

        public void Hinzufuegen(Medium medium)
        {
            medien.Add(medium);
            Console.WriteLine($"Hinzugefügt: {medium.GetTitel()} ({medium.GetISBN()})");
        }

        public void Entfernen(string isbn)
        {
            Medium medium = medien.FirstOrDefault(m => m.GetISBN() == isbn);
            if (medium != null)
            {
                medien.Remove(medium);
                Console.WriteLine($"Entfernt: {medium.GetTitel()} ({medium.GetISBN()})");
            }
            else
            {
                Console.WriteLine($"Kein Medium mit ISBN {isbn} gefunden.");
            }
        }

        public List<Medium> Suche(string suchbegriff)
        {
            List<Medium> ergebnisse = medien.Where(m =>
                m.GetTitel().Contains(suchbegriff, StringComparison.OrdinalIgnoreCase) ||
                m.GetAutor().Contains(suchbegriff, StringComparison.OrdinalIgnoreCase)).ToList();

            return ergebnisse;
        }

        public void Start()
        {
            Buch buch1 = new Buch("Der Hobbit", "J.R.R. Tolkien", 1937, "1234567890", "Hardcover");
            Buch buch2 = new Buch("1984", "George Orwell", 1949, "0987654321", "Softcover");
            Ebook ebook1 = new Ebook("Clean Code", "Robert C. Martin", 2008, "1122334455", "PDF");
            Ebook ebook2 = new Ebook("Design Patterns", "Erich Gamma", 1994, "2233445566", "EPUB");

            Hinzufuegen(buch1);
            Hinzufuegen(buch2);
            Hinzufuegen(ebook1);
            Hinzufuegen(ebook2);

            Console.WriteLine("Suche nach 'Tolkien':");
            List<Medium> suchergebnisse = Suche("Tolkien");
            foreach (Medium medium in suchergebnisse)
            {
                medium.ZeigeInfo();
            }

            Console.WriteLine("Suche nach '1984':");
            suchergebnisse = Suche("1984");
            foreach (Medium medium in suchergebnisse)
            {
                medium.ZeigeInfo();
            }

      
}}}