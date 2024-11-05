using System;
using System.IO;

namespace LucasSchiemann.Week05;

public static class Teilnehmerliste
{
    public static void Start()
    {
        using (StreamReader str = new StreamReader(@"C:\Users\Sluc\TestDocumente\input.txt"))
        {
            
            for(int i = 0;i < 12;i++)  
            {
                string lineToWrite = str.ReadLine();
                Console.WriteLine(lineToWrite);


            }

        }






    }
}