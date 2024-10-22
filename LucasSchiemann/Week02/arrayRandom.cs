using System;

namespace LucasSchiemann.Week02;


public static class RandomNumber  
{
    static void Rechner()
    {
        
        Random rand = new Random();
        int[] array = new int[100];
        //LucasSchiemann.Week02.TypenTest.TryParsingInt()        
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-50, 51); 
        }
        
        int maxValue = array.Max();
        
        int minValue = array.Min();
        
      
        double meanValue = array.Average();
        
        double meanAbsValue = array.Select(Math.Abs).Average();

  
        Console.WriteLine("Größter Wert: " + maxValue);
        Console.WriteLine("Kleinster Wert: " + minValue);
        Console.WriteLine("Durchschnittswert: " + meanValue);
        Console.WriteLine("Durchschnittswert der Beträge: " + meanAbsValue);
    }

}   