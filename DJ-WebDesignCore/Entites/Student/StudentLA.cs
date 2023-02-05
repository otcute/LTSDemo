using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Student
{
    public class StudentLA
    {
        public int StudentLAId { get; set; }
        public string? StudentLAName { get; set; }
        public string? StudentLAUserName { get; set; }
        public string? StudentLAPassword { get; set; }
        public Address? Address { get; set; }
        public DateTime? StudentLABirthDay { get; set; }
        public EmployeeLA? Sale { get; set; }
        public int? SaleId { get; set; }
        public Gender? Gender { get; set; }
        public StudentStatus? StudentStatus { get; set; }
        public float? HolidayTotal { get; set; }
        public float? ReserveTotal { get; set; }
        public float? UnauthorizedAbsencesTotal { get; set; }
    }
}
