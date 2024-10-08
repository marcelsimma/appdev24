namespace FatmanurKeles.Week01
{
    public class PrintTree
    {
        public static void PrintTree1(int size)
        {
            char star = '*';
            char zero = 'O';
            /*for (int i = 0; i <= size -1; i++)
            {
                if (i < size)
                {
                    Console.WriteLine(new string(' ', (size - 1) / 2 - i) + new string(star, 1 + (i * 2)) + new string(' ', (size - 1) / 2 - i));
                }
            }*/
            
            for (int i = 0; i<= size; i++)
            {
                Console.WriteLine(new string('.', size));
            }
        }
    }
}
