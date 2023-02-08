using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceCRUDDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Business.AttendanceManager
{
    public interface IAttendanceCRUD
    {
        AttendanceUpdateDTO updateAttendance();
        AttendanceCreateDTO createAttendance();
    }
}
