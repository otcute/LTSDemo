using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.StudentManagerEnums;

namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs
{
    public class StudentCreateDTO
    {
        public StudentCreateEnums? Status { get; set; }
        public int StudentLAId { get; set; }
        public string? StudentLAName { get; set; }
        public string? StudentLAUserName { get; set; }
        public DateTime? StudentLABirthDay { get; set; }
        public virtual EmployeeLA? Sale { get; set; }
        public Gender? Gender { get; set; }
        public StudentStatus? StudentStatus { get; set; }
        public float? HolidayTotal { get; set; }
        public float? ReserveTotal { get; set; }
        public float? UnauthorizedAbsencesTotal { get; set; }
        public string? ShortDetail { get; set; }
    }
}
