using System;

namespace OliverBedogg.Week02
{
    public class Operatoren
    {
        public static void Start()
        {
            Arithmetic();
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
            number += 1;
            Console.WriteLine("number:  " + number);
            number = number - 1;
            number -= 1;
            Console.WriteLine("number:  " + number);
            Console.WriteLine("--------------------");

            // Multiplikationsoperator * und Divisionsoperator * 
            // können gleich wie + - verwendet werden

            // TODO Ergänze Beispiele

            // Inkrementoperator
            Console.WriteLine("+ Inkrementoperator");
            number++;
            Console.WriteLine("number:  " + number);
            Console.WriteLine("number:  " + number++);
            Console.WriteLine("number:  " + ++number);
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
    }
}