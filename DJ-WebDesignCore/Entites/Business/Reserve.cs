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
    public class Reserve
    {
        public int ReserveId { get; set; }
        public int? StudentLAId { get; set; }
        [ForeignKey("StudentLAId")]
        public StudentLA? StudentLA { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? CloseTime { get; set;}
        public int? DateDiff { get; set; }
        public string? ReserveReason { get; set; }
        public int? EmployeeComfirmId { get; set; }
        [ForeignKey("EmployeeComfirmId")]
        public EmployeeLA? EmployeeComfirm { get; set; }

    }
}
