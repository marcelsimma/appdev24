class Malreihe
{
    private static void PrintMalreihe(string[] args)
    {
        for (int i = 0; i <= 10; i++){
            int result = i * 2;
            Console.WriteLine($"{i} * 2 = {result}");
        }
    }
}