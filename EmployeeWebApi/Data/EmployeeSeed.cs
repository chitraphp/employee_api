using EmployeeWebApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Data
{
	public class EmployeeSeed
	{
		public static async Task SeedAsync(EmployeeContext context)
		{
			context.Database.Migrate();

			if (!context.Employees.Any())
			{
				context.Employees.AddRange(GetPreconfiguredEmployees());

				await context.SaveChangesAsync();
			}
		}
		private static IEnumerable<Employee> GetPreconfiguredEmployees()
		{
			return new List<Employee>()
			{
				new Employee(){EmployeeID=23,EmpName="chitrakala", Email="chitra.at@gmail.com"},
				new Employee(){EmployeeID=25,EmpName="suchir", Email="suchi.at@gmail.com"}

			};
			
				
		
		}

	}
}
