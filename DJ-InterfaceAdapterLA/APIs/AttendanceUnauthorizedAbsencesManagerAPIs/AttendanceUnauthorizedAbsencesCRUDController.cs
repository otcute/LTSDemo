using DJ_UseCaseLayer.Business.AttendanceManager;
using DJ_WebDesignCore.Business.AttendanceManager;
using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceUnauthorizedAbsences;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.AttendanceUnauthorizedAbsencesGetAPIs
{
    public class AttendanceUnauthorizedAbsencesCRUDController : BaseAPI
    {
        public readonly IAttendanceUnauthorizedAbsencesCRUD _attendanceUnauthorizedAbsencesCRUD;
        public AttendanceUnauthorizedAbsencesCRUDController()
        {
            _attendanceUnauthorizedAbsencesCRUD = new AttendanceUnauthorizedAbsencesCRUD();
        }
        [HttpGet("AttendanceUnauthorizedAbsencesCRUD")]
        public ActionResult<AttendanceUnauthorizedAbsencesGetDTO> getAttendanceUnauthorizedAbsences(int? studentLAId)
        {
            return Ok(_attendanceUnauthorizedAbsencesCRUD.getAttendanceUnauthorizedAbsences(studentLAId));
        }
    }
}
