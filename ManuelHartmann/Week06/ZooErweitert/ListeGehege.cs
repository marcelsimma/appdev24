using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelHartmann.Week06.ZooErweitert
{
    public class ListeGehege
    {
        List<Gehege> geheges = new List<Gehege>();

        // Die in der Klasse 'Gehege' erstellten gehege, koennen hier nun der Liste hinzugefuegt werden.
        public void GehegeHinzufuegen(Gehege gehege)
        {
            geheges.Add(gehege);
        }
        public void GehegeEntfernen(Gehege gehege)
        {
            if (geheges.Contains(gehege))
            {
                geheges.Remove(gehege);
            }
            else
            {
                Console.WriteLine($"No need to remove {gehege} cause it's not in the List anyway.");
            }
        }
    }
}
