using System;

namespace CheyenneHarbarth.Week02
{

    class Randomize
    {

        public static void start(string input)
        {

            Random random = new Random();                       //Dies ist das Objekt, dass unser Random-generator darstellt, die Random-Klasse ist von C# bereits vorgegeben

            char[] charInput = input.ToCharArray();             //input.ToCharArray wandelt den string "input" in ein Char-Array, Bedeutung von [], damit können wir die Anzahl der chars festlegen, wenn eine Zahl drin steht dann werden nur so viele chars verwendet, wir lassen hier die Zahl der chars durch die Länge des Worts definieren

            for (int i = 0; i < input.Length - 2; i++)
            {          //warum -2? 1 stelle muss sowieso  gestrichen werden weil die Länge 5 beträgt und die stellen nur bis 4 gehen, und die letzte Stelle muss sowieso nicht mehr getauscht werden
                int rand = random.Next(i + 1, input.Length - 1);    //random.Next erzeugt eine zufällige Zahl in dem von uns vorgegebenen Wertebereich

                char tmp = charInput[i];                        //wir sagen ihm, nimm H(1.Stelle)
                charInput[i] = charInput[rand];                 //H mit a ersetzen , hier wird eine Variable mit einer anderen getauscht --> Problem ist aber die andere Variable ist nun gelöscht, denn sie wurde nirgends abgespeichert
                charInput[rand] = tmp;                          //alten Speicherort von a mit H aus tmp ersetzen, hier wird die Variable wieder zurückgetauscht

            }

            string result = new string(charInput);

            Console.WriteLine(result);
        }
    }
}

/*Randomize ohne Array lösen:

public static void start(string input) {

    string currentText = input;

    Random random = new Random();

    while (currentText.Length > 0) {
        
        //generate random number
        int rand = random.Next(0, currentText.Length -1);

        //split the currentText into three parts
        string substringBefore = currentText.Substring(0, rand);
        string randomLetter = currentText.Substring(rand, 1);
        string substringAfter = currentText.Substring(rand, currentText.Length -rand -1);

        //print the random Letter to console
        Console.Write(randomLetter);

        //rebuild the currentText for the next loop without the randomLetter
        currentText = substringBefore + substringAfter;

    }
}*/