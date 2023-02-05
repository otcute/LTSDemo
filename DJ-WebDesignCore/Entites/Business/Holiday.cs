using System;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Student;
using System.ComponentModel.DataAnnotations.Schema;

namespace DJ_WebDesignCore.Entites.Business
{
	public class Holiday : BaseEntity
    {
        public StudentLA? StudentLA { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? CloseTime { get; set; }
        public int? DateDiff { get; set; }
        public string? HolidayName { get; set; }
        public EmployeeLA? EmployeeComfirm { get; set; }
    }
}

