﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendancePermissionedLeave
{
    public class AttendancePermissionedLeaveGetter
    {
        public DateTime? DayOff { get; set; }
        public string? OffShitf { get; set; }
        public string? Reason { get; set; }
        public DateTime? ConfirmDateTime { get; set; }
        public int? EmployeeConfirmId { get; set; }
        public string? EmployeeConfirmName { get; set; }
    }
}
