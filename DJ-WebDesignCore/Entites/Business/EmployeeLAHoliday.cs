using DJ_WebDesignCore.Entites.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Business
{
	public class EmployeeLAHoliday :BaseEntity
	{
		public EmployeeLA? EmployeeLA { get; set; }
		public Holiday? Holiday { get; set; }
		public int? TotalDay { get; set; }
		public int? IsSalary { get; set; }

	}
}
