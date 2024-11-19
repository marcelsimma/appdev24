using System;
using System.Globalization;
using CheyenneHarbarth.Week07.Callcenter;

namespace CheyenneHarbarth.Week07.Callcenter
{
    public class Callcenter
    {
        public static void Start()
        {
            Queue<CallItem> calls = new Queue<CallItem>();                                                      //Queue ist eine Liste, bei der die verarbeiteten Zeilen gelöscht werden, wie eine Warteschlange
            CallItem call2 = new CallItem("Martin Hämmerle", "+43 660 .....", DateTime.Now);                    // Now ist ein Klassenattribut, deshalb brauchen wir das Keyword "new" nicht
            CallItem call3 = new CallItem("Andrea Bauer", "+43 5574 ....", DateTime.Now);
            CallItem call1 = new CallItem("Berta Längle", "+43 5522 ....", new DateTime(2024, 11, 19, 11, 33, 23));
            CallItem call4 = new CallItem("Walter Blum", "+43 699 ....", DateTime.Now);

            calls.Enqueue(call1);
            calls.Enqueue(call2);
            calls.Enqueue(call3);
            calls.Enqueue(call4);


            //Queue ausgeben und das Element gleichzeitig aus der Queue entfernen
            while (calls.Count > 0)                                                                             //solange noch Elemente in der Queue sind, soll die while-Schleife ablaufen
            {
                System.Console.WriteLine(calls.Dequeue());
            }
        }
    }
}