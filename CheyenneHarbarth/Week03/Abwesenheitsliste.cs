using System;
using System.Formats.Asn1;
using CheyenneHarbarth.Week02;

namespace CheyenneHarbarth.Week03
{

    class Abwesenheitsliste
    {

        public static void PrintList()
        {
            string[][] Liste = new string[1][];                 //1 Zeile festgelegt, 

            while (true)
            {
                //Console.WriteLine("Möchtest du Personen hinzufügen? Tippe 1");
                Console.WriteLine("Möchtest du Anwesenheiten eintragen? Tippe 2");
                Console.WriteLine("Möchtest du die Liste sehen? Tippe 3");
                
                /* if (Answer == 1)
                {
                    
                    Liste[0] = new string[] { AddPeople() };
                } */
                int Answer = ConsoleInput.ReadInt();
                if (Answer < 3 && Answer > 1)
                {
                    Liste[0] = new string[] { AddPeople(), AddPresence() };
                }

                else if (Answer > 2 && Answer < 4)
                {
                    for (int i = 0; i < Liste.Length; i++)
                    {
                        for (int j = 0; j < Liste[i].Length; j++)
                        {
                            Console.Write($"{Liste[i][j] + " |", -10}");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else {
                    Console.WriteLine("Das war keine gültige Zahl! Bitte versuche es erneut!");
                }
            }

        }

        public static string AddPeople()
        {
            Console.WriteLine("Wie heißt der/die Teilnehmer/in?");
            string name = Console.ReadLine();
            return name;
        }

        public static string AddPresence()
        {
            Console.WriteLine($"Ist die Person anwesend oder abwesend?");
            string presence = Console.ReadLine();
            return presence;
        }


    }
}