using System;
namespace NicoDobler.Week07
{

    public class Callcenter
    {


        public static void Start()
        {

            Queue<CallItem> calls = new Queue<CallItem>();


            CallItem call2 = new CallItem("Obama", "+43 5665", DateTime.Now); 
            CallItem call3 = new CallItem("Biden", "+43 5665", DateTime.Now);

            CallItem call1 = new CallItem("Chef", "+43 5665", new DateTime(2024, 11, 19, 11, 33, 23)); 

            CallItem call4 = new CallItem("Barbara", "+43 5665", DateTime.Now);




            calls.Enqueue(call1);
            calls.Enqueue(call2);
            calls.Enqueue(call3);
            calls.Enqueue(call4);

            while(calls.Count > 0) {
                System.Console.WriteLine(calls.Dequeue());
            }


            System.Console.WriteLine(calls.Count());

        }
    }

}