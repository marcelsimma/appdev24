using System;
using System.Threading;

namespace OliverBedogg.Week11
{
    class ThreadExample
    {
        public static void Start()
        {
            // Erstelle und starte Threads
            Thread t1 = new Thread(() => CountToTen(1));
            Thread t2 = new Thread(() => CountToTen(2));
            t1.Start();
            t2.Start();

            // Während t1 und t2 zählen, fährt das Hauptprogramm fort
            Console.WriteLine("Das Hauptprogramm läuft weiter...");
            Thread.Sleep(2000); // sleep im Hauptprogramm (das Hauptprogramm ist ein eigener Thread)
            Console.WriteLine("Hauptprogramm-Ausgabe");

            // Hauptprogramm wartet, bis Threads fertig sind (optional)
            t1.Join();
            t2.Join();
            Console.WriteLine("Alle Threads beendet.");
        }

        static void CountToTen(int threadNumber)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Thread {threadNumber}: " + i);
                Thread.Sleep(800);
            }
        }
    }
}