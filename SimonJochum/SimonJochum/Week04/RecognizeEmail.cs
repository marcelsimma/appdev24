using System;
using System.Text.RegularExpressions;

namespace SimonJochum.Week04
{
    public class RecognizeEmail
    {
        public static void Start()
        {
            CheckEMail();
        }

        public static void CheckEMail()
        {
            string[] eMailAdresses = ["simon.jochum95@gmail.com", "test@test.at", "simon.jochum@bachmann.info", "simon#jochum@gmail.com", "test#test@test.at", "Übung@test.at", "übung@test.info", "übung@tt.info", "SIMON.JOCHUM@bachmann.info", "test-test@test-info.at","test_test@test-info.at", "ubung@übung.at", "test_test.test@test.at"];
            string eMailPattern = @"^([a-z0-9\.-_]{1,64})+@([a-z0-9\.-]{3,249})+\.[a-z]{2,6}$"; 
            // ^ = beginnt den Regex Ausdruck, ([a-z0-9*_\.-]{1,64}) / () = fassen den Ausdruck zusammen / [] = enthält die Zeichen die erlaubt sind / {} = enthält die mindest und maximale Anzahl an Zeichen / +@ = es muss ein @ vorhanden sein 
            // / +\. = es muss ein Punkt in der Domain vorkommen (der \ ist ein Escapezeichen damit der Punkt von Regex nicht falsch interpretiert wird) / $ = beendet den Regex Ausdruck 

            foreach (string adress in eMailAdresses)
            {
                string adressLowercase = adress.ToLower();
                bool isValid = Regex.IsMatch(adressLowercase, eMailPattern);

                if (isValid == true)
                {
                    Console.WriteLine($"{adress} ist eine gültige Email Adresse.+");
                }
                else 
                {
                    Console.WriteLine($"{adress} ist keine gültige Email Adresse.-");
                }
            }
        }
    }
}