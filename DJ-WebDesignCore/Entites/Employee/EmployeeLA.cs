using DJ_WebDesignCore.Entites.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Employee
{
    internal class EmployeeLA
    {
        public int EmployeeLAId { get; set; }
        public Address? AddressId { get; set; }
        public int? GenderId { get; set; }
        public string? NumberPhone { get; set; }
        public string? FacebookUrl { get; set; }
        public string? SkyUrl { get; set; }
        public string? EmployeeLAName { get; set; }
        public DateTime? EmployeeLABirthDay { get; set; }


    }
}
