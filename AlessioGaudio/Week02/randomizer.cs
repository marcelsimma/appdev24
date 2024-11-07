using System;

namespace AlessioGaudio.Week02
{
    class randomizerr
    {
        public static void Start()
        {
            Console.WriteLine("Willkommen zum Zufallsshuffle Programm!");

            Console.Write("Bitte gib ein Wort ein: \t");
            string? input = Console.ReadLine();

            char[] characters = input.ToCharArray();

            Random rnd = new Random();
            for (int i = 0; i < characters.Length; i++)
            {
                int randomIndex = rnd.Next(0, characters.Length);

                char temp = characters[i];
                characters[i] = characters[randomIndex];
                characters[randomIndex] = temp;
            }

            string shuffledWord = new (characters);

            Console.WriteLine($"Das zufällig vertauschte Wort lautet: {shuffledWord}");
        }
    }
}


