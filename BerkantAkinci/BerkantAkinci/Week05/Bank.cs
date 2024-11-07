using System;
using System.ComponentModel.DataAnnotations;

namespace BerkantAkinci.Week05
{

    public class Bank
    {
        string _Name;
        int _Betrag;
        double _Zinsen;
        double _Darlehen;

        public Bank(string name, int betrag, double zinsen) {
            _Name = name;
            _Betrag = betrag;
            _Zinsen = zinsen;
            _Darlehen = Math.Round(betrag*zinsen,2);
        }

         public override string ToString()
        {
            return string.Format($"Name: {_Name,-15}, Betrag: {_Betrag,-6} Euro, Zinsen: {_Zinsen,-6}, Darlehen: {_Darlehen,-9} Euro");
        }
    }
}