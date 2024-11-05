
using System.Security.Cryptography;
using System.Linq;

namespace ManuelHartmann.Week02
{

    public class RandomNumberArray
    {
        static void Start(string[] args)
        {
            ArrayGenerator();
        }

        public static void ArrayGenerator()
        {
            // Erstellt ein 'int-Array' mit 100 Elementen.
            int[] ints = new int[100];
            for (int i = 0; i < 100 - 1; i++)
            {
                // Fuegt dem Array an der Stelle [i] eine zufaellige Zahl zwischen -50 und 50 hinzu.
                ints[i] = RandomGenerator();
            }
            Console.WriteLine($"Highest value in the array is: {ints.Max()}");
            Console.WriteLine($"Lowest value in the array is: {ints.Min()}");
            // (double), dass eine Zahl mit Kommastellen herauskommen kann.
            Console.WriteLine($"Average value in the array is: {(double)ints.Average()}");

            // Beträge der Zahlen summieren
            int sum = 0;
            foreach (int numbers in ints)
            {
                sum += Math.Abs(numbers); // Math.Abs() berechnet den Betrag einer Zahl
            }
            // Durchschnitt der Summe berechnen.
            double average = (double)sum / (double)ints.Length;
            Console.WriteLine($"Average value of the amounts in the array is: {average}");

            // // Den Durchschnittswert der Beträge (absoluten Werte) ermitteln
            // int sum = 0;

            // for (int i = 0; i < array.Length; i++)
            // {
            //     if (array[i] > 0)                // Alle positiven Zahlen aus dem 'array' entnehmen.
            //     {
            //         sum += array[i];     	    // Alle positiv entnommenen Zahlen addieren.
            //     }
            //     else                             // Pruefen, ob die Zahl negativ ist.
            //     {
            //         sum += (array[i] * (-1));    // Wenn die Zahl negativ ist (Zahl*-1) -> Zahl ist nun positiv und auch wieder addieren.
            //     }
            // }
            
            // double averageAbsValue = sum / array.Length;

            Bubblesorter(ints);
        }

        public static int RandomGenerator()
        {
            Random random = new Random();
            int randomNumber = random.Next(-50, 51);
            return randomNumber;
        }

        public static double RoundCommercial(double sum)
        {
            Console.WriteLine(sum);
            sum = sum * 100;
            sum = (int)sum; // Es werden die Kommastellen weggeschnitten und im Anschluss wieder als 'double' abespeichert.
            if (sum % 10 > 4)
            {
                sum++;  // Wenn der Restwert der Diffision groesser ist als 4, dann runde auf!
            }
            sum = sum / 100;    // wieder zwei Kommastellen kuerzen.
            Console.WriteLine(sum);
            return sum;
        }
        // Sorts the array either ASCENDING or DESCENDING.
        public static void Bubblesorter(int[] array)
        {
            Console.WriteLine("Would you like to sort the Array Ascending or Descending? \nTyp 1. for Ascending and 2. for Descending.");
            string respond = Console.ReadLine();
            if(int.TryParse(respond, out int number))
            {
                if(number == 1)
                {
                    // Sort the array ASCENDING.
                    Console.Clear();
                    // 'OrderBy' sorts ascending by default.
                    array = array.OrderBy(y => y).ToArray();
                    foreach (int i in array)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    // Sort the array DESCENDING.
                    Console.Clear();
                    array = array.OrderByDescending(x => x).ToArray();
                    foreach (int i in array)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}




