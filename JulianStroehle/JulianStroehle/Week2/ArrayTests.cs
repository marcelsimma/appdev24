using System;
namespace JulianStroehle.Week2
{
    public class ArrayTestA
    {
        public static void Start()
        {
            // Arr1();
            // Arr2();
            // Arr3();
            Arr4();
        }
        public static void Arr1()
        {
            Console.WriteLine("Wort eingeben: ");
            string? word = Console.ReadLine();
            char[] chars= word.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(chars);
        }
        public static void Arr2()
        {
            Console.WriteLine("Wort eingeben: ");
            string? word = Console.ReadLine();
            char[] chars= word.ToCharArray();
            Random rndm= new();
            rndm.Shuffle(chars);
            Console.WriteLine(chars);
        }
        public static void Arr3()
        {
            Console.WriteLine("Wort eingeben: ");
            string? word = Console.ReadLine();
            for (int i = word.Length-1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
        }
        public static void Arr4()
        {
            Console.WriteLine("Wort eingeben: ");
            string? Text = Console.ReadLine();
            Random rdm = new Random();
            while (Text.Length > 0)
            {
                int rnd = rdm.Next(0, Text.Length -1);
                string beforeNumber = Text.Substring(0, rnd);
                string randomLetter = Text.Substring(rnd, 1);
                string afterNumber = Text.Substring(rnd + 1, Text.Length - rnd - 1);

                Console.Write(randomLetter);
                Text = beforeNumber + afterNumber;
            }
        }

    }
}