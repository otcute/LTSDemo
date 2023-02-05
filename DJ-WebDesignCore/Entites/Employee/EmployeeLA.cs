using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Properties.Address;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Employee
{
    public class EmployeeLA : BaseEntity
    {
        public string? EmployeeLAUserName { get; set; }
        public string? EmployeeLAPassword { get; set; }
        public EmployeeRole? EmployeeRole { get; set; }
        public int? CommuneId { get; set; }
        public Commune? Commune { get; set; }
        public int? DistrictId { get; set; }
        public District? District { get; set; }
        public int? ProvinceId { get; set; }
        public Province? Province { get; set; }
        public Gender? Gender { get; set; }
        public string? NumberPhone { get; set; }
        public string? FacebookUrl { get; set; }
        public string? SkyUrl { get; set; }
        public string? EmployeeLAName { get; set; }
        public DateTime? EmployeeLABirthDay { get; set; }
        public EmployeeStatus? EmployeeStatus { get; set; }
    }
}
