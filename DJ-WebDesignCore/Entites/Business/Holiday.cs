using System;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Student;
using System.ComponentModel.DataAnnotations.Schema;
using DJ_WebDesignCore.Entites.Properties;

namespace DJ_WebDesignCore.Entites.Business
{
	public class Holiday : BaseEntity
    {
        public int? TotalDay { get; set; }
        public string? HolidayName { get; set; }
        public int? OpenDay { get; set; }
        public int? OpenMonth { get; set; }
        public int? CloseDay { get; set; }
        public int? CloseMonth { get; set; }
        public string? HolidayDetail { get; set; }
		public EmployeeLA? EmployeeLACreate { get; set; }
        public DateTime? CreateDateTime { get; set; }  
        public HolidayStatus? HolidayStatus { get; set; }
     
    }
}

