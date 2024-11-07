using System;

namespace JonasWehinger.Week03
{
    public class Abwesenheitsliste
    {

      public static void Liste(){

        const int anzahlTage = 3;
        string[] teilnehmer = { "Max Mustermann", "Nico Mustermann" };
        bool[,] abwesenheitsDaten = new bool[teilnehmer.Length, anzahlTage];

        
        abwesenheitsDaten[0, 1] = true; 
        abwesenheitsDaten[1, 0] = true; 

        
        Console.WriteLine("Abwesenheitsliste:");
        for (int i = 0; i < teilnehmer.Length; i++)
        {
            Console.Write($"{teilnehmer[i]}: ");
            for (int j = 0; j < anzahlTage; j++)
            {
                Console.Write(abwesenheitsDaten[i, j] ? "abwesend " : "anwesend ");
            }
            Console.WriteLine();
        }
    }
}
}  
    