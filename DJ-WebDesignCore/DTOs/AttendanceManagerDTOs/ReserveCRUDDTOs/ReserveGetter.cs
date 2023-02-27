using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.ReserveCRUDDTOs
{
    public class ReserveGetter
    {
        public string? ReserveReason { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? CloseTime { get; set; }
        public int? DateDiff { get; set; }
        public int? EmployeeConfirmId { get; set; }
        public string? EmployeeConfirmName { get; set; }

    }
}
