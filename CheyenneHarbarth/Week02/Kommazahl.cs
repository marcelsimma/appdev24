using System;

namespace CheyenneHarbarth.Week02
{

    class Kommazahl
    {

        public static void PrintKommazahl()
        {
            double number = 20.0/3.0;
            double ergebnis = Math.Round(number, 5);             //Math.Round kann Kommazahlen runden und in einer Variabel abspeichern

            Console.WriteLine(ergebnis);
        }
    }
}