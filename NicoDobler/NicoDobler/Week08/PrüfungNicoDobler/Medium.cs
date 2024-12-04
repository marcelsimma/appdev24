using System;
namespace NicoDobler.Week08{


public class Medium
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public int Releasedate { get; set; }
        public string ISBN { get; set; }

        public Medium(string titel, string autor, int veröffentlichungsjahr, string isbn)
        {
            Title = titel;
            Author = autor;
            Releasedate = veröffentlichungsjahr;
            ISBN = isbn;

        }
    }
}