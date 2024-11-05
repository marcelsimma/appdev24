/*

Erstelle ein Programm, dass alle Zahlen im Bereich -10 bis +10 ausgibt, die durch 2 teilbar sind.

Tipp: Modulo-Operator

*/

using System;

namespace JonasWehinger.Week01 {

    public class Rewind {

        public static void PrintRewind() {

            for (int i = -10; i <= 10; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }            

        }
    }
}