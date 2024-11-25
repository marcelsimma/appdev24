using System;
using System.Collections.Generic;

namespace BerkantAkinci.Week07
{
  class ParticipantsList
  {
    public static void Start()
    {
      /*
      Dictionary speichert immer Wertepaare
        - <TKey, TValue>
        - Key und Value können unterschiedliche Datentypen haben

      Key: Schlüssel
        - Damit kann der Wert gesucht werden.
        - ein Key-Wert darf nur einmal im Dictionary vorkommen
        - "ersetzt" den bisherigen Integer-Index


      Value: Wert
        - muss nicht eindeutig sein
        - wird ganz normal wie die bisherigen Werte verwendet
        - ist veränderbar
      */

      Dictionary<string, List<DateTime>> participantsList = new Dictionary<string, List<DateTime>>();

      // Teilnehmer zur Liste hinzufügen
      participantsList.Add("Lucas", new List<DateTime>());
      participantsList.Add("Berkant", new List<DateTime>());
      participantsList.Add("Magdalena", new List<DateTime>());

      // Abwesenheitseintrag zum Teilnehmer hinzufügen

      participantsList["Lucas"].Add(DateTime.Now);
      participantsList["Lucas"].Add(DateTime.Now);
      participantsList["Lucas"].Add(DateTime.Now);
      participantsList["Lucas"].Add(DateTime.Now);

      // Wert verändern
      //participantsList["Lucas"].Clear();

      foreach (KeyValuePair<string, List<DateTime>> participant in participantsList)
      {
        Console.Write($"{participant.Key,-10}: ");
        foreach (DateTime timeEntry in participant.Value)
        {
          Console.Write($"{timeEntry.ToShortDateString()}, ");
        }
        Console.WriteLine();
      }

      System.Console.WriteLine(participantsList["Lucas"]);
    }
  }
}