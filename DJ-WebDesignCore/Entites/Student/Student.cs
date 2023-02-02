using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Student
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public Address? AddressId { get; set; }
        public DateTime? StudentBirthDay { get; set; }
        public EmployeeLA? SaleId { get; set; }
        public Gender? GenderId { get; set; }

    }
}
