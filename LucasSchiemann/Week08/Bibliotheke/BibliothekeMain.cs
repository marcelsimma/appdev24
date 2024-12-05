using System;

namespace LucasSchiemann.Week08.Bibliotheke;



class MainOfBibliotheke
{
    static void StartBibliotheke(string[] args)
    {
        Bibliothek bibliothek = new Bibliothek();

       
        Buch buch1 = new Buch("HarryPOter", "Hanz Peter", 2020, "289748", "Hardcover");
        Buch buch2 = new Buch("Transformers", "Anna lang", 2018, "987654321", "Softcover");
        eBook ebook1 = new eBook("Gergs Tagebuch", "Peter griffin", 2021, "456123789", "pdf");

       
        bibliothek.Hinzufügen(buch1);
        bibliothek.Hinzufügen(buch2);
        bibliothek.Hinzufügen(ebook1);

      
        bibliothek.ShowBibliotheke();



        
        Console.WriteLine("\nMedium mit ISBN 123456789 entfernen:");
        bibliothek.Entfernen("123456789");

        
        Console.WriteLine("\nAlle Medien nach dem Entfernen:");
        bibliothek.ShowBibliotheke();
    }
}
