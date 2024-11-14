using System;
using OliverBedogg.Week05;

namespace OliverBedogg.Week06
{
    public class Kurs
    {
        // Komposition        
        private Person _Trainer;
        private List<Person> _TeilnehmerInnen;

        public Kurs(Person Trainer)
        {
            _Trainer = Trainer;
        }

        public void plusTeilnehmerIn(Person TeilnehmerIn)
        {
            _TeilnehmerInnen.Add(TeilnehmerIn);
        }
        public override string ToString()
        {
            return "TeilnehmerInnen: " + string.Join(", ", _TeilnehmerInnen);
        }
    }
}