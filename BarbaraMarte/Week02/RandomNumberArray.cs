using System.ComponentModel.DataAnnotations;

namespace BarbaraMarte.Week02;

class RandomNumberArray
{
    public static void PrintRandomNumberArray()
    {

        Random random = new Random();
        int[] teilnehmer = new int[100]; // Computer made space for 400 byte
        //int[] zahlen = new int[] { 1, 2, 3 }; Diese Schreibweise wird verwendet wenn man die Werte schon weiß
        //int[] zahlen2 = [1, 2, 3]; kurtschreibweise

        int Min = -50;
        int Max = 50;

        for (int i = 0; i < teilnehmer.Length; i++)
        {
            teilnehmer[i] = random.Next(Min, Max);
            Console.WriteLine(teilnehmer[i]);
        }


        Console.WriteLine($"Bigest Number2: {findeMax(teilnehmer)}");
        Console.WriteLine($"Smalest Number: {teilnehmer.Min()}");   // Einfache Schreibweise
        Console.WriteLine($"Smallest Number2:{findeMin(teilnehmer)}");   // mit Formel dahinter
        Console.WriteLine($"Avarage: {teilnehmer.Average()}");
        Console.WriteLine($"Aberage1: {findeAverage(teilnehmer)}");
        Console.WriteLine($"Biggest Number; {teilnehmer.Max()}");
    }
    static int findeMax(int[] arr)
    {
        int max = arr[0]; // ich greife auf die erste stelle im Array zu

        for (int i = 1; i < arr.Length; i++)
        {
            int currentValue = arr[i];
            Console.WriteLine(currentValue);

            if (currentValue > max)
            {
                // neues maximum gefunden => setze neuen wert als maximum
                max = currentValue;
            }
            else
            {
                // altes maximum ist noch gültig => noop (no operation)
            }
        }
        return max;

    }
    static int findeMin(int[] arr)
    {
        int min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            int currentValue = arr[i];
            Console.WriteLine(currentValue);

            if (currentValue < min)
            {
                min = currentValue;
            }


        }
        return min;
    }
    static int findeAverage(int[] arr)
    {
        int average = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {

        }

        return average;
    }
}

/* Erster versuch:
 int Min = -50;
        int Max = 50;
        string output = "Smalest number: ";
        string output1 = "Bigest number";

        Random random = new Random();
        int[] teilnehmer = new int[100];

        for (int i = 0; i < teilnehmer.Length; i++)
        {
            teilnehmer[i] = random.Next(Min, Max);
            output += random.Next(Min);
            output1 += random.Next(Max);

            
        }
        Console.WriteLine($"Smalest Number: {output} ");
        Console.WriteLine($"Bigest Number: {output1} ");

        2 versuch
if (teilnehmer[i] < smallest)
            {
                smallest = teilnehmer[i];
            }
            if (teilnehmer[i] > largest)
            {
                largest = teilnehmer[i];
            }

*/

