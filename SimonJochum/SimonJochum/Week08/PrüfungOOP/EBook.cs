using System;

namespace SimonJochum.Week08.PrüfungOOP
{
    public class EBook : Medium
    {
        private string _fileFormat;

        public EBook(string title, string author, string publishingYear, string ISBN, string fileFormat)
            : base(title, author, publishingYear, ISBN)
        {
            _fileFormat = fileFormat;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $", Format: {_fileFormat}";
        }
    }
}