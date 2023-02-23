using DJ_WebDesignCore.Enums.AttendanceManagerEnums;

namespace DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.AttendanceUnauthorizedAbsences
{
    public class AttendanceUnauthorizedAbsencesGetDTO
    {
        public AttendanceUnauthorizedAbsencesGetEnums? Status { get; set; }
        public List<AttendanceUnauthorizedAbsencesGetter> Data { get; set; }
        public string? ShortDetail { get; set; }
    }
}
