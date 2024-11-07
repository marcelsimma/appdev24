using System;

namespace AlessioGaudio.Schule
{
    class Binary
    {
        public static int BinaerZuDezimal(string binaerZahl)
        {
            int dezimalZahl = 0;
            int basis = 1;

            for (int i = binaerZahl.Length - 1; i >= 0; i--)
            {
                if (binaerZahl[i] == '1')
                {
                    dezimalZahl += basis;
                }

                basis *= 2;
            }

            return dezimalZahl;
        }

      public  static void Start()
        {
            string binaerZahl1 = "1101";
            string binaerZahl2 = "10101";

            Console.WriteLine("Die Dezimalzahl von " + binaerZahl1 + " ist: " + BinaerZuDezimal(binaerZahl1));
            Console.WriteLine("Die Dezimalzahl von " + binaerZahl2 + " ist: " + BinaerZuDezimal(binaerZahl2));
        }
    }
}
