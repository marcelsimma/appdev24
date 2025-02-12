using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/
class Player
{
    static void Main(string[] args)
    {
        int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7}; 
        int result = 0;
        int marker = 0;

        // game loop
        while (true)
        {
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                numbers[i] = mountainH;
            }

            for (int j = 0; j < 8; j++) 
            {
                if (numbers[j] > result) 
                {
                    result = numbers[j];
                    marker = j;
                }
            }
            result = 0;
            Console.WriteLine(marker); // The index of the mountain to fire on.
        }
    }
}