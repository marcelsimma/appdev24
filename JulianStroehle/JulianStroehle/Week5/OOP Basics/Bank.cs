using System;
namespace JulianStroehle.Week5.models
{
    public class Bank
    {
        string name;
        public Bank(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}", name);
        }
    }
}