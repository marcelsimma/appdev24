using System;

namespace AlessioGaudio.Week02
{
    class Ausgeberr
    {
        public static void Start()
        {
           
            Console.WriteLine("Gib hier dein Satz ein :");
            string userInput = Console.ReadLine();

          
            int i = 0;
            int a = 0;
            int b = 0;
            int c = 0;

           
            char[] charArray = userInput.ToCharArray();

        
            foreach (char character in charArray)
            {
                if (char.IsLetter(character))
                {
                    i++;
                }
                else if (char.IsDigit(character))
                {
                    a++;
                }
                else if (char.IsWhiteSpace(character))
                {
                    b++;
                }
                else
                {
                    c++;
                }
            }
            Console.WriteLine("Buchstabenanzahl: " + i);
            Console.WriteLine("Zahlenanzahl: " + a);
            Console.WriteLine("Leerzeichen: " + b);
            Console.WriteLine("Spezialzeichen: " + c);
        }
    }
}