using System;
using System.Security.Cryptography.X509Certificates;

namespace CheyenneHarbarth.Week02
{

    class RandomNumberArray
    {

        public static void PrintArray()
        {
            Random random = new Random();
            int[] Numbers = new int[100];                       //Array mit Name Number, Größe ist 100
                                                                //was fehlt? das Number eine random Zahl beinhaltet

            for (int i = 0; i < Numbers.Length; i++)            //for-Schleife lässt alle 100 Stellen des Arrays durchlaufen
            {
                Numbers[i] = random.Next(-50, 50);              //generiert random Zahlen im Bereich -50 bis +50
                Console.WriteLine(Numbers[i]);                  //gibt das komplette Array aus
            }
            int sum = 0;
            foreach (int num in Numbers)
            {

                sum += Math.Abs(num);                           //Math.Abs errechnet die Beträge des von dir vorgegebenen Zahlenbereichs
            }

            //Alternative
            /*

            Numbers.Max();
            //Alternative
            /*int max = -50;
            for (int i = 0, i < array.Length; i++){
                if(Numbers[i] > max){
                max = Numbers[i];
                } 
            }*/
            Numbers.Min();
            //Alternative
            /*int min = -50;
            for (int i = 0, i < array.Length; i++){
                if(Numbers[i] < min){
                min = Numbers[i];
                } 
            }*/
            int average = Convert.ToInt32(Numbers.Average());
            double BetragAverage = (double)sum / (double)Numbers.Length;
            Console.WriteLine($"Höchster Wert: {Numbers.Max()}");
            Console.WriteLine($"Niedrigster Wert: {Numbers.Min()}");
            Console.WriteLine($"Durchschnittswert: {average}");
            Console.WriteLine($"Durchschnittswert der Beträge: {BetragAverage:F2}");

        }
    }
}