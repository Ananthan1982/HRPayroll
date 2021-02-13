using System;
using System.Linq;
using HRPayRoll.Factories;
using HRPayRoll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRPayRoll.Pages.Employee
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public EmployeeModel Employee { get; set; }
        public void OnGet(string id)
        {
            EmployeeModel empModel = Common.ListOfEmployeeModel.Where(p => p.EmpoyeeID == id).FirstOrDefault();
            Employee = empModel;
        }

        public void OnPost()
        {
            try

            {
                if (Employee != null)
                {
                    if (Employee.EmployeeType == "Regular")
                    {
                        var regular = new Regular() { EmployeeName = Employee.EmployeeName, DateOfBirth = Employee.DateOfBirth, EmployeeType = Employee.EmployeeType, NoOfDays = Employee.NoOfDays };
                        if (regular.NoOfDays >= 0)
                        {
                            regular.CalculateSalary(regular);
                            Employee.Salary = regular.Salary;
                        }                        
                    }
                    else
                    {
                        var contractual = new Contractual() { EmployeeName = Employee.EmployeeName, DateOfBirth = Employee.DateOfBirth, EmployeeType = Employee.EmployeeType, NoOfDays = Employee.NoOfDays };

                        if (contractual.NoOfDays > 0)
                        {
                            contractual.CalculateSalary(contractual);
                            Employee.Salary = contractual.Salary;
                        }                       
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception on Salary Calculation. "+ ex.Message );
            }
        }
    }
}
