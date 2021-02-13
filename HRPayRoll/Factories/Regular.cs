
namespace HRPayRoll.Factories
{
    public class Regular : EmployeeBase
    {

        public Regular()
        {
        }
        /// <summary>
        /// Calculates the salary for regular employee
        /// </summary>
        /// <param name="employee">Employee Model</param>
        /// <returns>returns the updated employee model</returns>
        public override EmployeeBase CalculateSalary(EmployeeBase employee)
        {
            decimal basicMonthlySalary = 20000;
            decimal Tax = 0.12m; // Tax 12 %
            decimal salary = basicMonthlySalary - (basicMonthlySalary / 22) - (basicMonthlySalary * Tax);

            if (employee.NoOfDays>0)
            {
                decimal deducation = (salary / 22) * employee.NoOfDays;
                deducation -= (deducation * Tax);
                salary -= deducation;
            }
            employee.Salary = salary;
            return employee;
        }
    }
}
