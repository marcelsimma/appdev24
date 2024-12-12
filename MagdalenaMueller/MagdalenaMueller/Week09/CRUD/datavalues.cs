using System;

namespace MagdalenaMueller.Week09
{
    public class Datavalues
    {
        public static List<string> FillDataValues()
        {
            List<string> datavaluesList = new List<string>();

            datavaluesList.Add("insert into language2(country,name,percentage) values('CH','French',18);");
            datavaluesList.Add("insert into language2(country,name,percentage) values('A','German',100);");
            datavaluesList.Add("insert into language2(country,name,percentage) values('B','German',1);");
            datavaluesList.Add("insert into language2(country,name,percentage) values('CH','German',65);");
            datavaluesList.Add("insert into language2(country,name,percentage) values('D','German',100);");
            datavaluesList.Add("insert into language2(country,name,percentage) values('HAL','German',100);");
            datavaluesList.Add("insert into language2(country,name,percentage) values('NAM','German',32);");
            datavaluesList.Add("insert into language2(country,name,percentage) values('CH','Italian',12);");
            datavaluesList.Add("insert into language2(country,name,percentage) values('CH','Romansch',1);");

            return datavaluesList;
        }
    }
}