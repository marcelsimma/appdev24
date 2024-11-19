using System;
using System.Data;

namespace MagdalenaMueller.Week06
{
    public class Gehege
    {

        public static List<string> zooList = new List<string>();   

        public static List<int> amoundOfAnimals = new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

        public static void AddGehege()
        {
            Console.WriteLine("Gehege Name:");
            string? nameGehege = Console.ReadLine();

            zooList.Add(nameGehege);          
        }

        public static void RemoveGehege()
        {
            Console.WriteLine("Gehege Name:");
            string? removeGehegeName = Console.ReadLine();

            for(int i = 0; i < zooList.Count; i++)
            {
                if(zooList[i] == removeGehegeName)
                {
                    zooList.Remove(zooList[i]);
                    amoundOfAnimals.Remove(amoundOfAnimals[i]);
                }
            }
        }

        public static void AddAnimal()
        {
            int indexGehege = 0;

            Console.WriteLine("Zu welchem Gehege sollen Tiere Hinzugefügt werden: ");
            string? gehege = Console.ReadLine();

            for(int i = 0; i < zooList.Count; i++)
            {
                if(zooList[i] == gehege)
                {
                    indexGehege = i;
                    break;
                }
                if(zooList[i] != gehege && i == zooList.Count -1)
                {
                    Console.WriteLine("Gehege wurde nicht gefunden");
                    return;
                }
            }

            Console.WriteLine("Wie viele Tiere sollen hinzugefügt werden");
            int addAnimalsAmount = Convert.ToInt32(Console.ReadLine());

            amoundOfAnimals[indexGehege] += addAnimalsAmount;
        }

        public static void RemoveAnimal()
        {
            int indexGehege = 0;

            Console.WriteLine("Bei welchem Gehege sollen Tiere entfernt werden: ");
            string? gehege = Console.ReadLine();

            for(int i = 0; i < zooList.Count; i++)
            {
                if(zooList[i] == gehege)
                {
                    indexGehege = i;
                    break;
                }
                if(zooList[i] != gehege && i == zooList.Count -1)
                {
                    Console.WriteLine("Gehege wurde nicht gefunden");
                    return;
                }
            }
            Console.WriteLine("Wie viele Tiere sollen hinzugefügt werden");
            int removeAnimalsAmount = Convert.ToInt32(Console.ReadLine());

            amoundOfAnimals[indexGehege] -= removeAnimalsAmount;
        }

        public static void WriteZoo(string zooName, string zooGründung)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"|---Zoo: {zooName} Gründung: {zooGründung}");
            Console.ResetColor();

            for(int i = 0; i < zooList.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"|   |--- Gehege: {zooList[i]}");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"|   |          |--- Tiere: {amoundOfAnimals[i]}");
                Console.ResetColor();
            }
        }
    }
}