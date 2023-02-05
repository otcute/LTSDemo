using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.EmployeeManagerEnums;

namespace DJ_WebDesignCore.DTOs.EmployeeManagerDTOs.EmployeeCRUDDTOs
{
    public class EmployeeCreateDTO
    {
        public EmployeeCreateEnums? Status { get; set; }
        public int EmployeeLAId { get; set; }
        public string? EmployeeLAUserName { get; set; }
        public EmployeeRole? EmployeeRole { get; set; }
        public Gender? Gender { get; set; }
        public string? EmployeeLAName { get; set; }
        public DateTime? EmployeeLABirthDay { get; set; }
        public EmployeeStatus? EmployeeStatus { get; set; }
        public string? ShortDetail { get; set; }
    }
}
