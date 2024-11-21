using System;
using System.IO;
namespace JulianStroehle.Week6.Zoo
{
    internal class ZooMain
    {
        internal static string path = "C:/Users/JUSR/Documents/Coding Campus/StreamTest/";
        internal static List<Gehege> Gehege = new List<Gehege>();
        public static void Start()
        {
            bool failure = false;
            do
            {
                try
                {
                    Console.WriteLine("Name des Zoos?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Baujahr?");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wieviele gehege hat der Zoo?");
                    int count = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Name des Geheges?");
                        string name2 = Console.ReadLine();
                        Console.WriteLine("Wieviele Tiere hat dieses Gehege?");
                        int count2 = Convert.ToInt32(Console.ReadLine());
                        List<Tier> tiere = new List<Tier>();
                        for (int j = 0; j < count2; j++)
                        {
                            Console.WriteLine("Tierart?");
                            string art = Console.ReadLine();
                            Console.WriteLine("Name?");
                            string nameOfAnimal = Console.ReadLine();
                            Tier tier = new Tier(nameOfAnimal, art);
                            tiere.Add(tier);
                        }
                        Gehege gehege = new Gehege(name2, tiere);
                        Gehege.Add(gehege);
                    }
                    Zoo zoo = new Zoo(name, year, Gehege);
                    Print(zoo);
                }
                catch (FormatException)
                {
                    failure = true;
                }
            }
            while (failure == true);
        }
        static void Print(Zoo zoo)
        {
            using (StreamWriter sw = new StreamWriter(path + "Zoo.txt"))
            {
                sw.WriteLine("├──\t" + zoo.ToString());
                foreach (Gehege gehege in Gehege)
                {
                    int count = 0;
                    sw.WriteLine("│\t├──\t" + gehege.ToString());
                    foreach (Tier tier in gehege.Tiere)
                    {
                        sw.WriteLine("│\t\t├──\t" + tier.ToString());
                        sw.WriteLine("│\t\t\t├──\t" + tier.Futterbedarf + " Gramm Futter pro Tag");
                        count++;
                    }
                    if (count == 0)
                    {
                        sw.WriteLine("│\t\t├──\t(leer)");
                    }
                }
            }
        }
    }
}