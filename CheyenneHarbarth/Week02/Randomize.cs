using System;

namespace CheyenneHarbarth.Week02 {

    class Randomize {

        public static void start(string input) {

            Random random = new Random();                       //Dies ist das Objekt, dass unser Random-generator darstellt, die Random-Klasse ist von C# bereits vorgegeben

            char[] charInput = input.ToCharArray();             //Bedeutung von [], damit können wir die Anzahl der chars festlegen, wenn eine Zahl drin steht dann werden nur so viele chars verwendet, wir lassen hier die Zahl der chars durch die Länge des Worts definieren

            for (int i = 0; i < input.Length-2; i++) {
                int rand = random.Next(i+1, input.Length-1);    //random.Next erzeugt eine zufällige Zahl in dem von uns vorgegebenen Wertebereich

                char tmp = charInput[i];                        //wir sagen ihm, nimm H(1.Stelle)
                charInput[i] = charInput[rand];                 //H mit a ersetzen , hier wird eine Variable mit einer anderen getauscht --> Problem ist aber die andere Variable ist nun gelöscht, denn sie wurde nirgends abgespeichert
                charInput[rand] = tmp;                          //alten Speicherort von a mit H aus tmp ersetzen, hier wird die Variable wieder zurückgetauscht

            }

            string result = new string(charInput);

            Console.WriteLine(result);
        }
    }
}