using System;
using System.IO;
using System.Text.RegularExpressions;

namespace FlorianBaier.Week05
{

    public static class Inventur
    {

        public static void Start()
        {
            ReadAndPrintFile();
        }
        public static void ReadAndPrintFile()
        {
            string inputFilePath = "/Users/flori/Desktop/DigitalCampus/inputarticlelist.txt";
            string outputFilePath = "/Users/flori/Desktop/DigitalCampus/outputarticlelist.txt";

            var articleData = ReadAndParseFile(inputFilePath);

            var mostExpensiveArticle = FindMostExpensiveArticle(articleData);
            var cheapestArticle = FindCheapestArticle(articleData);
            decimal averagePrice = CalculateAveragePrice(articleData);
            decimal totalValue = ClaculateTotalValue(articleData);
            int totalQuantity = ClaculateTotalQuantity(articleData);

            WriteResultsToFile(outputFilePath, mostExpensiveArticle, cheapestArticle, averagePrice, totalValue, totalQuantity);

            Console.WriteLine("Inventurbericht wurde erfolgreich erstellt!");
        }

        public static List<string[]> ReadAndParseFile(string filePath)
        {
            var articleList = new List<string[]>();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('\t');
                    if (parts.Length == 3)
                    {
                        articleList.Add(parts);
                    }
                }
            }

            return articleList;
        }

        public static string FindMostExpensiveArticle(List<string[]> articleData)
        {
            string mostExpensiveArticle = "";
            decimal mostExpensivePrice = 0;

            foreach (var article in articleData)
            {
                var name = article[0].Trim();
                var price = decimal.Parse(article[2].Trim());

                if (price > mostExpensivePrice)
                {
                    mostExpensivePrice = price;
                    mostExpensiveArticle = name;
                }
            }

            return mostExpensiveArticle;
        }

        public static string FindCheapestArticle(List<string[]> articleData)
        {
            string cheapestArticle = "";
            decimal cheapestprice = decimal.MaxValue;

            foreach (var article in articleData)
            {
                var name = article[0].Trim();
                var price = decimal.Parse(article[2].Trim());

                if (price < cheapestprice)
                {
                    cheapestprice = price;
                    cheapestArticle = name;
                }
            }

            return cheapestArticle;
        }

        public static decimal CalculateAveragePrice(List<string[]> articleData)
        {
            decimal totalPrice = 0;
            int totalValuePrice = articleData.Count;

            if (totalValuePrice == 0)
            {
                return 0;
            }

            foreach (var article in articleData)
            {
                totalPrice += decimal.Parse(article[2].Trim());
            }

            return totalPrice / totalValuePrice;
        }

        public static decimal ClaculateTotalValue(List<string[]> articleData)
        {
            decimal totalValue = 0;

            foreach (var article in articleData)
            {
                var value = int.Parse(article[1].Trim());
                var price = decimal.Parse(article[2].Trim());
                totalValue += value * price;
            }

            return totalValue;
        }

        public static int ClaculateTotalQuantity(List<string[]> articleData)
        {
            int totalQuantity = 0;

            foreach (var article in articleData)
            {
                totalQuantity += int.Parse(article[1].Trim());
            }

            return totalQuantity;
        }

        public static void WriteResultsToFile(string filePath, string mostExpensiveArticle, string cheapestArticle, decimal averagePrice, decimal totalValue, int totalQuantity)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Teuerster Artikel, Name");
                writer.WriteLine(mostExpensiveArticle);

                writer.WriteLine("Billigster Artikel, Name");
                writer.WriteLine(cheapestArticle);

                writer.WriteLine("Durchschnittspreis");
                writer.WriteLine($"{averagePrice:F2}");

                writer.WriteLine("Gesamtwert der Artikel");
                writer.WriteLine($"{totalValue:F2}");

                writer.WriteLine("Gesamtmenge der Artikel");
                writer.WriteLine(totalQuantity);
            }
        }
    }
}//Programm funktioniert jz, alle Aufgaben sind in einzelne Methoden ausgelagert