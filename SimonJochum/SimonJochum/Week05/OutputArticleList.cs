using System;
using System.IO;

namespace SimonJochum.Week05
{
    public class OutputArticleList
{
    public static void Start()
    {
        // Öffnet die Eingabedatei zum Lesen
        using (StreamReader reader = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/inputarticlelist.txt"))
        {
            // Öffnet die Ausgabedatei zum Schreiben
            using (StreamWriter writer = new StreamWriter(@"C:\Users\SIJO\Documents\Testaufgaben\outputarticlelist.txt"))
            {
                // Liest die erste Zeile (Header) der Eingabedatei, aber tut nichts damit
                string header = reader.ReadLine();

                // Initialisiert Variablen, die für die Berechnungen benötigt werden
                int counter = 0;  // Zählt die Anzahl der Artikel
                double fullPriceOfList = 0.0;  // Hält den Gesamtpreis aller Artikel
                int fullAmountOfList = 0;  // Hält die Gesamtanzahl aller Artikel
                double averagePrice = 0.0;  // Berechnet den Durchschnittspreis der Artikel
                double mostExpensiveArticlePrice = 0.0;  // Der Preis des teuersten Artikels
                string mostExpensiveArticleName = "";  // Name des teuersten Artikels
                double cheapestArticlePrice = 0.0;  // Der Preis des günstigsten Artikels
                string cheapestArticleName = "";  // Name des günstigsten Artikels
                string inputRaw;  // Temporäre Variable zum Speichern einer Zeile aus der Eingabedatei

                // Liest die Datei Zeile für Zeile
                while ((inputRaw = reader.ReadLine()) != null)
                {
                    // Zerlegt die Zeile anhand des Tabulators (\t), um die Artikelinformationen zu extrahieren
                    string[] parts = inputRaw.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    // Überprüft, ob die Zeile genau 3 Teile enthält: Name, Menge und Preis
                    if (parts.Length == 3)
                    {
                        // Versucht, die Menge und den Preis in die richtigen Datentypen umzuwandeln
                        if (int.TryParse(parts[1], out int amount) && double.TryParse(parts[2], out double price))
                        {
                            // Zählt den Artikel
                            counter++;
                            
                            // Addiert den Preis des Artikels zur Gesamtsumme
                            averagePrice += price;
                            
                            // Addiert den Gesamtpreis (Preis * Menge) zur Gesamtsumme
                            fullPriceOfList += price * amount;
                            
                            // Addiert die Menge des Artikels zur Gesamtmenge
                            fullAmountOfList += amount;

                            // Wenn der Artikel der teuerste ist, aktualisiere den teuersten Artikel
                            if (mostExpensiveArticlePrice < price)
                            {
                                mostExpensiveArticlePrice = price;
                                mostExpensiveArticleName = parts[0];  // Name des teuersten Artikels
                            }

                            // Wenn der Artikel der günstigste ist, aktualisiere den günstigsten Artikel
                            if (cheapestArticlePrice == 0.0)
                            {
                                cheapestArticlePrice = price;
                                cheapestArticleName = parts[0];  // Name des günstigsten Artikels
                            }
                            else if (cheapestArticlePrice > price)
                            {
                                cheapestArticlePrice = price;
                                cheapestArticleName = parts[0];  // Name des günstigsten Artikels
                            }
                        }
                        else
                        {
                            // Wenn die Menge oder der Preis nicht korrekt sind, schreibe eine Fehlermeldung
                            writer.WriteLine("Fehlerhafte Daten: " + inputRaw);
                        }
                    }
                    else
                    {
                        // Wenn die Zeile nicht 3 Teile enthält (Name, Menge, Preis), schreibe eine Fehlermeldung
                        writer.WriteLine("Fehlerhafte Daten: " + inputRaw);
                    }
                }

                // Schreibt das Ergebnis in die Ausgabedatei:
                // 1. Der günstigste Artikel
                writer.WriteLine("Der günstigste Artikel auf der Liste ist: {0,28}{1,12:N2}€", cheapestArticleName, cheapestArticlePrice / 100);
                
                // 2. Der teuerste Artikel
                writer.WriteLine("Der teuerste Artikel auf der Liste ist: {0,30}{1,12:N2}€", mostExpensiveArticleName, mostExpensiveArticlePrice / 100);
                
                // 3. Der Durchschnittspreis aller Artikel
                writer.WriteLine("Der Durchschnittspreis aller {0} Artikel liegt bei: {1,31:N2}€", counter, averagePrice / 100 / 30);
                
                // 4. Der Gesamtpreis aller Artikel
                writer.WriteLine("Der Gesamtpreis aller Artikel ({0}) beträgt: {1,37:N2}€", fullAmountOfList, fullPriceOfList / 100);
            }
        }
    }
}

}