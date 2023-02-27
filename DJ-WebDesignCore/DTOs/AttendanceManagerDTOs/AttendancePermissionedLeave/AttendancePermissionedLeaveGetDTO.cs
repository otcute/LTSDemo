using DJ_WebDesignCore.Enums.AttendanceManagerEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendancePermissionedLeave
{
    public class AttendancePermissionedLeaveGetDTO
    {
        public AttendancePermissionedLeaveGetEnums Status { get; set; }
        public string? ShortDetail { get; set; }
        public List<AttendancePermissionedLeaveGetter> Data { get; set; }
    }
}
