using System;
using System.Diagnostics.Metrics;
using System.IO;                //IO = Input Output

namespace CheyenneHarbarth.Week05.Streams
{

    public class Streams
    {

        public static void Aufgabe1()
        {
            using (StreamReader str = new StreamReader("/Users/BAU28365/Documents/input.txt"))                         //mit using () gibst du dem Programm eine Resource mit der dann nur aktiv er in diesem Moment arbeitet, niemand sonst kann diese Datei dann momentan verwenden
            {
                string FirstRow = str.ReadLine();
                int counter = 1;

                while (counter < 12)
                {
                    string Names = str.ReadLine();
                    Console.WriteLine($"{counter,3}. {Names}");
                    counter++;
                }

            }
        }

        public static void Aufgabe2()
        {
            using (StreamReader str = new StreamReader("/Users/BAU28365/Documents/input.txt"))                         //mit using () gibst du dem Programm eine Resource mit der dann nur aktiv er in diesem Moment arbeitet, niemand sonst kann diese Datei dann momentan verwenden
            {
                string FirstRow = str.ReadLine();
                int counter = 1;

                for (int i = 0; i < 11; i++)
                {
                    string[] Names = new string[12];
                    Names[i] = str.ReadLine();

                    /*  using (StreamWriter stro = new StreamWriter("/Users/BAU28365/Documents/output.txt"))
                     {
                         stro.WriteLine($"{counter,3}. {Names[i]}");
                         stro.WriteLine($"{counter} Teilnehmer");
                     } */
                    Console.WriteLine($"{counter,3}. {Names[i]}");
                    counter++;
                }

            }
            Console.WriteLine("fertig");
        }
    }
}