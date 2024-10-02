using System;
//hier schreiben wir den Ordnernamen hin, wo unser File abgespeichert ist
namespace CheyenneHarbarth.Week01
{

    class Square
    {

        public static void PrintEmptySquare(char c, int size)
        {
            //Deklaration, wo wir im Rechteck beginnen
            for (int i = 0; i < size; i++)
            {
                //Jetzt schreiben wir die 1. Zeile
                if (i == 0)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(c);               //wir schreiben nur Console.Write weil WriteLine einen Zeilenumbruch verursachen würde
                    }
                }
                //Jetzt schreiben wir die letzte Zeile, ist nämlich fast gleich wie die 1.
                else if (i == 6)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(c);
                    }
                }
                //Jetzt schreiben wir die Zeilen dazwischen
                else
                {
                    Console.Write(c);           //schreibt das 1. Sternchen der Zeile

                    for (int j = 0; j < size - 2; j++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write(c);           //schreibt das letzte Sternchen der Zeile
                }
                Console.WriteLine();           //macht einen Zeilenumbruch nach 7 Zeichen
            }
        }
    }
}