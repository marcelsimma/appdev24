using System;
using System.IO;

namespace JonasWehinger.Week05
{
    public class Teilnehmerliste2
    {

        public static void Streams2()
        {

            using (StreamWriter str = new StreamWriter(@"C:\Digital Campus\Streams\output.txt")) {
                str.WriteLine("Teilnehmer");
                str.WriteLine("1. Gyula");
                str.WriteLine("2. Markus");
                str.WriteLine("3. Eva-Maria");
                str.WriteLine("4. Bernhard");
                str.WriteLine("5. Elena");
                str.WriteLine("6. Berkay");
                str.WriteLine("7. Michael");
                str.WriteLine("8. Stefan");
                str.WriteLine("9. Stefan");
                str.WriteLine("10. Luca");
                str.WriteLine("11. Julius");
                str.WriteLine("12. Sandro");

                str.WriteLine();
                
                str.WriteLine("12 Teilnehmer");

            }
                 
            
        }
    }
}