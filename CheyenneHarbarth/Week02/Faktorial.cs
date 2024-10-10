using System;

namespace CheyenneHarbarth.Week02
{

    class Faktorial
    {

        public static void Fakultät(int a, int e)
        {
            long Ergebnis = 1;
            for (int i = a; i <= e; i++)
            {
                Ergebnis *= i;
                Console.WriteLine($"{i,2}! = {Ergebnis,20}");               //mit dem $-Zeichen kannst du Variablen etc. direkt in den String (die "") einfügen ohne dass du die "" dauernd unterbrechen musst
            }                                                               //du musst die Variablen nur in {} setzen, das ganze nennt sich "Interpolation"
        }
    }
}