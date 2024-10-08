using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text.Json.Serialization;


namespace ManuelHartmann
{

    public class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            float decimale = 0.0f;
            for (int i = 1; i <= 20; i++)
            {
                sum = i / 5;
                decimale = i / 5.0f;
                // Bei Integern gibt es keine Kommastellen -> Somit ist z.B.: 1/5=0 und bei der Diffision mit Kommastellen (float/double)
                // ist das Ergebnis von 1/5.0=0,2.
                Console.WriteLine($"{i} / 5 = {sum} ------------- {i} / 5.0 = {decimale}");
            }
        }
    }
}




