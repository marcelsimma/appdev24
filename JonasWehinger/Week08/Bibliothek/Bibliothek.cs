using System;
 
namespace JonasWehinger.Week08
{
class Bibliothek
{
    private List<Medium> medien = new List<Medium>();
 
    public void Hinzufügen(Medium medium)
    {
        medien.Add(medium);
        Console.WriteLine($"{medium.Titel} hinzugefügt.");
    }
    public void Entfernen(string isbn)
    {
        foreach (Medium medium in medien)
        {
            if (medium.ISBN == isbn)
            {
                medien.Remove(medium);
                Console.WriteLine($"{medium.Titel} entfernt.");
                return;
            }
        }
        Console.WriteLine("Nicht gefunden.");
    }
 
   
    public void Suche(string suchbegriff)
    {
        foreach (Medium medium in medien)
        {
            if (medium.Titel == suchbegriff || medium.Autor == suchbegriff)
            {
                medium.ZeigeDetails();
            }
        }
    }
}
}