using System;

namespace CheyenneHarbarth.Week05.Streams
{
    class Artikelliste
    {
        public static void Start()
        {
            using (StreamReader str = new StreamReader("/Users/BAU28365/Documents/Artikelliste.txt"))
            {
                string Liste = str.ReadToEnd();
                Console.WriteLine(Liste);


            }
        }
    }
}