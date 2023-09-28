using Microsoft.AspNetCore.Mvc.RazorPages; // PageModel

using Northwind.Common.Models;
using Northwind.Common.Context;
using Microsoft.AspNetCore.Mvc;


namespace Northwind.Web.Pages;
public class SuppliersModel : PageModel
{

    public SuppliersModel(NorthwindDB db) {
        this.db = db;
    }


    private readonly NorthwindDB db;

    public IEnumerable<Supplier>? Suppliers { get; set; }
    [BindProperty]
    public Supplier? supplier { get; set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid || supplier == null)
        {
            return Page();
        }
        db.Suppliers.Add(supplier);
        db.SaveChanges();
        return RedirectToPage("/suppliers");
    }
    public void OnGet()
    {
        ViewData["Title"] = "Northwind B2B - Suppliers";
        Suppliers =db.Suppliers.ToList();
    }
}