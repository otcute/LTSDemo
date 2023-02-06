using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Business
{
    public class Reserve : BaseEntity
    {
        public StudentLA? StudentLA { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? CloseTime { get; set;}
        public int? DateDiff { get; set; }
        public string? ReserveReason { get; set; }
        public EmployeeLA? EmployeeComfirm { get; set; }

    }
}
