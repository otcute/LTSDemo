using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendancePermissionedLeave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Business.AttendanceManager
{
    public interface IAttendancePermissonedLeaveCRUD
    {
        AttendancePermissionedLeaveGetDTO getAttendancePermissonedLeave(int? studentLAId);
    }
}
