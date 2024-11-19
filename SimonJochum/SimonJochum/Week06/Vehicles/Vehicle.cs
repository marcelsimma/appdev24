using System;

namespace SimonJochum.Week06.Vehicles
{
    public abstract class Vehicle //abstract class dient rein zur Vererbung, dadurch kann Vehicle nicht Instanziert werden, funktioniert genauso mit Methoden, dort wird kein Body vergeben, in der erbenden Klasse muss die Methode mit override überschrieben werden
    {
        public string Name;
        public string AmountTires;

        public virtual string Drive()
        {
            return $"Ich bin ein {Name}. ";
        }
    }
}