using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HRPayRoll.Factories;
using HRPayRoll.Models;

namespace HRPayRoll.Pages.Employee
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public EmployeeModel Employee { get; set; }

        [BindProperty]
        public List<EmployeeType> EmployeeTypes { get; set; }

        private string _selectedEmployeeTypes;

        [BindProperty]
        public string SelectedEmployeeTypes
        {
            get { return _selectedEmployeeTypes; }
            set 
            {
                _selectedEmployeeTypes = value;               
            }
        }

        public void OnGet()
        {
            try
            {
                Employee = new EmployeeModel
                {
                    DateOfBirth = DateTime.Now
                };
                GetEmployeeTye();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception on Page Load" + ex.Message);
            }
        }

        public void GetEmployeeTye() // Get Employee Types
        {
            EmployeeTypes = new List<EmployeeType>()
            {
                new EmployeeType() { EmployeeTypeID=1, EmployeeTypeDescription="Regular" },
                new EmployeeType() { EmployeeTypeID=2, EmployeeTypeDescription="Contractual" }
            };
            SelectedEmployeeTypes = "Regular";
        }


        public List<Regular> ListOfRegularEmployees { get; set; }
        public List<Contractual> ListOfContractualEmployees { get; set; }

        public IActionResult  OnPost( )
        {
            try
            {
                if (Employee != null && _selectedEmployeeTypes != null)
                {

                    if (Common.ListOfEmployeeModel == null)
                    {
                        Common.ListOfEmployeeModel = new List<EmployeeModel>();
                    }

                    Employee.EmpoyeeID = Guid.NewGuid().ToString();
                    Employee.EmployeeType = SelectedEmployeeTypes;
                    Common.ListOfEmployeeModel.Add(Employee);
                }
                Employee = new EmployeeModel
                {
                    DateOfBirth = DateTime.Now
                };
                GetEmployeeTye();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception on Create Employee. " + ex.Message);
            }
            return RedirectToPage("./Index");
        }
    }
}
