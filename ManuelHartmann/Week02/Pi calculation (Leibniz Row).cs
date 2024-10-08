using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text.Json.Serialization;


namespace ManuelHartmann
{

    public class Pi
    {
        static void Pi(string[] args)
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




