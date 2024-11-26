using System;

namespace BarbaraMarte.Week07.QueueCallCenter;

class QueueCallCenter
{

    public static void Start()
    {

        Queue<CallCenter> calls = new Queue<CallCenter>();

        CallCenter call1 = new CallCenter("Barbara Marte", "+46...", DateTime.Now);
        CallCenter call2 = new CallCenter("Viktor Olsson", "+46.55.", new DateTime(2024, 11, 17, 10, 25, 48));
        CallCenter call3 = new CallCenter("Barbara Marte", "+46...", DateTime.Now);
        CallCenter call4 = new CallCenter("Barbara Marte", "+46...", DateTime.Now);
        CallCenter call5 = new CallCenter("Barbara Marte", "+46...", DateTime.Now);
        calls.Enqueue(call1);
        calls.Enqueue(call2);
        calls.Enqueue(call3);
        calls.Enqueue(call4);
        calls.Enqueue(call5);

        while (calls.Count > 0)
        {
            Console.WriteLine(calls.Dequeue());
        }
    }
}