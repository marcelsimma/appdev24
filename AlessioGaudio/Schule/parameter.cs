using System;

namespace AlessioGaudio.Schule
{
    class Parameter
    {
        public static int Multipliziere(int zahl1, int zahl2 = 1)
        {
            return zahl1 * zahl2;
        }

       public static void Start(string[] args)
        {
            
            int ergebnis1 = Multipliziere(5, 3);
            int ergebnis2 = Multipliziere(5);   

            Console.WriteLine("Ergebnis 1 (5 * 3): " + ergebnis1); 
            Console.WriteLine("Ergebnis 2 (5 * 1): " + ergebnis2); 
        }

        internal static void Multipliziere()
        {
            throw new NotImplementedException();
        }
    }
}
