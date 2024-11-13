using System;
namespace NicoDobler.Week05
{

    public class Auto
    {

        public string Marke;
        public int PS;

        public int Höchstgeschwindigkeit { get; set; }

        public Auto(string marke, int ps)
        {
            Marke = marke;
            PS = ps;
        }

        public static void output (){

           }
    }
}