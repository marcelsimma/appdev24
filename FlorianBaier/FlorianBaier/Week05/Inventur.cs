using System;
using System.IO;

namespace FlorianBaier.Week05
{

    public static class Inventur
    {

        public static void Start()
        {
            ReadAndPrintFile();
        }
        public static void ReadAndPrintFile()
        { 
            using (StreamReader reader = new StreamReader("/Users/flori/Desktop/DigitalCampus/inputarticlelist.txt"))
            {

            }
        }
    }
}