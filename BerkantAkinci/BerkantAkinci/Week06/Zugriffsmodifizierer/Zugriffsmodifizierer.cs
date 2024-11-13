
using System.ComponentModel;

namespace BerkantAkinci.Week06.Zugriffsmodifizierer
{
    /*
    Offizielle Tabelle mit den Zugriffsmodifizierern
    https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    
    public: von überall aus erreichbar; am wenigsten Schutz
    private: nur innerhalb der Klasse bzw. des Objektes erreichbar; am meisten Schutz
    protected: erweitert private insofern, dass auch erbende bzw. abgeleitet Klassen zugreifen können
    internal: Erlaubt den Zugriff von überall innerhalb des "Projektes"

    Zugriffsmodifizierer für Klassen innerhalb eines Namespace:
    https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs1527?f1url=%3FappId%3Droslyn%26k%3Dk(CS1527)
    
    public: auch von außerhalb der aktuellen Assembly erreichbar
    internal: nur innerhalb der aktuellen Assembly erreichbar 

    Definition einer Assembly: https://learn.microsoft.com/en-us/dotnet/standard/assembly/
    
    */

    public class Zugriffsmodifizierer {
        public static void PrintMessage() {
            System.Console.WriteLine("Ich bin im Namespace Zugriffsmodifizierer"); 
        }
    }
}