
class Schleifen
{
    public static void PrintSchleifen(string[] args)
    {
    for (int i = -10; i <= 10; i++)
    {
        if (i % 2 == 0){
            Console.WriteLine(i);
        }
    }
    int j = -10;
    while (j < 10)
    {
        if (j % 2 == 0){
        Console.WriteLine(j);}
        j++;
    }
    int k = -10;
    do
    {
       
        if (k % 2 == 0)
        { Console.WriteLine(k);
        }
        k++;
    }
    while (k <= 10);
    }
}