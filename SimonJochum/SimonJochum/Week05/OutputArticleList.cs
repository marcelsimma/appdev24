using System;
using System.IO;

namespace SimonJochum.Week05
{
    public class OutputArticleList
    {
        public static void Start()
        {
            using (StreamReader reader = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/inputarticlelist.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\SIJO\Documents\Testaufgaben\outputarticlelist.txt"))
                {
                    string header = reader.ReadLine();
                    int counter = 0;
                    double fullPriceOfList = 0.0;
                    int fullAmountOfList = 0;
                    double averagePrice = 0.0;
                    double mostExpensiveArticlePrice = 0.0;
                    string mostExpensiveArticleName = "";
                    double cheapestArticlePrice = 0.0;
                    string cheapestArticleName = "";
                    string inputRaw;

                    while ((inputRaw = reader.ReadLine()) != null)
                    {
                        string[] parts = inputRaw.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length == 3)
                        {
                            if (int.TryParse(parts[1], out int amount) && double.TryParse(parts[2], out double price))
                            {
                                counter++;
                                averagePrice += price;
                                fullPriceOfList += price * amount;
                                fullAmountOfList += amount;
                                if (mostExpensiveArticlePrice < price)
                                {
                                    mostExpensiveArticlePrice = price;
                                    mostExpensiveArticleName = parts[0];
                                }
                                if (cheapestArticlePrice == 0.0)
                                {
                                    cheapestArticlePrice = price;
                                }
                                else if (cheapestArticlePrice > price)
                                {
                                    cheapestArticlePrice = price;
                                    cheapestArticleName = parts[0];
                                }
                            }
                            else
                            {
                                writer.WriteLine("Fehlerhafte Daten: " + inputRaw);
                            }
                        }
                        else
                        {
                            writer.WriteLine("Fehlerhafte Daten: " + inputRaw);
                        }
                    }
                    writer.WriteLine("Der günstigste Artikel auf der Liste ist: {0,28}{1,12:N2}€", cheapestArticleName, cheapestArticlePrice / 100);
                    writer.WriteLine("Der teuerste Artikel auf der Liste ist: {0,30}{1,12:N2}€", mostExpensiveArticleName, mostExpensiveArticlePrice / 100);
                    writer.WriteLine("Der Durchschnittspreis aller {0} Artikel liegt bei: {1,31:N2}€", counter, averagePrice / 100 / 30);
                    writer.WriteLine("Der Gesamtpreis aller Artikel ({0}) beträgt: {1,37:N2}€", fullAmountOfList, fullPriceOfList / 100);
                    /*writer.WriteLine("Der günstigste Artikel auf der Liste ist: " + cheapestArticleName + " " + cheapestArticlePrice/100 + "€");
                    writer.WriteLine("Der teuerste Artikel auf der Liste ist: " + mostExpensiveArticleName + " " + mostExpensiveArticlePrice/100 + "€");
                    writer.WriteLine("Der Durchschnittspreis aller " + counter + " Artikel liegt bei: " + Math.Round(averagePrice/100/counter, 2) + "€");
                    writer.WriteLine($"Der Gesamtpreis aller Artikel ({fullAmountOfList}) beträgt: {fullPriceOfList/100}€");*/
                }
            }
        }
    }
}