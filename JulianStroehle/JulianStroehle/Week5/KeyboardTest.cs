using System;
using System.Windows.Input;
namespace JulianStroehle.Week5
{
    public class KeyboardTest
    {
        public static void Start()
        {
            int apples = 0;
            int applesCount = 10;
            // Console.WriteLine("Wieviel Äpfel möchtest du sammeln?");
            // int applesCount = Convert.ToInt32(Console.ReadLine());
            char[,] chars = new char[10, 20];
            Random rdm = new Random();
            do
            {
                int count = 0;
                int count2 = 0;
                for (int i = 0; i < chars.GetLength(0); i++)
                {
                    for (int j = 0; j < chars.GetLength(1); j++)
                    {
                        if (chars[i, j] == 'X')
                        {
                            count++;
                        }
                        if (chars[i, j] != 'X' && chars[i, j] != 'O')
                        {
                            chars[i, j] = '.';
                        }
                        if (chars[i, j] == 'O')
                        {
                            count2++;
                        }
                    }
                    Console.WriteLine();
                }
                if (count == 0)
                {
                    chars[4, 9] = 'X';
                }
                if (count2 == 0)
                {
                    int row = rdm.Next(0, 10);
                    int col = rdm.Next(0, 20);
                    chars[row, col] = 'O';
                }
                Print(chars, apples);
                ConsoleKeyInfo input = Console.ReadKey();
                Console.Clear();
                count = 0;
                for (int i = 0; i < chars.GetLength(0); i++)
                {
                    for (int j = 0; j < chars.GetLength(1); j++)
                    {
                        if (i - 1 >= 0 && chars[i, j] == 'X' && (input.Key == ConsoleKey.W) && count == 0)
                        {
                            if (chars[i - 1, j] == 'O')
                            {
                                int row = rdm.Next(0, 10);
                                int col = rdm.Next(0, 20);
                                chars[row, col] = 'O';
                                apples++;
                            }
                            chars[i, j] = '.';
                            chars[i - 1, j] = 'X';
                            count++;
                        }
                        if (count == 0 && j - 1 >= 0 && chars[i, j] == 'X' && (input.Key == ConsoleKey.A))
                        {
                            if (chars[i, j - 1] == 'O')
                            {
                                int row = rdm.Next(0, 10);
                                int col = rdm.Next(0, 20);
                                chars[row, col] = 'O';
                                apples++;
                            }
                            chars[i, j] = '.';
                            chars[i, j - 1] = 'X';
                            count++;
                        }
                        if (count == 0 && i + 1 < 10 && chars[i, j] == 'X' && (input.Key == ConsoleKey.S))
                        {
                            if (chars[i + 1, j] == 'O')
                            {
                                int row = rdm.Next(0, 10);
                                int col = rdm.Next(0, 20);
                                chars[row, col] = 'O';
                                apples++;
                            }
                            chars[i, j] = '.';
                            chars[i + 1, j] = 'X';
                            count++;
                        }
                        if (j + 1 < 20 && chars[i, j] == 'X' && (input.Key == ConsoleKey.D) && count == 0)
                        {
                            if (chars[i, j + 1] == 'O')
                            {
                                int row = rdm.Next(0, 10);
                                int col = rdm.Next(0, 20);
                                chars[row, col] = 'O';
                                apples++;
                            }
                            chars[i, j] = '.';
                            chars[i, j + 1] = 'X';
                            count++;
                        }
                    }
                }
            }
            while (apples < applesCount);
            Console.WriteLine("{0} Äpfel gesammelt, Gut gemacht.", apples);
        }
        static void Print(char[,] chars, int apples)
        {
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    Console.Write(chars[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Gesammelte Äpfe: {0}", apples);
        }
    }
}