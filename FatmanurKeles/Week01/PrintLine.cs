
namespace FatmanurKeles.Week01
{
    public class PrintLine
    {

public static void PrintLine1(char c, int size)
        {
            for (int i = 0; i < size; i++)
            Console.WriteLine(new string('.', i) + c + new string('.' , size - i -1));


            for (int i = 0; i < size; i++)
            Console.WriteLine(new string('.' , size - i - 1 ) + c + new string('.', i));


            for (int i = 0; i <size; i++)
            
            Console.WriteLine(new string('.', i + size - 1) + c + new string('.', size - i - 1));
            

            for (int i = 0; i <size; i++)
            
            Console.WriteLine(new string('.', size - i - 1 + size -1) + c + new string('.', i ));
        }
    }
}