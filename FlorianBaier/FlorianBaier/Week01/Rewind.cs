
class Rewind
{
    public static void PrintRewind(string[] args)
    {
        for (int i = -10; i <= 10; i ++){
        
        if (i % 2 == 0){
            Console.WriteLine(i);
        }
        }

    }
}