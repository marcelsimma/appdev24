using System;
using System.IO;                //IO = Input Output

namespace CheyenneHarbarth.Week05.Streams
{

    public class Streams
    {

        public static void Start()
        {
            using (StreamReader str = new StreamReader("/Users/BAU28365/Documents/input.txt"))                         //mit using () gibst du dem Programm eine Resource mit der dann nur aktiv er in diesem Moment arbeitet, niemand sonst kann diese Datei dann momentan verwenden
            {
                string wholeFile = str.ReadToEnd();
                Console.WriteLine(wholeFile);
            }
        }
    }
}