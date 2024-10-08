using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text.Json.Serialization;


namespace ManuelHartmann
{

    public class Counter
    {
        static void Counter(string[] args)
        {
            float count = 0f;
            for (int i = 0; i < 1000; i ++)
            {
                count += 0.1f;
                // Mit der Rechenoperation 'Math.Round' kann man einen 'float' auf eine bestimmte Nachkommastelle runden.
                float rounded = (float)Math.Round(count, 1); // Ergebnis enthält nur noch eine Kommastelle
                Console.WriteLine(rounded);
            }
        }
    }
}




