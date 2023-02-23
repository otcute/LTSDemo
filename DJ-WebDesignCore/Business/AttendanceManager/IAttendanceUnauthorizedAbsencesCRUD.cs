using DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceUnauthorizedAbsences;

namespace DJ_WebDesignCore.Business.AttendanceManager
{
    public interface IAttendanceUnauthorizedAbsencesCRUD
    {
        AttendanceUnauthorizedAbsencesGetDTO getAttendanceUnauthorizedAbsences(int? studentLAId);
    }
}
