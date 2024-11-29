using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MagdalenaMueller.Week07
{
    public class AbwesenheitsListe
    {
        static Dictionary<string, List<DateTime>> persons = new Dictionary<string, List<DateTime>>();

        public static void Start()
        {
            bool again = true;
            while(again ==true)
            {
                Console.WriteLine("(1) Person Hinzufügen\n(2) Fehlstunden Hinzufügen\n(3) Liste anzeigen\n(4) Beenden");
                string? task = Console.ReadLine();

                switch(task)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        AddMissedDay();
                        break;
                    case "3":
                        WriteList();
                        break;
                    case "4":
                        again = false;
                        break;
                    default:
                    break;
                }
                
            }
        } 
        public static void AddPerson()
        {
            Console.WriteLine("Name der Person:");
            persons.Add(Console.ReadLine(), new List<DateTime>());
        }
        public static void AddMissedDay()
        {
            Console.WriteLine("Name Person: ");
            string? namePerson = Console.ReadLine();
            
            try
            {
                persons[namePerson].Add(DateTime.Now);
            }
            catch
            {
                Console.WriteLine("Name nicht gültig!\n");
            }
        }
        public static void WriteList()
        {
            Console.WriteLine("Name:" + new string(' ', 10) + "|" + " Fehldatum:");
            Console.WriteLine(new string('-', 15) + "+" + new string('-', 15));
            foreach(var person in persons) 
            {
                Console.Write($"{person.Key, -15}| ");
                foreach (DateTime timeEntry in person.Value) 
                {
                    Console.Write($"{timeEntry.ToShortDateString()}, ");
                }
                Console.WriteLine();
            }
        }
    }
}