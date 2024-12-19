using System;

namespace BerkantAkinci.Week10
{
    public class AnimalDoctor
    {
        public string DoctorName;
        public List<Enclosure> EnclosureList;

        public AnimalDoctor(string doctorName)
        {
            DoctorName = doctorName;
            EnclosureList = new List<Enclosure>();
        }


        public void AddEnclosure(Enclosure enclosure)
        {
            EnclosureList.Add(enclosure);
        }
    }
}