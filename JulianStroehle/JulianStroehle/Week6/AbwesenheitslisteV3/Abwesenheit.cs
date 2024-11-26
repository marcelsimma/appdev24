using System;
namespace JulianStroehle.Week6.AbwesenheitslisteV3
{
    internal class Abwesenheit
    {
        internal DateTime Start;
        internal DateTime End;
        internal string Cause;
        internal bool IsExcused;
        internal Abwesenheit(DateTime start, DateTime end, string cause, bool isExcused)
        {
            Start = start;
            End = end;
            Cause = cause;
            IsExcused = isExcused;
        }
        public string Formated()
        {
            return string.Format("{0,-20}", Start.ToString("G")) + "│" + string.Format("{0,-20}", End.ToString("G")) + "│" + string.Format("{0,-30}", Cause) + "│" + string.Format("{0,-13}", IsExcused);
        }
        public override string ToString()
        {
            return $"{Start.Ticks}; {End.Ticks}; {Cause}; {IsExcused}";
        }
    }
}