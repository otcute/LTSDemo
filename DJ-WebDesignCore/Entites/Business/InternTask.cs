using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Business
{
    public class InternTask : BaseEntity
    {
        public int? InternId { get; set; }
        public Intern? Intern { get; set; }
        public int? StudentLAId { get; set; }
        public StudentLA StudentLA { get; set; }
        public int? EmployeeLAConfirmId { get; set; }
        public EmployeeLA? EmployeeLAEmployeeConfirm { get; set; }
        public string? LeadEvaluate { get; set; }
        public double? EvaluateScore { get; set; }
    }
}
