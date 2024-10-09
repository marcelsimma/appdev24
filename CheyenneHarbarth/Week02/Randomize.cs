using System;

namespace CheyenneHarbarth.Week02 {

    class Randomize {

        public static void start(string input) {

            Random random = new Random();                       //Dies ist das Objekt, dass unser Random-generator darstellt, die Random-Klasse ist von C# bereits vorgegeben

            char[] charInput = input.ToCharArray();             //Bedeutung von [], damit können wir die Anzahl der chars festlegen, wenn eine Zahl drin steht dann werden nur so viele chars verwendet, wir lassen hier die Zahl der chars durch die Länge des Worts definieren

            for (int i = 0; i < input.Length-2; i++) {
                int rand = random.Next(i+1, input.Length-1);    //random.Next erzeugt eine zufällige Zahl in dem von uns vorgegebenen Wertebereich

                Console.WriteLine(rand);
            }
        }
    }
}