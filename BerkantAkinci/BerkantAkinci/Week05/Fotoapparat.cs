using System;

namespace BerkantAkinci.Week05
{

    public class Fotoapparat
    {
        int _BrennweiteMAX;
        int _BrennweiteMIN;
        string _Model;
        string _Hersteller;
        string _Objektiv;
        double _Megapixel;

        public Fotoapparat(int brennweiteMAX, int brennweiteMIN, string hersteller, string model, string objektiv, double megapixel)
        {
            _BrennweiteMAX = brennweiteMAX;
            _BrennweiteMIN = brennweiteMIN;
            _Hersteller = hersteller;
            _Model = model;
            _Objektiv = objektiv;
            _Megapixel = megapixel;
        }

        public override string ToString()
        {
            return string.Format($"maximale Brennweite; {_BrennweiteMAX, -2}\nmindest Brennweite: {_BrennweiteMIN,-2}\nModel: {_Hersteller,-7}\nHersteller: {_Model,-6}\nObjektiv: {_Objektiv,-7}\nMegapixel: {_Megapixel,-4}");
        }


    }
}