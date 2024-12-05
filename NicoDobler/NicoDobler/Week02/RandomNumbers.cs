using System;
namespace NicoDobler.Week02;

class RandomNumbers
{
    public static void NumbersCalc()
    {
        // Array 
        int[] numbers = new int[100];
        Random random = new Random();

        // Array mit zufälligen Werten zwischen -50 und +50 befüllen
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-50, 51); // 51 ist exklusiv
        }

        // Größten und kleinsten Wert finden
        int max = numbers[0];
        int min = numbers[0];
        double sum = 0;

        foreach (int number in numbers)
        {
            if (number > max) max = number;
            if (number < min) min = number;
            sum += number;
        }

        // Durchschnitt berechnen
        double average = sum / numbers.Length;

        // Ergebnisse ausgeben
        Console.WriteLine($"Größter Wert: {max}");
        Console.WriteLine($"Kleinster Wert: {min}");
        Console.WriteLine($"Durchschnittswert: {average:F2}"); // F2 für zwei Nachkommastellen
    }
}