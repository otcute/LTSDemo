using DJ_WebDesignCore.Entites.Student;
using DJ_WebDesignCore.Enums.StudentManagerEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.DTOs.StudentManagerDTOs.StudentCRUDDTOs
{
    public class StudentFindByIdDTO
    {
        public StudentReadEnums? Status { get; set; }
        public StudentLA? StudentLA { get; set; }
        public string? ShortDetail { get; set; }
    }
}
