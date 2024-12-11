using System;

namespace FatmanurKeles.Week08
{
    public class eBook : Medium
    {
        public List<eBook> eBooks {get; set;}
        public string Dateiformat { get; set; }

        public eBook(string titel, string autor, int veroeffentlichungsjahr, string isbn, string dateiformat) : base( titel,  autor,  veroeffentlichungsjahr,  isbn)
        {
            Dateiformat = dateiformat;
        }


    }
}