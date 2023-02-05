using System;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Student;
using System.ComponentModel.DataAnnotations.Schema;

namespace DJ_WebDesignCore.Entites.Business
{
	public class UnauthorizedAbsences : BaseEntity
    {
        public StudentLA? StudentLA { get; set; }
        public DateTime? UnauthorizedAbsencesDateTime { get; set; }
        public string? UnauthorizedAbsencesName { get; set; }
        public EmployeeLA? EmployeeComfirm { get; set; }
    }
}

