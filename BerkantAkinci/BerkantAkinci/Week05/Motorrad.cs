using System;

namespace BerkantAkinci.Week05
{

    public class Motorrad
    {
        string _Name;
        string _Bewegung;
        int _Kilometerstand;
        int _Fahren;
        int _KilometerstandNeu;

        public Motorrad(string name, int kilometerstand, int fahren, string bewegung)
        {
            _Name = name;
            _Kilometerstand = kilometerstand;
            _Fahren = fahren;
            _Bewegung = bewegung;
            _KilometerstandNeu = kilometerstand + fahren;
        }

        public override string ToString()
        {
            return string.Format($"{_Name,-9}: {_Kilometerstand,-5}km\n{_Name,-9} fährt {_Fahren,-3}km.\n{_Name,-9} ist in Bewegung: {_Bewegung,-5}\n{_Name,-9}: {_KilometerstandNeu,-4} km ");
        }
    }
}