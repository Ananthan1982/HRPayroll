using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HRPayRoll.Models;

namespace HRPayRoll.Pages.Employee
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public EmployeeCollection ListOfEmployee { get; set; }

        public void OnGet()
        {
            ListOfEmployee = new EmployeeCollection
            {
                EmployeeModels = Common.ListOfEmployeeModel
            };

        }
        public IActionResult OnPostEdit(string id)
        {
            ListOfEmployee.EmployeeModels = Common.ListOfEmployeeModel;
            return RedirectToPage("./Edit", new { id });
        }
    }
}
