
namespace ConsoleApp1.Week05
{
    public static class InventurList
    {
        //static string[][] inventurList =
        //    {
        //        new string[] {"" },
        //        new string[] {"Apfel", "20", "0,50" },
        //        new string[] { "Banane", "15", "0,30" },
        //        new string[] { "Karotten", "10", "1,30" },
        //        new string[] { "Kartoffeln", "30", "0,40" },
        //        new string[] { "Zwiebeln", "25", "0,80" },
        //        new string[] { "Tomaten", "18", "1,20" },
        //        new string[] { "Gurken", "12", "0,90" },
        //        new string[] { "Brokkoli", "9", "1,50" },
        //        new string[] { "Salat", "5", "1,70" },
        //        new string[] { "Paprika", "22", "1,10" },
        //        new string[] { "Kirschen", "10", "2,00" },
        //        new string[] { "Äpfel (BIO)", "7", "1,00" },
        //        new string[] { "Birnen", "20", "0,75" },
        //        new string[] { "Erdbeeren", "5", "2,50" },
        //        new string[] { "Heidelbeeren", "8", "3,00" },
        //        new string[] { "Pfirsiche", "12", "1,30" },
        //        new string[] { "Wassermelone", "6", "4,80" },
        //        new string[] { "Mango", "4", "2,80" },
        //        new string[] { "Melone", "10", "3,00" },
        //        new string[] { "Kiwi", "15", "1,50" },
        //        new string[] { "Papaya", "6", "2,20" },
        //        new string[] { "Granatapfel", "8", "2,70" },
        //        new string[] { "Avocado", "14", "2,10" },
        //        new string[] { "Limetten", "20", "0,40" },
        //        new string[] { "Kiwis (BIO)", "12", "1,90" },
        //        new string[] { "Mandarinen", "18", "0,80" },
        //        new string[] { "Knoblauch", "10", "0,15" },
        //        new string[] { "Manderinen", "1", "0,50" },
        //        new string[] { "Avocado", "14", "2,10" }
        //    };
        static string[][] inventurList =
        {
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""},
            new string[] {"", "", ""}
        };

        public static void Start()
        {
            //Console.WriteLine("Give me your fileName!");
            //string respond = Console.ReadLine();
            string respond = "inputInventur";
            ReadFile(respond);
        }
        public static void ReadFile(string respond)
        {
            using (StreamReader str = new StreamReader($"C:/Users/harmanu/Downloads/DigitalCampus/{respond}.txt"))
            {
                string wholeFile = str.ReadToEnd(); // List das komplette File in einen String ein.
                string[] strings = wholeFile.Split('\n');   // Splitte das File in Absaetze auf.

                // Es muesste fuer jede Zeile die Anzahl Spalten definiert werden.
                //string[][] inventurList = new string[strings.Length][];

                //for (int i = 0; i < inventurList.Length; i++)
                //{
                //    inventurList[i] = new string[3];
                //}

                int count = 0;
                foreach (string s in strings)
                {
                    inventurList[count] = s.Split(' ');
                    count++;
                }

                for (int i = 0; i < inventurList.Length; i++)   // Ueberpruefung.
                {
                    for (int j = 0; j < inventurList[i].Length; j++)
                    {
                        Console.WriteLine(inventurList[i][j]);
                    }
                }
            }
            WriteFile();
        }
        public static void WriteFile()
        {
            using (StreamWriter str = new StreamWriter("C:/Users/harmanu/Downloads/DigitalCampus/outputInventur.txt"))
            {
                float value = 0.0f;
                int item = 0;
                for (int i = 1; i < inventurList.Length; i++)   // Welches ist der teuerste Artikel.
                {
                    if (float.TryParse(inventurList[i][2], out float check))
                    {
                        if (check > value)
                        {
                            value = check;  // Welcher Artikel ist der teuerste.
                            item = i;       // Speichern, auf welchem ArrayPlatz sich der Artikel befindet.
                        }
                    }
                }
                str.WriteLine($"The most expensive article is: {inventurList[item][0]}, costs: {value}€.");

                value = 50.0f;
                item = 0;
                for (int i = 1; i < inventurList.Length; i++)   // Welches ist der guenstigste Artikel.
                {
                    if (float.TryParse(inventurList[i][2], out float check))
                    {
                        if (check < value)
                        {
                            value = check;  // Welcher Artikel ist der teuerste.
                            item = i;       // Speichern, auf welchem ArrayPlatz sich der Artikel befindet.
                        }
                    }
                }
                str.WriteLine($"The cheapest article is: {inventurList[item][0]}, costs: {value}€.");

                float sum = 0.0f;
                for (int i = 1; i < inventurList.Length; i++)   // Durchschnittlicher Preis
                {
                    if (float.TryParse(inventurList[i][2], out float check))
                    {
                        sum += check;   // Alle Positionen zusammenrechnen.
                    }
                }
                float average = sum / inventurList.Length;  // Mittelwert aus allen Positionen berechnen.
                average = (float)Math.Round(average, 2);    // Auf zwei Kommastellen runden.
                str.WriteLine($"The average article price is: {average}€.");

                sum = 0.0f;
                for (int i = 1; i < inventurList.Length; i++)   // Gesamtkosten aller Artikel im Array.
                {
                    if (int.TryParse(inventurList[i][1], out int quant))
                    {
                        if (float.TryParse(inventurList[i][2], out float price))
                        {
                            sum += quant * price;
                        }
                    }
                }
                str.WriteLine($"Total value is: {sum}€.");
            }
        }
    }
}
