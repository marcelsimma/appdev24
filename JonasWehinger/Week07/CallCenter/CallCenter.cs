using System;
using JonasWehinger.Week07.CallCenter;

namespace JonasWehinger.Week07.CallCenter
{

    public class Callcenter
    {
        public static void Start()
        {

            Queue<CallItem> calls = new Queue<CallItem>();

            CallItem call1 = new CallItem("Nico", "+43 5665", new DateTime(2024, 11, 19, 11, 33, 23)); 
            CallItem call2 = new CallItem("Lucas", "+43 5665", DateTime.Now); 
            CallItem call3 = new CallItem("Alessio", "+43 5665", DateTime.Now);
            CallItem call4 = new CallItem("Jonas", "+43 5665", DateTime.Now);

            calls.Enqueue(call1);
            calls.Enqueue(call2);
            calls.Enqueue(call3);
            calls.Enqueue(call4);
            
            foreach (CallItem call in calls)
            {
                System.Console.WriteLine(call.ToString());
            }

        }
    }

}