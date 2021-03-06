using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindContextLib;
using NorthwindEntitiesLib;
using System.Collections.Generic;
using System.Linq;


namespace NorthwindWeb.Pages
{
	public class SuppliersModel : PageModel
	{
		public IEnumerable<string> Suppliers { get; set; }
		private Northwind db;

		public SuppliersModel(Northwind injectedContext)
		{
			db = injectedContext;
		}

		public void OnGet()
		{
			ViewData["Title"] = "Northwind Web Site - Suppliers";

			Suppliers = db.Suppliers.Select(s => s.CompanyName);
		}

		[BindProperty]
		public Supplier Supplier { get; set; }

		public IActionResult OnPost()
		{
			if (ModelState.IsValid)
			{
				db.Suppliers.Add(Supplier);
				db.SaveChanges();
				return RedirectToAction("/supplies");
			}

			return Page();
		}

	}
}
