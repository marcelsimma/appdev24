using System;
using System.Windows.Input;
namespace JulianStroehle.Week5
{
    public class KeyboardTest
    {
        public static void Start()
        {
            char[,] chars = new char[10, 20];
            do
            {
                int count = 0;
                for (int i = 0; i < chars.GetLength(0); i++)
                {
                    for (int j = 0; j < chars.GetLength(1); j++)
                    {
                        if (chars[i,j] == 'X')
                        {
                            count++;
                        }
                        else
                        {
                            chars[i,j] = '.';
                        }
                    }
                    Console.WriteLine();
                }
                if (count == 0)
                {
                    chars[4,9] = 'X';
                }
                count = 0;
                ConsoleKeyInfo input = Console.ReadKey();
                Console.Clear();
                for (int i = 0; i < chars.GetLength(0); i++)
                {
                    for (int j = 0; j < chars.GetLength(1); j++)
                    {
                        if (i - 1 >= 0 && chars[i,j] == 'X' && (input.Key == ConsoleKey.W) && count == 0)
                        {
                            chars[i,j] = '.';
                            chars[i-1,j] = 'X';
                            count++;
                        }
                        if (count == 0 && j - 1 >= 0 && chars[i,j] == 'X' && (input.Key == ConsoleKey.A))
                        {
                            chars[i,j] = '.';
                            chars[i,j-1] = 'X';
                            count++;
                        }
                        if (count == 0 && i + 1 < 10 && chars[i,j] == 'X' && (input.Key == ConsoleKey.S))
                        {
                            chars[i,j] = '.';
                            chars[i+1,j] = 'X';
                            count++;
                        }
                        if (j + 1 < 20 && chars[i,j] == 'X' && (input.Key == ConsoleKey.D) && count == 0)
                        {
                            chars[i,j] = '.';
                            chars[i,j+1] = 'X';
                            count++;
                        }
                    }
                }
                for (int i = 0; i < chars.GetLength(0); i++)
                {
                    for (int j = 0; j < chars.GetLength(1); j++)
                    {
                        Console.Write(chars[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            while (true);
        }
    }
}