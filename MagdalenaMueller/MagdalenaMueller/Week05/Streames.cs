using System;
using System.Diagnostics.Metrics;
using System.IO;

namespace MagdalenaMueller.Week05
{
    public class Streames
    {
        public static void WriteTeilnehmer()
        {
            int count = 1;

            using (StreamReader str = new StreamReader("M:/Documents/Campus/input.txt"))
            {
                while(str.EndOfStream == false)
                {
                    string? readteilnehmer = str.ReadLine();
                    if(readteilnehmer != "Teilnehmer")
                    {
                        Console.WriteLine($"{count}. {readteilnehmer}");
                        count++;
                    }
                }
            }
        }
        public static void  WriteTeilnehmer2()
        {
            int count = 1;
            int counter = 0;
            using (StreamReader strInput = new StreamReader("M:/Documents/Campus/input.txt"))
            {
                using(StreamWriter strOutput = new StreamWriter("M:/Documents/Campus/output.txt"))
                {
                    while(strInput.EndOfStream == false)
                    {
                        string? readteilnehmer = strInput.ReadLine();
                        if(readteilnehmer != "Teilnehmer")
                        {
                            strOutput.WriteLine($"{count}. {readteilnehmer}");
                            count++;
                            counter++;
                        }
                    }
                    strOutput.WriteLine($"{counter} Teilnehmer");
                }
            }
        }
        public static void CalcPow()
        {
            using (StreamReader strInput = new StreamReader("M:/Documents/Campus/input.txt"))
            {
                using(StreamWriter strOutput = new StreamWriter("M:/Documents/Campus/output.txt"))
                {
                    while(strInput.EndOfStream == false)
                    {
                        int readNumber = Convert.ToInt32(strInput.ReadLine());

                        strOutput.WriteLine($"{readNumber} ^ 2 = {Math.Pow(readNumber,2)}");
                    }
                }
            }
        }
        public static void Tabelle()
        {
             using (StreamReader strInput = new StreamReader("M:/Documents/Campus/input.txt"))
            {
                using(StreamWriter strOutput = new StreamWriter("M:/Documents/Campus/output.txt"))
                {
                    int logestName = 0;
                    int logestHight = 0;
                    int logestAge = 0;

                    string str;
                    while ((str = strInput.ReadLine()) != null)
                    {
                        string[] line = str.Split(' ');

                        for (int i = 0; i < line.Length; i += 3)
                        {
                            if (line[i].Length > logestName)
                            {
                                logestName = line[i].Length;
                            }
                        }
                        for (int i = 1; i < line.Length; i += 3)
                        {
                            if (line[i].Length > logestHight)
                            {
                                logestHight = line[i].Length;
                            }
                        }
                        for (int i = 2; i < line.Length; i += 3)
                        {
                            if (line[i].Length > logestAge)
                            {
                                logestAge = line[i].Length;
                            }
                        }
                    }

                    strInput.BaseStream.Seek(0, SeekOrigin.Begin); 

                    string seperate = "+" + new string('-', logestName + 1) + "+" + new string('-', logestHight + 1) + "+" + new string('-', logestAge + 1) + "+";
                   

                    while ((str = strInput.ReadLine()) != null)
                    {
                        string[] line = str.Split(' ');
                        int counter = 1;
                        

                        for(int i = 0; i < line.Length; i++)
                        {
                            if(counter == 1)
                            {
                                strOutput.Write("|" +line[i] + new string(' ',logestName - line[i].Length + 1) + "|");
                                counter++;
                            }
                            else if(counter == 2)
                            {
                                strOutput.Write(line[i] + new string(' ',logestHight - line[i].Length + 1) + "|");
                                counter++;
                            }
                            else if(counter == 3)
                            {
                                strOutput.WriteLine(line[i] + new string(' ',logestAge - line[i].Length + 1) + "|");
                                strOutput.WriteLine(seperate);
                                counter = 1;
                            }
                        }
                    }
                }
            }  
        }
        public static void Inventur()
        {
            using (StreamReader strInput = new StreamReader("M:/Documents/Campus/input.txt"))
            {
                using(StreamWriter strOutput = new StreamWriter("M:/Documents/Campus/output.txt"))
                {
                    double highesprice = 0;
                    string highespriceProduct = " ";
                    double lowestprice = 9999999999999999999;
                    string lowestpriceProduct = " ";
                    double average = 0;
                    double priceOfAll = 0;
                    int valueOfAll = 0;
                    
                    string str;
                    while((str = strInput.ReadLine()) != null)
                    {
                        string[] line = str.Split(' ');

                        for(int i = 2; i < line.Length; i+=3)
                        {
                            if(highesprice < Convert.ToDouble(line[i]))
                            {
                                highesprice = Convert.ToDouble(line[i]);
                                highespriceProduct = line[i-2];
                            }
                            if(lowestprice > Convert.ToDouble(line[i]))
                            {
                                lowestprice = Convert.ToDouble(line[i]);
                                lowestpriceProduct = line[i-2];
                            }
                            priceOfAll += Convert.ToDouble(line[i]) * Convert.ToDouble(line[i-1]); 
                        }
                        for(int i = 1; i < line.Length; i += 3)
                        {
                            valueOfAll += Convert.ToInt32(line[i]);
                        }
                    }
                    average = priceOfAll / valueOfAll;
                    average = Math.Round(average,2);
                    priceOfAll = Math.Round(priceOfAll, 2);

                    strOutput.WriteLine($"Teuerstes Produkt: {highespriceProduct} {highesprice}€");
                    strOutput.WriteLine($"Günstigstes Produkt: {lowestpriceProduct} {lowestprice}€");
                    strOutput.WriteLine($"Durchschnitt: {average}€");
                    strOutput.WriteLine($"Preis von allen Produkten: {priceOfAll}€");
                    strOutput.WriteLine($"Anzahl von allen Produkte: {valueOfAll}");
                }
            }
        }
    }
}