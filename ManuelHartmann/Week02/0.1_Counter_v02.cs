using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text.Json.Serialization;


namespace ManuelHartmann
{

    public class Counter
    {
        static void Counter(string[] args)
        {
            for (float i = 0.0f; i <= 100.0; i += 0.1f)
            {
                // Das "F1"-Format gibt an, dass der Wert als Fließkommazahl mit genau einer Nachkommastelle formatiert werden soll.
                string tryparseValue = i.ToString("F1");
                Console.WriteLine(tryparseValue);
            }
        }
    }
}




