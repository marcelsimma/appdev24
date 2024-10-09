using System;
using System.Text;
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
            var chars = Console.ReadLine();
            var output = new StringBuilder();
            var random = new Random();
            for (int i = 0; i < chars.Length; i++)
            {
                output.Append(chars[random.Next(chars.Length)]);
            }
            Console.WriteLine(output.ToString());
        }

    }
}