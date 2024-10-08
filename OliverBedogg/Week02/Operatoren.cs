using System;

namespace OliverBedogg.Week02
{
    public class Operatoren
    {
        public static void Start()
        {
            Arithmetic();
            Comparison();
            Logical();
        }

        public static void Arithmetic()
        {
            // Arithmetische Operatoren für mathematische Berechnungen
            // https://learn.microsoft.com/de-at/dotnet/csharp/language-reference/operators/arithmetic-operators

            int number = 200;
            Console.WriteLine("+ start with number:  " + number + "\n");

            // Plus- und Minusoperatoren
            Console.WriteLine("+ Plus- und Minusoperatoren");
            number = number + 1;
            number += 1; // Assignment Operator
            Console.WriteLine("number:  " + number);
            number = number - 1;
            number -= 1; // Assignment Operator
            Console.WriteLine("number:  " + number);
            Console.WriteLine("--------------------");

            // Multiplikationsoperator * und Divisionsoperator * 
            // können gleich wie + - verwendet werden

            // TODO Ergänze Beispiele

            // Inkrementoperator
            Console.WriteLine("+ Inkrementoperator");
            number++; // 201
            Console.WriteLine("number:  " + number); // 201
            Console.WriteLine("number:  " + number++); // 201 in Ausgabe, number = 202
            Console.WriteLine("number:  " + ++number); // 203 in Ausgabe, number = 203
            Console.WriteLine("number:  " + number);
            Console.WriteLine("--------------------");

            // Dekrementoperator
            Console.WriteLine("+ Dekrementoperator");
            number--;
            Console.WriteLine("number:  " + number);
            Console.WriteLine("number:  " + number--);
            Console.WriteLine("number:  " + --number);
            Console.WriteLine("number:  " + number);
            Console.WriteLine("--------------------");

            // Restoperator / Modulo %
            Console.WriteLine("+ Restoperator");
            number %= 168;
            Console.WriteLine("number:  " + number);
            Console.WriteLine("--------------------");
        }

        public static void Comparison()
        {
            // Vergleichsoperatoren für den Vergleich von Operanden
            // liefern einen Boolean als Ergebnis
            // https://learn.microsoft.com/de-at/dotnet/csharp/language-reference/operators/comparison-operators
            Console.WriteLine("+ Vergleichsoperatoren");

            int number = 5;
            Console.WriteLine("i == 5: " + (number == 5)); // Gleichheitsoperator 
            Console.WriteLine("i != 5: " + (number != 5)); // Ungleichheitsoperator
            Console.WriteLine("i <  5: " + (number < 5));
            Console.WriteLine("i <= 5: " + (number <= 5));
            Console.WriteLine("i >  5: " + (number > 5));
            Console.WriteLine("i >= 5: " + (number >= 5));
            Console.WriteLine("--------------------");
        }

        public static void Logical()
        {
            // (Boolesche) Logische Operatoren für den logischen Vorgang mit bool-Operanden
            // liefern einen Boolean als Ergebnis
            Console.WriteLine("+ Logische Operatoren");

            int number = 5;
            bool isBigger = number > 3;
            Console.WriteLine("isBigger: " + isBigger);

            // Negation
            Console.WriteLine("!isBigger: " + !isBigger);
            Console.WriteLine("--------------------");
            // isBigger = !isBigger;

            // Logisches UND
            bool bothIsTrue = isBigger && 15 > 10;
            Console.WriteLine("bothIsTrue: " + bothIsTrue);
            Console.WriteLine("bothIsTrue: " + (isBigger && 15 > 20));
            Console.WriteLine("bothIsTrue: " + (isBigger && true));
            Console.WriteLine("bothIsTrue: " + (true && true));
            Console.WriteLine("bothIsTrue: " + (false && true));
            Console.WriteLine("--------------------");

            // Logisches ODER
            bool oneIsTrue = isBigger || 15 > 10; // rechter Operand wird nicht mehr ausgeführt, wenn erster true ist
            Console.WriteLine("oneIsTrue: " + oneIsTrue);
            Console.WriteLine("oneIsTrue: " + (isBigger || 15 > 20));
            Console.WriteLine("oneIsTrue: " + (isBigger || false));
            Console.WriteLine("oneIsTrue: " + (true || true));
            Console.WriteLine("oneIsTrue: " + (true || false));
            Console.WriteLine("oneIsTrue: " + (false || false));
            Console.WriteLine("--------------------");
        }
    }
}