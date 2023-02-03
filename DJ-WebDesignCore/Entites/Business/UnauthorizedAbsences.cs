using System;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Student;
using System.ComponentModel.DataAnnotations.Schema;

namespace DJ_WebDesignCore.Entites.Business
{
	public class UnauthorizedAbsences
	{
		public int UnauthorizedAbsencesId { get; set; }
        public int? StudentLAId { get; set; }
        [ForeignKey("StudentLAId")]
        public StudentLA? StudentLA { get; set; }
        public DateTime? UnauthorizedAbsencesDateTime { get; set; }
        public string? UnauthorizedAbsencesName { get; set; }
        public int? EmployeeComfirmId { get; set; }
        [ForeignKey("EmployeeComfirmId")]
        public EmployeeLA? EmployeeComfirm { get; set; }
    }
}

