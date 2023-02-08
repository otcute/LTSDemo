using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Properties.Address;
using System.ComponentModel.DataAnnotations.Schema;

namespace DJ_WebDesignCore.Entites.Student
{
    public class StudentLA : BaseEntity
    {
        public string? StudentLAName { get; set; }
        public string? StudentLAUserName { get; set; }
        public string? StudentLAPassword { get; set; }
        //   public byte[]? StudentLAAvatar { get; set; }
        public string? WardCode { get; set; }
        [ForeignKey("WardCode")]
        public Ward? Ward { get; set; }
        public string? DistrictCode { get; set; }
        [ForeignKey("DistrictCode")]
        public District? District { get; set; }
        public string? ProvinceCode { get; set; }
        [ForeignKey("ProvinceCode")]
        public Province? Province { get; set; }
        public DateTime? StudentLABirthDay { get; set; }
        public int? SaleId { get; set; }
        public virtual EmployeeLA? Sale { get; set; }
        public int? GenderId { get; set; }
        public Gender? Gender { get; set; }
        public string? InsightName { get; set; }

        public StudentStatus? StudentStatus { get; set; }
        public float? HolidayTotal { get; set; }
        public float? ReserveTotal { get; set; }
        public float? UnauthorizedAbsencesTotal { get; set; }
    }
}
