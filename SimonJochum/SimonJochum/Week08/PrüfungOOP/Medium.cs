using System;

namespace SimonJochum.Week08.PrüfungOOP
{
    public class Medium
    {
     
        public string _title;
        public string _author;
        public string _publishingYear;
        public string _ISBN;

        public Medium(string title, string author, string publishingYear, string ISBN)
        {
            _title = title;
            _author = author;
            _publishingYear = publishingYear;
            _ISBN = ISBN;
        }

       
        public virtual string GetDetails()
        {
            return $"Titel: {_title}, Autor: {_author}, Jahr: {_publishingYear}, ISBN: {_ISBN}";
        }
    }
}