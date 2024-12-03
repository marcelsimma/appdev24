using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace BerkantAkinci.Week07.Callcenter
{
    public class Callcenter
    {
        public static void Start()
        {
            Queue<CallItem> calls = new Queue<CallItem>();

            // Queue ohne vorgegebenen Datentyp
            //Queue callsTmp = new Queue();

            //Objekt erstell und hinzufügen in 2 Schritten
            // 1. Schritt
            CallItem call2 = new CallItem("Nico", "+43 5665", DateTime.Now); // Now ist ein Klassenattribut
            CallItem call3 = new CallItem("Berkant", "+43 5665", DateTime.Now);
            CallItem call1 = new CallItem("Chef", "+43 5665", new DateTime(2024, 11, 19, 11, 33, 23)); // neues DateTime Objekt erstellen
            CallItem call4 = new CallItem("Barbara", "+43 5665", DateTime.Now);

            // 2. Schritt
            calls.Enqueue(call1);
            calls.Enqueue(call2);
            calls.Enqueue(call3);
            calls.Enqueue(call4);

            //Objekt erstell und hinzufügen in 1 Schritt
            calls.Enqueue(new CallItem("Nico", "+43 5665", DateTime.Now));

            // Queue auf der Console ausgeben
            /*
            foreach (CallItem call in calls)
            {
                System.Console.WriteLine(call.ToString());
            }
            */

            // Queue auf der Console ausgeben und das ausgegebene Element aus der Queue entfernen
            while (calls.Count > 0)
            {
                System.Console.WriteLine(calls.Dequeue());
            }

            System.Console.WriteLine(calls.Count());








        }




    }

}