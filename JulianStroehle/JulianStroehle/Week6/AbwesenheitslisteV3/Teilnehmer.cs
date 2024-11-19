using System;
namespace JulianStroehle.Week6.AbwesenheitslisteV3
{
    internal class Teilnehmer
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal double Cost = 5000;
        internal Abwesenheit Abwesenheit;
        internal Teilnehmer(string firstName, string lastName, Abwesenheit abwesenheit)
        {
            FirstName = firstName;
            LastName = lastName;
            Abwesenheit = abwesenheit;
        }
        public double GetCost()
        {
            int temp = 0;
            long temp2 = Abwesenheit.Start.Day;
            int temp3 = 0;
            if (Abwesenheit.End.Hour == 17 && Abwesenheit.Start.Hour == 08)
            {
                temp3 = 1;
            }
            if (Abwesenheit.End.Hour >= 13 && Abwesenheit.Start.Hour <= 12 && Abwesenheit.Start.Day == Abwesenheit.End.Day)
            {
                temp++;
            }
            else
            {
                while (temp2 < Abwesenheit.End.Day-temp3)
                {
                    temp++;
                    temp2++;
                }
            }
            if (Abwesenheit.Start.Day == Abwesenheit.End.Day)
            {
                temp2 = Abwesenheit.End.Ticks - Abwesenheit.Start.Ticks;
            }
            else
            {
                temp2 = (Abwesenheit.End.Day - Abwesenheit.Start.Day) * TimeSpan.TicksPerHour * 8;
            }
            return Cost / 10 / 3 / (TimeSpan.TicksPerHour * 8) * (temp2 - (TimeSpan.TicksPerHour * temp));
        }
        public string Formated()
        {
            return string.Format("{0,-13}", FirstName) + "│" + string.Format("{0,-10}", LastName) + "│";
        }
        public override string ToString()
        {
            return $"{FirstName}; {LastName}; ";
        }
    }
}