using System;

namespace FlorianBaier.Week10.Test
{
    public class River
    {
        public string Name { get; set; }
        public double Length { get; set; }

        public River(string name, double length)
        {
            Name = name;
            Length = length;
        }
    }
}