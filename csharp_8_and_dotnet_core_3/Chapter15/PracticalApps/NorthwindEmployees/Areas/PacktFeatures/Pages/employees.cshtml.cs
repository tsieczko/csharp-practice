using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindContextLib;
using NorthwindEntitiesLib;

namespace PacktFeatures.Pages
{
	public class EmployeesPageModel : PageModel
	{
		private Northwind db;
		public EmployeesPageModel(Northwind injectedContext)
		{
			db = injectedContext;
		}
		public IEnumerable<Employee> Employees { get; set; }
		public void OnGet()
		{
			Employees = db.Employees.ToArray();
		}
	}
}
