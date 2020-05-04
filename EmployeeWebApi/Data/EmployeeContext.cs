using EmployeeWebApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Data
{
	public class EmployeeContext:DbContext
	{
		public EmployeeContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Employee> Employees { get; set; }
		
		protected override void OnModelCreating
			(ModelBuilder builder)
		{
			builder.Entity<Employee>(ConfigureEmployee);
		}
		
		private void ConfigureEmployee(EntityTypeBuilder<Employee> builder)
		{
			builder.ToTable("Employee");
			builder.Property(c => c.EmployeeID)

				.UseHiLo("employee_hilo")
				.IsRequired();
			builder.Property(c => c.EmpName)
				.IsRequired()
				.HasMaxLength(40);
			builder.Property(c => c.Email);
			
		}
	}
}
