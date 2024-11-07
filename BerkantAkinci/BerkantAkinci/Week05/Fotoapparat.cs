using System;

namespace BerkantAkinci.Week05
{

    public class Fotoapparat
    {
        int _BrennweiteMAX;
        int _BrennweiteMIN;
        string _Model;
        string _Hersteller;
        double _Megapixel;


        public Fotoapparat(int brennweiteMAX, int brennweiteMIN, string hersteller, string model, double megapixel)
        {
            _BrennweiteMAX = brennweiteMAX;
            _BrennweiteMIN = brennweiteMIN;
            _Hersteller = hersteller;
            _Model = model;
            _Megapixel = megapixel;
        }

        public static string ShotFoto()
        {

            return "";
        }

        public override string ToString()
        {

            return string.Format($"maximale Brennweite; {_BrennweiteMAX}\nmindest Brennweite: {_BrennweiteMIN}\nModel: {_Hersteller}\n Megapixel: {_Model}\nHertseller: {_Megapixel}");
        }


    }
}