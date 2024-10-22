namespace BarbaraMarte.Week01
{
    class Julgran
    {

        public static void PrintJulgran(char c, int size)
        {
            int half = (size - 1) / 2;
            PrintTanne(half, size, c);
            PrintKugeln(size);
            PrintStamm(size, half);



        }
        public static void PrintTanne(int half, int size, char c) // Tanne
        {
            for (int i = 0; i < size; i++)
                if (i > 0 && i < (half - 1))
                {
                    Console.WriteLine(new string(' ', (size - 1) / 2) + c + new string(' ', (size - 1) / 2));
                    Console.WriteLine(new string(' ', half - i) + c + new string('*', i * 2 - 1) + c + new string(' ', half - i));
                }
        }
        public static void PrintKugeln(int size) // Kugeln
        {
            for (int j = 0; j < size; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write(' ');
                }
                else
                {
                    Console.Write('0');
                }
            }

        }
        public static void PrintStamm(int size, int half) // Stamm
        {


            Console.WriteLine();
            Console.Write(new string(' ', (size - (size / 4)) / 2) + new string('+', size / 4) + new string(' ', (size - (size / 4)) / 2));
            Console.WriteLine();
            Console.Write(new string(' ', (size - (size / 4)) / 2) + new string('+', size / 4) + new string(' ', (size - (size / 4)) / 2));


        }

    }
}