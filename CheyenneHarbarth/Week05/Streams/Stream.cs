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

                    using (StreamWriter stro = new StreamWriter("/Users/BAU28365/Documents/output.txt"))
                    {
                        stro.WriteLine($"{counter,3}. {Names[i]}");
                        stro.WriteLine($"{counter} Teilnehmer");
                    }
                    Console.WriteLine($"{counter,3}. {Names[i]}");
                    counter++;
                }
            }
            Console.WriteLine("fertig");
        }

        public static void Aufgabe3()           //Quadrieren
        {
            using (StreamReader str = new StreamReader("/Users/BAU28365/Documents/numbers.txt"))
            {
                int a = Convert.ToInt32(str.ReadLine());
                int b = Convert.ToInt32(str.ReadLine());
                int c = Convert.ToInt32(str.ReadLine());
                int d = Convert.ToInt32(str.ReadLine());
                int e = Convert.ToInt32(str.ReadLine());



                using (StreamWriter stro = new StreamWriter("/Users/BAU28365/Documents/results.txt"))
                {
                    int f = a * a;
                    int g = b * b;
                    int h = c * c;
                    int i = d * d;
                    int j = e * e;

                    stro.WriteLine(f + " = " + a + " * " + a);
                    stro.WriteLine($"{g} = {b} * {b}");
                    stro.WriteLine($"{h} = {c} * {c}");
                    stro.WriteLine(i + " = " + d + " * " + d);
                    stro.WriteLine(j + " = " + e + " * " + e);
                }
            }
            Console.WriteLine("fertig");
        }
        public static void Aufgabe4()
        {
            int i = 2;
            using (StreamReader str = new StreamReader("/Users/BAU28365/Documents/Liste.txt"))
            {
                Console.WriteLine("Teilnehmer  |  Größe   | Alter  ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine(str.Read());
            }
        }
    }
}