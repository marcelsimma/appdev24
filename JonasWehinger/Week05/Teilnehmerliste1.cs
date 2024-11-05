using System;
using System.IO;

namespace JonasWehinger.Week05
{
 
    public  class Teilnehmerliste1()
    {
        public static void Streams()
        {

            using (StreamReader str = new StreamReader(@"C:\Digital Campus\Streams\Teilnehmer.txt"))
            {

                string wholeFile = str.ReadToEnd();
                Console.WriteLine(wholeFile);
            }
        }
    }
}