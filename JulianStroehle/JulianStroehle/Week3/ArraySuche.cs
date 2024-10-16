using System;
namespace JulianStroehle.Week3
{
    public class ArraySuche
    {
        public static void Start()
        {
            Console.WriteLine("Zahlen (z), Buchstaben (b) oder Wörter (w) erraten?");
            string? choose = Console.ReadLine();
            switch (choose)
            {
                case "z": GuessNumbers(); break;
                case "b": GuessLetters(); break;
                case "w": GuessWords(); break;
            }
        }
        public static void GuessNumbers()
        {
            int[] numbers = new int[10];
            Random rdm = new Random();
            bool foundNumber;
            int count;
            for (int i = 0; i < 10; i++)
            {
                count = 0;
                int temp = rdm.Next(0, 21);
                for (int j = 0; j < 10; j++)
                {
                    if (numbers[j] != temp)
                    {
                        count++;
                    }
                }
                if (count < 10)
                {
                    i--;
                }
                else
                {
                    numbers[i] = temp;
                }
            }
            count = 0;
            Console.WriteLine("Versuche 10 zufällige Zahlen zwischen 1 und 20 mit 15 Versuchen zu erraten.");
            for (int i = 0; i < 15; i++)
            {
                foundNumber = false;
                Console.WriteLine($"{i + 1}. Versuch");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess < 20 && guess > 0)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (guess == numbers[j])
                        {
                            count++;
                            Console.WriteLine($"{count}. Zahl gefunden");
                            numbers[j] = -1;
                            foundNumber = true;
                        }
                    }
                    if (foundNumber == false)
                    {
                        Console.WriteLine("Nummer nicht vorhanden oder schon gefunden.");
                    }
                    if (count == 10)
                    {
                        Console.WriteLine("Alle Zahlen gefunden.");
                        break;
                    }
                    else if (i == 14 && count < 10)
                    {
                        Console.WriteLine($"Leider nicht alle Zahlen gefunden. Gefundene Zahlen: {count}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalide Eingabe, nochmal versuchen.");
                    i--;
                }
            }
        }
        static void GuessLetters()
        {
            char[] letters = { 'a', 'n', 'l', 'd', 'm', 'f', 'v', 'h', 'i', 'w' };
            bool foundLetter;
            int count = 0;
            Console.WriteLine("Versuche 10 Kleinbuchstaben mit 15 Versuchen zu erraten.");
            for (int i = 0; i < 15; i++)
            {
                foundLetter = false;
                Console.WriteLine($"{i + 1}. Versuch");
                string? guess = Console.ReadLine();
                char guessChar = ' ';
                if (guess != null)
                {
                    guessChar = Convert.ToChar(guess);
                }
                if (guessChar != ' ')
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (guessChar == letters[j])
                        {
                            count++;
                            Console.WriteLine($"{count}. Buchstabe gefunden");
                            letters[j] = ' ';
                            foundLetter = true;
                        }
                    }
                    if (foundLetter == false)
                    {
                        Console.WriteLine("Buchstabe nicht vorhanden oder schon gefunden.");
                    }
                    if (count == 10)
                    {
                        Console.WriteLine("Alle Buchstaben gefunden.");
                        break;
                    }
                    else if (i == 14 && count < 10)
                    {
                        Console.WriteLine($"Leider nicht alle Buchstaben gefunden. Anzahl der gefundenen Buchstaben: {count}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalide Eingabe, nochmal versuchen.");
                    i--;
                }
            }
        }
        static void GuessWords()
        {
            int count = 0;
            bool foundWord;
            string[] words = { "Cringe", "Akkurat", "Sheesh", "Digga", "Mittwoch", "Gommemode", "Sick", "Huansohn", "Angenehm", "Schabernack"};
            Console.WriteLine(words.Length);
            Console.WriteLine("Versuche 10 Wörter mit 15 Versuchen zu erraten.");
            for (int i = 0; i < 15; i++)
            {
                foundWord = false;
                Console.WriteLine($"{i + 1}. Versuch");
                string? guess = Console.ReadLine();
                if (guess != " ")
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (guess == words[j])
                        {
                            count++;
                            Console.WriteLine($"{count}. Wort gefunden");
                            words[j] = " ";
                            foundWord = true;
                        }
                    }
                    if (foundWord == false)
                    {
                        Console.WriteLine("Wort nicht vorhanden oder schon gefunden.");
                    }
                    if (count == 10)
                    {
                        Console.WriteLine("Alle Wörter gefunden.");
                        break;
                    }
                    else if (i == 14 && count < 10)
                    {
                        Console.WriteLine($"Leider nicht alle Wörter gefunden. Anzahl der gefundenen Wörter: {count}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalide Eingabe, nochmal versuchen.");
                    i--;
                }
            }
        }
    }
}