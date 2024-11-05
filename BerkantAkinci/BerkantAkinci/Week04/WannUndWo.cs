using System;
using System.Data.Common;
using System.Globalization;

namespace BerkantAkinci.Week04
{

    class WannUndWo
    {

        public static void PrintWannUndWo()
        {
            DateTime moment = DateTime.Now; 
            System.Console.WriteLine(moment); // heutiger Tag und jetztige Zeit
            System.Console.WriteLine(moment.ToString("dd.MM.yyyy")); // nur das Datum
            System.Console.WriteLine(moment.TimeOfDay); // nur die Uhrzeit
            //System.Console.WriteLine(); // Datum und Uhrzeit mit Zeizone
            System.Console.WriteLine($"{moment.Second} | {moment.Millisecond}"); //Sekunde und Millisekunde

        }
    }
}