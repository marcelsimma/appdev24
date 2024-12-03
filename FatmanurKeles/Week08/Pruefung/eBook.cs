using System;

namespace FatmanurKeles.Week08
{
    public class eBook : Medium
    {
        public List<eBook> eBooks {get; set;}
        public string Dateiformat { get; set; }

        public eBook(string titel, string autor, int veroeffentlichungsjahr, string isbn, string dateiformat)
        {
            Dateiformat = dateiformat;
        }

        public override void Ausgabe()
        {
            base.Ausgabe();
            Console.WriteLine($"Dateiformat: {Dateiformat}");
        }
    }
}