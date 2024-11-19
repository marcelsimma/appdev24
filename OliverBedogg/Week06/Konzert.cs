using System;

namespace OliverBedogg.Week06
{
    public class Konzert
    {
        public string _name;
        // Warteschlange
        public Queue<string> queue = new Queue<string>();

        public Konzert(string name)
        {
            _name = name;
        }
    }
}