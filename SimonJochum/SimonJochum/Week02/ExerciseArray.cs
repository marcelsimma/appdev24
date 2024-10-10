using System;

namespace SimonJochum.Week02
{
    public class ExerciseArray
    {
        public static void Start()
        {

            int[] randomNumberArray = new int[100]; // Array mit der größe 100 wird erstellt
            Random random = new Random();



            for (int i = 0; i < randomNumberArray.Length; i++)
            {
                int randomNumber = random.Next(-50, 50); // die Schleife füllt das Array mit zufälligen Zahlen zwischen -50 bis 50
                randomNumberArray[i] = randomNumber;
            }
            int max = randomNumberArray.Max(); // der höchste Zahlenwert wird aus dem Array gelesen
            int min = randomNumberArray.Min(); // der niedrigste Zahlenwert wird aus dem Array gelesen
            double average = randomNumberArray.Average(); // der Durchschnittliche Wert wird aus dem gesamten Array errechnet und ausgegeben


            for (int i = 0; i < randomNumberArray.Length; i++) //um den Betrag aus dem Array auszurechnen wird über das Array itteriert und alle negativen Zahlen mit *-1 gerechnet um sie positiv zu bekommen
            {
                if (randomNumberArray[i] < 0)
                {
                    randomNumberArray[i] *= -1; // Multipliziere negative Zahlen mit -1
                }
            }

            double average2 = randomNumberArray.Average();


            Console.WriteLine($"Die kleinste Zahl ist {min}, der Durchschnitt ist {average}, der Durchschnittliche Betrag ist {average2} und die höchste Zahl ist {max}");

        }
    }
}
