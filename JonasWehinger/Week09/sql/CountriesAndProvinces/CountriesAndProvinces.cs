using System;
using System.Collections.Generic;
using JonasWehinger.Models;

namespace JonasWehinger.Models
{
    public class CountriesAndProvinces
    {
        public static List<State> States { get; set; } = new List<State>();


        public static void Start()
        {
            Console.WriteLine("Geben Sie die Länderkürzel ein (mit Komma getrennt, z. B. DE,FR,IT):");
            string[] countryCodes = Console.ReadLine().Split(',');

            foreach (var code in countryCodes)
            {
                string trimmedCode = code.Trim();
                Console.WriteLine($"Geben Sie Informationen für das Land {trimmedCode} ein:");

                Console.Write("Name des Staates: ");
                string stateName = Console.ReadLine();

                Console.Write("Hauptstadt des Staates: ");
                string stateCapital = Console.ReadLine();

                Console.Write("Kontinent: ");
                string continent = Console.ReadLine();

                State state = new State
                {
                    Name = stateName,
                    CapitalCityName = stateCapital,
                    Continent = continent
                };

                Console.WriteLine("Geben Sie die Anzahl der Provinzen ein:");
                int provinceCount = int.Parse(Console.ReadLine());

                for (int i = 0; i < provinceCount; i++)
                {
                    Console.WriteLine($"Geben Sie Informationen für Provinz {i + 1} ein:");

                    Console.Write("Name der Provinz: ");
                    string provinceName = Console.ReadLine();

                    Console.Write("Hauptstadt der Provinz: ");
                    string provinceCapital = Console.ReadLine();

                    Console.Write("Bevölkerung der Provinz: ");
                    int population = int.Parse(Console.ReadLine());

                    state.Provinces.Add(new Province
                    {
                        Name = provinceName,
                        CapitalCityName = provinceCapital,
                        Population = population
                    });
                }

                States.Add(state);
            }

            Console.WriteLine("\n--- Übersicht aller eingegebenen Daten ---\n");
            foreach (var state in States)
            {
                state.PrintStateInfo();
            }
        }
    }
}
