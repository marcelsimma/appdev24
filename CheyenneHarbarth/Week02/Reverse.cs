using System;
using System.ComponentModel;

namespace CheyenneHarbarth.Week02
{

    class Reverse
    {

        public static void Reverseprogramm()
        {

            Console.WriteLine("Willkommen zum Reverseprogramm! Bitte geben Sie ein Wort ein");
            string original = Console.ReadLine();                    //Wort einlesen lassen
            string reversed = null;                                  //Umgedrehter String, 
            char[] stringhinein = new char[original.Length];         //hier wird der String in Einzelteile zerlegt und eingelesen
            char[] stringumdrehen = new Char[original.Length];       //hier wird das Feld stringhinein umgedreht eingelesen
            int counter = 0;

            //original in stringhinein unterteilen mit Substring (zerlegt den String mit (i,1) -> Bsp.: ab stelle i eine Stelle rausschneiden)
            for (int i = 0; i < original.Length; i++)
            {
                stringhinein[i] = Convert.ToChar(original.Substring(i, 1));
            }

            //umgedrehte Forschleife, counter fängt bei null an weil möchten ja in die 0 Stell von stringumdrehen die letzte von stringhinein einlesen
            for (int i = original.Length; i > 0; i--)
            {
                stringumdrehen[counter] = stringhinein[i - 1];
                counter++;
            }

            //stringumdrehen in reversed
            for (int y = 0; y < original.Length; y++)
            {
                reversed += stringumdrehen[y];
            }
            //Ausgabe
            Console.WriteLine(reversed);

            Console.ReadKey();
        }

    }
}