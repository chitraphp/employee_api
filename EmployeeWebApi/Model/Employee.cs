using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Model
{
	public class Employee
	{
		[Required]
		public int EmployeeID { get; set; }
		[Required]
		public string EmpName { get; set; }
		public string Email { get; set; }

	}
}
