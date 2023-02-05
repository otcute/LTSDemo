using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Properties
{
    public class EmployeeStatus:BaseEntity
    {
        public string? EmployeeStatusCode { get; set; }
        public string? EmployeeStatusName { get; set; }
    }
}
