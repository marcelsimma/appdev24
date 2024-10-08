using System;

/*
Aufgabe: Fakultät
------------------
Erstelle eine Funktion, die von 1 bis 20 die Fakultät ausrechnet und ausgibt.
Erklärung Fakultät: https://de.wikipedia.org/wiki/Fakultät_(Mathematik)

Formel für die Faktorialrechnung ist: 10! = 1 * 2 * 3 * 4 * 5 * 6 * 7 * 8 * 9 * 10

Denke daran, wie groß diese Werte werden und wähle das geeignete Datentyp
*/

namespace OliverBedogg.Week02
{

    public class Factorial
    {
        public static void Start()
        {
            Solution1();
            Solution2();
        }

        public static void Solution1()
        {
            long result = 1;

            for (int i = 1; i <= 20; i++)
            {
                result *= i;
                Console.WriteLine($"{i}! = {result}");
            }
        }

        public static void Solution2()
        {
            long result;
            int operand;

            for (int i = 1; i <= 20; i++)
            {
                // setze Ergebnis und Operand zurück:
                result = 1;
                operand = 1;

                do
                {
                    result *= operand;
                    operand++;
                    // multipliziere so lange bis i erreicht ist
                } while (operand <= i);

                Console.WriteLine($"{i}! = {result}");
            }
        }
    }
}