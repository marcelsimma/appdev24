using System;

namespace CheyenneHarbarth.Week07.Supermarket
{
    public class SupermarektMain
    {
        public static void Start()
        {
            Supermarket MuehlebacherLaedele = new Supermarket("Mühlebacher Lädele", "Mühelbacherstraße 24, 6850 Dornbirn", new Dictionary<DateTime, DateTime>());

            DateTime OpenDay = new DateTime();

            Checkout checkout = new Checkout("145314530");

            DateTime OpenHour = new DateTime();
            DateTime ClosingHour = new DateTime();

            TimeSpan OpenHours = OpenHour - ClosingHour;

            //MuehlebacherLaedele.OpeningHours.Add(OpenDay.DayOfWeek, );



            MuehlebacherLaedele.IsSupermarketOpen();
        }
    }
}