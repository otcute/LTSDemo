using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Business
{
    public class StudentEmployee : BaseEntity
    {
        public int? StudentLAId { get; set; }
        public StudentLA? StudentLA { get; set; }    
        public int? EmployeeLAId { get; set; }
        public EmployeeLA? EmployeeLA { get; set; }
        public DateTime? SetMentorDatetime { get; set; }
        public string? ChangeReason { get; set; }
        // Lần thay đổi mentor
        public int? SortNumber { get; set; }

    }
}
