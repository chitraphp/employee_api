
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeWebApi.Data;
using EmployeeWebApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebApi.Controllers
{
	[Produces("application/json")]
	[Route("[controller]")]
	public class EmployeeController : Controller
    {
		//private readonly ILogger<EmployeeController> _logger;
		private readonly EmployeeContext _employeeContext;


		public EmployeeController(EmployeeContext empContext)
		{
			_employeeContext = empContext;
					
		}
		[HttpGet]
		
		public async Task<ActionResult> Employee()
		{
			var items = await _employeeContext.Employees.ToListAsync();
			return Ok(items);
		}
		[HttpPost]
		public async Task<ActionResult> Employee(Employee employee)
		{
			if (ModelState.IsValid)
			{
				var employee1 = new Employee
				{
					EmpName = employee.EmpName,
					Email = employee.Email

				};
				_employeeContext.Employees.Add(employee1);
				await _employeeContext.SaveChangesAsync();

				return Ok(employee1);
				
			}
			else
			{
				return BadRequest();
			}
		}
	}
}