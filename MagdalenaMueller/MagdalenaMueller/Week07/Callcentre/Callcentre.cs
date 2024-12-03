using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MagdalenaMueller.Week07
{
    public class Callcentre
    {
        public static void StartCallcentre()
        {
            Queue<Caller> calls = new Queue<Caller>();

            Caller call1 = new Caller("Tim", "+42 1234", DateTime.Now);
            Caller call2 = new Caller("Tom", "+42 4321", DateTime.Now);
            Caller call3 = new Caller("Timon", "+42 1423", DateTime.Now);


            calls.Enqueue(call1);
            calls.Enqueue(call2);
            calls.Enqueue(call3);

            while(calls.Count > 0)
            {
                Console.WriteLine(calls.Dequeue().ToString());
                ;
            }
        }
    }
}