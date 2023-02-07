using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Business
{
    public class Intern : BaseEntity
    {
        public DateTime? OpenDateTime { get; set; }
        public DateTime? CloseDateTime { get; set; }
        public int? StudentSlot { get; set; }
        public int? EmployeeLeadId { get; set; }
        public EmployeeLA? EmployeeLead { get; set; }
        public int? InternStatusId { get; set; }
        public InternStatus? InternStatus { get; set; }

    }
}
