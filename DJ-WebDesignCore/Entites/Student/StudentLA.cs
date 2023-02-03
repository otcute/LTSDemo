using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Student
{
    public class StudentLA
    {
        public int StudentLAId { get; set; }
        public string? StudentLAName { get; set; }
        [ForeignKey("AddressId")]
        public Address? Address { get; set; }
        public int? AddressId { get; set; }
        public DateTime? StudentLABirthDay { get; set; }
        [ForeignKey("SaleId")]
        public EmployeeLA? Sale { get; set; }
        public int? SaleId { get; set; }
        [ForeignKey("GenderId")]
        public Gender? Gender { get; set; }
        public int? GenderId { get; set; }
    }
}
