using DJ_WebDesignCore.Enums.AttendanceManagerEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTOs.AttendanceManagerDTOs.ReserveCRUDDTOs
{
    public class ReserveGetDTO
    {
        public ReservesGetEnums status { get; set; }
        public string? ShortDetail { get; set; }
        public List<ReserveGetter> Data { get; set; }
    }
}
