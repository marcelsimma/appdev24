using System;

namespace SimonJochum.Week08.PrüfungOOP
{
    public class Book : Medium
    {
        private string _coverType;

        public Book(string title, string author, string publishingYear, string ISBN, string coverType)
            : base(title, author, publishingYear, ISBN)
        {
            _coverType = coverType;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $", Cover: {_coverType}";
        }
    }
}