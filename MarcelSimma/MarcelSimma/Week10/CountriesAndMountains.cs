using System;

/*

Aufgabenstellung: Erstelle eine Klasse "Country". 
Wird der Konstrukturo dieser Klasse aufgerufen, holt sich diese eigenständig alle Berge, die im jeweiligen Country sind aus der Mondial
Datenbank und speichert diese in eine Liste. 

*/

namespace MarcelSimma.Week10 {
    public class CountriesAndMountains {

        public static string DatabaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=Abcd1234!;
            database=mondial
            ";


        public static void Start() {
            System.Console.WriteLine("Hallo");

            Country aut = new Country("D");
            aut.PrintMountains();
        }
    }
}