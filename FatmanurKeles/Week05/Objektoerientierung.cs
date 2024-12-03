using System;
using System.Diagnostics.Metrics;
using System.IO.Pipes;

namespace FatmanurKeles.Week05
{
    public class Objektorientierung
    {
        public static void Start()
        {
            Person fatma = new Person("Fatma", "Keles", 19);
            Person furkan = new Person("Furkan", "Keles", 22);
            Person Ridvan = new Person("Ridvan", "Keles", 25);

            Console.WriteLine($"{fatma}\n{furkan}\n{Ridvan}\n");

            Auto BMW = new Auto("BMW", "schwarz", 350);
            Auto Audi = new Auto("Audi", "blau", 200);
            Auto Mazda = new Auto("Mazda", "weiss", 120);

            Console.WriteLine($"{BMW}\n{Audi}\n{Mazda}\n");

            Schule Gisingen = new Schule(23, "Frau Bachmann", "Englisch");
            Schule Tosters = new Schule(25, "Herr Müller", "Deutsch");
            Schule Tisis = new Schule(19, "Frau Schwarzmann", "Mathe");

            Console.WriteLine($"{Gisingen}\n{Tosters}\n{Tisis}\n");
        }
    }
}

