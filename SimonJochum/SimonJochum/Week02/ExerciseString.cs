using System;
using System.Runtime.CompilerServices;

namespace SimonJochum.Week02
{
    public class ExerciseString
    {


        public static void Start()
        {
            //StringReverse();
            StringRandomiser();
        }
        public static void StringReverse()
        {
            // String der umgedreht wird
            string input;
            // umgedrehter String
            string inputReverse = ""; 

            //String wird eingelesen
            Console.WriteLine("Hallo gib hier bitte dein Wort zum umdrehen ein"); 
            input = Console.ReadLine();

            // Hier wird die Länge des Eingabestrings gespeichert
            int length = input.Length;

            // hier wird stringReverse definiert
            char[] stringReverse = new char[length]; 

            // Schleife zum Umdrehen des Strings
            for (int i = 0; i < length; i++)
            {
                stringReverse[i] = input[length - 1 - i]; // umgedrehte Zuweisung
            }

            // Umwandlung des char-Arrays in einen String
            inputReverse = new string(stringReverse);

            Console.WriteLine(inputReverse);
        }

        public static void StringRandomiser()
        {
            Console.WriteLine("Gib hier dein Wort ein welches zu zufällig mischen möchtest");
            string input = Console.ReadLine();

            Random random = new Random(); //wird benötigt um Zufallszahlen zu erstellen

            char[] charInput = input.ToCharArray();

            for (int i = 0; i < input.Length - 2; i++)
            {
                int rand = random.Next(i+1, input.Length-1);

                char temp = charInput[i]; //wird benötigt damit der zu verschiebende Index nicht überschrieben wird
                charInput[i] = charInput[rand]; //der verschiebende Index wird mit dem Zufallsindex überschieben
                charInput[rand] = temp; //der Zufallsindex wir mit dem zu verschiebenden Index überschrieben 

                
            }
            string result = new string(charInput);
            Console.WriteLine(result);
           
        }
    }
}
