using System;
using JulianStroehle.Week5.models;
namespace JulianStroehle.Week5
{
    public class FotoapparatOOP
    {
        public static void Start()
        {
            int speicher = 0;
            do
            {
                Fotoapparat fotoapparat = new Fotoapparat("D-Lux 8", "Leica", 17);
                Speicherkarte speicherkarte = new Speicherkarte(speicher, 20);
                if (speicherkarte.CheckMemory())
                {
                    fotoapparat.takePhoto();
                    Console.WriteLine(fotoapparat + "\n");
                    Console.WriteLine(speicherkarte + "\n");
                }
                else
                {
                    Console.WriteLine("Speicherkarte " + fotoapparat.Model + " voll." + "\n");
                }
                Fotoapparat fotoapparat2 = new Fotoapparat("D-Lux 7", "Leica", 17);
                Speicherkarte speicherkarte2 = new Speicherkarte(speicher, 15);
                if (speicherkarte2.CheckMemory())
                {
                    fotoapparat2.takePhoto();
                    Console.WriteLine(fotoapparat2 + "\n");
                    Console.WriteLine(speicherkarte2 + "\n");
                }
                else
                {
                    Console.WriteLine("Speicherkarte " + fotoapparat2.Model + " voll." + "\n");
                }
                Fotoapparat fotoapparat3 = new Fotoapparat("D-Lux 6", "Leica", 12.7);
                Speicherkarte speicherkarte3 = new Speicherkarte(speicher, 10);
                if (speicherkarte3.CheckMemory())
                {
                    fotoapparat3.takePhoto();
                    Console.WriteLine(fotoapparat3 + "\n");
                    Console.WriteLine(speicherkarte3 + "\n");
                }
                else
                {
                    Console.WriteLine("Speicherkarte " + fotoapparat3.Model + " voll." + "\n");
                }
                speicher++;
            }
            while (Console.ReadLine() == "a");
        }
    }
}