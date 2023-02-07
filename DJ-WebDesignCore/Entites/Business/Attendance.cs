using System;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Entites.Properties;

namespace DJ_WebDesignCore.Entites.Business
{
	public class Attendance : BaseEntity
    {
        public StudentLA? StudentLA { get; set; }
        public DateTime? ComfirmDateTime { get; set; }
        public string? UnauthorizedAbsencesName { get; set; }
        public EmployeeLA? EmployeeComfirm { get; set; }
        public int? AttendanceTypeStatusId { get; set; }
        public AttendanceTypeStatus? AttendanceTypeStatus { get; set; }
    }
}

