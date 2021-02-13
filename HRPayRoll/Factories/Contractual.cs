
namespace HRPayRoll.Factories
{
    public class Contractual : EmployeeBase
    {
        public Contractual()
        { }
        /// <summary>
        /// Calaculates Salary for Contract employee
        /// </summary>
        /// <param name="employee">Employee Model</param>
        /// <returns>Updated employee model</returns>
        public override EmployeeBase CalculateSalary(EmployeeBase employee)
        {
            decimal perDayRate = 500; // rate per day
            employee.Salary = perDayRate * employee.NoOfDays;
            return employee;

        }
    }
}
