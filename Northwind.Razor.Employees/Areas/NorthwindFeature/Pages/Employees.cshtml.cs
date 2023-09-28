using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Northwind.Common.Context;
using Northwind.Common.Models;

namespace Northwind.Razor.Employees.NorthwindFeature.Pages.Employees
{
    public class EmployeesPageModel : PageModel
    {
        private NorthwindDB db;
        public EmployeesPageModel(NorthwindDB injectedContext)
        {
            db = injectedContext;
        }
        public Employee[] Employees { get; set; } = null!;
        public void OnGet()
        {
            ViewData["Title"] = "Northwind B2B - Employees";
            Employees = db.Employees.OrderBy(e => e.LastName)
                 .ThenBy(e => e.FirstName).ToArray();
        }
    }
}