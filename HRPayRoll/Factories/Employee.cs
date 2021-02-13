using System;

namespace HRPayRoll.Factories
{
    public abstract class EmployeeBase   
    {
        public EmployeeBase()
        {

        }

        public  string EmpoyeeID { get; set; }
       
        public  string EmployeeName { get; set; }
  
        public  DateTime DateOfBirth { get; set; }

        public  string TIN { get; set; }

        public  decimal NoOfDays { get; set; }
        public  decimal Salary { get; set; }
  
        public  string EmployeeType { get; set; }
        public abstract EmployeeBase CalculateSalary(EmployeeBase employeeBase);
       
    }
}
