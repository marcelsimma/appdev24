using System;

namespace CheyenneHarbarth.Week07.Supermarket
{
    internal class Employee
    {
        internal string employeename { get; set; }
        internal bool Available = true;

        internal Employee(string _employeename)
        {
            employeename = _employeename;
        }
        internal void HandReceipt()
        {
            //neue Datei in C:\Users\BAU28365\Documents\SupermarktBelege erstellen
            //Dateiname: Beleg(nummer, aufsteigend)
            //Beleg formatieren
        }
    }
}