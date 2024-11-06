using System;

class ZahlenOrdner
{
    static void Ordner(string[] args)
    {
        int[] array = { 5, 3, 8, 4, 2 };
        
        Console.WriteLine("Original Array: " + string.Join(", ", array));
        
        
        
        Console.WriteLine("Aufsteigend sortiert: " + string.Join(", ", array));
    }
}