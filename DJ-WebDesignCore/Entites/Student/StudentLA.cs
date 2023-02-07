using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Properties.Address;

namespace DJ_WebDesignCore.Entites.Student
{
    public class StudentLA: BaseEntity
    {
        public string? StudentLAName { get; set; }
        public string? StudentLAUserName { get; set; }
        public string? StudentLAPassword { get; set; }
     //   public byte[]? StudentLAAvatar { get; set; }
        public int? CommuneId { get; set; }
        public Commune? Commune { get; set; }
        public int? DistrictId { get; set; }
        public District? District { get; set; }
        public int? ProvinceId { get; set; }
        public Province? Province { get; set; }
        public DateTime? StudentLABirthDay { get; set; }
        public int? SaleId { get; set; }
        public virtual EmployeeLA? Sale { get; set; }
        public Gender? Gender { get; set; }
        public StudentStatus? StudentStatus { get; set; }
        public float? HolidayTotal { get; set; }
        public float? ReserveTotal { get; set; }
        public float? UnauthorizedAbsencesTotal { get; set; }
    }
}
