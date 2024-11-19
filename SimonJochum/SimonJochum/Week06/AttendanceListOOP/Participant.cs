using System;
using System.Globalization;
using System.Collections.Generic;


namespace SimonJochum.Week06.AttendanceListOOP
{
    public class Participant
    {
        public string FirstName;
        public string LastName;
        public double HourRate;
        public List<ReasonOfAbsence> Absences = new List<ReasonOfAbsence>();

        public Participant(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddAbsence(ReasonOfAbsence absence)
        {
            Absences.Add(absence);
        }

        public string PrintParticipant()
        {
            return $"{FirstName} {LastName} - Stundensatz: {HourRate.ToString("C", CultureInfo.GetCultureInfo("de-AT"))}";
        }

        public double CalculateAttendanceCost()
        {
            double totalCost = 0;

            foreach (var absence in Absences)
            {
                TimeSpan duration = absence.EndTime - absence.StartTime;

                // Berechne die Stunden, die auf Pause fallen (12:00 - 13:00 Uhr)
                if (absence.StartTime.TimeOfDay < TimeSpan.FromHours(13) && absence.EndTime.TimeOfDay > TimeSpan.FromHours(12))
                {
                    duration -= TimeSpan.FromHours(1);
                }

                // Berechnung der Abwesenheitsstunden und der Kosten, falls die Abwesenheit entschuldigt ist
                double hoursAbsent = duration.TotalHours;
                double absenceCost = hoursAbsent * HourRate;

                if (!absence.Excused)
                {
                    totalCost += absenceCost;
                }
            }

            return totalCost;
        }
    }
}