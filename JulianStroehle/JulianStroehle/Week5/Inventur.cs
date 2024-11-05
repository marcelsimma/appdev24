using System;
using System.IO;
namespace JulianStroehle.Week5
{
    public class Inventur
    {
        public static void Start()
        {
            List<string> names = new List<string>();
            List<int> amounts = new List<int>();
            List<float> prices = new List<float>();
            using (StreamReader str = new StreamReader("C:/Users/JUSR/Documents/Coding Campus/StreamTest/Inventarliste.txt"))
            {
                while (!str.EndOfStream)
                {
                    string[] lines = str.ReadLine().Split("\t");
                    names.Add(lines[0]);
                    amounts.Add(Convert.ToInt32(lines[1]));
                    prices.Add(Convert.ToSingle(lines[2]));
                }
            }
            float temp = 0;
            string tempName = "";
            float temp2 = int.MaxValue;
            string tempName2 = "";
            for (int i = 0; i < prices.Count; i++)
            {
                if (temp < prices[i])
                {
                    temp = prices[i];
                    tempName = names[i];

                }
                if (temp2 > prices[i])
                {
                    temp2 = prices[i];
                    tempName2 = names[i];
                }
            }
            using (StreamWriter stw = new StreamWriter("C:/Users/JUSR/Documents/Coding Campus/StreamTest/Inventur.txt"))
            {
                stw.WriteLine(string.Format("{0,-35}","Teuerster Artikel:") + tempName + " " + temp + " EUR");
                stw.WriteLine(string.Format("{0,-35}", "Billigster Artikel:") + tempName2 + " " + temp2 + " EUR");
                stw.WriteLine(string.Format("{0,-35}", "Durchschnittspreis der Artikel:") + Math.Round(prices.Average(), 2) + " EUR");
                stw.WriteLine(string.Format("{0,-35}", "Gesamtwert Preise:") + prices.Sum() + " EUR");
                stw.WriteLine(string.Format("{0,-35}", "Gesamte Menge der Artikel:") + amounts.Sum() + " Stk.");
            }
        }
    }
}