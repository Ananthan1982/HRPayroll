using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace HRPayRoll.Models
{ 
    public class EmployeeModel
    {
        public string EmpoyeeID { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Employee Name is mandatory !")]
        [Display(Name = "Employee Name :")]
        public string EmployeeName { get; set; }

        [BindProperty]
        [Display(Name = "Date Of Birth :")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "TIN is mandatory !")]
        [Display(Name = "TIN :")]
        public string TIN { get; set; }
        [Range(0, 22 ,ErrorMessage = "{0} must be between {1} and {2}.")]

        [BindProperty]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal NoOfDays { get; set; }

        [BindProperty]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }

        [BindProperty]
        [Display(Name = "Employee Type :")]
        public string EmployeeType { get; set; }

        [BindProperty]
        public bool IsSelected { get; set; }
    }

    public class EmployeeCollection
    {
        [BindProperty]
        public List<EmployeeModel> EmployeeModels { get; set; }
    }
   
}
