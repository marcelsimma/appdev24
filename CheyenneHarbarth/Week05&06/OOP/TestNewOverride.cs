using System;
using System.Text;

namespace OverrideAndNew
{

    //Dieses Beispiel findest du bei https://learn.microsoft.com/de-de/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords
    class BaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");
        }

        public virtual void Method2()           //virtual bräuchte es hier garnicht zwingend, da wir unten das Keyword new benutzt haben
        {
            Console.WriteLine("Base - Method2");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Method1()          //override kann nur verwendet werden, wenn die ursprüngliche Methode virtual, abstract oder override ist
        {
            Console.WriteLine("Derived - Method1");
        }

        public new void Method2()               //durch new wird weiterhin auf die Methode der Elternklasse zugegriffen, aber es unterdrückt die Warnmeldung, du könntest aber auch etwas neues dazuschreiben
        {                                       //Die Verwendung von new ist also genaugenommen nicht ganz korrekt beim Vererben
            Console.WriteLine("Derived - Method2");
        }
    }
    public class TestNewOverride
    {
        public static void Start()
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();


            bc.Method1();               // Base - Method1 
            bc.Method2();               // Base - Method2 


            dc.Method1();               // Derived - Method1  
            dc.Method2();               // Derived - Method2


            // The following two calls produce different results, depending
            // on whether override (Method1) or new (Method2) is used.  
            bcdc.Method1();             // Derived - Method1
            bcdc.Method2();             // Base - Method2  
        }
    }
}