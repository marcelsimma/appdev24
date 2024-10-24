using System;

namespace BerkantAkinci.Week02
{

    class Generationen
    {
        public static void PrintGenerationen()
        {
             // Funktionsaufrufe und Ausgabe
            Console.WriteLine("Anna 10: " + getGenerationByAge(10));
            Console.WriteLine("Peter 20: " + getGenerationByAge(20));
            Console.WriteLine("Silvia 30: " + getGenerationByAge(30));
            Console.WriteLine("Ines 50: Generation " + getGenerationByAge2(50));
        }

        // Methode 1
        static string getGenerationByAge(int age)
        {
            string generation = "";
            int year = 2024 - age;

            Console.WriteLine("// Geburtsjahr: " + year);

            if (year >= 2011)
            {
                generation = "Alpha";
            }
            else if (year <= 2010 && year >= 1997)
            {
                generation = "Z";
            }
            else if (year <= 1996 && year >= 1981)
            {
                generation = "Y";
            } // ...

            return "Generation " + generation;
        }

        // short
        static string getGenerationByAge2(int age)
        {
            int year = 2024 - age;

            if (year >= 2011)
                return "Alpha";
            else if (year <= 2010 && year >= 1997)
                return "Z";
            else if (year <= 1996 && year >= 1981)
                return "Y";
            else if (year <= 1980 && year >= 1965)
                return "X";
            // ...
            else
                return "vor 1928";
        }
    }
}
            //Mein Versuch, vergleichen und verstehen wie mann vorangeht beim Programmieren
            /*System.Console.WriteLine(getGenerationbyAge(10));
            System.Console.WriteLine(getGenerationbyAge(20));
            System.Console.WriteLine(getGenerationbyAge(40));
            System.Console.WriteLine(getGenerationbyAge(60));
            System.Console.WriteLine(getGenerationbyAge(80));
        }

        public static string getGenerationbyAge()
        {
            int age = 0;
            int year = 0;
            int generation = 0;

            return "Generation" + generation;




        }
    }
}*/