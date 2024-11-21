using System;
namespace JulianStroehle.Week7
{
    internal class Hangman
    {
        static int Mistakes = 9;
        internal static void WrongInput()
        {
            Mistakes++;
            Console.Clear();
            if (Mistakes > 3)
            {
                Console.WriteLine("   _____________________");
            }
            if (Mistakes > 4)
            {
                Console.WriteLine("   |   /               |\n   |  /                |\n   | /                 |\n   |/                 _|_");
            }
            else if (Mistakes > 2)
            {
                Console.WriteLine("   |   /\n   |  /\n   | /\n   |/");
            }
            if (Mistakes > 9)
            {
                Console.WriteLine("   |                 (°-°)");
            }
            else if (Mistakes > 5)
            {
                Console.WriteLine("   |                 (^-^)");
            }
            if (Mistakes > 9)
            {
                Console.WriteLine("   |                ~~~|~~~\n   |                   |\n   |                   |\n   |                  / \\\n   |                 /   \\\n   |           /\\  /\\  /\\  /\\  /\\  \n   |          /  \\/  \\/  \\/  \\/  \\");
            }
            else if (Mistakes > 8)
            {
                Console.WriteLine("   |                ~~~|~~~\n   |                   |\n   |                   |\n   |                  / \\\n   |                 /   \\\n   |\n   |");
            }
            else if (Mistakes > 7)
            {
                Console.WriteLine("   |                ~~~|~~~\n   |                   |\n   |\n   |\n   |\n   |\n   |");
            }
            else if (Mistakes > 6)
            {
                Console.WriteLine("   |                   |\n   |                   |\n   |\n   |\n   |\n   |\n   |");
            }
            else if (Mistakes > 1)
            {
                Console.WriteLine("   |\n   |\n   |\n   |\n   |\n   |");
            }
            if (Mistakes > 9)
            {
                Console.WriteLine(" __|__       (    (°)      (°)    )\n/_____\\~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            else if (Mistakes > 0)
            {
                Console.WriteLine(" __|__ \n/_____\\~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }
    }
}