using System.Threading.Tasks.Dataflow;

namespace BarbaraMarte.Week01
{
    class Christbaum
    {
        public static void PrintChristbaum (char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('*', (size-1)/2));
            }
        }
    }
}