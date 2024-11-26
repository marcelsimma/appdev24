using System;
using System.Timers;
namespace JulianStroehle.Week5
{
    public class SnakeTest
    {
        private static System.Timers.Timer aTimer;
        private static char[,] field = new char[20, 20];
        private static string direction;
        private static int row = 9;
        private static int col = 9;
        public static void Start()
        {
            int count = 0;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] != 'S' && field[i, j] != 'O')
                    {
                        field[i, j] = '.';
                    }
                    if (field[i, j] == 'S')
                    {
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                field[9, 9] = 'S';
            }
            SetTimer();
            while (true)
            {
                Move();
                if (direction == "esc")
                {
                    aTimer.Stop();
                    aTimer.Dispose();
                    break;
                }
            }
        }

        private static void SetTimer()
        {
            aTimer = new System.Timers.Timer(200);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            try
            {
                switch (direction)
                {
                    case "up": field[row - 1, col] = 'S'; field[row, col] = '.'; row -= 1; break;
                    case "down": field[row + 1, col] = 'S'; field[row, col] = '.'; row += 1; break;
                    case "left": field[row, col - 1] = 'S'; field[row, col] = '.'; col -= 1; break;
                    case "right": field[row, col + 1] = 'S'; field[row, col] = '.'; col += 1; break;
                }
                Print();
            }
            catch (IndexOutOfRangeException)
            {
                switch (direction)
                {
                    case "up": direction = "down"; break;
                    case "down": direction = "up"; break;
                    case "left": direction = "right"; break;
                    case "right": direction = "left"; break;
                }
                Print();
            }
        }
        static void Move()
        {
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.UpArrow: direction = "up"; break;
                case ConsoleKey.DownArrow: direction = "down"; break;
                case ConsoleKey.LeftArrow: direction = "left"; break;
                case ConsoleKey.RightArrow: direction = "right"; break;
                case ConsoleKey.Escape: direction = "esc"; break;
                default: direction = direction; break;
            }
            // switch (Console.ReadLine())
            // {
            //     case "w": direction = "up"; break;
            //     case "s": direction = "down"; break;
            //     case "a": direction = "left"; break;
            //     case "d": direction = "right"; break;
            //     case "r": direction = "esc"; break;
            //     default: direction = direction; break;
            // }
            // return direction;
        }
        static void Print()
        {
            Console.Clear();
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}