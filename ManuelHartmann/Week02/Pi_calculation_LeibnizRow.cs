
namespace ManuelHartmann.Week02
{

    public class Pi_calculation_LeibnizRow
    {
        static void Start(string[] args)
        {
            double pi = 0.0d;
            const int constante = 4;
            double factor = 1;
            double factorExtended = 3;
            for (long i = 0; i < 500000000; i++)
            {
                pi += (constante / factor) - (constante / factorExtended);
                factor += 4;
                factorExtended += 4;
            }
            Console.WriteLine(pi);
        }
    }
}




