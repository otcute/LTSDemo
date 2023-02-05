using DJ_WebDesignCore.Entites.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Employee
{
    public class EmployeeLA
    {
        public int EmployeeLAId { get; set; }
        public string? EmployeeLAUserName { get; set; }
        public string? EmployeeLAPassword { get; set; }
        public Address? Address { get; set; }
        public EmployeeRole? EmployeeRole { get; set; }
        public Gender? Gender { get; set; }
        public string? NumberPhone { get; set; }
        public string? FacebookUrl { get; set; }
        public string? SkyUrl { get; set; }
        public string? EmployeeLAName { get; set; }
        public DateTime? EmployeeLABirthDay { get; set; }
        public EmployeeStatus? EmployeeStatus { get; set; }
    }
}
