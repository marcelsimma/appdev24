using System;

class HigherLower
{
    public static void game()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101); 
        int guessedNumber = -1; 

        Console.WriteLine("Willkommen beim super coolen Zahlen Ratespiel!");
        Console.WriteLine("Errate die Zahl zwischen 0 und 100!");

        while (guessedNumber != randomNumber)
        {
            Console.Write("Gib die Zahl nun ein: ");
            string input = Console.ReadLine();

            
            if (int.TryParse(input, out guessedNumber))
            {
                
                if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("Die Zahl ist zu niedrig!");
                }
                else if (guessedNumber > randomNumber)
                {
                    Console.WriteLine("Die Zahl ist zu hoch!");
                }
                else
                {
                    Console.WriteLine("Du hast gewonnen!!!");
                }
            }
            else
            {
                Console.WriteLine("Bitte gib eine gültige Zahl ein.");
            }
        }
    }
}
