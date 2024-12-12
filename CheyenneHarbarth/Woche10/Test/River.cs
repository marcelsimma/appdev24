using System;
using MySql.Data.MySqlClient;

namespace CheyenneHarbarth.Week10.Test
{
    public class River
    {

        internal string Rivername { get; }

        internal double Riverlength { get; }

        public River(string rivername, double riverlength)
        {
            Rivername = rivername;
            Riverlength = riverlength;
        }
    }
}