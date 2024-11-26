using System;

namespace BerkantAkinci.Week07.Supermarket
{
    public class Employee
    {
        public string EmployeeName;
        public bool EmployeeAvailable;
        public string StaffNumber;

        public Employee(string employeeName, bool employeeAvailable, string staffNumber)
        {
            EmployeeName = employeeName;
            EmployeeAvailable = employeeAvailable;
            StaffNumber = staffNumber;
        }

        public string HandsReceipt()
        {
            return "";
        }
    }
}


