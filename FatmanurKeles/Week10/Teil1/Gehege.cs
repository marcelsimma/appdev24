using System;

namespace FatmanurKeles.Week10.Teil1
{
    public class Gehege
    {
        public string GehegeName { get; set; }

        public Gehege(string gehegename)
        {
            GehegeName = gehegename;
        }

        public override string ToString()
        {
            return
            String.Format("Gehege:" + GehegeName);
        }
    }
}